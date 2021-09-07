using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using Bunifu.Framework.UI;
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
                        string myDir = @".\";
                        List<string> keepFiles = new List<string>();

                        keepFiles.Add("Guna.UI.dll");
                        keepFiles.Add("Bunifu_UI_v1.5.3.dll");
                        keepFiles.Add("Bunifu_UI_v1.5.3.xml");
                        keepFiles.Add("SBAutoUpdate.exe");
                        keepFiles.Add("SBAutoUpdate.exe.config");
                        keepFiles.Add("SBAutoUpdate.pdb");

                        DeleteAllExcept(myDir, keepFiles, true);


                        var client = new WebClient();
                        //Directory.CreateDirectory(@".\");
                        client.DownloadFile("https://www.dropbox.com/s/8a5oekhvwuujhqx/Update.zip?dl=1", "Update.zip");
                        DirectoryInfo di2 = new DirectoryInfo("Update.zip");
                        Thread.Sleep(10);
                        //Thread.Sleep(5000);
                        //string zipPath = @"..\Update.zip";
                        string extractPath = @".\";
                        //ZipFile.ExtractToDirectory(zipPath, extractPath);
                        ZipFile.ExtractToDirectory(di2.FullName, extractPath);
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
                    if (MessageBox.Show("Atualizado com Sucesso!\nO StandBy System vai abrir automaticamente em alguns segundos...",
                        "APROVEITE!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Process.Start(@".\StandBy System.exe");
                        File.Delete(@"..\Update.zip");
                    }
                }
            }
        }

        public static void DeleteAllExcept(string folderPath, List<string> except, bool recursive = true)
        {
            var dir = new DirectoryInfo(folderPath);

            //Delete files excluding the list of file names
            foreach (var fi in dir.GetFiles().Where(n => !except.Contains(n.Name)))
            {
                fi.Delete();
            }

            //Loop sub directories if recursive == true
            if (recursive)
            {
                foreach (var di in dir.GetDirectories())
                {
                    DeleteAllExcept(di.FullName, except, recursive);
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
