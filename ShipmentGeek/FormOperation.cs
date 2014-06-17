using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentGeek
{
    class FormOperation
    {
        public static string ShowDialog(string text, string caption, bool password = false, string preText = null, FormStartPosition startPos = FormStartPosition.CenterParent, int width = 200)
        {
            string strReturn = null;
            Form prompt = new Form();
            prompt.Width = width;
            prompt.Height = 100;
            prompt.Text = caption;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.MaximizeBox = false;
            prompt.MinimizeBox = false;
            prompt.ShowIcon = false;
            prompt.ShowInTaskbar = false;
            prompt.StartPosition = startPos;
            Label textLabel = new Label() { Left = 13, Top = 13, Text = text + ":", AutoSize = true };
            TextBox textBox = new TextBox() { Left = 13, Top = 30, Width = width - 40 };
            textBox.Text = preText;
            textBox.UseSystemPasswordChar = password;
            textBox.KeyDown += (Sender, eventArgs) =>
            {
                if (eventArgs.KeyCode == Keys.Enter) { strReturn = textBox.Text; prompt.Close(); }
                if (eventArgs.KeyCode == Keys.Escape) { strReturn = string.Empty; prompt.Close(); }
            };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            return strReturn;
        }

        public static void AddScriptMenues(string category)
        {
            ToolStripMenuItem newItem = new ToolStripMenuItem(category);
            Program.MainForm.mnuCategory.DropDownItems.Add(newItem);
            newItem.Click += (sender, eventArgs) =>
            {
                foreach (ToolStripMenuItem item in Program.MainForm.mnuCategory.DropDownItems)
                    if (item != sender) item.Checked = false;

                newItem.Checked = true;
                Program.MainForm.PopulateLists(FilterType.Category, newItem.Text);
            };
        }

        public static void CopyToClipboard()
        {
            try
            {
                if (ShipmentInfo.List.Count > 0)
                {
                    StringBuilder clipboard = new StringBuilder();

                    foreach (ShipmentInfo item in ShipmentInfo.List)
                    {
                        string stringLine = string.Empty;

                        foreach (ShipmentItem si in item.Items)
                        {
                            if (!string.IsNullOrEmpty(stringLine)) stringLine += " | ";
                            stringLine += string.Format("{0}: {1}", si.Count, si.Text);
                        }

                        string type = string.Empty;
                        if (item.Incomming) type = "Incoming";
                        else if (item.Outgoing) type = "Outgoing";

                        string status = "Open";
                        if (item.Received) status = "Received";
                        else if (item.Missing) status = "Missing";

                        clipboard.AppendLine(string.Format("{0}: {1} [{2}] {3} ({4})", type, item.Date.ToShortDateString(), status, item.Name, stringLine));

                    }

                    Clipboard.SetText(clipboard.ToString());
                }

                //StatusHandler.SetStatusToolStrip(Program.MainForm, "Computer list copied to clipboard");
            }
            catch (Exception exp)
            {
                MsgManager.Show(exp.Message, "Clipboard", MessageBoxIcon.Warning);
            }
        }
    }
}
