using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using System.Threading;

namespace SBAutoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progress.Value = 0;
            BaixarNovaVersao();
            Update.WorkerReportsProgress = true;
            //backProgress.WorkerReportsProgress = true;
            //backProgress.RunWorkerAsync();
        }

        public void BaixarNovaVersao()
        {
            Thread.Sleep(5000);
            Update.RunWorkerAsync();
        }

        private void Update_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                progress.Value += 2;
                Update.ReportProgress(2);

                foreach (var process in Process.GetProcessesByName("StandBy System"))
                {
                    process.Kill();
                }

                if (progress.Value == 50)
                {
                    foreach (var process in Process.GetProcessesByName("StandBy System"))
                    {
                        process.Kill();
                    }
                    Thread.Sleep(3000);
                    try
                    {
                        string meuDiretorio = @".\";
                        List<string> arquivosSeremMantidos = new List<string>
                        {
                            "Guna.UI.dll",
                            "Bunifu_UI_v1.5.3.dll",
                            "Bunifu_UI_v1.5.3.xml",
                            "SBAutoUpdate.exe",
                            "SBAutoUpdate.exe.config",
                            "SBAutoUpdate.pdb"
                        };

                        DeleteTodosExceto(meuDiretorio, arquivosSeremMantidos, true);

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
                else if (progress.Value == 100)
                {
                    if (MessageBox.Show(@"Atualizado com Sucesso! O StandBy System vai abrir automaticamente em alguns segundos...",
                        @"APROVEITE!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Process.Start(@".\StandBy System.exe");
                        File.Delete(@"..\Update.zip");
                    }
                }
            }
        }

        public static void DeleteTodosExceto(string meuDiretorio, List<string> arquivosParaManter, bool recursive = true)
        {
            var DiretorioDoExecutavel = new DirectoryInfo(meuDiretorio);

            //Delete files excluding the list of file names
            foreach (var arquivo in DiretorioDoExecutavel.GetFiles().Where(n => !arquivosParaManter.Contains(n.Name)))
            {
                arquivo.Delete();
            }

            //Loop sub directories if recursive == true
            if (recursive)
            {
                foreach (var di in DiretorioDoExecutavel.GetDirectories())
                {
                    DeleteTodosExceto(di.FullName, arquivosParaManter, recursive);
                }
            }
        }

        public void StatusPorcento()
        {
            lblPorcento.Text = progress.Value + "%";
        }

        public void FecharForm()
        {
            this.Close();
        }

        private void Update_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StatusPorcento();
        }

        private void Update_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FecharForm();
        }
    }
}