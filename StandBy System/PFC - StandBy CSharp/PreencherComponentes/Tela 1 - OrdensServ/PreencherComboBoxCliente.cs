using System;
using System.Collections.Generic;
using PFC___StandBy_CSharp.MsgBox;
using System.Data.SqlClient;
using PFC___StandBy_CSharp.Models;

namespace PFC___StandBy_CSharp.PreencherComponentes
{
    internal class PreencherComboBoxCliente : MensagensErro
    {
        public List<ClienteDados> Preencher()
        {
            List<ClienteDados> listClientes = new List<ClienteDados>();
            SqlConnection con = OpenConnection();
            string query = "select cl_id, cl_nome, cl_cpf, cl_telefone, cl_telefone_recado, cl_data_nascimento, cl_endereco, cl_bairro, cl_estado from tb_clientes order by cl_id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader;

            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nome = dataReader.GetString(1);
                    string cpf = dataReader.GetString(2);
                    string telefone = dataReader.GetString(3);
                    string telefoneRecado = dataReader.GetString(4);
                    string dataNascimento = dataReader.IsDBNull(5) ? "---" : dataReader.GetDateTime(5).ToShortDateString();
                    string endereco = dataReader.IsDBNull(6) ? "---" : dataReader.GetString(6);
                    string bairro = (dataReader.IsDBNull(7)) || (dataReader.GetString(7) == "") ? "---" : dataReader.GetString(7);
                    string estado = dataReader.IsDBNull(8) ? "---" : dataReader.GetString(8);

                    listClientes.Add(new ClienteDados
                    {
                        ID = id,
                        Nome = nome,
                        Cpf = cpf,
                        Telefone = telefone,
                        TelefoneRecado = telefoneRecado,
                        DataNascimento = dataNascimento,
                        Endereco = endereco,
                        Bairro = bairro,
                        Estado = estado
                    });
                }
            }
            catch (Exception e)
            {
                ComboBoxClienteErroEmPreencher(e);
            }

            return listClientes;
        }
    }
}