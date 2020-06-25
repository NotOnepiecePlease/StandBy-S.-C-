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
    public partial class form_Lucros_Gastos_Exibir_Alterar : Form
    {
        form_Lucros formLucros;
        AlterarDados ad = new AlterarDados();
        Formatar formatar = new Formatar();
        int[] corGeral = { 0, 0, 0 };
        public form_Lucros_Gastos_Exibir_Alterar(form_Lucros _formLucros, int[] corRgb)
        {
            InitializeComponent();
            formLucros = _formLucros;
            corGeral = corRgb;
            formatar.AplicarApenasNumeroVirgulaEMoeda(txtValorGastosEditar);
            MudarCores();
        }

        public void MudarCores()
        {
            panel1.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtProdutoGastosEditar.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtValorGastosEditar.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnAlterar.OnHoverBaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //Tirar o R$ do inicio do valor
                formatar.TirarMascara(txtValorGastosEditar);
                ad.AtualizarGastos(datePicker1.Value, txtProdutoGastosEditar.Text,
                Convert.ToDecimal(txtValorGastosEditar.Text), Convert.ToInt32(lblID.Text));
                formLucros.PreencherTableConformCheck();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void form_Lucros_Gastos_Exibir_Alterar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                formLucros.PreencherTableConformCheck();
                this.Close();
            }
        }
    }
}
