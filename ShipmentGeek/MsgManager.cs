using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionReporting;

namespace ShipmentGeek
{
    class MsgManager
    {
        public static void Show(string text, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, icon);
        }

        public static bool ShowDialog(string text, string title, MessageBoxIcon icon = MessageBoxIcon.Question, MessageBoxButtons buttons = MessageBoxButtons.YesNo, DialogResult result = DialogResult.Yes)
        {
            return MessageBox.Show(text, title, buttons, icon) == result;
        }

        public static void LaunchExceptionReporter(Exception e)
        {
            ExceptionReporter reporter = new ExceptionReporter();

            reporter.Config.AppAssembly = System.Reflection.Assembly.GetCallingAssembly();
            reporter.Config.AppName = Var.AssemblyInfo.Name;
            reporter.Config.AppVersion = Var.AssemblyInfo.Version.ToString();
            reporter.Config.TitleText = string.Format("{0} Exception Report", Var.AssemblyInfo.Name);
            reporter.Config.EmailReportAddress = "hebron@tilhol.net";
            //reporter.Config.FilesToAttach = new[] { LogHandler.LogFileName(LogFile.Exception), LogHandler.LogFileName(LogFile.Debug) };
            reporter.Config.ShowConfigTab = false;

            reporter.Show(e);
        }

    }
}
