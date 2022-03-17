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
    public partial class form_Lucros_Gastos : Form
    {
        //Objetos
        form_Lucros formLucros;
        readonly InserirDados ins_Dados = new InserirDados();
        Formatar format_campos = new Formatar();
        int[] corGeral = { 0, 0, 0 };
        
        public form_Lucros_Gastos(form_Lucros _formLucros, int[] corRgb)
        {
            InitializeComponent();
            corGeral = corRgb;
            MudarCores();
            format_campos.AplicarApenasNumeroVirgulaEMoeda(txtValor);
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
                    format_campos.TirarMascara(txtValor);
                    ins_Dados.InserirGasto(dataAtual, txtProduto.Text, Convert.ToDecimal(txtValor.Text), 0);
                    MessageBox.Show(@"Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formLucros.PreencherTableConformCheck();
                }
                else if (radioGastoTemp.Checked == true && radioGastoReal.Checked == false)
                {
                    format_campos.TirarMascara(txtValor);
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
            if(txtValor.Text.Equals("R$ 0,00"))
            {
                txtValor.Text = "";
            }
        }
    }
}
