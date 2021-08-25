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
                //MessageBox.Show(webClient.DownloadString("https://www.dropbox.com/s/revwuo9ry89po4t/UpdateVersionStandBY.txt?dl=1"));
                if (!webClient.DownloadString("https://www.dropbox.com/s/revwuo9ry89po4t/UpdateVersionStandBY.txt?dl=1").Contains("5.5.0"))
                //if (!webClient.DownloadString("https://pastebin.com/raw/ibWAkD4c").Contains("5.2.2"))
                {
                    if (MessageBox.Show("Existe uma nova versão do sistema StandBy,\ndeseja atualizar o sistema agora?",
                        "Nova Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes) using (var cliente = new WebClient())
                        {
                            Process.Start("SBAutoUpdate.exe");
                            Application.Exit();
                            //return true;
                        }
                }
                else
                {
                    //return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possivel estabelecer uma conexao para verificar a versão do sistema\n\nErro: "+ex, "Falha na Verificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //return false;
        }
    }
}
