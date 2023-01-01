using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Models;

namespace PFC___StandBy_CSharp.Dados
{
    internal class InserirDados : conexao
    {
        private readonly MensagensErro mErro = new MensagensErro();
        private readonly MensagensSucesso mSucesso = new MensagensSucesso();
        private readonly VerificarExistencia verificarExistencia = new VerificarExistencia();

        #region Inserir Servico

        //public void InserirServico(ServicoDados _servicoDados, ClienteDados _clienteDados, ChecklistDados _condicoesFisicasDados, CondicoesFisicasDados _condicoesFisicasDados)
        //{
        //    {
        //        //Abro a conexao.
        //        using (SqlConnection conexaoSQL = OpenConnection())
        //        {
        //            //Defino a query que preciso com os parametros que vao ser criados logo apos.
        //            string query = "";
        //            if (DiasParaEntregar == 0)
        //            {
        //                query = "INSERT INTO tb_servicos (sv_data, sv_cl_idcliente, sv_aparelho, sv_defeito, sv_senha, sv_situacao, sv_existe_um_prazo, sv_senha_pattern, sv_acessorios, sv_cor_tempo) " +
        //                "VALUES (@Data,  @FkCliente, @Aparelho, @Defeito, @Senha, @Situacao, @SeExisteUmPrazo, @ImagePattern, @Acessorios, @CorTempo)";
        //            }
        //            else
        //            {
        //                query = "INSERT INTO tb_servicos (sv_data, sv_cl_idcliente, sv_aparelho, sv_defeito, sv_senha, sv_situacao, sv_previsao_entrega, sv_existe_um_prazo, sv_senha_pattern, sv_acessorios, sv_cor_tempo) " +
        //                "VALUES (@Data,  @FkCliente, @Aparelho, @Defeito, @Senha, @Situacao, @PrevisaoEntrega, @SeExisteUmPrazo, @ImagePattern, @Acessorios, @CorTempo)";
        //            }

        //            //Crio um novo objeto do tipo "Comando em SQL" passando como argumento
        //            //a minha query e uma conexao pra ele saber em que banco inserir.
        //            SqlCommand cmd = new SqlCommand(query, conexaoSQL);

        //            DateTime previsaoEntrega = DateTime.Now;
        //            previsaoEntrega = previsaoEntrega.AddDays(DiasParaEntregar);

        //            //Defino os parametros e quais dados eles vao receber
        //            cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = data;
        //            cmd.Parameters.Add("@FkCliente", SqlDbType.Int).Value = fk_cliente;
        //            cmd.Parameters.Add("@Aparelho", SqlDbType.VarChar).Value = aparelho;
        //            cmd.Parameters.Add("@Defeito", SqlDbType.VarChar).Value = defeito;
        //            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;
        //            cmd.Parameters.Add("@Situacao", SqlDbType.VarChar).Value = situacao;
        //            if (DiasParaEntregar == 0)
        //            {
        //            }
        //            else
        //            {
        //                cmd.Parameters.Add("@PrevisaoEntrega", SqlDbType.DateTime).Value = previsaoEntrega;
        //            }
        //            cmd.Parameters.Add("@SeExisteUmPrazo", SqlDbType.Int).Value = SeExisteUmPrazo;
        //            cmd.Parameters.Add("@ImagePattern", SqlDbType.Image).Value = image;
        //            cmd.Parameters.Add("@Acessorios", SqlDbType.VarChar).Value = acessorios;
        //            cmd.Parameters.Add("@CorTempo", SqlDbType.Int).Value = 4;

        //            //Executo ta query completa
        //            cmd.ExecuteNonQuery();
        //        }
        //        //Fecho a conexao, nunca deixar aberta pois ocasiona lag e erros de acesso.
        //        //conexaoSQL.Close();
        //    }
        //}

