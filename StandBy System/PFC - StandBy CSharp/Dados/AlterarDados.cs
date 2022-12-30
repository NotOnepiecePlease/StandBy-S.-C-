using System;
using System.Data;
using System.Data.SqlClient;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Models;

namespace PFC___StandBy_CSharp.Dados
{
    public class AlterarDados : conexao
    {
        private readonly MensagensErro mErro = new MensagensErro();
        private readonly MensagensSucesso mSucesso = new MensagensSucesso();

        public void AtualizarColunaTempoEntrega(SqlConnection _con, string _tempo, int _id)
        {
            try
            {
                //using (SqlConnection con = OpenConnection())
                //{
                string query = "update tb_servicos set sv_tempo_para_entregar = @tempo where sv_id = @id";

                SqlCommand cmd = new SqlCommand(query, _con);

                cmd.Parameters.Add("@tempo", SqlDbType.VarChar).Value = _tempo;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = _id;

                cmd.ExecuteNonQuery();
                //}
            }
            catch (Exception e)
            {
                mErro.ErroAoAtualizarTempoRestanteEntrega(e);
            }
        }

        #region Atualizar coluna das cores

        public void atualizarColunaTempoCores(SqlConnection _con, int _id, DateTime _previsaoEntrega)
        {
            try
            {
                //4 = sem cor
                //1 = verde
                //2 = amarelo/laranja
                //3 = vermelho
                string query = "";

                DateTime dataEntrega = _previsaoEntrega;
                DateTime dataAtual = DateTime.Now;

                TimeSpan diasParaEntrega = dataEntrega.Subtract(dataAtual);

                if (diasParaEntrega.TotalHours < 0)
                {
                    query = "UPDATE tb_servicos SET sv_cor_tempo = 3 WHERE sv_id = @_IdServico";
                }
                else if (diasParaEntrega.TotalHours >= 0 && diasParaEntrega.TotalHours <= 12)
                {
                    query = "UPDATE tb_servicos SET sv_cor_tempo = 2 WHERE sv_id = @_IdServico";
                }
                else if (diasParaEntrega.TotalHours > 12)
                {
                    query = "UPDATE tb_servicos SET sv_cor_tempo = 1 WHERE sv_id = @_IdServico";
                }
                else
                {
                    query = "UPDATE tb_servicos SET sv_cor_tempo = 4 WHERE sv_id = @_IdServico";
                }

                //using (SqlConnection con = OpenConnection())
                //{
                SqlCommand cmd = new SqlCommand(query, _con);
                cmd.Parameters.AddWithValue("@_IdServico", SqlDbType.Int).Value = _id;
                cmd.ExecuteNonQuery();
                //}
            }
            catch (Exception e)
            {
                //Msg Erro
                mErro.ErroAoAtualizarCoresTempo(e);
            }
        }

        #endregion Atualizar coluna das cores

        #region Alterar Senha de Padrão

        public void AlterarSenhaPattern(byte[] _image, int _idServico)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
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

        #endregion Alterar Senha de Padrão

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

        #endregion Alterar Servicos

        #region Alterar Clientes

        public void AlterarClientes(ClienteModel _dadosDoCliente)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "";

                    query = "UPDATE [dbo].[tb_clientes]" +
                            "SET[cl_nome] = @_nome" +
                            ",[cl_telefone] = @_telefone" +
                            ",[cl_cpf] = @_cpf" +
                            ",[cl_telefone_recado] = @_telefoneRecados" +
                            ",[cl_nome_recado] = @_nomeRecado" +
                            ",[cl_parentesco_recado] = @_parentescoRecado" +
                            ",[cl_sexo] = @_sexo" +
                            ",[cl_data_nascimento] = @_dataNascimento" +
                            ",[cl_cep] = @_cep" +
                            ",[cl_endereco] = @_endereco" +
                            ",[cl_complemento] = @_complemento" +
                            ",[cl_bairro] = @_bairro" +
                            ",[cl_cidade] = @_cidade" +
                            ",[cl_estado] = @_estado" +
                            " WHERE [cl_id] = @_idcliente";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@_nome", SqlDbType.VarChar).Value = _dadosDoCliente.Nome;
                    cmd.Parameters.AddWithValue("@_telefone", SqlDbType.VarChar).Value = _dadosDoCliente.Telefone;
                    cmd.Parameters.AddWithValue("@_telefoneRecados", SqlDbType.VarChar).Value = _dadosDoCliente.TelefoneRecado;
                    cmd.Parameters.AddWithValue("@_cpf", SqlDbType.VarChar).Value = _dadosDoCliente.Cpf;
                    cmd.Parameters.AddWithValue("@_idcliente", SqlDbType.VarChar).Value = _dadosDoCliente.ID;
                    cmd.Parameters.AddWithValue("@_nomeRecado", SqlDbType.VarChar).Value = _dadosDoCliente.NomeRecado;
                    cmd.Parameters.AddWithValue("@_parentescoRecado", SqlDbType.VarChar).Value = _dadosDoCliente.ParentescoRecado;
                    cmd.Parameters.AddWithValue("@_sexo", SqlDbType.Char).Value = _dadosDoCliente.Sexo;
                    if (_dadosDoCliente.DataNascimento != "")
                    {
                        cmd.Parameters.AddWithValue("@_dataNascimento", SqlDbType.DateTime).Value = _dadosDoCliente.DataNascimento;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@_dataNascimento", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    cmd.Parameters.AddWithValue("@_cep", SqlDbType.VarChar).Value = _dadosDoCliente.Cep.Equals("Ex: 42803317") ? string.Empty : _dadosDoCliente.Cep;
                    cmd.Parameters.AddWithValue("@_endereco", SqlDbType.VarChar).Value = _dadosDoCliente.Endereco;
                    cmd.Parameters.AddWithValue("@_complemento", SqlDbType.VarChar).Value = _dadosDoCliente.Complemento;
                    cmd.Parameters.AddWithValue("@_bairro", SqlDbType.VarChar).Value = _dadosDoCliente.Bairro;
                    cmd.Parameters.AddWithValue("@_estado", SqlDbType.VarChar).Value = _dadosDoCliente.Estado;
                    cmd.Parameters.AddWithValue("@_cidade", SqlDbType.VarChar).Value = _dadosDoCliente.Cidade;

                    cmd.ExecuteNonQuery();

                    mSucesso.AlterarClienteSucesso();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAlterarCliente(ex);
            }
        }

