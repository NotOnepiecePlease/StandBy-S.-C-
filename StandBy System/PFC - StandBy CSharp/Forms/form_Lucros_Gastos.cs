using PFC___StandBy_CSharp.Dados;
using System;
using System.Drawing;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Utils;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_Lucros_Gastos : Form
    {
        //Objetos
        private form_Lucros formLucros;

        private readonly InserirDados ins_Dados = new InserirDados();

        //Formatar format_campos = new Formatar();
        private int[] corGeral = { 0, 0, 0 };

        public form_Lucros_Gastos(form_Lucros _formLucros, int[] corRgb)
        {
            InitializeComponent();
            corGeral = corRgb;
            MudarCores();
            FormatarCampos.AplicarApenasNumeroVirgulaEMoeda(txtValor);
            formLucros = _formLucros;
            radioGastoTemp.Checked = true;
        }

        public void MudarCores()
        {
            radioGastoReal.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            radioGastoTemp.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnInserirGasto.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtProduto.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtValor.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void form_Lucros_Gastos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnInserirGasto_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;
            try
            {
                if (radioGastoReal.Checked == true && radioGastoTemp.Checked == false)
                {
                    FormatarCampos.TirarMascara(txtValor);
                    ins_Dados.InserirGasto(dataAtual, txtProduto.Text, Convert.ToDecimal(txtValor.Text), 0);
                    MessageBox.Show(@"Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formLucros.PreencherTableConformCheck();
                }
                else if (radioGastoTemp.Checked == true && radioGastoReal.Checked == false)
                {
                    FormatarCampos.TirarMascara(txtValor);
                    ins_Dados.InserirGasto(dataAtual, txtProduto.Text, Convert.ToDecimal(txtValor.Text), 1);
                    MessageBox.Show(@"Sucesso!, Pressione ESC para sair!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formLucros.PreencherTableConformCheck();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            if (txtValor.Text.Equals("R$ 0,00"))
            {
                txtValor.Text = "";
            }
        }
    }
}