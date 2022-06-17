using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.Forms
{
    public partial class form_ServicosEdit : Form
    {
        public form_ServicosEdit()
        {
            InitializeComponent();
        }

        private void form_TodosServicos_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}