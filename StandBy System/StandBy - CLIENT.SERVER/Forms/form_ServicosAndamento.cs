using StandBy___CLIENT.SERVER.PreencherComponentes;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_ServicosAndamento : Form
    {
        PreencherTableTodosServicos preencherTableOrdensServ = new PreencherTableTodosServicos();
        public form_ServicosAndamento()
        {
            InitializeComponent();
            preencherTableOrdensServ.Preencher(table_ServicosAndamento);
        }
    }
}
