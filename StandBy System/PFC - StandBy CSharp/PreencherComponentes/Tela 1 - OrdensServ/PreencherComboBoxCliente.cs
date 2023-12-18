using System.Collections.Generic;
using PFC___StandBy_CSharp.MsgBox;
using PFC___StandBy_CSharp.Models;
using System.Data;
using System.Linq;
using PFC___StandBy_CSharp.Dados;
using Syncfusion.Windows.Forms.Tools;

namespace PFC___StandBy_CSharp.PreencherComponentes
{
    internal class PreencherComboBoxCliente : MensagensErro
    {
        private List<ClienteEstrutura> listClientesComId = new List<ClienteEstrutura>();

        private BuscarDados bd = new BuscarDados();

        private int ultimoClienteAdicionadoID = 0;

        public int CarregarComboxClientes(MultiColumnComboBox cmbCliente, ref DataTable _dtPrincipal)
        {
            cmbCliente.Style                = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            cmbCliente.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Black;

            listClientesComId = bd.BuscarListaClientes();

            DataTable dtLocal = new DataTable("Table1");
            dtLocal.Columns.Add("ID");            //0
            dtLocal.Columns.Add("Nome");          //1
            dtLocal.Columns.Add("Cpf");           //2
            dtLocal.Columns.Add("⠀⠀⠀Telefone⠀⠀"); //3

            //dtLocal.Columns.Add("Full", typeof(string),
            //    "Nome + ' - ' + Cpf ");
            //"Nome + ' - ' + Cpf ");
            dtLocal.Columns.Add("Recado"); //4
            dtLocal.Columns.Add("CEP");    //5
            dtLocal.Columns.Add("RUA");    //6
            dtLocal.Columns.Add("BAIRRO"); //7
            dtLocal.Columns.Add("CIDADE"); //8
            dtLocal.Columns[0].ColumnMapping = MappingType.Hidden;
            dtLocal.Columns[4].ColumnMapping = MappingType.Hidden;
            dtLocal.Columns[5].ColumnMapping = MappingType.Hidden;
            dtLocal.Columns[6].ColumnMapping = MappingType.Hidden;
            dtLocal.Columns[7].ColumnMapping = MappingType.Hidden;
            dtLocal.Columns[8].ColumnMapping = MappingType.Hidden;

            DataSet ds = new DataSet();
            ds.Tables.Add(dtLocal);

            listClientesComId
                .OrderBy(x => x.Nome)
                .ToList()
                .ForEach(cliente =>
                {
                    //Pegando a id do ultimo cliente adicionado (ou o que tem MAIOR ID q da na mesma)
                    ultimoClienteAdicionadoID =
                        cliente.ID > ultimoClienteAdicionadoID ? cliente.ID : ultimoClienteAdicionadoID;

                    dtLocal.Rows.Add(new string[]
                    {
                        $"{cliente.ID}", $"{cliente.Nome}", $"{cliente.Cpf}", $"{cliente.Telefone}"
                        , $"{cliente.TelefoneRecado}", $"{cliente.Cep}", $"{cliente.Endereco}", $"{cliente.Bairro}"
                        , $"{cliente.Cidade}"
                    });
                });

            DataView view = new DataView(dtLocal);
            _dtPrincipal = dtLocal;

            cmbCliente.DataSource    = view;
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember   = "ID";

            return ultimoClienteAdicionadoID;
        }
    }
}