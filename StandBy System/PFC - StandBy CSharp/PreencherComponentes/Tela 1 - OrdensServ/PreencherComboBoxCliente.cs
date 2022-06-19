using System;
using System.Collections.Generic;
using PFC___StandBy_CSharp.MsgBox;
using System.Windows.Forms;
using System.Data.SqlClient;
using PFC___StandBy_CSharp.Models;

namespace PFC___StandBy_CSharp.PreencherComponentes
{
    internal class PreencherComboBoxCliente : MensagensErro
    {
        public struct ClienteModel
        {
            public string Nome { get; set; }
            public int Id { get; set; }
        }

        public List<ClienteDados> Preencher()
        {
            List<ClienteDados> listClientes = new List<ClienteDados>();
            SqlConnection con = OpenConnection();
            string query = "select cl_nome, cl_id, cl_cpf from tb_clientes order by cl_id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataReader;

            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string nome = dataReader.GetString(0);
                    int id = dataReader.GetInt32(1);
                    string Cpf = dataReader.GetString(2);
                    listClientes.Add(new ClienteDados { Nome = nome, ID = id, Cpf = Cpf });
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