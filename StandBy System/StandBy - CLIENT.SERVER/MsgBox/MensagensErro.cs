using System;
using System.Windows.Forms;
using PFC___StandBy_CSharp.SqlDbConnect;

namespace StandBy___CLIENT.SERVER.MsgBox
{
    internal class MensagensErro : conexao
    {
        #region ORDENS DE SERVICO

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        // EEROS DA TELA DE ORDENS DE SERVICO
        public void ComboBoxClienteErroEmPreencher(Exception e)
        {
            MessageBox.Show("(OR-SV01)Erro ao tentar preencher os clientes na combobox!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV01)Erro ao tentar preencher os clientes na combobox!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroBuscarIdCliente(Exception e)
        {
            MessageBox.Show("(OR-SV02)Erro ao tentar buscar a ID do cliente!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV02)Erro ao tentar buscar a ID do cliente!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroInserirServico(Exception e)
        {
            MessageBox.Show("(OR-SV03)Erro ao tentar inserir serviço!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV03)Erro ao tentar inserir serviço!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroPreencherTabelaServicos(Exception e)
        {
            MessageBox.Show("(OR-SV04)Erro ao tentar preencher a tabela de serviços!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV04)Erro ao tentar preencher a tabela de serviços!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroPreencherServicosCliente(Exception e)
        {
            MessageBox.Show("(OR-SV05)Erro ao preencher os serviços do cliente solicitado!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV05)Erro ao preencher os serviços do cliente solicitado!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroAlterarServico(Exception e)
        {
            MessageBox.Show("(OR-SV06)Erro ao alterar o serviço do cliente!\nERRO: " + e + "",
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroDeletarServico(Exception e)
        {
            MessageBox.Show("(OR-SV07)Erro ao deletar o serviço do cliente!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV07)Erro ao deletar o serviço do cliente!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroAoConcluirServico(Exception e)
        {
            MessageBox.Show("(OR-SV08)Erro ao concluir serviço!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV08)Erro ao concluir serviço!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroAoAlterarSenhaPadrao(Exception e)
        {
            MessageBox.Show("(OR-SV09)Erro ao alterar senha de padrão!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV08)Erro ao concluir serviço!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroAoAtualizarCoresTempo(Exception e)
        {
            MessageBox.Show("(OR-SV10)Erro ao atualizar as cores do status!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(OR-SV08)Erro ao concluir serviço!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroAoAbrirTelaDeEdicaoServicos(Exception e)
        {
            MessageBox.Show("(OR-SV11)Erro ao abrir tela de edição!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroAoBuscarIDUltimoServico(Exception e)
        {
            MessageBox.Show("(OR-SV12)Erro buscar o ultimo serviço!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion ORDENS DE SERVICO

        #region SERVICOS CONCLUIDOS

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //SERVICOS CONCLUIDOS
        public void ErroAoCancelarConclusao(Exception e)
        {
            MessageBox.Show("(SV-CN01)Erro ao retornar serviço concluido!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(SV-CN01)Erro ao retornar serviço concluido!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        #endregion SERVICOS CONCLUIDOS

        #region GARANTIAS

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //GARANTIAS
        public void ErroAoDeletarGarantia(Exception e)
        {
            MessageBox.Show("(GAR01)Erro ao apagar a garantia!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(SV-CN01)Erro ao retornar serviço concluido!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        #endregion GARANTIAS

        #region CADASTRO DE CLIENTE

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //ERROS DA TELA DE CADASTRO DE CLIENTE
        public void ErroAlterarCliente(Exception e)
        {
            MessageBox.Show("(CAD-CL01)Erro ao alterar o serviço do cliente!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //
        }

        public void ErroInserirCliente(Exception e)
        {
            MessageBox.Show("(CAD-CL02)Erro ao tentar inserir o cliente!\n\n" + e, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(CAD-CL02)Erro ao tentar inserir o cliente!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroDeletarCliente(Exception e)
        {
            MessageBox.Show("(CAD-CL03)Erro ao deletar o cliente!\nERRO: " + e + "", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(CAD-CL03)Erro ao deletar o cliente!", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        public void ErroClientePossuiServicos()
        {
            MessageBox.Show(@"(CAD-CL04)Cliente possui servicos ativos, nao pode ser deletado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //form_ALERT message = new form_ALERT("(CAD-CL04)Cliente possui servicos ativos, nao pode ser deletado.", form_ALERT.AlertType.Erro);
            //message.Show();
        }

        #endregion CADASTRO DE CLIENTE
    }
}