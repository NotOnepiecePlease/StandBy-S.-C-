using PFC___StandBy_CSharp.Graficos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_ServicosAnuais : Form
    {
        int anoAtual = DateTime.Now.Year;
        int[] corGeral = { 0, 0, 0 };
        GraficoServicosAnuais graficoAno = new GraficoServicosAnuais();
        GraficoTotalGanhoAnualmente totalGanhoAno = new GraficoTotalGanhoAnualmente();
        public form_ServicosAnuais(int[] corRgb)
        {
            InitializeComponent();
            corGeral = corRgb;
            graficoAno.Preencher(bunifuDataViz1, anoAtual, lblJan, lblFev, lblMar, lblAbr, lblMai, lblJun, lblJul, lblAgo, lblSet, lblOut, lblNov, lblDez, corGeral);
            cmbAno.SelectedIndex = 0;
            //totalGanhoAno.TotalGanho(lblValorGanhoAnualmente, anoAtual);
            MudarCores();
        }

        public void MudarCores()
        {
            lblValorGanhoAnualmente.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //cmbAno.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblJan.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblFev.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblMar.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblAbr.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblMai.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblJun.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblJul.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblAgo.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblSet.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblOut.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblNov.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblDez.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnfechar.BaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelLinhaTopo.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void form_ServicosAnuais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnPesquisarAno_Click(object sender, EventArgs e)
        {
            try
            {
                int anoCmb = Convert.ToInt32(cmbAno.SelectedItem);
                bunifuDataViz1.Refresh();
                bunifuDataViz1.Update();
                graficoAno.Preencher(bunifuDataViz1, anoCmb, lblJan, lblFev, lblMar, lblAbr, lblMai, lblJun, lblJul, lblAgo, lblSet, lblOut, lblNov, lblDez, corGeral);
                totalGanhoAno.TotalGanho(lblValorGanhoAnualmente, anoCmb);
            }
            catch (Exception)
            {
                MessageBox.Show("Nao existem dados neste ano.", "SEM DADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
