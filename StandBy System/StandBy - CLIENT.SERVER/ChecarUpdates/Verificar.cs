using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.ChecarUpdates
{
    internal class Verificar
    {
        public void ChecarVersao(form_PrincipalClientServer form)
        {
            WebClient webClient = new WebClient();
            try
            {
                form.lblUpdate.Visible = true;
                form.lblUpdate.Text = "Verificando atualizações...";
                if (!webClient.DownloadString("https://www.dropbox.com/s/revwuo9ry89po4t/UpdateVersionStandBY.txt?dl=1").Contains("1.0.0"))
                //if (!webClient.DownloadString("https://pastebin.com/raw/ibWAkD4c").Contains("5.7.1"))
                {
                    //form.lblUpdate.Text = "Nova atualização disponivel, reinicie o sistema.";
                    if (MessageBox.Show("Existe uma nova versão do sistema StandBy,\ndeseja atualizar o sistema agora?",
                            "Nova Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.Yes)
                        using (var cliente = new WebClient())
                        {
                            Process.Start("SBAutoUpdate.exe");
                            Application.Exit();
                        }
                    else
                    {
                        //label.Text = "Nova atualização disponivel, reinicie o sistema.";
                    }
                }
                else
                {
                    //form.lblUpdate.Text = "Atualizado!";
                    //return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possível verificar a versão do sistema, nao se preocupe, tudo funcionará normalmente.\n\n\nErro: " + ex, "Falha na Verificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //return false;
            // label.Visible = false;
        }
    }
}