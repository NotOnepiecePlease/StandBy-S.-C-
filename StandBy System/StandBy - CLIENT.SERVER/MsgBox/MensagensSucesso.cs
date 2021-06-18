using System.Windows.Forms;

namespace StandBy___CLIENT.SERVER.MsgBox
{
    class MensagensSucesso
    {
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //ORDENS DE SERVICO
        public void InserirServicoSucesso()
        {
            MessageBox.Show("Serviço inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço inserido com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void AlterarServicoSucesso()
        {
            MessageBox.Show("Serviço salvo com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço alterado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void DeletarServicoSucesso()
        {
            MessageBox.Show("Serviço deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço deletado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }




        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //SERVICOS CONCLUIDOS
        public void CancelarConclusaoSucesso()
        {
            MessageBox.Show("Serviço retornou com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço retornado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void ConcluirServicoSucesso()
        {
            MessageBox.Show("Serviço concluido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço concluido com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //CADASTRO DE CLIENTE
        public void AlterarClienteSucesso()
        {
            MessageBox.Show("Cliente alterado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Cliente alterado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void InserirClienteSucesso()
        {
            MessageBox.Show("Cliente inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Cliente inserido com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        public void DeletarClienteSucesso()
        {
            MessageBox.Show("Cliente deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Cliente deletado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }


    }
}
