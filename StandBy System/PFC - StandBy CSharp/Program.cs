using PFC___StandBy_CSharp.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_ALERT("Inserido com Sucesso", form_ALERT.AlertType.Sucesso));
            //Application.Run(new form_WordNota());
            Application.Run(new form_License());
            //Application.Run(new form_Principal());
        }
    }
}