using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Forms;
using System.Runtime.InteropServices;

namespace PFC___StandBy_CSharp.Dados
{
    class InserirDados : conexao
    {
        MensagensErro mErro = new MensagensErro();
        MensagensSucesso mSucesso = new MensagensSucesso();
        VerificarExistencia verificarExistencia = new VerificarExistencia();

        public void Alert(string msg, form_AlertMessage.enmType type)
        {
            form_AlertMessage frm = new form_AlertMessage();
            frm.showAlert(msg, type);
        }


        #region Inserir Servico
        public void InserirServico(DateTime data, int fk_cliente, string aparelho, string defeito, string senha, string situacao, int DiasParaEntregar, int SeExisteUmPrazo, [Optional] byte[] image)
        {
            {
                //Abro a conexao.
                using (SqlConnection conexaoSQL = OpenConnection())
                {
                    //Defino a query que preciso com os parametros que vao ser criados logo apos.
                    string query = "INSERT INTO tb_servicos (sv_data, sv_cl_idcliente, sv_aparelho, sv_defeito, sv_senha, sv_situacao, sv_previsao_entrega, sv_existe_um_prazo) " +
                        "VALUES (@Data,  @FkCliente, @Aparelho, @Defeito, @Senha, @Situacao, @PrevisaoEntrega, @SeExisteUmPrazo)";

                    //Crio um novo objeto do tipo "Comando em SQL" passando como argumento
                    //a minha query e uma conexao pra ele saber em que banco inserir.
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    DateTime previsaoEntrega = DateTime.Now;
                    previsaoEntrega = previsaoEntrega.AddDays(DiasParaEntregar);

                    //Defino os parametros e quais dados eles vao receber
                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = data;
                    cmd.Parameters.Add("@FkCliente", SqlDbType.Int).Value = fk_cliente;
                    cmd.Parameters.Add("@Aparelho", SqlDbType.VarChar).Value = aparelho;
                    cmd.Parameters.Add("@Defeito", SqlDbType.VarChar).Value = defeito;
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;
                    cmd.Parameters.Add("@Situacao", SqlDbType.VarChar).Value = situacao;
                    cmd.Parameters.Add("@PrevisaoEntrega", SqlDbType.DateTime).Value = previsaoEntrega;
                    cmd.Parameters.Add("@SeExisteUmPrazo", SqlDbType.Int).Value = SeExisteUmPrazo;

                    //Executo ta query completa
                    cmd.ExecuteNonQuery();
                }
                //Fecho a conexao, nunca deixar aberta pois ocasiona lag e erros de acesso.
                //conexaoSQL.Close();
            }
        }
        #endregion

        #region Inserir Cliente
        public void InserirCliente(string _nome, string _cpf, string _telPrincipal, string _telRecados)
        {
            bool CpfExistente = false;
            if(_cpf.Equals("SEM CPF/CNPJ"))
            {
                CpfExistente = false;
            }
            else
            {
                CpfExistente = verificarExistencia.VerificarExistenciaCPF(_cpf);
            }

            if (CpfExistente == true)
            {
                MessageBox.Show("CPF/CNPJ Já existe, verifique se o cliente já esta cadastrado.", "CPF/CNPJ Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Abrir conexão
                    using (SqlConnection con = OpenConnection())
                    {
                        //Inserção
                        String qry = "insert into dbo.tb_clientes (cl_nome, cl_telefone, cl_cpf, cl_telefone_recado) " +
                            "VALUES (@Nome, @TelefonePrincipal, @CpfOuCnpj, @TelefoneRecados)";

                        //String qry = "insert into dbo.tb_clientes (cl_nome, cl_telefone, cl_cpf) " +
                        //    "VALUES ('" + nome + "','" + tel + "','" + cpf + "')";

                        SqlCommand cmd = new SqlCommand(qry, con);

                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = _nome;
                        cmd.Parameters.Add("@TelefonePrincipal", SqlDbType.VarChar).Value = _telPrincipal;
                        cmd.Parameters.Add("@CpfOuCnpj", SqlDbType.VarChar).Value = _cpf;
                        cmd.Parameters.Add("@TelefoneRecados", SqlDbType.VarChar).Value = _telRecados;
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
        #endregion

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
        #endregion

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
                MessageBox.Show("Nao foi possivel inserir a garantia no banco de dados.\n\n\nErro: " + ex);
            }
        }
        #endregion

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
                    MessageBox.Show("Orçamento inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n\n"+ex, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
