using PFC___StandBy_CSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraGrid;
using PFC___StandBy_CSharp.Context;
using System.Data;
using System.Drawing;
using DevExpress.DataAccess.Sql.DataApi;
using PFC___StandBy_CSharp.Dados;
using PFC___StandBy_CSharp.Forms.Pagamento_e_Compras;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PFC___StandBy_CSharp.Forms.Pagamento
{
    public partial class form_Pagamento : Form
    {
        private List<string> lista = new List<string>();
        private BindingList<tb_pagamento> bindFiltrado;
        private standby_orgContext context = new standby_orgContext();
        BuscarDados bd = new BuscarDados();
        private int idServico = 0;

        public form_Pagamento(int _idServico)
        {
            InitializeComponent();
            idServico = _idServico;
            PopularGridview();
        }

        private void BuscarValorTotalPecas()
        {
            decimal valorTotalPecas = 0;
            //for (int i = 0; i < gridView1.RowCount; i++)
            //{
            //    DataRowView row = gridView1.GetRow(i) as DataRowView;
            //    if (row != null)
            //    {
            //        valorTotalPecas += Convert.ToDecimal(gridView1.GetRowCellValue(i, "pag_valor"));
            //    }
            //}

            standby_orgContext context = new standby_orgContext();
            List<tb_compras> pecas = context.tb_compras.Where(x => x.cp_sv_id == idServico).ToList();
            foreach (tb_compras peca in pecas)
            {
                valorTotalPecas += peca.cp_valor_peca;
            }

            txtValorPeca.Text = $"{valorTotalPecas:C}";
        }

        private void CalcularLucroTotal()
        {
            decimal valorServico = Convert.ToDecimal(txtValorServico.Text.Replace("R$", "").Trim());
            decimal valorPecas = Convert.ToDecimal(txtValorPeca.Text.Replace("R$", "").Trim());

            txtLucroTotal.Text = $"{valorServico - valorPecas:C}";
        }

        private void PopularGridview()
        {
            bindFiltrado =
                new BindingList<tb_pagamento>(context.tb_pagamento.Where(x => x.pag_sv_id == idServico).ToList());
            bindingSource1.DataSource = bindFiltrado;
            //MessageBox.Show();
            gridView1.RefreshData();
        }

        private void btnConcluirServicoPagamento_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gridView1.PostEditor();
                gridView1.UpdateCurrentRow();
                gridView1.FocusedRowHandle = GridControl.NewItemRowHandle;
                gridView1.FocusedColumn = gridView1.VisibleColumns[0];
            }
        }

        private int BuscarQtdTotalParcelas()
        {
            int qtdTotalParcelas = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (Convert.ToInt32(gridView1.GetRowCellValue(i, "pag_parcelas")) != 0)
                {
                    qtdTotalParcelas += Convert.ToInt32(gridView1.GetRowCellValue(i, "pag_parcelas"));
                }
            }

            return qtdTotalParcelas;
        }

        private void CalcularValoresDasParcelas(int _qtdTotalParcelas)
        {
            decimal valorServico = Convert.ToDecimal(txtValorServico.Text.Replace("R$", "").Trim());
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (Convert.ToInt32(gridView1.GetRowCellValue(i, "pag_parcelas")) != 0)
                {
                    int parcelasLinhaAtual = Convert.ToInt32(gridView1.GetRowCellValue(i, "pag_parcelas"));
                    decimal valorUnidadeParcela = valorServico / _qtdTotalParcelas;

                    decimal valorRealParcela = valorUnidadeParcela * parcelasLinhaAtual;
                    decimal valoParcelaDuasCasasDecimais =
                        decimal.Round(valorRealParcela, 2, MidpointRounding.AwayFromZero);
                    gridView1.SetRowCellValue(i, "pag_valor", $"{valoParcelaDuasCasasDecimais}");
                }
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            CalcularValoresDasParcelas(BuscarQtdTotalParcelas());
            tb_pagamento dado = e.Row as tb_pagamento;

            if (e.RowHandle == GridControl.NewItemRowHandle)
            {
                dado.pag_sv_id = idServico;
                context.tb_pagamento.Add(dado);
            }

            gridView1.UpdateCurrentRow();
        }

        private void form_Pagamento_Shown(object sender, EventArgs e)
        {
            BuscarValorTotalPecas();
            CalcularLucroTotal();
        }

        private void form_Pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtValorPeca_TextChanged(object sender, EventArgs e)
        {
            CalcularLucro();
        }

        public void CalcularLucro()
        {
            float valorServico = 0.0f;
            float valorPeca = 0.0f;
            float lucro = valorServico - valorPeca;
            try
            {
                valorServico = float.Parse(txtValorServico.Text.TrimStart('R', '$').Trim());
                valorPeca = float.Parse(txtValorPeca.Text.TrimStart('R', '$').Trim());
                lucro = valorServico - valorPeca;
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.ToString());
            }

            if (lucro > 0)
            {
                txtLucroTotal.ForeColor = Color.LimeGreen;
                txtLucroTotal.Text = $"{lucro:C}";
            }
            else if (lucro == 0)
            {
                txtLucroTotal.ForeColor = Color.White;
                txtLucroTotal.Text = $"{lucro:C}";
            }
            else if (lucro < 0)
            {
                txtLucroTotal.ForeColor = Color.Red;
                txtLucroTotal.Text = $"{lucro:C}";
            }
        }

        private void btnAbrirListaCompras_Click(object sender, EventArgs e)
        {
            AbrirFormaCompras();
            txtValorPeca.Text = $@"{bd.BuscarTotalPecas(Convert.ToInt32(lblIdServico.Text)):C}";
        }


        private void AbrirFormaCompras()
        {
            int ordemServico = bd.BuscarNumeroDaOSPelaIdServico(Convert.ToInt32(lblIdServico.Text));
            int idServico = Convert.ToInt32(lblIdServico.Text);
            form_Compras formCompra = new form_Compras(ordemServico, idServico);
            formCompra.lblIdServico.Text = lblIdServico.Text;
            formCompra.cmbOrdemServico.Enabled = false;
            formCompra.ShowDialog();
            CalcularValoresDasParcelas(BuscarQtdTotalParcelas());
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns[3], "0");
            view.SetRowCellValue(e.RowHandle, view.Columns[4], "0");
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            {
                GridView view = sender as GridView;
                view.GridControl.BeginInvoke(new MethodInvoker(() =>
                {
                    PopupBaseEdit edit = view.ActiveEditor as PopupBaseEdit;
                    if (edit == null) return;
                    edit.ShowPopup();
                }));
            }
        }
    }
}