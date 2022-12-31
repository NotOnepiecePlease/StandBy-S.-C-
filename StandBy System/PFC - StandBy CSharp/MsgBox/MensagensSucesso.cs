using System;
using System.Linq;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Forms;

namespace PFC___StandBy_CSharp.MsgBox
{
    internal class MensagensSucesso
    {
        private static form_AlertMessage frm;

        public void Alert(string msg, form_AlertMessage.enmType type)
        {
            //form_AlertMessage frm = new form_AlertMessage();
            //frm.showAlert(msg, type);
            if (Application.OpenForms.OfType<form_AlertMessage>().Count() > 0)
            {
                //MessageBox.Show("O Form2 já está aberto!");
                frm.showAlert(msg, type);
            }
            else
            {
                frm = new form_AlertMessage();
                frm.showAlert(msg, type);
            }
        }

        #region ORDENS DE SERVICO

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

        public void AlterarSenhaPadraoSucesso()
        {
            Alert("Senha Padrão Alterada \ncom sucesso!", form_AlertMessage.enmType.Success);
            //MessageBox.Show("Serviço deletado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //form_ALERT message = new form_ALERT("Serviço deletado com sucesso!", form_ALERT.AlertType.Sucesso);
            //message.Show();
        }

        #endregion ORDENS DE SERVICO

        #region SERVICOS CONCLUIDOS

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

        #endregion SERVICOS CONCLUIDOS

        #region CADASTRO DE CLIENTE

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

        

        #endregion CADASTRO DE CLIENTE
    }
}