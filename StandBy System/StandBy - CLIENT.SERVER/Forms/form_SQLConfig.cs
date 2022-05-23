using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Dados;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_SQLConfig : Form
    {
        private readonly BackupDados bckData = new BackupDados();

        public form_SQLConfig()
        {
            InitializeComponent();
            CarregarDadosConfiguracaoSql();
        }

        private List<string> BuscarDadosSQLtxt()
        {
            string txtPath = bckData.CAMINHO_TXT;
            return File.ReadAllLines(txtPath).ToList();
        }

        private void CarregarDadosConfiguracaoSql()
        {
            List<string> dadosSqlTxt = BuscarDadosSQLtxt();

            txtIP.Text = dadosSqlTxt[1].TrimStart('I', 'P', '=').Trim();
            txtPorta.Text = dadosSqlTxt[2].TrimStart('P', 'O', 'R', 'T', '=').Trim();
            txtLogin.Text = dadosSqlTxt[3].TrimStart('U', 'S', 'E', 'R', '=').Trim();
            txtSenha.Text = dadosSqlTxt[4].TrimStart('P', 'A', 'S', '=').Trim();
            txtType.Text = dadosSqlTxt[5].TrimStart('T', 'Y', 'P', 'E', '=').Trim();
        }

        private void SalvarDadosConfiguracoes()
        {
            List<string> DadosParaEscrever = new List<string>()
            {
                "#SQL Data Config",
                $"IP= {txtIP.Text}",
                $"PORT= {txtPorta.Text}",
                $"USER= {txtLogin.Text}",
                $"PASS= {txtSenha.Text}",
                $"TYPE= {txtType.Text}"
            };
            using (StreamWriter sw = File.CreateText(bckData.CAMINHO_TXT))
            {
                DadosParaEscrever.ForEach(x => sw.WriteLine(x));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDadosConfiguracoes();
            MessageBox.Show("Salvo com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }
    }
}