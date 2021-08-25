using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Forms;

namespace PFC___StandBy_CSharp.MsgBox
{
    class MensagensSucesso
    {
        public void Alert(string msg, form_AlertMessage.enmType type)
        {
            form_AlertMessage frm = new form_AlertMessage();
            frm.showAlert(msg, type);
        }

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //ORDENS DE SERVICO
        public void InserirServicoSucesso()
        {
            Alert("Serviço inserido \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Serviço inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço inserido com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void AlterarServicoSucesso()
        {
            Alert("Serviço salvo \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Serviço salvo com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço alterado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void DeletarServicoSucesso()
        {
            Alert("Serviço deletado \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Serviço deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço deletado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }




        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //SERVICOS CONCLUIDOS
        public void CancelarConclusaoSucesso()
        {
            Alert("Serviço retornou \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Serviço retornou com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço retornado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void ConcluirServicoSucesso()
        {
            Alert("Serviço concluido \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Serviço concluido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço concluido com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //CADASTRO DE CLIENTE
        public void AlterarClienteSucesso()
        {
            Alert("Cliente alterado \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Cliente alterado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Cliente alterado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void InserirClienteSucesso()
        {
            Alert("Cliente inserido \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Cliente inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Cliente inserido com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void DeletarClienteSucesso()
        {
            Alert("Cliente deletado \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Cliente deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Cliente deletado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }
    }
}
