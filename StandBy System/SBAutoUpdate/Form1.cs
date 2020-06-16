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

                if (progress.Value == 50)
                {
                    var client = new WebClient();
                    //Directory.Delete(@".\", true);
                    File.Delete(@".\PFC - StandBy CSharp.exe");
                    File.Delete(@".\Bunifu.Core.dll");
                    File.Delete(@".\BunifuDataViz.dll");
                    File.Delete(@".\BunifuDataViz.xml");
                    File.Delete(@".\FontAwesome.Sharp.dll");
                    File.Delete(@".\PFC - StandBy CSharp.exe.config");
                    File.Delete(@".\PFC - StandBy CSharp.pdb");
                    //Directory.CreateDirectory(@".\");
                    client.DownloadFile("https://forum.brvipmodteam.ga/standbysystem/Update.zip", "Update.zip");
                    string zipPath = @".\Update.zip";
                    string extractPath = @".\";
                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                    File.Delete(@".\Update.zip");
                }
                else if (progress.Value == 100)
                {
                    if (MessageBox.Show("Atualizado com Sucesso!\nO StandBy System vai abrir automaticamente em alguns segundos...", 
                        "APROVEITE!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Process.Start(@".\PFC - StandBy CSharp.exe");
                    }
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
