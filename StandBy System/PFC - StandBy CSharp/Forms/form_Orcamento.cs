using PFC___StandBy_CSharp.PreencherComponentes.Tela_4___Orcamentos;
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
    public partial class form_Orcamento : Form
    {
        int[] corGeral = { 0, 0, 0 };
        PreencherTableOrcamento preencherTable = new PreencherTableOrcamento();
        public form_Orcamento(int[] _corRgb)
        {
            InitializeComponent();
            corGeral = _corRgb;
            MudarCores();
            PreencherTabela("SAMSUNG");
            lblOrcStatus.Visible = false;
        }

        private void MudarCores()
        {
            menu.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            submenuAdicionarNovo.BackColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
        }

        public void PreencherTabela(string _marca)
        {
            preencherTable.Preencher(tabelaOrcamento, _marca, lblOrcStatus);
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            PreencherTabela("SAMSUNG");
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            PreencherTabela("IPHONE");
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            PreencherTabela("ALCATEL");
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            PreencherTabela("ASUS");
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            PreencherTabela("XIAOMI");
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            PreencherTabela("LENOVO");
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            PreencherTabela("MOTOROLA");
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            PreencherTabela("LG");
        }

        private void submenuAdicionarNovo_Click(object sender, EventArgs e)
        {
            using (form_Orcamento_Adicionar orcAdiciona = new form_Orcamento_Adicionar(this, corGeral))
            {
                orcAdiciona.ShowDialog();
            }
        }
    }
}
