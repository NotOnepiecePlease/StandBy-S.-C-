using PFC___StandBy_CSharp.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Impressao;
using Syncfusion.Licensing;
using DevExpress.XtraEditors;
using PFC___StandBy_CSharp.Forms._1___Ordems_Servico;
using PFC___StandBy_CSharp.Forms.Pagamento;
using PFC___StandBy_CSharp.Forms.Pagamento_e_Compras;

namespace PFC___StandBy_CSharp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Essa linha abaixa desbuga as rows cortadas do gridview, era um problema com DPI dos monitores em escala 125%
            //WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.SetPerMonitorDpiAware();
            //https://www.syncfusion.com/account/downloads
            SyncfusionLicenseProvider.RegisterLicense(
                "Nzc3MDU4QDMyMzAyZTMzMmUzMEhpVEkwRGI5V21BSk5KbFd6ckYwUUNLNkRXcm55T2tGRFAwTHV6VFNqcFU9");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("pt-BR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_StandBy());
        }
    }
}