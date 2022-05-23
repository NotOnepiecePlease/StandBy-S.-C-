﻿using Guna.UI.WinForms;
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
                            "SBAutoUpdate.exe",
                        };

                        Uteis.DeleteTodosExceto(meuDiretorio, arquivosSeremMantidos, true);

                        var client = new WebClient();
                        client.DownloadFile("https://www.dropbox.com/s/8a5oekhvwuujhqx/Update.zip?dl=1", "Update.zip");
                        DirectoryInfo diretorioArquivoBaixado = new DirectoryInfo("Update.zip");
                        Thread.Sleep(10);
                        string diretorioParaExtrair = @".\";
                        ZipFile.ExtractToDirectory(diretorioArquivoBaixado.FullName, diretorioParaExtrair);
                        File.Delete(@"..\Update.zip");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: \n\n" + ex);
                        Application.Exit();
                    }
                }
                else if (_progressBar.Value == 100)
                {
                    if (MessageBox.Show(@"Atualizado com Sucesso! O StandBy System vai abrir automaticamente em alguns segundos...",
                        @"APROVEITE!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Process.Start(@".\StandBy System.exe");
                        File.Delete(@"..\Update.zip");
                    }
                }
            }

            return Task.CompletedTask;
        }
    }
}