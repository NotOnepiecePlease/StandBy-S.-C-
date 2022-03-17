using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Formatar_Campos;
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
    public partial class form_Orcamento_Adicionar : Form
    {
        Formatar formatar = new Formatar();
        int[] corGeral = { 0, 0, 0 };
        InserirDados inserirDados = new InserirDados();
        form_Orcamento formOrcamento;
        public form_Orcamento_Adicionar(form_Orcamento _formOrcamento, int[] _corRgb)
        {
            InitializeComponent();
            formOrcamento = _formOrcamento;
            formatar.AplicarApenasNumeroVirgulaEMoeda(txtValor);
            formatar.AplicarApenasNumeroVirgulaEMoeda(txtPeca);
            formatar.AplicarApenasNumeroVirgulaEMoeda(txtTotal);
            corGeral = _corRgb;
            MudarCores();
        }

        private void MudarCores()
        {
            cmbMarca.OnHoverItemBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtModelo.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtPeca.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtTotal.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtValor.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnAdd.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void form_Orcamento_Adicionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMarca.SelectedItem.ToString()) || string.IsNullOrEmpty(txtModelo.Text) || string.IsNullOrEmpty(txtPeca.Text) || string.IsNullOrEmpty(txtTotal.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show(@"Preencha todos os campos antes de clicar no botão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                formatar.TirarMascara(txtPeca);
                formatar.TirarMascara(txtValor);
                formatar.TirarMascara(txtTotal);
                inserirDados.InserirOrcamento(cmbMarca.SelectedItem.ToString(), txtModelo.Text, Convert.ToDecimal(txtPeca.Text), Convert.ToDecimal(txtValor.Text), Convert.ToDecimal(txtTotal.Text));
                formOrcamento.PreencherTabela(cmbMarca.SelectedItem.ToString());
                this.Close();
            }
        }
    }
}
