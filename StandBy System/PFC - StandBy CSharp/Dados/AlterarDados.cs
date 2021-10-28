﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.Forms;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Dados
{
    class AlterarDados : conexao
    {
        MensagensErro mErro = new MensagensErro();
        MensagensSucesso mSucesso = new MensagensSucesso();
        VerificarExistencia verificarExistencia = new VerificarExistencia();


        #region Atualizar coluna das cores
        public void atualizarColunaTempoCores(int _id, DateTime _previsaoEntrega)
        {
            try
            {
                using(SqlConnection con = OpenConnection())
                {
                    //4 = sem cor
                    //1 = verde
                    //2 = amarelo/laranja
                    //3 = vermelho
                    string Query = "";

                    DateTime dataEntrega = _previsaoEntrega;
                    DateTime dataAtual = DateTime.Now;

                    TimeSpan DiasParaEntrega = dataEntrega.Subtract(dataAtual);

                    if (DiasParaEntrega.TotalHours < 0)
                    {
                        //row.Cells[2].Style.BackColor = Color.Red;
                        //row.Cells[2].Style.ForeColor = Color.Black;
                        Query = "UPDATE tb_servicos SET sv_cor_tempo = 3 WHERE sv_id = @_IdServico";
                    }
                    else if (DiasParaEntrega.TotalHours >= 0 && DiasParaEntrega.TotalHours <= 12)
                    {
                        //row.Cells[2].Style.BackColor = Color.Orange;
                        //row.Cells[2].Style.ForeColor = Color.Black;
                        Query = "UPDATE tb_servicos SET sv_cor_tempo = 2 WHERE sv_id = @_IdServico";
                    }
                    else if (DiasParaEntrega.TotalHours > 12)
                    {
                        //row.Cells[2].Style.BackColor = Color.Lime;
                        //row.Cells[2].Style.ForeColor = Color.Black;
                        Query = "UPDATE tb_servicos SET sv_cor_tempo = 1 WHERE sv_id = @_IdServico";
                    }
                    else
                    {
                        //row.Cells[2].Style.BackColor = Color.FromArgb(30, 30, 46);
                        //row.Cells[2].Style.ForeColor = Color.Gray;
                        Query = "UPDATE tb_servicos SET sv_cor_tempo = 4 WHERE sv_id = @_IdServico";
                    }

                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.Parameters.AddWithValue("@_IdServico", SqlDbType.Int).Value = _id;

                    cmd.ExecuteNonQuery();

                    //Msg Sucesso
                }
            }
            catch (Exception e)
            {
                //Msg Erro
                mErro.ErroAoAtualizarCoresTempo(e);
            }
        }
        #endregion

        #region Alterar Senha de Padrão
        public void AlterarSenhaPattern(byte[] _image, int _idServico)
        {
            try
            {
                using(SqlConnection con = OpenConnection())
                {
                    string query = "UPDATE tb_servicos SET sv_senha_pattern = @ImagePattern WHERE sv_id = @idServico";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ImagePattern", SqlDbType.Image).Value = _image;
                    cmd.Parameters.AddWithValue("@idServico", SqlDbType.Int).Value = _idServico;

                    cmd.ExecuteNonQuery();

                    mSucesso.AlterarSenhaPadraoSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAoAlterarSenhaPadrao(ex);
            }
        }
        #endregion

        #region Alterar Servicos
        public void AlterarServico(int _idServico, DateTime _data, string _aparelho, string _defeito, string _senha,
            string _situacao, float _valorServico, float _valorPeca, float _lucro, string _servico, DateTime _dataPrevisao, string _acessorios)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "";
                    if (_dataPrevisao == DateTime.Parse("26/03/2020"))
                    {
                        query = "update tb_servicos set sv_data = @Data, sv_aparelho = @Aparelho, sv_defeito = @Defeito, " +
                        "sv_senha = @Senha, sv_situacao = @Situacao, sv_valorservico = @ValorServico, sv_valorpeca = @ValorPeca, " +
                        "sv_lucro = @Lucro, sv_servico = @Servico, sv_previsao_entrega = null, sv_existe_um_prazo = 0, sv_acessorios = @Acessorios, sv_cor_tempo = 4 where sv_id = @IdServico";
                    }
                    else
                    {
                        query = "update tb_servicos set sv_data = @Data, sv_aparelho = @Aparelho, sv_defeito = @Defeito, " +
                        "sv_senha = @Senha, sv_situacao = @Situacao, sv_valorservico = @ValorServico, sv_valorpeca = @ValorPeca, " +
                        "sv_lucro = @Lucro, sv_servico = @Servico, sv_previsao_entrega = @DataPrevisao, sv_existe_um_prazo = 1, sv_acessorios = @Acessorios where sv_id = @IdServico";
                    }

                    //SqlCommand cmd = new SqlCommand("AlterarServicos", con);
                    SqlCommand cmd = new SqlCommand(query, con);

                    //cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = _data;
                    cmd.Parameters.Add("@Aparelho", SqlDbType.NVarChar).Value = _aparelho;
                    cmd.Parameters.Add("@Defeito", SqlDbType.NVarChar).Value = _defeito;
                    cmd.Parameters.Add("@Senha", SqlDbType.NVarChar).Value = _senha;
                    cmd.Parameters.Add("@Situacao", SqlDbType.NVarChar).Value = _situacao;
                    cmd.Parameters.Add("@ValorServico", SqlDbType.Float).Value = _valorServico;
                    cmd.Parameters.Add("@ValorPeca", SqlDbType.Float).Value = _valorPeca;
                    cmd.Parameters.Add("@Lucro", SqlDbType.Float).Value = _lucro;
                    cmd.Parameters.Add("@Servico", SqlDbType.NVarChar).Value = _servico;
                    cmd.Parameters.Add("@IdServico", SqlDbType.Int).Value = _idServico;
                    cmd.Parameters.Add("@DataPrevisao", SqlDbType.DateTime).Value = _dataPrevisao;
                    cmd.Parameters.Add("@Acessorios", SqlDbType.NVarChar).Value = _acessorios;
                    cmd.ExecuteNonQuery();

                    con.Close();
                    //MessageBox.Show("SUCESSO");
                    //formServ.refreshTable();
                    mSucesso.AlterarServicoSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAlterarServico(ex);
            }
        }
        #endregion

        #region Alterar Clientes
        public void AlterarClientes(int _idcliente, string _nome, string _telefone, string _cpfOuCnpj, string _telefoneRecados)
        {
            bool cpfExistente = verificarExistencia.VerificarExistenciaCPF(_cpfOuCnpj);
            //if(cpfExistente == true)
            //{
            //    MessageBox.Show("CPF Já existe, verifique se o cliente já esta cadastrado.", "CPF Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "UPDATE [dbo].[tb_clientes] " +
                        "SET[cl_nome] = @_nome " +
                        ",[cl_telefone] = @_telefone " +
                        ",[cl_telefone_recado] = @_telefoneRecados " +
                        ",[cl_cpf] = @_cpf " +
                        " WHERE cl_id = @_idcliente";
                    //SqlCommand cmd = new SqlCommand("AlterarClientes", con);
                    SqlCommand cmd = new SqlCommand(query, con);

                    //cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@_nome", SqlDbType.VarChar).Value = _nome;
                    cmd.Parameters.AddWithValue("@_telefone", SqlDbType.VarChar).Value = _telefone;
                    cmd.Parameters.AddWithValue("@_telefoneRecados", SqlDbType.VarChar).Value = _telefoneRecados;
                    cmd.Parameters.AddWithValue("@_cpf", SqlDbType.VarChar).Value = _cpfOuCnpj;
                    cmd.Parameters.AddWithValue("@_idcliente", SqlDbType.VarChar).Value = _idcliente;

                    cmd.ExecuteNonQuery();

                    mSucesso.AlterarClienteSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAlterarCliente(ex);
            }
            //}
        }
        #endregion

        #region Concluir Servicos
        public void ConcluirServicos(int _idServico)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    //string procedure = "Servico_Concluir";
                    string query = "update tb_servicos set sv_status = 0, sv_data_conclusao = GETDATE() where sv_id = @sv_id";

                    //SqlCommand cmd = new SqlCommand(procedure, con);
                    SqlCommand cmd = new SqlCommand(query, con);

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sv_id", _idServico);
                    cmd.ExecuteNonQuery();

                    mSucesso.ConcluirServicoSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAoConcluirServico(ex);
            }
        }
        #endregion

        #region Cancelar Serviço concluido
        public void CancelarConclusaoServicos(int _idServico)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string procedure = "Servico_Cancelar_Conclusao";
                    SqlCommand cmd = new SqlCommand(procedure, con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sv_id", _idServico);

                    cmd.ExecuteNonQuery();

                    mSucesso.CancelarConclusaoSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAoCancelarConclusao(ex);
            }
        }
        #endregion

        #region Alterar os Gastos
        public void AlterarGastos(int _idGasto, int _realORtemp)
        {
            //Alterar para gasto fixo ou temporario
            using (SqlConnection conexao = OpenConnection())
            {
                string procedure = "GastosAlterarRealOrTemp";
                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_RealOrTemp", _realORtemp);
                cmd.Parameters.AddWithValue("@_ID", _idGasto);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Atualizar Gastos
        public void AtualizarGastos(DateTime _data, string _produto, decimal _valor, int _id)
        {
            //Atualizar dados dos gastos, como data ou nome do produto.
            using (SqlConnection conexao = OpenConnection())
            {
                string procedure = "GastosAlterar";
                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_Data", _data);
                cmd.Parameters.AddWithValue("@_Produto", _produto);
                cmd.Parameters.AddWithValue("@_Valor", _valor);
                cmd.Parameters.AddWithValue("@_ID", _id);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Resetar Dados Mensais
        public void ResetarDadosMensais()
        {
            try
            {
                using (SqlConnection conexao = OpenConnection())
                {
                    string procedure = "ResetarMes";

                    SqlCommand cmd = new SqlCommand(procedure, conexao);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mes resetado com sucesso, tenha um excelente trabalho este mês!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao resetar o mes!\n\n" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
