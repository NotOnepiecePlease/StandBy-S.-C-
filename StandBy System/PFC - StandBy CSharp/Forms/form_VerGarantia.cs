using PFC___StandBy_CSharp.Dados;
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
    public partial class form_VerGarantia : Form
    {
        BuscarDados bd = new BuscarDados();
        public form_VerGarantia()
        {
            InitializeComponent();
            CentralizarLabels();
            //bd.BuscarDiasGarantia(lblDataInicial, lblDataFinal, Convert.ToInt32(lblIDServico.Text));
        }

        public void EsconderComponentes()
        {
            lblAparelho.Visible = false;
            lblDataFinal.Visible = false;
            lblDataInicial.Visible = false;
            lblDiasRestantes.Visible = false;
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

        public void CentralizarLabels()
        {
            lblAparelho.Left = (this.Width / 2) - (lblAparelho.Width / 2);
            lblDataInicial.Left = (this.Width / 2) - (lblDataInicial.Width / 2);
            lblDataFinal.Left = (this.Width / 2) - (lblDataFinal.Width / 2);
            lblNomeCliente.Left = (this.Width / 2) - (lblNomeCliente.Width / 2);
            lblServico.Left = (this.Width / 2) - (lblServico.Width / 2);
            lblDiasRestantes.Left = (this.Width / 2) - (lblDiasRestantes.Width / 2);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_VerGarantia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
