using PFC___StandBy_CSharp.Dados;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_VerGarantia : Form
    {
        private BuscarDados bd = new BuscarDados();
        private int[] corGeral = { 0, 0, 0 };

        public form_VerGarantia(int[] _corRgb)
        {
            InitializeComponent();
            corGeral = _corRgb;
            CentralizarLabels();
            MudarCores();
            //bd.BuscarDiasGarantia(lblDataInicial, lblDataFinal, Convert.ToInt32(lblIDServico.Text));
        }

        public void MudarCores()
        {
            lblAparelho.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblDataFinal.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblDataInicial.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            //lblDiasRestantes.Visible = false;
            //lblIDServico.Visible = false;
            lblNomeCliente.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblServico.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelGarantia.LineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnConfirmar.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        public void CentralizarLabels()
        {
            lblAparelho.Left = (this.Width / 2) - (lblAparelho.Width / 2);
            lblDataInicial.Left = (this.Width / 2) - (lblDataInicial.Width / 2);
            lblDataFinal.Left = (this.Width / 2) - (lblDataFinal.Width / 2);
            lblNomeCliente.Left = (this.Width / 2) - (lblNomeCliente.Width / 2);
            lblServico.Left = (this.Width / 2) - (lblServico.Width / 2);
            lblDiasDeGarantia.Left = (this.Width / 2) - (lblDiasDeGarantia.Width / 2);
        }

        public void EsconderComponentes()
        {
            lblAparelho.Visible = false;
            lblDataFinal.Visible = false;
            lblDataInicial.Visible = false;
            lblDiasDeGarantia.Visible = false;
            lblIDServico.Visible = false;
            lblNomeCliente.Visible = false;
            lblServico.Visible = false;

            gunaLabel1.Visible = false;
            gunaLabel2.Visible = false;
            gunaLabel3.Visible = false;
            gunaLabel4.Visible = false;
            gunaLabel5.Visible = false;
            gunaLabel6.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_VerGarantia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}