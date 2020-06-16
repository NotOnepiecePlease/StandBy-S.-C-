using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFC___StandBy_CSharp.Forms;
using PFC___StandBy_CSharp.SqlDbConnect;
using PFC___StandBy_CSharp.MsgBox;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.Framework.UI;

namespace PFC___StandBy_CSharp.PreencherComponentes
{
    class PreencherComboBoxCliente : MensagensErro 
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
