using StandBy___CLIENT.SERVER.PreencherComponentes;
using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_ServicosAndamento : Form
    {
        PreencherTableOrdensServicos preencher = new PreencherTableOrdensServicos();
        public form_ServicosAndamento()
        {
            InitializeComponent();
            preencher.PreencherServicosAndamento(table_ServicosAndamento);
        }
    }
}
