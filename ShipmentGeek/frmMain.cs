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
                shipmentInfo.Date = dateTimePicker.Value;
                shipmentInfo.Value = txtValue.Text;
                shipmentInfo.URL = txtURL.Text;
                shipmentInfo.Carrier = (cmbCarrier.SelectedItem != null ? cmbCarrier.SelectedItem.ToString() : string.Empty);
                shipmentInfo.Tracking = txtTracking.Text;
                shipmentInfo.Comment = txtComment.Text;
                shipmentInfo.Received = chkReceived.Checked;
                shipmentInfo.Missing = chkMissing.Checked;

                if (selectedShipment == 0)
                {
                    shipmentInfo.ID = ShipmentInfo.GetID;
                    ShipmentInfo.List.Add(shipmentInfo);
                }
                else
                {
                    shipmentInfo.ID = siGlobal.ID;
                    shipmentInfo.Items = siGlobal.Items;
                    ShipmentInfo.List[ShipmentInfo.List.IndexOf(siGlobal)] = shipmentInfo;
                }

                Save();
                ClearListFocus();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Var.FileInfo.ShipmentFile))
            {
                XML.DeSerializeList<ShipmentInfo>(Var.FileInfo.ShipmentFile, ShipmentInfo.List);
                lblStatStrip.Text = string.Format("Loaded {0} shipment{1}", ShipmentInfo.List.Count, (ShipmentInfo.List.Count == 1 ? "" : "s"));
            }

            ShipmentInfo.List.Sort(ShipmentInfo.DateComparison);

            PopulateLists();

            Carrier.List.Sort(Carrier.NameComparison);
            foreach (Carrier carrier in Carrier.List)
                cmbCarrier.Items.Add(carrier.Name);
            cmbCarrier.Items.Add("Other");
        }

        private void Save()
        {
            XML.SerializeList<ShipmentInfo>(Var.FileInfo.ShipmentFile, ShipmentInfo.List);
            lblStatStrip.Text = string.Format("Saved {0} shipment{1}", ShipmentInfo.List.Count, (ShipmentInfo.List.Count == 1 ? "" : "s"));

            PopulateLists();
        }

        private void PopulateLists()
        {
            lstIncoming.Items.Clear();
            lstOutgoing.Items.Clear();

            foreach (ShipmentInfo shipment in ShipmentInfo.List)
            {
                ListViewItem item = new ListViewItem(new[] { 
                    shipment.ID.ToString(),
                    shipment.Name,
                    shipment.Date.ToString("d"),
                    (!shipment.Missing && !shipment.Received ? shipment.Days.ToString("%d") : "-"),
                    shipment.Items.Sum(f => f.Count).ToString()
                });

                if (chkShowAll.Checked || (!chkShowAll.Checked && !shipment.Received && !shipment.Missing))
                {
                    if (shipment.Missing) item.ForeColor = Color.Red;
                    else if (shipment.Received) item.ForeColor = Color.Green;

                    if (shipment.Incomming) lstIncoming.Items.Add(item);
                    else if (shipment.Outgoing) lstOutgoing.Items.Add(item);
                }
            }
        }

        private void PutShipmentDetails(ListView listView)
        {
            errProvider.Clear();

            if (listView.SelectedItems.Count > 0)
            {
                ShipmentInfo si = ShipmentInfo.List.First(f => f.ID == Convert.ToInt32(listView.SelectedItems[0].Text));

                radIncoming.Checked = si.Incomming;
                radOutgoing.Checked = si.Outgoing;
                txtName.Text = si.Name;
                dateTimePicker.Value = si.Date;
                txtValue.Text = si.Value;
                txtURL.Text = si.URL;
                cmbCarrier.SelectedItem = si.Carrier;
                txtTracking.Text = si.Tracking;
                txtComment.Text = si.Comment;
                chkReceived.Checked = si.Received;
                chkMissing.Checked = si.Missing;

                lstItems.Items.Clear();
                si.Items.Sort(ShipmentItem.TextComparison);
                PutShipmentItems(si);

                selectedShipment = si.ID;
                lblStatStrip.Text = string.Format("Selected: {0} - {1}", (radIncoming.Checked ? "In" : "Out"), si.Name);

                grpItems.Enabled = true;
                cmdURLopen.Enabled = true;
                cmdTrack.Enabled = true;
            }
            else
            {
                lblStatStrip.Text = string.Empty;
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
            if (lstIncoming.SelectedItems.Count > 0) lstOutgoing.SelectedIndices.Clear();
            PutShipmentDetails(lstIncoming);
        }

        private void lstOutgoing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOutgoing.SelectedItems.Count > 0) lstIncoming.SelectedIndices.Clear();
            PutShipmentDetails(lstOutgoing);
        }

        private void chkShowReceived_CheckedChanged(object sender, EventArgs e)
        {
            PopulateLists();
        }

        private void ClearListFocus()
        {
            lstIncoming.SelectedItems.Clear();
            lstOutgoing.SelectedItems.Clear();

            radIncoming.Checked = false;
            radOutgoing.Checked = false;
            txtName.Text = string.Empty;
            dateTimePicker.Value = DateTime.Today;
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

            selectedShipment = 0;
            errProvider.Clear();

            grpItems.Enabled = false;
            cmdURLopen.Enabled = false;
            cmdTrack.Enabled = false;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            ClearListFocus();
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
                    ShipmentItem item = new ShipmentItem();
                    item.Text = txtItemText.Text;
                    item.Count = Convert.ToInt32(numItemCount.Value);

                    if (lstItems.SelectedIndices.Count == 0)
                    {
                        siGlobal.Items.Add(item);
                    }
                    else
                    {
                        siGlobal.Items[lstItems.SelectedIndices[0]] = item;
                    }

                    Save();
                    PutShipmentItems(siGlobal);
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
                    MenuItem removeItem = cm.MenuItems.Add("Remove item");
                    removeItem.Click += (Sender, eventArgs) => 
                    {
                        ShipmentInfo si = ShipmentInfo.List.First(f => f.ID == Convert.ToInt32(item.Text));
                        ShipmentInfo.List.Remove(si);

                        Save();
                        ClearListFocus();
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
            }
            else
            {
                txtItemText.Text = string.Empty;
                numItemCount.Value = 1;
            }
        }

        private void cmdItemClear_Click(object sender, EventArgs e)
        {
            txtItemText.Text = string.Empty;
            numItemCount.Value = 1;
            lstItems.SelectedIndices.Clear();
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
                    MenuItem removeItem = cm.MenuItems.Add("Remove item");
                    removeItem.Click += (Sender, eventArgs) =>
                    {
                        ShipmentItem si = siGlobal.Items[lstItems.SelectedIndices[0]];
                        siGlobal.Items.Remove(si);

                        Save();
                        PutShipmentItems(siGlobal);
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

            PopulateLists();
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

    }
}