        #endregion Alterar Clientes

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

        #endregion Concluir Servicos

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

        #endregion Cancelar Serviço concluido

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

        #endregion Alterar os Gastos

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

        #endregion Atualizar Gastos

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
                    MessageBox.Show(@"Mes resetado com sucesso, tenha um excelente trabalho este mês!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao resetar o mes!\n\n" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal int AtualizarOS(ClienteModel _clienteDados, ServicoModel _servicoDados)
        {
            try
            {
                using (SqlConnection conexaoSQL = OpenConnection())
                {
                    string query = "UPDATE tb_servicos " +
                                   "SET sv_data = @Data, " +
                                   "sv_cl_idcliente = @FkCliente, " +
                                   "sv_tipo_aparelho = @TipoAparelho, " +
                                   "sv_marca = @Marca, " +
                                   "sv_aparelho = @Aparelho, " +
                                   "sv_cor = @Cor, " +
                                   "sv_mei_serialnumber = @MeiSerialNumber, " +
                                   "sv_senha = @Senha, " +
                                   "sv_situacao = @Situacao, " +
                                   "sv_status = @Status0_1, " +
                                   "sv_senha_pattern = @SenhaPattern, " +
                                   "sv_relato_cliente = @RelatoCliente, " +
                                   "sv_observacoes = @Observacoes, " +
                                   "sv_avaliacao_servico = @AvaliacaoServico " +
                                   "WHERE sv_id = @idServico";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.Add("@idServico", SqlDbType.Int).Value = _servicoDados.ID;
                    cmd.Parameters.Add("@Data", SqlDbType.Date).Value = _servicoDados.DataServico;
                    cmd.Parameters.Add("@FkCliente", SqlDbType.Int).Value = _clienteDados.ID;
                    cmd.Parameters.Add("@TipoAparelho", SqlDbType.VarChar).Value = _servicoDados.TipoAparelho;
                    cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = _servicoDados.Marca;
                    cmd.Parameters.Add("@Aparelho", SqlDbType.VarChar).Value = _servicoDados.Aparelho;
                    cmd.Parameters.Add("@Cor", SqlDbType.VarChar).Value = _servicoDados.Cor;
                    cmd.Parameters.Add("@MeiSerialNumber", SqlDbType.VarChar).Value = _servicoDados.MeiSerialNumber;
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = _servicoDados.Senha;
                    cmd.Parameters.Add("@Situacao", SqlDbType.VarChar).Value = _servicoDados.Situacao;
                    cmd.Parameters.Add("@Status0_1", SqlDbType.Int).Value = _servicoDados.Status;
                    cmd.Parameters.Add("@SenhaPattern", SqlDbType.Image).Value = _servicoDados.SenhaPatternAndroid;
                    cmd.Parameters.Add("@RelatoCliente", SqlDbType.VarChar).Value = _servicoDados.RelatoCliente;
                    cmd.Parameters.Add("@Observacoes", SqlDbType.VarChar).Value = _servicoDados.Observacoes;
                    cmd.Parameters.Add("@AvaliacaoServico", SqlDbType.VarChar).Value = _servicoDados.AvaliacaoServico;

                    int idRegistrada = (int)cmd.ExecuteScalar();

                    return idRegistrada;
                }
            }
            catch (Exception ex)
            {
                //Mensagem de Erro
                mErro.ErroInserirServico(ex);
                return -1;
            }
        }

        internal void AtualizarCheckList(int? idUltimoServico, ChecklistModel checklistDados)
        {
            throw new NotImplementedException();
        }

        #endregion Resetar Dados Mensais

        public void AtualizarCondicoesFisicas(int? _idUltimoServico, CondicoesFisicasModel _condicoesFisicasDados)
        {
            throw new NotImplementedException();
        }
    }
}