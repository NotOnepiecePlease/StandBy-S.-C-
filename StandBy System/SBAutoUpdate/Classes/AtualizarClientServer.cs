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
    internal static class AtualizarClientServer
    {
        public static Task Atualizar(GunaProgressBar _progressBar)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                _progressBar.Value += 2;

                Uteis.FecharSistemas();

                if (_progressBar.Value == 50) //Quando a progressbar for 50 o loop do for ta em 25
                {
                    Uteis.FecharSistemas();
                    Thread.Sleep(1000);

                    try
                    {
                        string meuDiretorio = @".\";
                        List<string> arquivosSeremMantidos = new List<string>
                        {
                            "SBAutoUpdate.exe",
                            "dts.ini",
                            "*.txt",
                        };

                        Uteis.DeleteTodosExceto(meuDiretorio, arquivosSeremMantidos, false);

                        var client = new WebClient();
                        client.DownloadFile("https://www.dropbox.com/s/thwsdq62rnf93tu/UpdateClientServer.zip?dl=1", "UpdateClientServer.zip");
                        DirectoryInfo diretorioArquivoBaixado = new DirectoryInfo("UpdateClientServer.zip");
                        Thread.Sleep(10);
                        string diretorioParaExtrair = @".\";
                        ZipFile.ExtractToDirectory(diretorioArquivoBaixado.FullName, diretorioParaExtrair);
                        File.Delete(@"UpdateClientServer.zip");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: \n\n" + ex);
                        Application.Exit();
                    }
                }
                else if (_progressBar.Value == 100)
                {
                    if (MessageBox.Show(@"Atualizado com Sucesso! O StandBy Client - Server vai abrir automaticamente em alguns segundos...",
                        @"APROVEITE!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Process.Start(@".\StandBy - CLIENT.SERVER.exe");
                        File.Delete(@"UpdateClientServer.zip");
                    }
                }
            }

            return Task.CompletedTask;
        }
    }
}