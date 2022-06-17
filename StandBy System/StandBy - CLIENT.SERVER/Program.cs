using System;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_PrincipalClientServer());
        }
    }
}