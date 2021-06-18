using StandBy___CLIENT.SERVER.Dados;
using StandBy___CLIENT.SERVER.PreencherComponentes;
using System;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_TodosServicos : Form
    {
        PreencherTableOrdensServicos preencherTabelaTodosServicos = new PreencherTableOrdensServicos();
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
    }
}
