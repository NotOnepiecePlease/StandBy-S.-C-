using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBAutoUpdate.Classes
{
    internal static class AtualizarStandBy
    {
        const string ARQUIVO_NOME = "UpdateNEW.zip";

        public static Task Atualizar(GunaProgressBar _progressBar)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                _progressBar.Value += 2;

                Uteis.FecharSistemas();

                if (_progressBar.Value == 50)
                {
                    Uteis.FecharSistemas();
                    Thread.Sleep(1000);

                    try
                    {
                        string meuDiretorio = @".\";
                        List<string> arquivosSeremMantidos = new List<string>
                        {
                            "SBAutoUpdate.exe", "dts.ini",
                        };

                        Uteis.DeleteTodosExceto(meuDiretorio, arquivosSeremMantidos, true);

                        var client = new WebClient();
                        client.DownloadFile("https://www.dropbox.com/s/xqoqoh12zmgsbmf/UpdateNEW.zip?dl=1"
                            , ARQUIVO_NOME);

                        //client.DownloadFile("https://www.dropbox.com/s/8a5oekhvwuujhqx/Update.zip?dl=1", "Update.zip");
                        DirectoryInfo diretorioArquivoBaixado = new DirectoryInfo(ARQUIVO_NOME);
                        Thread.Sleep(10);
                        string diretorioParaExtrair = @".\";
                        ZipFile.ExtractToDirectory(diretorioArquivoBaixado.FullName, diretorioParaExtrair);
                        File.Delete($@"..\{ARQUIVO_NOME}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: \n\n" + ex);
                        Application.Exit();
                    }
                }
                else if (_progressBar.Value == 100)
                {
                    if (MessageBox.Show(
                            @"Atualizado com Sucesso! O StandBy System vai abrir automaticamente em alguns segundos...",
                            @"APROVEITE!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Process.Start(@".\StandBy System.exe");
                        File.Delete($@"..\{ARQUIVO_NOME}");
                    }
                }
            }

            return Task.CompletedTask;
        }
    }
}