        public int InserirOS(ClienteEstrutura _clienteDados, ServicoEstrutura _servicoDados)
        {
            try
            {
                using (SqlConnection conexaoSQL = OpenConnection())
                {
                    string query = "INSERT INTO tb_servicos (sv_ordem_serv, sv_data, sv_cl_idcliente, sv_tipo_aparelho,sv_marca, sv_aparelho,sv_cor, sv_mei_serialnumber, sv_senha, sv_situacao, sv_status, sv_senha_pattern, sv_relato_cliente, sv_observacoes, sv_avaliacao_servico) " +
                    "output INSERTED.sv_id VALUES (@OrdemServico, @Data, @FkCliente, @TipoAparelho,@Marca,@Aparelho,@Cor,@MeiSerialNumber, @Senha, @Situacao, @Status0_1, @SenhaPattern, @RelatoCliente, @Observacoes, @AvaliacaoServico)";

                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    cmd.Parameters.Add("@OrdemServico", SqlDbType.Int).Value = _servicoDados.OrdemServico;
                    cmd.Parameters.Add("@Data", SqlDbType.Date).Value = _servicoDados.DataServico;
                    cmd.Parameters.Add("@FkCliente", SqlDbType.Int).Value = _clienteDados.ID;
                    cmd.Parameters.Add("@TipoAparelho", SqlDbType.VarChar).Value = _servicoDados.TipoAparelho;
                    cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = _servicoDados.Marca;
                    cmd.Parameters.Add("@Aparelho", SqlDbType.VarChar).Value = _servicoDados.Aparelho;
                    cmd.Parameters.Add("@Cor", SqlDbType.VarChar).Value = _servicoDados.Cor ?? Convert.DBNull;
                    cmd.Parameters.Add("@MeiSerialNumber", SqlDbType.VarChar).Value = _servicoDados.MeiSerialNumber ?? Convert.DBNull;
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = _servicoDados.Senha ?? Convert.DBNull;
                    cmd.Parameters.Add("@Situacao", SqlDbType.VarChar).Value = _servicoDados.Situacao ?? Convert.DBNull;
                    cmd.Parameters.Add("@Status0_1", SqlDbType.Int).Value = _servicoDados.Status;
                    cmd.Parameters.Add("@SenhaPattern", SqlDbType.Image).Value = _servicoDados.SenhaPatternAndroid ?? Convert.DBNull;
                    cmd.Parameters.Add("@RelatoCliente", SqlDbType.VarChar).Value = _servicoDados.RelatoCliente ?? Convert.DBNull;
                    cmd.Parameters.Add("@Observacoes", SqlDbType.VarChar).Value = _servicoDados.Observacoes ?? Convert.DBNull;
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

        #endregion Inserir Servico

        #region Inserir Cliente

        public void InserirCliente(string _nome, string _cpf, string _telPrincipal, string _telRecados, string _nomeRecado, string _parentescoRecado,
            string _sexo, string _dataNascimento, string _cep, string _endereco, string _complemento, string _bairro, string _cidade, string _estado)
        {
            bool CpfExistente;
            if (_cpf.Equals("SEM CPF/CNPJ"))
            {
                CpfExistente = false;
            }
            else
            {
                CpfExistente = verificarExistencia.VerificarExistenciaCPF(_cpf);
            }

            if (CpfExistente == true)
            {
                MessageBox.Show(@"CPF/CNPJ Já existe, verifique se o cliente já esta cadastrado.", "CPF/CNPJ Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Abrir conexão
                    using (SqlConnection con = OpenConnection())
                    {
                        string query = "";

                        query = "insert into dbo.tb_clientes " +
                                "(cl_nome, cl_telefone, cl_cpf, cl_telefone_recado, cl_nome_recado, cl_parentesco_recado," +
                                "cl_sexo, cl_data_nascimento, cl_cep, cl_endereco, cl_complemento, cl_bairro, cl_cidade, cl_estado)" +
                                "VALUES(@Nome, @TelefonePrincipal, @CpfOuCnpj, @TelefoneRecados, @NomeRecado, @ParentescoRecado," +
                                "@Sexo, @DataNascimento, @Cep, @Endereco, @Complemento, @Bairro, @Cidade, @Estado)";

                        //String qry = "insert into dbo.tb_clientes (cl_nome, cl_telefone, cl_cpf) " +
                        //    "VALUES ('" + nome + "','" + tel + "','" + cpf + "')";

                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = _nome;
                        cmd.Parameters.Add("@TelefonePrincipal", SqlDbType.VarChar).Value = _telPrincipal;
                        cmd.Parameters.Add("@CpfOuCnpj", SqlDbType.VarChar).Value = _cpf;
                        cmd.Parameters.Add("@TelefoneRecados", SqlDbType.VarChar).Value = _telRecados;
                        cmd.Parameters.Add("@NomeRecado", SqlDbType.VarChar).Value = _nomeRecado;
                        cmd.Parameters.Add("@ParentescoRecado", SqlDbType.VarChar).Value = _parentescoRecado;
                        cmd.Parameters.Add("@Sexo", SqlDbType.Char).Value = _sexo;

                        if (_dataNascimento != "")
                        {
                            cmd.Parameters.Add("@DataNascimento", SqlDbType.DateTime).Value = _dataNascimento;
                        }
                        else
                        {
                            cmd.Parameters.Add("@DataNascimento", SqlDbType.DateTime).Value = DBNull.Value;
                        }
                        cmd.Parameters.Add("@Cep", SqlDbType.VarChar).Value = _cep;
                        cmd.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = _endereco;
                        cmd.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = _complemento;
                        cmd.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = _bairro;
                        cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = _cidade;
                        cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = _estado;
                        cmd.ExecuteNonQuery();

                        //Checagem
                        //int QueryRetorno = cmd.ExecuteNonQuery();

                        mSucesso.InserirClienteSucesso();
                    }
                }
                catch (Exception ex)
                {
                    mErro.ErroInserirCliente(ex);
                }
            }
        }

        #endregion Inserir Cliente

        #region Inserir Gasto

        public void InserirGasto(DateTime _data, string _produto, decimal _valor, int _temporario)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                string procedure = "GastosInserir";
                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_Data", _data);
                cmd.Parameters.AddWithValue("@_Produto", _produto);
                cmd.Parameters.AddWithValue("@_Valor", _valor);
                cmd.Parameters.AddWithValue("@_Temp", _temporario);
                cmd.Parameters.AddWithValue("@_Ativo", 1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }

        #endregion Inserir Gasto

        #region Inserir Garantia

        public void InserirGarantia(int _idServico, int _idCliente, int _qntDiasGarantia)
        {
            try
            {
                using (SqlConnection conexao = OpenConnection())
                {
                    string procedure = "GarantiaInserir";
                    SqlCommand cmd = new SqlCommand(procedure, conexao);
                    cmd.Parameters.AddWithValue("@_fkServico", _idServico);
                    cmd.Parameters.AddWithValue("@_fkCliente", _idCliente);
                    cmd.Parameters.AddWithValue("@_DataAtual", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@_QntsDiasGarantia", _qntDiasGarantia);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAoInserirGarantia(ex);
            }
        }

        #endregion Inserir Garantia

        #region Inserir Orcamento

        public void InserirOrcamento(string _marca, string _modelo, decimal _peca, decimal _valor, decimal _total)
        {
            try
            {
                using (SqlConnection conexao = OpenConnection())
                {
                    string procedure = "OrcamentosInserir";

                    SqlCommand cmd = new SqlCommand(procedure, conexao);

                    cmd.Parameters.AddWithValue("@_Marca", _marca);
                    cmd.Parameters.AddWithValue("@_Modelo", _modelo);
                    cmd.Parameters.AddWithValue("@_Peca", _peca);
                    cmd.Parameters.AddWithValue("@_Valor", _valor);
                    cmd.Parameters.AddWithValue("@_Total", _total);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(@"Orçamento inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n\n" + ex, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Inserir Orcamento

        #region Inserir Checklist

        public void InserirCheckList(int _idServico, ChecklistEstrutura _checklistDados)
        {
            try
            {
                using (SqlConnection conexao = OpenConnection())
                {
                    string query = "INSERT INTO tb_checklist (ch_ordem_serv, ch_data, ch_sv_idservico, ch_biometria_faceid, " +
                                   "ch_microfone, ch_tela, ch_chip, ch_botoes, ch_sensor, ch_cameras, ch_auricular, ch_wifi, " +
                                   "ch_altofalante, ch_bluetooth, ch_carregamento, ch_observacoes, ch_ausente, ch_motivo_ausencia)" +
                                   " VALUES (@OrdemServico, @DataChecklist, @FK_IdServico, @Biometria," +
                                   "@Microfone, @Tela, @Chip, @Botoes, @Sensor, @Cameras, @Auricular, @Wifi," +
                                   "@AltoFalante, @Bluetooth, @Carregamento, @Observacoes, @Ausente, @MotivoAusencia)";

                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@OrdemServico", _checklistDados.OrdemServico);
                    cmd.Parameters.AddWithValue("@DataChecklist", _checklistDados.DataChecklist);
                    cmd.Parameters.AddWithValue("@FK_IdServico", _idServico);
                    cmd.Parameters.AddWithValue("@Biometria", _checklistDados.BiometriaFaceID ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Microfone", _checklistDados.Microfone ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Tela", _checklistDados.Tela ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Chip", _checklistDados.Chip ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Botoes", _checklistDados.Botoes ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Sensor", _checklistDados.Sensor ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Cameras", _checklistDados.Cameras ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Auricular", _checklistDados.Auricular ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Wifi", _checklistDados.Wifi ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@AltoFalante", _checklistDados.AltoFalante ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Bluetooth", _checklistDados.Bluetooth ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Carregamento", _checklistDados.Carregamento ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Observacoes", _checklistDados.Observacoes ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Ausente", _checklistDados.Ausente);
                    cmd.Parameters.AddWithValue("@MotivoAusencia", _checklistDados.MotivoAusencia ?? Convert.DBNull);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAoInserirChecklist(ex);
            }
        }

        #endregion Inserir Checklist

        public void InserirCondicoesFisicas(int _idServico, CondicoesFisicasEstrutura _condicoesFisicasDados)
        {
            try
            {
                using (SqlConnection conexao = OpenConnection())
                {
                    string query = "INSERT INTO tb_condicoes_fisicas (cf_ordem_serv, cf_data, cf_sv_idservico, cf_pelicula, cf_tela, " +
                                   "cf_tampa, cf_aro, cf_botoes, cf_lente_camera)" +
                                   " VALUES (@OrdemServico, @DataCondicoesFisicas, @FK_IdServico, @Pelicula, @Tela, @Tampa, @Aro, @Botoes, @LenteCamera)";

                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@OrdemServico", _condicoesFisicasDados.OrdemServico);
                    cmd.Parameters.AddWithValue("@DataCondicoesFisicas", _condicoesFisicasDados.DataCondicoesFisicas);
                    cmd.Parameters.AddWithValue("@FK_IdServico", _idServico);
                    cmd.Parameters.AddWithValue("@Pelicula", _condicoesFisicasDados.Pelicula ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Tela", _condicoesFisicasDados.Tela ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Tampa", _condicoesFisicasDados.Tampa ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Aro", _condicoesFisicasDados.Aro ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@Botoes", _condicoesFisicasDados.Botoes ?? Convert.DBNull);
                    cmd.Parameters.AddWithValue("@LenteCamera", _condicoesFisicasDados.LenteCamera ?? Convert.DBNull);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                mErro.ErroAoInserirCondicoesFisicas(ex);
            }
        }
    }
}