using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using SBAutoUpdate.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PFC___StandBy_CSharp.Dados;

namespace SBAutoUpdate
{
    public partial class Form1 : Form
    {
        private readonly VerificarTipoSistema verificarTipoSistema = new VerificarTipoSistema();
        private readonly BackupDados bckData = new BackupDados();
        private string nomeArquivoSistemaPrincipal = "";
        private string nomeArquivoSistemaSecundario = "";

        public Form1()
        {
            InitializeComponent();
            progress.Value = 0;
            Atualizar();
        }

        private void LerArquivoConfiguracao(bool _isSistemaPrincipal)
        {
            string txtPath = bckData.CAMINHO_TXT; //@"./data/dts.ini";

            //Removo as letras e os espacos e deixo so as informações uteis
            List<string> dadosSqlConexao = File.ReadAllLines(txtPath).Where(x => !x.Contains("#")).ToList();

            if (_isSistemaPrincipal == true)
            {
                foreach (var item in dadosSqlConexao)
                {
                    if (item.Contains("FILE_1"))
                    {
                        nomeArquivoSistemaPrincipal   = item.TrimStart('F', 'I', 'L', 'E', '_', '1', '=').Trim();
                        AtualizarStandBy.ARQUIVO_NOME = nomeArquivoSistemaPrincipal;
                    }
                    else if (item.Contains("LINK_1"))
                    {
                        AtualizarStandBy.LINK_DOWNLOAD_PRINCIPAL =
                            item.TrimStart('L', 'I', 'N', 'K', '_', '1', '=').Trim();
                    }
                }
            }
            else
            {
                foreach (var item in dadosSqlConexao)
                {
                    if (item.Contains("FILE_2"))
                    {
                        nomeArquivoSistemaSecundario       = item.TrimStart('F', 'I', 'L', 'E', '_', '2', '=').Trim();
                        AtualizarClientServer.ARQUIVO_NOME = nomeArquivoSistemaSecundario;
                    }
                    else if (item.Contains("LINK_2"))
                    {
                        AtualizarClientServer.LINK_DOWNLOAD_SECUNDARIO =
                            item.TrimStart('L', 'I', 'N', 'K', '_', '2', '=').Trim();
                    }
                }
            }
        }

        private void Atualizar()
        {
            if (verificarTipoSistema.SeForSistemaPrincipal() == true)
            {
                LerArquivoConfiguracao(true);
                Task.Run(() =>
                {
                    AtualizarStandBy.Atualizar(progress);
                    File.Delete(nomeArquivoSistemaPrincipal);
                    FecharForm();
                });
            }
            else
            {
                LerArquivoConfiguracao(false);
                Task.Run(() =>
                {
                    AtualizarClientServer.Atualizar(progress);
                    File.Delete(nomeArquivoSistemaSecundario);
                    FecharForm();
                });
            }
        }

        public void FecharForm()
        {
            Application.Exit();
        }
    }
}