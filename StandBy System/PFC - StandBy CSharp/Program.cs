using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using PFC___StandBy_CSharp.Forms;
using PFC___StandBy_CSharp.Forms.Configurações.Banco_de_Dados;
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
            //Essa linha abaixa desbuga as rows cortadas do gridview, era um problema com DPI dos monitores em escala 125%
            //WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.SetPerMonitorDpiAware();

            //https://www.syncfusion.com/account/downloads
            SyncfusionLicenseProvider.RegisterLicense(
                "Nzc3MDU4QDMyMzAyZTMzMmUzMEhpVEkwRGI5V21BSk5KbFd6ckYwUUNLNkRXcm55T2tGRFAwTHV6VFNqcFU9");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("pt-BR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new form_StandBy());

            Application.Run(new form_V2Standby());

            //Application.Run(new form_BancoDados());
        }
    }
}