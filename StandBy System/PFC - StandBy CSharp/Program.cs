using PFC___StandBy_CSharp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_ALERT("Inserido com Sucesso", form_ALERT.AlertType.Sucesso));
            //Application.Run(new form_WordNota());
            Application.Run(new form_StandBy());
            //Application.Run(new form_Principal());
        }
    }
}
