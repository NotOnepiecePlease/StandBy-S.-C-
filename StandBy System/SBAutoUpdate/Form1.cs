using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using SBAutoUpdate.Classes;

namespace SBAutoUpdate
{
    public partial class Form1 : Form
    {
        private readonly VerificarTipoSistema verificarTipoSistema = new VerificarTipoSistema();

        public Form1()
        {
            InitializeComponent();
            progress.Value = 0;
            Atualizar();
        }

        private void Atualizar()
        {
            if (verificarTipoSistema.SeForSistemaPrincipal() == true)
            {
                Task.Run(() =>
                {
                    AtualizarStandBy.Atualizar(progress);
                    File.Delete(@"Update.zip");
                    FecharForm();
                });
            }
            else
            {
                Task.Run(() =>
                {
                    AtualizarClientServer.Atualizar(progress);
                    File.Delete(@"UpdateClientServer.zip");
                    FecharForm();
                });
            }
        }

        public void FecharForm()
        {
            Application.Exit();
        }
    }
}