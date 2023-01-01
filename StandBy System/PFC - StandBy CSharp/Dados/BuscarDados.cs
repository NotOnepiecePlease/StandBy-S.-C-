using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Guna.UI.WinForms;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Models;

// ReSharper disable All

namespace PFC___StandBy_CSharp.Dados
{
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class BuscarDados : conexao
    {
        private readonly MensagensErro me = new MensagensErro();

        #region Buscar OS pela ID (servico)

        public ServicoEstrutura BuscarOS_ApenasServico(int _idServico)
        {
            ServicoEstrutura servico = new ServicoEstrutura();
            CondicoesFisicasEstrutura condicoesFisicas = new CondicoesFisicasEstrutura();
            ChecklistEstrutura checklist = new ChecklistEstrutura();
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "SELECT sv_id, sv_ordem_serv, sv_data, sv_cl_idcliente, sv_marca, sv_aparelho, sv_cor , sv_mei_serialnumber, sv_senha, sv_observacoes, sv_relato_cliente, " +
                                   "sv_tipo_aparelho, sv_situacao, sv_avaliacao_servico " +
                                   "FROM tb_servicos " +
                                   "WHERE sv_id = @idServico";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idServico", _idServico);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            if (dr.HasRows)
                            {
                                //Dados do servico
                                servico.ID = Convert.ToInt32(dr["sv_id"]);
                                servico.OrdemServico = Convert.ToInt32(dr["sv_ordem_serv"]);
                                servico.DataServico = Convert.ToDateTime(dr["sv_data"]);
                                servico.FK_IdCliente = Convert.ToInt32(dr["sv_cl_idcliente"]);
                                servico.Marca = dr["sv_marca"].ToString();
                                servico.Aparelho = dr["sv_aparelho"].ToString();
                                servico.Cor = dr["sv_cor"].ToString();
                                servico.MeiSerialNumber = dr["sv_mei_serialnumber"].ToString();
                                servico.Senha = dr["sv_senha"].ToString();
                                servico.Observacoes = dr["sv_observacoes"].ToString();
                                servico.RelatoCliente = dr["sv_relato_cliente"].ToString();
                                servico.TipoAparelho = dr["sv_tipo_aparelho"].ToString();
                                servico.Situacao = dr["sv_situacao"].ToString();
                                servico.AvaliacaoServico = dr["sv_avaliacao_servico"].ToString();

                                return servico;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                me.ErroAoBuscarServico(e);
            }

            return null;
        }

        #endregion Buscar OS pela ID (servico)

        #region Buscar OS pela ID (servico, condicao fisica, checklist)

        public (ServicoEstrutura, CondicoesFisicasEstrutura, ChecklistEstrutura) BuscarOS(int _idServico)
        {
            ServicoEstrutura servico = new ServicoEstrutura();
            CondicoesFisicasEstrutura condicoesFisicas = new CondicoesFisicasEstrutura();
            ChecklistEstrutura checklist = new ChecklistEstrutura();
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "SELECT sv_id, sv_ordem_serv, sv_data, sv_cl_idcliente, sv_marca, sv_aparelho, sv_cor , sv_mei_serialnumber, sv_senha, sv_observacoes, sv_relato_cliente, sv_tipo_aparelho, " +
                                   "sv_situacao, sv_avaliacao_servico,cf_id, cf_pelicula, cf_tela, cf_tampa, cf_aro, cf_botoes, cf_lente_camera,ch_id, ch_biometria_faceid, ch_microfone, " +
                                   "ch_tela, ch_chip, ch_botoes, ch_sensor, ch_cameras, ch_auricular, ch_wifi, ch_altofalante, ch_bluetooth, ch_carregamento, " +
                                   "ch_observacoes, ch_ausente, ch_motivo_ausencia " +
                                   "FROM tb_servicos as servico " +
                                   "INNER JOIN tb_checklist as checklist " +
                                   "ON servico.sv_id = checklist.ch_sv_idservico " +
                                   "INNER JOIN tb_condicoes_fisicas as condicoes " +
                                   "ON servico.sv_id = condicoes.cf_sv_idservico " +
                                   "WHERE sv_id = @idServico";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idServico", _idServico);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            if (dr.HasRows)
                            {
                                //Dados do servico
                                servico.ID = Convert.ToInt32(dr["sv_id"]);
                                servico.OrdemServico = Convert.ToInt32(dr["sv_ordem_serv"]);
                                servico.DataServico = Convert.ToDateTime(dr["sv_data"]);
                                servico.FK_IdCliente = Convert.ToInt32(dr["sv_cl_idcliente"]);
                                servico.Marca = dr["sv_marca"].ToString();
                                servico.Aparelho = dr["sv_aparelho"].ToString();
                                servico.Cor = dr["sv_cor"].ToString();
                                servico.MeiSerialNumber = dr["sv_mei_serialnumber"].ToString();
                                servico.Senha = dr["sv_senha"].ToString();
                                servico.Observacoes = dr["sv_observacoes"].ToString();
                                servico.RelatoCliente = dr["sv_relato_cliente"].ToString();
                                servico.TipoAparelho = dr["sv_tipo_aparelho"].ToString();
                                servico.Situacao = dr["sv_situacao"].ToString();
                                servico.AvaliacaoServico = dr["sv_avaliacao_servico"].ToString();

                                //Dados das condicoes fisicas
                                condicoesFisicas.ID = Convert.ToInt32(dr["cf_id"]);
                                condicoesFisicas.Pelicula = dr["cf_pelicula"].ToString();
                                condicoesFisicas.Tela = dr["cf_tela"].ToString();
                                condicoesFisicas.Tampa = dr["cf_tampa"].ToString();
                                condicoesFisicas.Aro = dr["cf_aro"].ToString();
                                condicoesFisicas.Botoes = dr["cf_botoes"].ToString();
                                condicoesFisicas.LenteCamera = dr["cf_lente_camera"].ToString();

                                //Dados do checklist
                                checklist.ID = Convert.ToInt32(dr["ch_id"]);
                                checklist.BiometriaFaceID = dr["ch_biometria_faceid"].ToString();
                                checklist.Microfone = dr["ch_microfone"].ToString();
                                checklist.Tela = dr["ch_tela"].ToString();
                                checklist.Chip = dr["ch_chip"].ToString();
                                checklist.Botoes = dr["ch_botoes"].ToString();
                                checklist.Sensor = dr["ch_sensor"].ToString();
                                checklist.Cameras = dr["ch_cameras"].ToString();
                                checklist.Auricular = dr["ch_auricular"].ToString();
                                checklist.Wifi = dr["ch_wifi"].ToString();
                                checklist.AltoFalante = dr["ch_altofalante"].ToString();
                                checklist.Bluetooth = dr["ch_bluetooth"].ToString();
                                checklist.Carregamento = dr["ch_carregamento"].ToString();
                                checklist.Observacoes = dr["ch_observacoes"].ToString();
                                checklist.Ausente = (bool)dr["ch_ausente"];
                                checklist.MotivoAusencia = dr["ch_motivo_ausencia"].ToString();

                                return (servico, condicoesFisicas, checklist);
                            }
                            else
                            {
                                servico = BuscarOS_ApenasServico(_idServico);
                                return (servico, null, null);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                me.ErroAoBuscarServicoCondicoesFisicasChecklist(e);
            }

            return (null, null, null);
        }

        #endregion Buscar OS pela ID (servico, condicao fisica, checklist)

        #region Buscar numero da ordem de servico e a data pela ID

        public ServicoEstrutura BuscarOrdemServicoEDataPelaId(int _idServico)
        {
            if (_idServico == -1)
            {
                MessageBox.Show("Nao foi possivel buscar ordem de servico pois a ID é -1", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    ServicoEstrutura dadosDoServico = null;
                    string query = "select sv_id from tb_servicos where sv_id = @IdServico";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(_idServico);

                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    dadosDoServico.ID = dr.GetInt32(0);

                    return dadosDoServico;
                }
            }
            catch (Exception e)
            {
                me.ErroAoBuscarOrdemServico(e);
                return null;
            }
        }

        #endregion Buscar numero da ordem de servico e a data pela ID

        #region Buscar quantidade de clientes existentes

        public int buscarQuantidadeClientes()
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "select count(cl_id) from tb_clientes";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        #endregion Buscar quantidade de clientes existentes

        #region Buscar a ID do Cliente

        public int BuscarIdCliente(string _nome)
        {
            int idCliente = 0;
            SqlDataReader reader;
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string Query = "Select cl_id from tb_clientes where cl_nome = @Nome";
                    SqlCommand cmd = new SqlCommand(Query, con);

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = _nome;

                    reader = cmd.ExecuteReader();
                    reader.Read();
                    idCliente = reader.GetInt32(0);

                    reader.Close();
                    //con.Close();
                }
            }
            catch (Exception e)
            {
                me.ErroBuscarIdCliente(e);
            }
            return idCliente;
        }

        #endregion Buscar a ID do Cliente

        #region Buscar imagem do banco (Senha de padrao)

        public byte[] BuscarImagem(string _idServico)
        {
            byte[] bytes;
            using (SqlConnection con = OpenConnection())
            {
                string query = "select sv_senha_pattern from tb_servicos where sv_id = @idServico";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;

                cmd.Parameters.AddWithValue("@idServico", SqlDbType.Int).Value = Convert.ToInt32(_idServico);
                reader = cmd.ExecuteReader();

                reader.Read();
                try
                {
                    bytes = (byte[])reader[0];
                    return bytes;
                }
                catch (Exception)
                {
                    return new byte[] { 0 };
                }
            }
        }

        #endregion Buscar imagem do banco (Senha de padrao)

        #region Buscar servicos do cliente

        public void BuscarServicosDoCliente(string _nomeCliente)
        {
            using (SqlConnection con = OpenConnection())
            {
                string Query = "select sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha from tb_servicos inner join tb_clientes on tb_servicos.sv_cl_idcliente = tb_clientes.cl_id where cl_nome like '%@NomeCliente%'";
                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = _nomeCliente;

                cmd.ExecuteNonQuery();
                //con.Close();
            }
        }

        #endregion Buscar servicos do cliente

        #region Buscar servicos concluidos (pesquisa por nome)

        public void BuscarServicosConcluidosPorNome(string _nomeCliente)
        {
            using (SqlConnection con = OpenConnection())
            {
                //@_nomeCliente
                SqlCommand cmd = new SqlCommand("SelecionarServicos_Done_NomeCliente", con);
                cmd.Parameters.AddWithValue("@_nomeCliente", _nomeCliente);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }

        #endregion Buscar servicos concluidos (pesquisa por nome)

        #region Buscar dias totais de garantia

        public void BuscarDiasGarantia(GunaLabel _Emissao, GunaLabel _DataFinal, GunaLabel _DiasRestantes, int _idServico)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string procedure = "GarantiaQuantosDias";

                SqlCommand cmd = new SqlCommand(procedure, conexao);
                cmd.Parameters.AddWithValue("@_fkServico", _idServico);
                cmd.CommandType = CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                dr.Read();

                _Emissao.Text = dr.GetDateTime(0).ToShortDateString();
                _DataFinal.Text = dr.GetDateTime(1).ToShortDateString();
                _DiasRestantes.Text = "Garantia: " + dr.GetInt32(2).ToString() + " Dias";

                dr.Close();
            }
        }

        #endregion Buscar dias totais de garantia

        #region Buscar dias faltantes da garantia

        public void BuscarDiasFaltantesGarantia(GunaLabel _LabelDiasFaltantes, GunaLabel _DataFinal, GunaLabel _DiasRestantes, int _idServico)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select gar_data_inicial, gar_data_final, datediff(DD, GETDATE(), gar_data_final) as diferenca from tb_garantias where fk_servico_id = @_fkServico";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@_fkServico", _idServico);
                cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();

                dr.Read();

                _LabelDiasFaltantes.Text = dr.GetDateTime(0).ToShortDateString();
                _DataFinal.Text = dr.GetDateTime(1).ToShortDateString();
                if (dr.GetInt32(2) < 0)
                {
                    _DiasRestantes.Text = "Faltam: 0 Dias";
                }
                else
                {
                    _DiasRestantes.Text = "Faltam: " + dr.GetInt32(2).ToString() + " Dias";
                }

                dr.Close();
            }
        }

        #endregion Buscar dias faltantes da garantia

        #region Buscar CPF do cliente

        public string BuscarCPFCliente(int _idCliente)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select cl_cpf from tb_clientes where cl_id = @IdCliente";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);
                dr = cmd.ExecuteReader();

                dr.Read();

                return dr.GetString(0);
            }
        }

        #endregion Buscar CPF do cliente

        #region Buscar Telefone do Cliente

        public string BuscarTelefoneCliente(int _idCliente)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                SqlDataReader dr;
                string query = "select cl_telefone from tb_clientes where cl_id = @IdCliente";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);
                dr = cmd.ExecuteReader();

                dr.Read();

                return dr.GetString(0);
            }
        }

        #endregion Buscar Telefone do Cliente

        #region Buscar telefone secundario do cliente

        public string BuscarTelefoneRecadoCliente(int _idCliente)
        {
            using (SqlConnection conexao = OpenConnection())
            {
                string query = "select cl_telefone_recado from tb_clientes where cl_id = @IdCliente";

                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);
                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                return dr.GetString(0);
            }
        }

        #endregion Buscar telefone secundario do cliente

        #region Buscar total de servicos concluidos

        public int BuscarTotalServicosConcluidos()
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "SELECT COUNT(sv_id) FROM tb_servicos WHERE sv_status = 0 and sv_ativo = 1";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    return dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return 0;
            }
        }

        #endregion Buscar total de servicos concluidos

        #region Buscar ID do ultimo servico adicionado

        public int BuscarIdUltimoServicoAdicionado()
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "select max(sv_id) from tb_servicos";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

                    return dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex);
                me.ErroAoBuscarIDUltimoServico(ex);
                return 0;
            }
        }

        #endregion Buscar ID do ultimo servico adicionado

        #region Buscar servico por ID

        public List<object> BuscarServicoPorID(int _idServico)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "select sv_id, sv_cl_idcliente, sv_data, cl_nome, sv_aparelho, sv_defeito, sv_situacao, sv_senha, " +
                    "sv_valorservico, sv_valorpeca, sv_lucro, sv_servico, sv_previsao_entrega, sv_existe_um_prazo, sv_acessorios, sv_cor_tempo " +
                    "FROM tb_servicos " +
                    "INNER JOIN tb_clientes ON tb_servicos.sv_cl_idcliente = tb_clientes.cl_id " +
                    "WHERE sv_id = @IdServico";

                    List<object> dados = new List<object>();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdServico", _idServico);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dados.Add(dr.GetValue(0));//id
                        dados.Add(dr.GetValue(1));//id cliente
                        dados.Add(dr.GetValue(2));//sv_data
                        dados.Add(dr.GetValue(3));//cl_nome
                        dados.Add(dr.GetValue(4));//sv_aparelho
                        dados.Add(dr.GetValue(5));//sv_defeito
                        dados.Add(dr.GetValue(6));//sv_situacao
                        dados.Add(dr.GetValue(7));//sv_senha
                        dados.Add(dr.GetValue(8));//sv_valorservico
                        dados.Add(dr.GetValue(9));//sv_valorpeca
                        dados.Add(dr.GetValue(10));//sv_lucro
                        dados.Add(dr.GetValue(11));//sv_servico
                        dados.Add(dr.GetValue(12));//sv_previsao_entrega
                        dados.Add(dr.GetValue(13));//sv_existe_um_prazo
                        dados.Add(dr.GetValue(14));//sv_acessorios
                        dados.Add(dr.GetValue(15));//sv_cor_tempo

                        return dados;
                    }
                }
            }
            catch (Exception)
            {
                // throw;
            }

            return null;
        }

        #endregion Buscar servico por ID

        #region Buscar ID ultima Ordem de Servico

        public int BuscarUltimaIdOrdemServico()
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string query = "SELECT TOP 1 sv_ordem_serv FROM tb_servicos ORDER BY sv_id DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return dr.GetInt32(0);
                    }
                    return -1; //Retornando -1 porque 0 é um valor valido no banco.
                }
            }
            catch (Exception ex)
            {
                me.ErroAoBuscarIDUltimaOrdemServico(ex);
                return -1;
            }
        }

        #endregion Buscar ID ultima Ordem de Servico
    }
}