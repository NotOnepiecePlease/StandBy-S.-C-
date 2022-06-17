using PFC___StandBy_CSharp.Dados;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_Concluido_Desfazer : Form
    {
        private int[] corGeral = { 0, 0, 0 };
        private AlterarDados ad = new AlterarDados();
        private DeletarDados dd = new DeletarDados();
        private form_Concluidos formConcluidos;

        public form_Concluido_Desfazer(form_Concluidos _formConcluidos, int[] _corRgb)
        {
            InitializeComponent();
            corGeral = _corRgb;
            formConcluidos = _formConcluidos;
            CentralizarLabels();
            MudarCores();
        }

        public void MudarCores()
        {
            lblData.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblAparelho.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblDefeito.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblNomeCliente.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnConfirmar.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnNegar.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            panelTop.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelLeft.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelRight.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            panelBottom.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        public void CentralizarLabels()
        {
            lblData.Left = (panel1.Width / 2) - (lblData.Width / 2);
            lblAparelho.Left = (panel1.Width / 2) - (lblAparelho.Width / 2);
            lblDefeito.Left = (panel1.Width / 2) - (lblDefeito.Width / 2);
            lblNomeCliente.Left = (panel1.Width / 2) - (lblNomeCliente.Width / 2);
        }

        private void form_Concluido_Desfazer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idservico = int.Parse(formConcluidos.table_ServicosConcluidos.SelectedCells[0].Value.ToString());
            ad.CancelarConclusaoServicos(idservico);
            dd.DeletarGarantia(idservico);
            formConcluidos.refreshTable();
            this.Close();
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}