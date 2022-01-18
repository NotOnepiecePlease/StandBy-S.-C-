using StandBy___CLIENT.SERVER.Dados;
using StandBy___CLIENT.SERVER.PreencherComponentes;
using System;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_TodosServicos : Form
    {
        PreencherTableTodosServicos preencherTabelaTodosServicos = new PreencherTableTodosServicos();
        AlterarDados ad = new AlterarDados();
        public form_TodosServicos()
        {
            InitializeComponent();
            preencherTabelaTodosServicos.Preencher(table_TodosServicos);
        }

        private void toolsANALISAR_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(table_TodosServicos.SelectedCells[0].Value);
            ad.ServicoAndamento(id);
        }

        private void timerAtualizarTabela_Tick(object sender, EventArgs e)
        {
            preencherTabelaTodosServicos.Preencher(table_TodosServicos);
            table_TodosServicos.ClearSelection();
        }

        private void table_TodosServicos_MouseEnter(object sender, EventArgs e)
        {
            timerAtualizarTabela.Stop();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_TodosServicos_Edit frmTodosServicos = new form_TodosServicos_Edit();
            frmTodosServicos.ShowDialog();
        }
    }
}
