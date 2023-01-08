using DevExpress.ChartRangeControlClient.Core;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Microsoft.Office.Interop.Word;
using PFC___StandBy_CSharp.Context;
using PFC___StandBy_CSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using PFC___StandBy_CSharp.Utils;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_ComboboxConfig : Form
    {
        private standby_orgContext context;

        private int rowHandle;
        private GridColumn column;
        private BindingList<tb_comp_items> bindFiltrado;

        public form_ComboboxConfig()
        {
            InitializeComponent();
            context = new standby_orgContext();
            CarregarComboboxTela();
            //CarregarGrid();
            //context.tb_comp_items.Load();
            //bindingSource1.DataSource = context.tb_comp_items.Local.ToBindingList();
        }

        private void CarregarComboboxTela()
        {
            ComboBoxItemCollection collection = cmbTela.Properties.Items;
            collection.BeginUpdate();

            var telas = context.tb_comp_items.Select(x => x.item_tela).Distinct().ToList();
            cmbTela.Properties.Items.Clear();
            foreach (var texto in telas)
            {
                cmbTela.Properties.Items.Add(texto);
            }
            collection.EndUpdate();
            cmbTela.SelectedIndex = 0;
        }

        private void CarregarComboboxGrupo()
        {
            ComboBoxItemCollection collection = cmbGrupo.Properties.Items;
            collection.BeginUpdate();

            var grupo = context.tb_comp_items.Where(y => y.item_tela == cmbTela.Text).Select(x => x.item_grupo).Distinct().ToList();
            cmbGrupo.Properties.Items.Clear();
            foreach (var texto in grupo)
            {
                cmbGrupo.Properties.Items.Add(texto);
            }
            collection.EndUpdate();
            cmbGrupo.Enabled = true;
            cmbGrupo.SelectedIndex = 0;
        }

        private void CarregarComboboxCampo()
        {
            ComboBoxItemCollection collection = cmbCampo.Properties.Items;
            collection.BeginUpdate();

            var grupo = context.tb_comp_items.Where(y => y.item_tela == cmbTela.Text && y.item_grupo == cmbGrupo.Text).Select(x => x.item_nome).Distinct().ToList();
            cmbCampo.Properties.Items.Clear();
            foreach (var texto in grupo)
            {
                cmbCampo.Properties.Items.Add(texto);
            }
            collection.EndUpdate();
            cmbCampo.Enabled = true;
            cmbCampo.SelectedIndex = 0;
        }

        private void cmbTela_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComboboxGrupo();
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComboboxCampo();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Versao usando query, util pra fazer inner join (usar o context.saveChanges)

            //var query = from items in context.tb_comp_items
            //            where items.item_tela == cmbTela.Text &&
            //                  items.item_grupo == cmbGrupo.Text &&
            //                  items.item_nome == cmbCampo.Text
            //            select items;

            //var bindFiltrado = new BindingList<tb_comp_items>(query.ToList());

            #endregion Versao usando query, util pra fazer inner join (usar o context.saveChanges)

            bindFiltrado = new BindingList<tb_comp_items>(context.tb_comp_items
                .Where(y => y.item_tela == cmbTela.Text && y.item_grupo == cmbGrupo.Text &&
                            y.item_nome == cmbCampo.Text).ToList());
            bindingSource1.DataSource = bindFiltrado;
            gridView1.Columns[2].OptionsColumn.AllowEdit = false;
            gridView1.Columns[2].OptionsColumn.ReadOnly = true;

            gridView1.Columns[3].OptionsColumn.AllowEdit = false;
            gridView1.Columns[4].OptionsColumn.AllowEdit = false;
            gridView1.Columns[5].OptionsColumn.AllowEdit = false;
            //MessageBox.Show();
            gridView1.RefreshData();
        }

        private int zero = 0;

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            try
            {
                if (e.RowHandle == GridControl.NewItemRowHandle)
                {
                    tb_comp_items dado = e.Row as tb_comp_items;

                    if (Control.ModifierKeys == Keys.Shift)
                    {
                        context.tb_comp_items.Add(dado);
                    }
                    else
                    {
                        if (dado.item_editavel == false)
                        {
                            MessageBox.Show("Item nao pode ser removido ou editado");
                            return;
                        }
                        context.tb_comp_items.Add(dado);
                    }
                }

                gridView1.UpdateCurrentRow();
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            MessageBox.Show("Salvou");
        }

        private void btnAdicionarRegistro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bindFiltrado.AddNew();
            gridView1.AddNewRow();
            //bindingSource1.AddNew();
        }

        private void btnRemoverRegistro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            //GridView view = sender as GridView;
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            //view.DeleteSelectedRows();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRowCell)
            {
                view.FocusedRowHandle = rowHandle = hitInfo.RowHandle;
                column = hitInfo.Column;
                popupMenu1.ShowPopup(barManager1, view.GridControl.PointToScreen(e.Point));
            }
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            //view.SetRowCellValue(e.RowHandle, view.Columns[0], 0);
            //view.SetRowCellValue(e.RowHandle, view.Columns[1], 1);
            view.SetRowCellValue(e.RowHandle, view.Columns[2], cmbGrupo.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns[3], cmbTela.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns[4], cmbCampo.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns[5], true);
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            try
            {
                tb_comp_items dado = e.Row as tb_comp_items;
                if (dado.item_editavel == false)
                {
                    MessageBox.Show("Item nao pode ser removido ou editado");
                    return;
                }
                context.tb_comp_items.Remove(dado);

                gridView1.UpdateCurrentRow();
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            MessageBox.Show("REMOVIDO");
        }

        private void form_ComboboxConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Constantes.IniciarOpcoesChecklistEntrada();
                this.Close();
            }
            else if (e.Modifiers == Keys.Shift)
            {
                if ((ModifierKeys & Keys.Shift) != 0)
                {
                    gridView1.Columns[5].OptionsColumn.AllowEdit = false;
                    gridView1.Columns[5].OptionsColumn.AllowFocus = false;
                    gridView1.Columns[5].OptionsColumn.ReadOnly = true;
                }
                else
                {
                    gridView1.Columns[5].OptionsColumn.AllowEdit = true;
                    gridView1.Columns[5].OptionsColumn.AllowFocus = true;
                    gridView1.Columns[5].OptionsColumn.ReadOnly = false;
                }
                // MessageBox.Show("Liberado acesso");
            }
        }

        private void form_ComboboxConfig_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.ShiftKey)
            //{
            //    gridView1.Columns[5].OptionsColumn.AllowEdit = false;
            //    gridView1.Columns[5].OptionsColumn.AllowFocus = false;
            //    gridView1.Columns[5].OptionsColumn.ReadOnly = true;
            //    //MessageBox.Show("Bloqueado acesso");
            //}
        }
    }
}