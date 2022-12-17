using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.ChecarUpdates
{
    public class Verificar
    {
        public string VERSAO_STANDBY { get; set; } = "8.1.0";
        private const string LINK_STANDBY = "https://www.dropbox.com/s/revwuo9ry89po4t/UpdateVersionStandBY.txt?dl=1";
        private const string VERSAO_CLIENT_SERVER = "3.1.1";
        private const string LINK_CLIENT_SERVER = "https://www.dropbox.com/s/zb8ezcxnzk8fyz6/UpdateVersionClientServer.txt?dl=1";

        public void ForcarAtualizacao()
        {
            Process.Start("SBAutoUpdate.exe");
            Application.Exit();
        }

        public string ChecarVersaoStandBy()
        {
            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString(LINK_STANDBY).Contains(VERSAO_STANDBY))
                {
                    return @"Atualização Pendente!";
                }

                return "Sistema Atualizado!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possível verificar a versão do sistema, nao se preocupe, tudo funcionará normalmente.\n\n\nErro: " + ex, @"Falha na Verificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "Erro ao atualizar!";
            }
        }

        public string ChecarVersaoClientServer()
        {
            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString(LINK_CLIENT_SERVER).Contains(VERSAO_CLIENT_SERVER))
                {
                    return @"Atualização Pendente!";
                }

                return "Sistema Atualizado!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possível verificar a versão do sistema, nao se preocupe, tudo funcionará normalmente.\n\n\nErro: " + ex, @"Falha na Verificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "Erro ao atualizar!";
            }
        }
    }
}