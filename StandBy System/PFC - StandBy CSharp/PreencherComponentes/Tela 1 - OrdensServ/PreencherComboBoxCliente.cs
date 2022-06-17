using System;
using PFC___StandBy_CSharp.MsgBox;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PFC___StandBy_CSharp.PreencherComponentes
{
    internal class PreencherComboBoxCliente : MensagensErro
    {
        public void Preencher(ComboBox cmbClientes)
        {
            SqlConnection con = OpenConnection();
            string Query = "select cl_nome from tb_clientes order by cl_id";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dataReader;

            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string nome = dataReader.GetString(0);
                    cmbClientes.Items.Add(nome);
                }
            }
            catch (Exception e)
            {
                ComboBoxClienteErroEmPreencher(e);
            }
        }
    }
}