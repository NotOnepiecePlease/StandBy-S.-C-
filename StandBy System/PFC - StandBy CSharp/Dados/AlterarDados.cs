using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Models;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Forms._1___Ordems_Servico;
using PFC___StandBy_CSharp.Utils;

namespace PFC___StandBy_CSharp.Dados
{
    public class AlterarDados : conexao
    {
        private readonly MensagensErro mErro = new MensagensErro();
        private readonly MensagensSucesso mSucesso = new MensagensSucesso();

        #region Atualizar Coluna Tempo de Entrega

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

        #endregion Atualizar Coluna Tempo de Entrega

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
            string _situacao, float _valorServico, float _valorPeca, float _lucro, string _servico,
            DateTime _dataPrevisao, string _acessorios)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "";
                    if (_dataPrevisao == DateTime.Parse("26/03/2020"))
                    {
                        query =
                            "update tb_servicos set sv_data = @Data, sv_aparelho = @Aparelho, sv_defeito = @Defeito, " +
                            "sv_senha = @Senha, sv_situacao = @Situacao, sv_valorservico = @ValorServico, sv_valorpeca = @ValorPeca, " +
                            "sv_lucro = @Lucro, sv_servico = @Servico, sv_previsao_entrega = null, sv_existe_um_prazo = 0, sv_acessorios = @Acessorios, sv_cor_tempo = 4 where sv_id = @IdServico";
                    }
                    else
                    {
                        query =
                            "update tb_servicos set sv_data = @Data, sv_aparelho = @Aparelho, sv_defeito = @Defeito, " +
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

        public void AlterarClientes(ClienteEstrutura _dadosDoCliente)
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
                    cmd.Parameters.AddWithValue("@_telefoneRecados", SqlDbType.VarChar).Value =
                        _dadosDoCliente.TelefoneRecado;
                    cmd.Parameters.AddWithValue("@_cpf", SqlDbType.VarChar).Value = _dadosDoCliente.Cpf;
                    cmd.Parameters.AddWithValue("@_idcliente", SqlDbType.VarChar).Value = _dadosDoCliente.ID;
                    cmd.Parameters.AddWithValue("@_nomeRecado", SqlDbType.VarChar).Value = _dadosDoCliente.NomeRecado;
                    cmd.Parameters.AddWithValue("@_parentescoRecado", SqlDbType.VarChar).Value =
                        _dadosDoCliente.ParentescoRecado;
                    cmd.Parameters.AddWithValue("@_sexo", SqlDbType.Char).Value = _dadosDoCliente.Sexo;
                    if (_dadosDoCliente.DataNascimento != "")
                    {
                        cmd.Parameters.AddWithValue("@_dataNascimento", SqlDbType.DateTime).Value =
                            _dadosDoCliente.DataNascimento;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@_dataNascimento", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    cmd.Parameters.AddWithValue("@_cep", SqlDbType.VarChar).Value =
                        _dadosDoCliente.Cep.Equals("Ex: 42803317") ? string.Empty : _dadosDoCliente.Cep;
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

        #region Concluir Servicos (efcore)

        public void ConcluirServicos(int _idServico)
        {
            try
            {
                standby_orgContext context = new standby_orgContext();

                tb_servicos servico = context.tb_servicos.FirstOrDefault(x => x.sv_id == _idServico);
                servico.sv_status = 0;
                servico.sv_data_conclusao = DateTime.Now;

                context.SaveChanges();

                //using (SqlConnection con = OpenConnection())
                //{
                //    string query = "update tb_servicos set sv_status = 0, sv_data_conclusao = GETDATE() where sv_id = @sv_id";

                //    SqlCommand cmd = new SqlCommand(query, con);

                //    cmd.Parameters.AddWithValue("@sv_id", _idServico);
                //    cmd.ExecuteNonQuery();

                //}
                mSucesso.ConcluirServicoSucesso();
            }
            catch (Exception ex)
            {
                mErro.ErroAoConcluirServico(ex);
            }
        }

        #endregion Concluir Servicos (efcore)

        #region Cancelar Serviço concluido

        public void CancelarConclusaoServicos(int _idServico)
        {
            try
            {
                standby_orgContext context = new standby_orgContext();
                if (MessageBox.Show("Deseja apagar os checklists de SAIDA relacionados a esse serviço?, para concluir ele após isso, os checklists devem ser preenchidos novamente.", "Remover checklists",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tb_checklist checklist = context.tb_checklist.FirstOrDefault(x => x.ch_sv_idservico == _idServico);
                    tb_condicoes_fisicas condF = context.tb_condicoes_fisicas.FirstOrDefault(x => x.cf_sv_idservico == _idServico);

                    if (checklist != null)
                        context.tb_checklist.Remove(checklist);

                    if (condF != null)
                        context.tb_condicoes_fisicas.Remove(condF);


                    context.SaveChanges();
                }


                tb_servicos servico = context.tb_servicos.FirstOrDefault(x => x.sv_id == _idServico);
                servico.sv_status = 1;
                servico.sv_avaliacao_servico = Constantes.STATUS_AVALIACAO;
                servico.sv_data_conclusao = null;
                context.SaveChanges();
                mSucesso.CancelarConclusaoSucesso();

                //using (SqlConnection con = OpenConnection())
                //{
                //    string procedure = "Servico_Cancelar_Conclusao";
                //    SqlCommand cmd = new SqlCommand(procedure, con);

                //    cmd.CommandType = CommandType.StoredProcedure;
                //    cmd.Parameters.AddWithValue("@sv_id", _idServico);

                //    cmd.ExecuteNonQuery();

                //    mSucesso.CancelarConclusaoSucesso();
                //}
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
                    MessageBox.Show(@"Mes resetado com sucesso, tenha um excelente trabalho este mês!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao resetar o mes!\n\n" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Resetar Dados Mensais

        //V2

        #region Atualizar servico (efcore)

        public void AtualizarServico(form_OrdemServicoEditar _form)
        {
            try
            {
                standby_orgContext context = new standby_orgContext();
                if (_form.lblIdServico.Text != "IdServico")
                {
                    tb_servicos s = context.tb_servicos.FirstOrDefault(x => x.sv_id == Convert.ToInt32(_form.lblIdServico.Text));

                    var a = _form.dtpPrevisaoEntrega.EditValue;
                    var ba = _form.dtpPrevisaoEntrega.DateTime;
                    if (_form.dtpPrevisaoEntrega.DateTime == DateTime.MinValue)
                    {
                        _form.dtpPrevisaoEntrega.EditValue = null;
                    }

                    s.sv_marca = _form.cmbMarca.Text;
                    s.sv_aparelho = _form.txtModelo.Text;
                    s.sv_cor = _form.cmbCor.Text;
                    s.sv_mei_serialnumber = _form.txtMei_SerialNumber.Text;
                    s.sv_senha = _form.txtSenhaDispositivo.Text;
                    s.sv_senha_pattern = ConvertImage.ConvertImageToByte(_form.picSenhaPattern.Image);
                    s.sv_situacao = _form.txtObservacoes.Text;
                    s.sv_relato_cliente = _form.txtRelatoCliente.Text;
                    s.sv_condicoes_balcao = _form.txtCondicoesBalcao.Text;
                    s.sv_servico = _form.txtSolucao.Text;
                    s.sv_defeito = _form.txtDefeito.Text;
                    s.sv_tipo_aparelho = _form.cmbTipoAparelho.Text;
                    s.sv_valorservico = Convert.ToDecimal(_form.txtServicoValor.Text.TrimStart('R', '$').Trim());
                    s.sv_valorpeca = Convert.ToDecimal(_form.txtPecaValor.Text.TrimStart('R', '$').Trim());
                    s.sv_lucro = Convert.ToDecimal(_form.txtLucroValor.Text.Replace("R$ ", "").Trim());
                    s.sv_previsao_entrega = (DateTime?)(_form.dtpPrevisaoEntrega.EditValue);
                    s.sv_acessorios = _form.txtAcessorios.Text;
                    s.sv_avaliacao_servico = _form.cmbStatusServico.Text;


                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                mErro.erroAoAtualizarServico(e);
            }
        }

        #endregion Atualizar servico (efcore)

        #region Atualizar condicoes fisicas (efcore)

        public void AtualizarCondicoesFisicas(form_OrdemServicoEditar _form)
        {
            try
            {
                standby_orgContext context = new standby_orgContext();
                if (_form.lblIdServico.Text != "IdServico")
                {
                    tb_condicoes_fisicas c =
                        context.tb_condicoes_fisicas.FirstOrDefault(x =>
                            x.cf_sv_idservico == Convert.ToInt32(_form.lblIdServico.Text));

                    //Caso nao encontre, tenho que criar um novo.
                    if (c == null)
                    {
                        if (!string.IsNullOrWhiteSpace(_form.cmbPelicula.Text) ||
                            !string.IsNullOrWhiteSpace(_form.cmbTela.Text) ||
                            !string.IsNullOrWhiteSpace(_form.cmbTampa.Text) ||
                            !string.IsNullOrWhiteSpace(_form.cmbAro.Text) ||
                            !string.IsNullOrWhiteSpace(_form.cmbBotoes.Text) ||
                            !string.IsNullOrWhiteSpace(_form.cmbLenteCamera.Text))
                        {
                            tb_servicos servico = context.tb_servicos.Find(Convert.ToInt32(_form.lblIdServico.Text));
                            c = new tb_condicoes_fisicas();

                            c.cf_ordem_serv = servico.sv_ordem_serv;
                            c.cf_data = servico.sv_data;
                            c.cf_sv_idservico = servico.sv_id;
                            c.cf_tipo = Constantes.CHK_ENTRADA;
                            c.cf_pelicula = _form.cmbPelicula.Text;
                            c.cf_tela = _form.cmbTela.Text;
                            c.cf_tampa = _form.cmbTampa.Text;
                            c.cf_aro = _form.cmbAro.Text;
                            c.cf_botoes = _form.cmbBotoes.Text;
                            c.cf_lente_camera = _form.cmbLenteCamera.Text;

                            context.tb_condicoes_fisicas.Add(c);
                            context.SaveChanges();

                            return;
                        }

                        return;
                    }

                    c.cf_pelicula = _form.cmbPelicula.Text;
                    c.cf_tela = _form.cmbTela.Text;
                    c.cf_tampa = _form.cmbTampa.Text;
                    c.cf_aro = _form.cmbAro.Text;
                    c.cf_botoes = _form.cmbBotoes.Text;
                    c.cf_lente_camera = _form.cmbLenteCamera.Text;

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                mErro.ErroAoAtualizarCondicoesFisicasEfCore(e);
            }
        }

        #endregion Atualizar condicoes fisicas (efcore)

        #region Atualizar ordem de servico

        internal void AtualizarOS(ClienteEstrutura _clienteDados, ServicoEstrutura _servicoDados)
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
                                   "sv_condicoes_balcao = @CondicoesBalcao, " +
                                   "sv_avaliacao_servico = @AvaliacaoServico " +
                                   "WHERE sv_id = @idServico";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.Add("@idServico", SqlDbType.Int).Value = _servicoDados.ID;
                    cmd.Parameters.Add("@Data", SqlDbType.Date).Value = _servicoDados.DataServico;
                    cmd.Parameters.Add("@FkCliente", SqlDbType.Int).Value = _clienteDados.ID;
                    cmd.Parameters.Add("@TipoAparelho", SqlDbType.VarChar).Value = _servicoDados.TipoAparelho;
                    cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = _servicoDados.Marca;
                    cmd.Parameters.Add("@Aparelho", SqlDbType.VarChar).Value = _servicoDados.Aparelho;
                    cmd.Parameters.Add("@Cor", SqlDbType.VarChar).Value = _servicoDados.Cor ?? Convert.DBNull;
                    cmd.Parameters.Add("@MeiSerialNumber", SqlDbType.VarChar).Value =
                        _servicoDados.MeiSerialNumber ?? Convert.DBNull;
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = _servicoDados.Senha ?? Convert.DBNull;
                    cmd.Parameters.Add("@Situacao", SqlDbType.VarChar).Value = _servicoDados.Situacao ?? Convert.DBNull;
                    cmd.Parameters.Add("@Status0_1", SqlDbType.Int).Value = _servicoDados.Status;
                    cmd.Parameters.Add("@SenhaPattern", SqlDbType.Image).Value =
                        _servicoDados.SenhaPatternAndroid ?? Convert.DBNull;
                    cmd.Parameters.Add("@RelatoCliente", SqlDbType.VarChar).Value =
                        _servicoDados.RelatoCliente ?? Convert.DBNull;
                    cmd.Parameters.Add("@CondicoesBalcao", SqlDbType.VarChar).Value =
                        _servicoDados.CondicoesBalcao ?? Convert.DBNull;
                    cmd.Parameters.Add("@AvaliacaoServico", SqlDbType.VarChar).Value = _servicoDados.AvaliacaoServico;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                //Mensagem de Erro
                mErro.ErroAoAtualizarOrdemServico(e);
            }
        }

        #endregion Atualizar ordem de servico

        #region Atualizar o CheckList

        internal void AtualizarCheckList(int? _idServico, ChecklistEstrutura checklistDados)
        {
            try
            {
                using (SqlConnection conexaoSQL = OpenConnection())
                {
                    string query = "UPDATE tb_checklist " +
                                   "SET ch_biometria_faceid = @Biometria, " +
                                   "ch_microfone = @Microfone, " +
                                   "ch_tela = @Tela, " +
                                   "ch_chip = @Chip, " +
                                   "ch_botoes = @Botoes, " +
                                   "ch_sensor = @Sensor, " +
                                   "ch_cameras = @Cameras, " +
                                   "ch_auricular = @Auricular, " +
                                   "ch_wifi = @Wifi, " +
                                   "ch_altofalante = @AltoFalante, " +
                                   "ch_bluetooth = @Bluetooth, " +
                                   "ch_carregamento = @Carregamento, " +
                                   "ch_observacoes = @CondicoesBalcao, " +
                                   "ch_ausente = @Ausente, " +
                                   "ch_motivo_ausencia = @MotivoAusencia " +
                                   "WHERE ch_sv_idservico = @idServico";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.AddWithValue("@Biometria", checklistDados.BiometriaFaceID ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Microfone", checklistDados.Microfone ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Tela", checklistDados.Tela ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Chip", checklistDados.Chip ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Botoes", checklistDados.Botoes ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Sensor", checklistDados.Sensor ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Cameras", checklistDados.Cameras ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Auricular", checklistDados.Auricular ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Wifi", checklistDados.Wifi ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@AltoFalante", checklistDados.AltoFalante ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Bluetooth", checklistDados.Bluetooth ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Carregamento", checklistDados.Carregamento ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@CondicoesBalcao", checklistDados.Observacoes ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Ausente", checklistDados.Ausente);
                    cmd.Parameters.AddWithValue("@MotivoAusencia", checklistDados.MotivoAusencia ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@idServico", _idServico);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                //Mensagem de Erro
                mErro.ErroAoAtualizarCheckList(e);
            }
        }

        #endregion Atualizar o CheckList

        #region Atualizar Condicoes Fisicas

        public void AtualizarCondicoesFisicas(int? _idServico, CondicoesFisicasEstrutura _condicoesFisicasDados)
        {
            try
            {
                using (SqlConnection conexao = OpenConnection())
                {
                    string query = "UPDATE tb_condicoes_fisicas " +
                                   "SET cf_pelicula = @Pelicula, " +
                                   "cf_tela = @Tela, " +
                                   "cf_tampa = @Tampa, " +
                                   "cf_aro = @Aro, " +
                                   "cf_botoes = @Botoes, " +
                                   "cf_lente_camera = @LenteCamera " +
                                   "WHERE cf_sv_idservico = @idServico";

                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@Pelicula", _condicoesFisicasDados.Pelicula ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Tela", _condicoesFisicasDados.Tela ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Tampa", _condicoesFisicasDados.Tampa ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Aro", _condicoesFisicasDados.Aro ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Botoes", _condicoesFisicasDados.Botoes ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@LenteCamera", _condicoesFisicasDados.LenteCamera ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@idServico", _idServico);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                mErro.ErroAoAtualizarCondicoesFisicas(e);
            }
        }

        #endregion Atualizar Condicoes Fisicas

        #region Concluir Serviço (Efcore)

        private void ConcluirServico(int _idServico)
        {
            try
            {
                standby_orgContext context = new standby_orgContext();
                tb_servicos servico = context.tb_servicos.Find(_idServico);
                servico.sv_status = 0;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                mErro.ErroAoConcluirServicoEfcore(e);
            }
        }

        #endregion
    }
}