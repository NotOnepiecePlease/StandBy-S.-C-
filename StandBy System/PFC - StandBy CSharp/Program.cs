using PFC___StandBy_CSharp.Forms;
using System;
using System.Windows.Forms;
using Syncfusion;

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
            //https://www.syncfusion.com/account/downloads
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzc3MDU4QDMyMzAyZTMzMmUzMEhpVEkwRGI5V21BSk5KbFd6ckYwUUNLNkRXcm55T2tGRFAwTHV6VFNqcFU9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_StandBy());
            Application.Run(new form_OrdemServico());
        }
    }
}