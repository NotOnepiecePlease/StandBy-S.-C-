using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.ChecarUpdates
{
    class Verificar
    {
        public void ChecarVersao()
        {
            //https://pastebin.com/raw/ibWAkD4c
            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/ibWAkD4c").Contains("2.0.0"))
                {
                    if (MessageBox.Show("Existe uma nova versão do sistema StandBy,\ndeseja atualizar o sistema agora?",
                        "Nova Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes) using (var cliente = new WebClient())
                        {
                            Process.Start("SBAutoUpdate.exe");
                            Application.Exit();
                        }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
