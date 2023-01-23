using PFC___StandBy_CSharp.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.DataAccess.Sql;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Dados;
using DevExpress.DataAccess.ConnectionParameters;
using static PFC___StandBy_CSharp.Enums.EnumStandby;
using System.Linq;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PFC___StandBy_CSharp.Forms.Pagamento_e_Compras
{
    public partial class form_Compras : DevExpress.XtraEditors.XtraForm
    {
        //private BindingList<tb_comp_items> bindFiltrado;
        private BuscarDados bd = new BuscarDados();
        private standby_orgContext context = new standby_orgContext();
        private int ordemServico = 0;
        private int idServico = 0;
        private int rowHandle;
        private GridColumn column;

        public form_Compras(int _ordemServico, int _idServico)
        {
            InitializeComponent();
            idServico = _idServico;
            ordemServico = _ordemServico;
            CarregarTudo();
        }

        private void SetarOrdemServicoNaCombobox()
        {
            cmbOrdemServico.EditValue = ordemServico;
            cmbOrdemServico.Text = ordemServico.ToString();
        }

        private void CarregarTudo()
        {
            //MsSqlConnectionParameters connectionParameters = new MsSqlConnectionParameters("localhost", "standby_org", "sa", "123adr", MsSqlAuthorizationType.SqlServer);
            //SqlDataSource ds = new SqlDataSource(connectionParameters);
            //CustomSqlQuery query = new CustomSqlQuery();
            //query.Name = "customQuery1";
            //query.Sql = "SELECT * FROM tb_clientes";
            //ds.Queries.Add(query);
            //ds.Fill();

            //gridControl1.DataSource = ds;
            //gridControl1.DataMember = "customQuery1";
            //int idServicoInt = Convert.ToInt32(lblIdServico.Text);
            //string idServicoString = lblIdServico.Text;

            gridControl1.BeginInit();
            // QueryParameter param = sqlDataSource1.Queries["QueryCompras"].Parameters.Where(p => p.Name == "parameter1")
            //   .First();
            sqlDataSource1.Queries[0].Parameters["IDServico"].Value = idServico;
            sqlDataSource1.Fill();
            gridControl1.EndInit();
            sqlDataSource2.Fill();
            SetarOrdemServicoNaCombobox();
        }

        private void form_Compras_Load(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //cmbOrdemServico.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "sv_ordem_serv");
                txtPeca.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "cp_peca_comprada").ToString();
                txtValor.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "cp_valor_peca").ToString();
                txtFornecedor.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "cp_fornecedor").ToString();
                //MessageBox.Show($"{gridView1.GetRowCellValue(e.FocusedRowHandle, "sv_ordem_serv")}\n{gridView1.GetRowCellValue(e.FocusedRowHandle, "cp_valor_peca")}");
            }
            catch
            {
            }
        }

        private void btnSalvarLista_Click(object sender, EventArgs e)
        {
            tb_compras compras = new tb_compras();
            compras.cp_data = DateTime.Now;
            compras.cp_peca_comprada = txtPeca.Text;
            compras.cp_valor_peca = Convert.ToDecimal(txtValor.Text);
            compras.cp_fornecedor = txtFornecedor.Text;
            compras.cp_sv_id = bd.BuscarIDServicoPelaOS(Convert.ToInt32(cmbOrdemServico.EditValue));
            context.tb_compras.Add(compras);
            context.SaveChanges();
            CarregarTudo();
        }

        private void form_Compras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnRemoverCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var compra = BuscarDadosLinhaSelecionada();
            int idCompra = Convert.ToInt32(compra[0]);

            standby_orgContext context = new standby_orgContext();
            context.tb_compras.Remove(context.tb_compras.FirstOrDefault(x => x.cp_id == idCompra));
            context.SaveChanges();
            CarregarTudo();
        }

        private IRow BuscarDadosLinhaSelecionada()
        {
            var indexLinhaAtual = gridView1.FocusedRowHandle;
            var dadosDaLinhaAtual = gridView1.GetRow(indexLinhaAtual);
            var servico = dadosDaLinhaAtual as IRow;

            return servico;
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //Faz o component de popup ser associado ao gridview
            //assim quando clico botao direito no grid, ele aparece
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRowCell)
            {
                view.FocusedRowHandle = rowHandle = hitInfo.RowHandle;
                column = hitInfo.Column;
                popupMenu1.ShowPopup(barManager1, view.GridControl.PointToScreen(e.Point));
            }
        }
    }
}