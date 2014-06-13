using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShipmentGeek
{
    public partial class frmMain : Form
    {
        static int selectedShipment;
        ShipmentInfo siGlobal { get { return ShipmentInfo.List.FirstOrDefault(f => f.ID == selectedShipment); } }

        List<string> Categories = new List<string>();

        FilterType Filter = FilterType.None;
        string FilterSearch = null;

        public frmMain()
        {
            InitializeComponent();

            TextWriterTraceListener debugLog = new TextWriterTraceListener(Var.FolderInfo.Work + string.Format("\\Debug_{0}.log", Var.DateTimeStr));
            Debug.Listeners.Add(debugLog);
            Debug.AutoFlush = true;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            FileHandling.BackupShipmentDatabase();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (!radIncoming.Checked && !radOutgoing.Checked)
            {
                errProvider.SetError(radIncoming, "Select either incoming or outgoing.");
                errProvider.SetError(radOutgoing, "Select either incoming or outgoing.");
            }

            else if (string.IsNullOrEmpty(txtName.Text))
                errProvider.SetError(txtName, "Enter shipment name.");

            else
            {
                ShipmentInfo shipmentInfo = new ShipmentInfo();

                shipmentInfo.Incomming = radIncoming.Checked;
                shipmentInfo.Outgoing = radOutgoing.Checked;
                shipmentInfo.Name = txtName.Text;
                shipmentInfo.Date = dateSent.Value;
                shipmentInfo.Category = (cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : cmbCategory.Text);
                shipmentInfo.Value = txtValue.Text;
                shipmentInfo.URL = txtURL.Text;
                shipmentInfo.Carrier = (cmbCarrier.SelectedItem != null ? cmbCarrier.SelectedItem.ToString() : string.Empty);
                shipmentInfo.Tracking = txtTracking.Text;
                shipmentInfo.Comment = txtComment.Text;
                shipmentInfo.Received = chkReceived.Checked;
                shipmentInfo.Missing = chkMissing.Checked;

                if (sender == cmdNew)
                {
                    shipmentInfo.ID = ShipmentInfo.GetID;
                    ShipmentInfo.List.Add(shipmentInfo);
                }
                else if (sender == cmdSave)
                {
                    shipmentInfo.ID = siGlobal.ID;
                    shipmentInfo.Items = siGlobal.Items;
                    ShipmentInfo.List[ShipmentInfo.List.IndexOf(siGlobal)] = shipmentInfo;
                }

                SaveShipment();
                SelectShipment(shipmentInfo);
                numItemCount.Focus();
                AddToCategory(shipmentInfo.Category);
            }
        }

        private void SelectShipment(ShipmentInfo si)
        {
            if (si != null)
            {
                if (si.Incomming)
                {
                    if (lstIncoming.FindItemWithText(si.ID.ToString()) != null)
                    {
                        lstIncoming.FindItemWithText(si.ID.ToString()).Selected = true;
                        lstIncoming.FindItemWithText(si.ID.ToString()).EnsureVisible();
                    }
                    else
                        ClearListFocus();
                }

                if (si.Outgoing)
                {
                    if (lstOutgoing.FindItemWithText(si.ID.ToString()) != null)
                    {
                        lstOutgoing.FindItemWithText(si.ID.ToString()).Selected = true;
                        lstOutgoing.FindItemWithText(si.ID.ToString()).EnsureVisible();
                    }
                    else
                        ClearListFocus();
                }
            }
        }

        private void AddToCategory(string cat)
        {
            if (!Categories.Contains(cat) && !string.IsNullOrEmpty(cat))
            {
                Categories.Add(cat);
                Categories.Sort();

                cmbCategory.Items.Clear();
                mnuCategory.DropDownItems.Clear();

                foreach (string item in Categories)
                {
                    cmbCategory.Items.Add(item);
                    FormOperation.AddScriptMenues(item);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} {1}", Var.AssemblyInfo.Name, Var.AssemblyInfo.VersionText);

            mnuReadme.Enabled = System.IO.File.Exists(Var.FileInfo.ReadMeFile);
            mnuChangeLog.Enabled = System.IO.File.Exists(Var.FileInfo.ChangeLogFile);

            if (Properties.Settings.Default.SettingsVersion != Var.AssemblyInfo.Version.ToString())
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.SettingsVersion = Var.AssemblyInfo.Version.ToString();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Var.FileInfo.ShipmentFile)) Var.FileInfo.ShipmentFile = Var.FileInfo.DefaultShipmentFile;
            LoadShipment();

            Carrier.List.Sort(Carrier.NameComparison);
            foreach (Carrier carrier in Carrier.List)
                cmbCarrier.Items.Add(carrier.Name);
            cmbCarrier.Items.Add("Other");
        }

        private void LoadShipment()
        {
            if (System.IO.File.Exists(Var.FileInfo.ShipmentFile))
            {
                ShipmentInfo.List.Clear();
                XML.DeSerializeList<ShipmentInfo>(Var.FileInfo.ShipmentFile, ShipmentInfo.List);
                StatusText(srpLoadSave, string.Format("Loaded {0}", Var.FileInfo.ShipmentFile));
                ShipmentInfo.List.Sort(ShipmentInfo.DateComparison);

                mnuShipment.Enabled = true;
                PopulateLists();

                foreach (ShipmentInfo cat in ShipmentInfo.List)
                    if (!string.IsNullOrEmpty(cat.Category)) AddToCategory(cat.Category);
            }
            else
                mnuShipment.Enabled = false;
        }

        private void SaveShipment()
        {
            XML.SerializeList<ShipmentInfo>(Var.FileInfo.ShipmentFile, ShipmentInfo.List);
            StatusText(srpLoadSave, string.Format("Saved {0}", Var.FileInfo.ShipmentFile));

            PopulateLists(Filter, FilterSearch);
        }

        internal void PopulateLists(FilterType filter = FilterType.None, string search = null)
        {
            Filter = filter;
            FilterSearch = search;

            lstIncoming.Items.Clear();
            lstOutgoing.Items.Clear();

            List<ShipmentInfo> list = new List<ShipmentInfo>();

            if (filter == FilterType.None)
            {
                list = ShipmentInfo.List;
            }
            else if (filter == FilterType.Find)
            {
                list = ShipmentInfo.List.Where(s =>
                    s.Name.ToLower().Contains(search.ToLower()) ||
                    s.Comment.ToLower().Contains(search.ToLower())
                    ).ToList();
            }
            else if (filter == FilterType.Category)
            {
                list = ShipmentInfo.List.Where(s =>
                    s.Category.Contains(search)
                    ).ToList();
            }

            mnuClearFilter.Enabled = (filter != FilterType.None);
            mnuShowAllShipments.Enabled = (filter == FilterType.None);

            mnuShipmentSearch.Checked = (filter == FilterType.Find);
            mnuCategory.Checked = (filter == FilterType.Category);

            if (filter != FilterType.Category)
            {
                foreach (ToolStripMenuItem item in Program.MainForm.mnuCategory.DropDownItems)
                    item.Checked = false;
            }

            foreach (ShipmentInfo shipment in list)
            {
                ListViewItem item = new ListViewItem(new[] { 
                    shipment.ID.ToString(),
                    shipment.Name,
                    shipment.Date.ToString("d"),
                    (!shipment.Missing && !shipment.Received ? shipment.Days.ToString("%d") : "-"),
                    shipment.Items.Sum(f => f.Count).ToString()
                });

                if (mnuShowAllShipments.Checked || (!mnuShowAllShipments.Checked && !shipment.Received && !shipment.Missing) || filter != FilterType.None)
                {
                    if (shipment.Missing) item.ForeColor = Color.Red;
                    else if (shipment.Received) item.ForeColor = Color.Green;

                    if (shipment.Incomming) lstIncoming.Items.Add(item);
                    else if (shipment.Outgoing) lstOutgoing.Items.Add(item);
                }
            }

            if (filter != FilterType.None)
                srpFilterOn.ToolTipText = string.Format("Filter: {0} ({1} shipment{2})", filter.ToString(), list.Count, (list.Count == 1 ? "" : "s"));

            srpFilterOn.Visible = (filter != FilterType.None);
        }

        private void PutShipmentDetails(ListView listView)
        {
            errProvider.Clear();
            cmdSave.Enabled = true;

            if (listView.SelectedItems.Count > 0)
            {
                ShipmentInfo si = ShipmentInfo.List.First(f => f.ID == Convert.ToInt32(listView.SelectedItems[0].Text));

                radIncoming.Checked = si.Incomming;
                radOutgoing.Checked = si.Outgoing;
                txtName.Text = si.Name;
                dateSent.Value = si.Date;
                cmbCategory.SelectedItem = si.Category;
                txtValue.Text = si.Value;
                txtURL.Text = si.URL;
                cmbCarrier.SelectedItem = si.Carrier;
                txtTracking.Text = si.Tracking;
                txtComment.Text = si.Comment.Replace("\n", Environment.NewLine);
                chkReceived.Checked = si.Received;
                chkMissing.Checked = si.Missing;

                lstItems.Items.Clear();
                si.Items.Sort(ShipmentItem.TextComparison);
                PutShipmentItems(si);

                selectedShipment = si.ID;
                srpSelected.Visible = true;
                srpSelected.Text = string.Format("{0} : {1} : {2}", si.ID, (radIncoming.Checked ? "In" : "Out"), si.Name);

                grpItems.Enabled = true;
                cmdURLopen.Enabled = true;
                cmdTrack.Enabled = true;
            }
            else
            {
                srpSelected.Visible = false;
                ClearListFocus();
            }
        }

        private void PutShipmentItems(ShipmentInfo si)
        {
            txtItemText.Text = string.Empty;
            numItemCount.Value = 1;
            lstItems.Items.Clear();

            foreach (ShipmentItem item in si.Items)
            {
                ListViewItem i = new ListViewItem(new[] { item.Count.ToString(), item.Text });

                lstItems.Items.Add(i);
            }
        }

        private void lstIncoming_SelectedIndexChanged(object sender, EventArgs e)
        {
            PutShipmentDetails(lstIncoming);
        }

        private void lstOutgoing_SelectedIndexChanged(object sender, EventArgs e)
        {
            PutShipmentDetails(lstOutgoing);
        }

        private void ClearListFocus()
        {
            cmdSave.Enabled = false;
            selectedShipment = 0;

            lstIncoming.SelectedItems.Clear();
            lstOutgoing.SelectedItems.Clear();

            radIncoming.Checked = false;
            radOutgoing.Checked = false;
            txtName.Text = string.Empty;
            dateSent.Value = DateTime.Today;
            cmbCategory.SelectedItem = null;
            cmbCategory.Text = string.Empty;
            txtValue.Text = string.Empty;
            txtURL.Text = string.Empty;
            cmbCarrier.SelectedItem = null;
            cmbCarrier.Text = string.Empty;
            txtTracking.Text = string.Empty;
            txtComment.Text = string.Empty;
            chkReceived.Checked = false;
            chkMissing.Checked = false;

            numItemCount.Value = 1;
            txtItemText.Text = string.Empty;
            lstItems.Items.Clear();
            
            errProvider.Clear();

            grpItems.Enabled = false;
            cmdURLopen.Enabled = false;
            cmdTrack.Enabled = false;
        }

        private void cmdItemSave_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (selectedShipment > 0)
            {
                if (string.IsNullOrEmpty(txtItemText.Text))
                {
                    errProvider.SetError(txtItemText, "Missing item text.");
                }
                else
                {
                    int selectedItem = -1;

                    ShipmentItem item = new ShipmentItem();
                    item.Text = txtItemText.Text;
                    item.Count = Convert.ToInt32(numItemCount.Value);

                    if (sender == cmdItemAdd)
                    {
                        siGlobal.Items.Add(item);
                        selectedItem = lstItems.Items.Count;
                    }
                    else if (sender == cmdItemSave)
                    {
                        selectedItem = lstItems.SelectedIndices[0];
                        siGlobal.Items[selectedItem] = item;
                    }

                    SaveShipment();
                    SelectShipment(siGlobal);
                    PutShipmentItems(siGlobal);

                    if (sender == cmdItemSave && lstItems.Items[selectedItem] != null)
                    {
                        lstItems.Items[selectedItem].Selected = true;
                        lstItems.Items[selectedItem].EnsureVisible();
                    }
                }
            }
        }

        private void ListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView sourceList = sender as ListView;
                ContextMenu cm = new ContextMenu();

                ListViewItem item = sourceList.GetItemAt(e.X, e.Y);

                if (item != null)
                {
                    MenuItem removeItem = cm.MenuItems.Add("Remove shipment");
                    removeItem.Click += (Sender, eventArgs) => 
                    {
                        ShipmentInfo si = ShipmentInfo.List.First(f => f.ID == Convert.ToInt32(item.Text));

                        if (MsgManager.ShowDialog(string.Format("Really delete shipment '{0}' ?", si.Name), "Remove shipment"))
                        {
                            ShipmentInfo.List.Remove(si);

                            SaveShipment();
                            ClearListFocus();
                        }
                    };

                    cm.Show(sourceList, e.Location);
                }
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                ShipmentItem si = siGlobal.Items[lstItems.SelectedIndices[0]];

                txtItemText.Text = si.Text;
                numItemCount.Value = si.Count;
                cmdItemSave.Enabled = true;
            }
            else
            {
                txtItemText.Text = string.Empty;
                numItemCount.Value = 1;
                cmdItemSave.Enabled = false;
            }
        }

        private void lstItems_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView sourceList = sender as ListView;
                ContextMenu cm = new ContextMenu();

                ListViewItem item = sourceList.GetItemAt(e.X, e.Y);

                if (item != null)
                {
                    MenuItem removeItem = cm.MenuItems.Add("Remove shipment item");
                    removeItem.Click += (Sender, eventArgs) =>
                    {
                        ShipmentItem si = siGlobal.Items[lstItems.SelectedIndices[0]];

                        if (MsgManager.ShowDialog(string.Format("Really delete shipment item '{0}' ?", si.Text), "Remove shipment item"))
                        {
                            siGlobal.Items.Remove(si);

                            SaveShipment();
                            PutShipmentItems(siGlobal);
                        }
                    };

                    cm.Show(sourceList, e.Location);
                }
            }
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exp = (Exception)e.ExceptionObject;
            MsgManager.LaunchExceptionReporter(exp);
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception exp = (Exception)e.Exception;
            MsgManager.LaunchExceptionReporter(exp);
        }

        private void Shipment_ColumnSort(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0) ShipmentInfo.List.Sort(ShipmentInfo.IdComparison);
            if (e.Column == 1) ShipmentInfo.List.Sort(ShipmentInfo.NameComparison);
            if (e.Column == 2) ShipmentInfo.List.Sort(ShipmentInfo.DateComparison);
            if (e.Column == 3) ShipmentInfo.List.Sort(ShipmentInfo.DaysComparison);
            if (e.Column == 4) ShipmentInfo.List.Sort(ShipmentInfo.ItemComparison);

            PopulateLists(Filter, FilterSearch);
        }

        private void lstItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0) siGlobal.Items.Sort(ShipmentItem.CountComparison);
            if (e.Column == 1) siGlobal.Items.Sort(ShipmentItem.TextComparison);

            PutShipmentItems(siGlobal);
        }

        private void cmdURLopen_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            if (!url.StartsWith("http://")) url = "http://" + url;

            try
            {
                if (!string.IsNullOrEmpty(txtURL.Text)) Process.Start(url);
            }
            catch (Exception exp)
            {
                MsgManager.Show(exp.Message, "Error lauching URL", MessageBoxIcon.Error);
            }
        }

        private void cmdTrack_Click(object sender, EventArgs e)
        {
            if (cmbCarrier.SelectedItem != null)
            {
                if (cmbCarrier.SelectedItem.ToString() != "Other")
                {
                    string url = Carrier.List.FirstOrDefault(f => f.Name == cmbCarrier.SelectedItem.ToString()).TrackURL;

                    try
                    {
                        if (!string.IsNullOrEmpty(txtTracking.Text)) Process.Start(string.Format(url, txtTracking.Text));
                    }
                    catch (Exception exp)
                    {
                        MsgManager.Show(exp.Message, "Error lauching tracking", MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lstIncoming_Enter(object sender, EventArgs e)
        {
            ClearListFocus();
        }

        private void lstOutgoing_Enter(object sender, EventArgs e)
        {
            ClearListFocus();
        }

        private void chkState_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == chkReceived && chkReceived.Checked) chkMissing.Checked = false;
            if (sender == chkMissing && chkMissing.Checked) chkReceived.Checked = false;
        }

        private void StatusText(ToolStripLabel label, string text)
        {
            label.Visible = true;
            label.Text = text;

            Timer aTimer = new Timer();
            aTimer.Tick += (Sender, Args) => { label.Visible = false; aTimer.Stop(); aTimer.Dispose(); };
            aTimer.Interval = 5000;
            aTimer.Start();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout formAbout = new frmAbout(Var.AssemblyInfo.Version.ToString(), Var.AssemblyInfo.DEVELOPED_BY);
            formAbout.ShowDialog();
        }

        private void mnuShipmentSearch_Click(object sender, EventArgs e)
        {
            string searchText = FormOperation.ShowDialog("Search phrase", "Find shipment");

            if (!string.IsNullOrEmpty(searchText))
            {
                ClearListFocus();
                PopulateLists(FilterType.Find, searchText);
            }
        }

        private void mnuOpenShipments_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                Var.FileInfo.ShipmentFile = openFileDialog.FileName;
                LoadShipment();
            }
        }

        private void mnuSaveShipments_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                Var.FileInfo.ShipmentFile = saveFileDialog.FileName;
                SaveShipment();
            }
        }

        private void mnuNewShipment_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                Var.FileInfo.ShipmentFile = saveFileDialog.FileName;
                ShipmentInfo.List.Clear();
                SaveShipment();
            }
        }

        private void mnuReadme_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", Var.FileInfo.ReadMeFile);
            }
            catch (Exception exp)
            {
                MsgManager.Show(exp.Message, "Error opening file", MessageBoxIcon.Error);
            }
        }

        private void mnuChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", Var.FileInfo.ChangeLogFile);
            }
            catch (Exception exp)
            {
                MsgManager.Show(exp.Message, "Error opening file", MessageBoxIcon.Error);
            }
        }

        private void mnuShowAllShipments_Click(object sender, EventArgs e)
        {
            PopulateLists();

            if (selectedShipment > 0)
            {
                if ((siGlobal.Incomming && lstIncoming.FindItemWithText(siGlobal.ID.ToString()) == null) || (siGlobal.Outgoing && lstOutgoing.FindItemWithText(siGlobal.ID.ToString()) == null))
                    ClearListFocus();
            }
        }

        private void mnuClearFilter_Click(object sender, EventArgs e)
        {
            PopulateLists();

            foreach (ToolStripMenuItem item in Program.MainForm.mnuCategory.DropDownItems)
                item.Checked = false;
        }

        private void mnuShipment_Click(object sender, EventArgs e)
        {
            mnuCategory.Enabled = Categories.Count > 0;
        }

    }
}
