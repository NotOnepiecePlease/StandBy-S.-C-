using PFC___StandBy_CSharp.Dados;
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
    public partial class form_Lucros_Gastos_Exibir : Form
    {
        form_Lucros formLucros;
        PreencherTabelaGastos tab_Gastos = new PreencherTabelaGastos();
        AlterarDados ad = new AlterarDados();
        DeletarDados dd = new DeletarDados();
        int[] corGeral = { 0, 0, 0 };
        public form_Lucros_Gastos_Exibir(form_Lucros _formLucros, int[] corRgb, bool _checkBox)
        {
            InitializeComponent();
            corGeral = corRgb;
            tab_Gastos.Preencher(tabelaGastos, 0);
            MudarCores();
            formLucros = _formLucros;
            checkGastos.Checked = _checkBox;
        }

        public void MudarCores()
        {
            panelTopColor.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            checkGastos.CheckedOnColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[0].BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[1].BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            menu.Items[2].BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }
        private void form_Lucros_Gastos_Exibir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void checkGastos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGastos.Checked == true)
            {
                //tornar temp
                menu.Items[0].Visible = false;
                //tornar real
                menu.Items[1].Visible = true;
                lblGastos.Text = "Exibindo Gastos Temp";
                tab_Gastos.Preencher(tabelaGastos, 1);
            }
            else
            {
                //tornar temp
                menu.Items[0].Visible = true;
                //tornar real
                menu.Items[1].Visible = false;
                lblGastos.Text = "Exibindo Gastos Reais";
                tab_Gastos.Preencher(tabelaGastos, 0);
            }
        }

        private void tabelaGastos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            int realORtemp = Convert.ToInt32(tabelaGastos.SelectedCells[4].Value);
            if (realORtemp == 0)
            {
                DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() + "\n\nDeseja tornar um gasto temporario?", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogTemp == DialogResult.Yes)
                {
                    ad.AlterarGastos(gastoID, 1);
                    tab_Gastos.Preencher(tabelaGastos, 0);
                    formLucros.PreencherTableConformCheck();
                }
                else
                {
                }
            }
            else if (realORtemp == 1)
            {
                DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() + "\n\nDeseja tornar um gasto real?", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogTemp == DialogResult.Yes)
                {
                    ad.AlterarGastos(gastoID, 0);
                    tab_Gastos.Preencher(tabelaGastos, 1);
                    formLucros.PreencherTableConformCheck();
                }
                else
                {
                }
            }
        }

        private void tornarTemporarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() +
                "\n\nDeseja tornar um gasto temporario?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                ad.AlterarGastos(gastoID, 1);
                tab_Gastos.Preencher(tabelaGastos, 0);
                formLucros.PreencherTableConformCheck();
            }
            else
            {
            }
        }

        private void tornarRealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() +
                "\n\nDeseja tornar um gasto real?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                ad.AlterarGastos(gastoID, 0);
                tab_Gastos.Preencher(tabelaGastos, 1);
                formLucros.PreencherTableConformCheck();
            }
            else
            {
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gastoID = Convert.ToInt32(tabelaGastos.SelectedCells[0].Value);
            int status = Convert.ToInt32(tabelaGastos.SelectedCells[4].Value);
            DialogResult dialogTemp = MessageBox.Show("Produto: " + tabelaGastos.SelectedCells[2].Value.ToString() + "\n\nDeseja deletar esse gasto?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogTemp == DialogResult.Yes)
            {
                if (status == 0)
                {
                    dd.DeletarGastos(gastoID, tabelaGastos);
                    tab_Gastos.Preencher(tabelaGastos, 0);
                    formLucros.PreencherTableConformCheck();
                }
                else if (status == 1)
                {
                    dd.DeletarGastos(gastoID, tabelaGastos);
                    tab_Gastos.Preencher(tabelaGastos, 1);
                    formLucros.PreencherTableConformCheck();
                }
            }
            else
            {
            }
        }
    }
}
