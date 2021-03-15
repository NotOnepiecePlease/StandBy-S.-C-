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
    public partial class form_QntdGarantia : Form
    {
        Formatar formatar = new Formatar();
        InserirDados ins_Dados = new InserirDados();
        AlterarDados ad = new AlterarDados();
        int[] CorGeral = { 0, 0, 0 };
        public form_QntdGarantia(int[] _corRgb)
        {
            InitializeComponent();
            CorGeral = _corRgb;
            MudarCores();
        }

        private void MudarCores()
        {
            btnConcluirServico.OnPressedColor = Color.FromArgb(CorGeral[0], CorGeral[1], CorGeral[2]);
        }

        private void gunaTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            formatar.AplicarApenasNumerosSemVirgula(txtGarantiaDias);
        }

        private void form_QntdGarantia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ConcluirServico();
                DarGarantia();
                this.Close();
            }
        }

        public void ConcluirServico()
        {
            ad.ConcluirServicos(Int32.Parse(lblIDServico.Text));
            //formServ1.refreshTable();
        }

        public void DarGarantia()
        {
            ins_Dados.InserirGarantia(Convert.ToInt32(lblIDServico.Text), Convert.ToInt32(lblIDCliente.Text), Convert.ToInt32(txtGarantiaDias.Text));
        }
        private void btnConcluirServico_Click(object sender, EventArgs e)
        {
            if (txtGarantiaDias.Text.Length < 1)
            {
                MessageBox.Show("Digite a quantidade de dias ou digite 0 para nenhuma garantia!.");
            }
            else
            {
                ConcluirServico();
                DarGarantia();
                this.Close();
            }
        }
    }
}
