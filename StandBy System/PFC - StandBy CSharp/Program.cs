using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PFC___StandBy_CSharp.ConsoleLogServer;
using PFC___StandBy_CSharp.Forms.Testes;
using Syncfusion.Licensing;

namespace PFC___StandBy_CSharp
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (ConsoleLog.IsModoDebugLog())
            {
                Process.Start("ConsoleLogServer.exe");
                ConsoleLog.IniciarServidor();
            }

            //Essa linha abaixa desbuga as rows cortadas do gridview, era um problema com DPI dos monitores em escala 125%
            WindowsFormsSettings.SetDPIAware();
            //WindowsFormsSettings.SetPerMonitorDpiAware();

            //https://www.syncfusion.com/account/downloads
            SyncfusionLicenseProvider.RegisterLicense(
                "Mjk4MTg3MUAzMjMzMmUzMDJlMzBSYUQ2MG5CYkxJT2NhVUZZSW5nSjBDMlZVT1k1VFhpUm01dEkxUEpiSm1ZPQ==");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("pt-BR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new form_StandBy());
            Application.Run(new form_V2Standby());

            //Application.Run(new form_BancoDados());
        }
    }
}