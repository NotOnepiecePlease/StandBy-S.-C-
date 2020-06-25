﻿using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Dados
{
    class InserirDados : conexao
    {
        MensagensErro mErro = new MensagensErro();
        MensagensSucesso mSucesso = new MensagensSucesso();
        public void InserirServico(DateTime data, int fk_cliente, string aparelho, string defeito, string senha, string situacao)
        {
            {
                //Abro a conexao.
                using (SqlConnection conexaoSQL = OpenConnection())
                {
                    //Defino a query que preciso com os parametros que vao ser criados logo apos.
                    string query = "INSERT INTO tb_servicos (sv_data, sv_cl_idcliente, sv_aparelho, sv_defeito, sv_senha, sv_situacao) " +
                        "VALUES (@Data,  @FkCliente, @Aparelho, @Defeito, @Senha, @Situacao)";

                    //Crio um novo objeto do tipo "Comando em SQL" passando como argumento
                    //a minha query e uma conexao pra ele saber em que banco inserir.
                    SqlCommand cmd = new SqlCommand(query, conexaoSQL);

                    //Defino os parametros e quais dados eles vao receber
                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = data;
                    cmd.Parameters.Add("@FkCliente", SqlDbType.Int).Value = fk_cliente;
                    cmd.Parameters.Add("@Aparelho", SqlDbType.VarChar).Value = aparelho;
                    cmd.Parameters.Add("@Defeito", SqlDbType.VarChar).Value = defeito;
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;
                    cmd.Parameters.Add("@Situacao", SqlDbType.VarChar).Value = situacao;

                    //Executo ta query completa
                    cmd.ExecuteNonQuery();
                }
                //Fecho a conexao, nunca deixar aberta pois ocasiona lag e erros de acesso.
                //conexaoSQL.Close();
            }
        }

        public void InserirCliente(string nome, string cpf, string tel)
        {
            try
            {
                //Abrir conexão
                using (SqlConnection con = OpenConnection())
                {
                    //Inserção
                    String qry = "insert into dbo.tb_clientes (cl_nome, cl_telefone, cl_cpf) " +
                        "VALUES ('" + nome + "','" + tel + "','" + cpf + "')";

                    SqlCommand cmd = new SqlCommand(qry, con);
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
                    cmd.Parameters.AddWithValue("@_DataAtual", DateTime.Now.ToShortDateString());
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
    }
}
