using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Dados;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_OrdemServico : Form
    {
        private BuscarDados buscarDados = new BuscarDados();

        public form_OrdemServico()
        {
            InitializeComponent();
            GerarNovaOrdemServico();
            lblDataOrdemServico.Text = $"{DateTime.Now:G}";
        }

        private void GerarNovaOrdemServico()
        {
            int? ultimaOrdemServicoAdicionada = buscarDados.BuscarUltimaIdOrdemServico();

            if (ultimaOrdemServicoAdicionada != null)
            {
                int? novaOrdemServico = ultimaOrdemServicoAdicionada + 1;
                lblOrdemServico.Text = $@"OS {novaOrdemServico:0000}";
            }
        }

        private void txtStatusServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusServico.Text == "APROVADO")
            {
                cmbStatusServico.BackColor = Color.DodgerBlue;
                cmbStatusServico.BackgroundColor = Color.DodgerBlue;
            }
            else if (cmbStatusServico.Text == "AVALIAÇÃO")
            {
                cmbStatusServico.BackColor = Color.DarkOrange;
                cmbStatusServico.BackgroundColor = Color.DarkOrange;
            }
            else if (cmbStatusServico.Text == "CONCLUÍDO")
            {
                cmbStatusServico.BackColor = Color.Chartreuse;
                cmbStatusServico.BackgroundColor = Color.Chartreuse;
            }
        }

        private void txtStatusServico_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStatusServico_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void txtStatusServico_Click(object sender, EventArgs e)
        {
        }
    }
}