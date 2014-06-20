using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace ShipmentGeek
{
    class PrintHandler
    {
        private Font printFont;
        private StringReader stringRead;

        public void PrintShipments(string s)
        {
            stringRead = new StringReader(s);

            printFont = new Font("Arial", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);

            PrintDialog pdi = new PrintDialog();
            pdi.UseEXDialog = true;
            pdi.Document = pd;

            if (pdi.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pd.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }
        }

        // The PrintPage event is raised for each page to be printed. 
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file. 
            while (count < linesPerPage &&
               ((line = stringRead.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page. 
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}
