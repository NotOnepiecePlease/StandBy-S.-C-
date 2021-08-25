using PFC___StandBy_CSharp.PreencherComponentes.Tela_5___Lucros;
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
    public partial class form_Gastos : Form
    {
        PreencherTabelaGastos preencherGastos = new PreencherTabelaGastos();
        int[] corGeral = { 0, 0, 0 };
        public form_Gastos(int[] _corRgb)
        {
            InitializeComponent();
            corGeral = _corRgb;
            MudarCores();
        }

        private void MudarCores()
        {
            txtPesquisarGastos.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            iconClose.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            iconClose.IconColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        private void form_Gastos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnPesquisarGastos_Click(object sender, EventArgs e)
        {
            preencherGastos.PreencherGastosEntreDatas(table_Gastos, datepicker1.Value, datepicker2.Value, 0);
        }

        private void txtPesquisarGastos_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarGastos.Text == "Digite o gasto que deseja buscar")
            {
                txtPesquisarGastos.Text = "";
                txtPesquisarGastos.Font = new Font(txtPesquisarGastos.Font, FontStyle.Regular);
                txtPesquisarGastos.BorderColorIdle = Color.White;
                txtPesquisarGastos.ForeColor = Color.White;
            }
        }

        private void txtPesquisarGastos_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarGastos.Text == "")
            {
                txtPesquisarGastos.Text = "Digite o gasto que deseja buscar";
                txtPesquisarGastos.Font = new Font(txtPesquisarGastos.Font, FontStyle.Italic);
                txtPesquisarGastos.ForeColor = Color.Silver;
                txtPesquisarGastos.BorderColorIdle = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
                preencherGastos.PreencherGastosEntreDatas(table_Gastos, datepicker1.Value, datepicker2.Value, 0);
            }
        }

        private void txtPesquisarGastos_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisarGastos.Text == "")
            {
                //
            }
            else
            {
                try
                {
                    //preencherClientes.PesquisarClienteNome(txtPesquisarGastos.Text, table_Clientes);
                    preencherGastos.BuscarGastosPorNome(table_Gastos, txtPesquisarGastos.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex + "");
                }
            }
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
