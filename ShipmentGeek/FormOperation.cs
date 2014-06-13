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
    }
}
