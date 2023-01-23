namespace PFC___StandBy_CSharp.Forms.Pagamento_e_Compras
{
    partial class form_Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Compras));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            this.lblOrdemServico = new DevExpress.XtraEditors.LabelControl();
            this.lblIdServico = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeca = new DevExpress.XtraEditors.TextEdit();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.txtFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvarLista = new DevExpress.XtraEditors.SimpleButton();
            this.cmbOrdemServico = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tb_servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsv_ordem_serv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsv_aparelho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcl_nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnRemoverCompra = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.moverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.moverPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdemServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(306, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(283, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "LISTA DE COMPRAS";
            // 
            // panelTop
            // 
            this.panelTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelTop.Appearance.Options.UseBackColor = true;
            this.panelTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelTop.Controls.Add(this.lblOrdemServico);
            this.panelTop.Controls.Add(this.labelControl1);
            this.panelTop.Controls.Add(this.lblIdServico);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(895, 51);
            this.panelTop.TabIndex = 1;
            // 
            // lblOrdemServico
            // 
            this.lblOrdemServico.Location = new System.Drawing.Point(0, 25);
            this.lblOrdemServico.Name = "lblOrdemServico";
            this.lblOrdemServico.Size = new System.Drawing.Size(94, 16);
            this.lblOrdemServico.TabIndex = 15;
            this.lblOrdemServico.Text = "lblOrdemServico";
            this.lblOrdemServico.Visible = false;
            // 
            // lblIdServico
            // 
            this.lblIdServico.Location = new System.Drawing.Point(0, 3);
            this.lblIdServico.Name = "lblIdServico";
            this.lblIdServico.Size = new System.Drawing.Size(66, 16);
            this.lblIdServico.TabIndex = 13;
            this.lblIdServico.Text = "lblIdServico";
            this.lblIdServico.Visible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Principal";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "QueryCompras";
            queryParameter1.Name = "IDServico";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "0";
            customSqlQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(86, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(169, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Selecione a ordem de serviço";
            // 
            // txtPeca
            // 
            this.txtPeca.EditValue = "";
            this.txtPeca.Location = new System.Drawing.Point(340, 81);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(170, 30);
            this.txtPeca.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.EditValue = "";
            this.txtValor.Location = new System.Drawing.Point(548, 81);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 30);
            this.txtValor.TabIndex = 6;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.EditValue = "";
            this.txtFornecedor.Location = new System.Drawing.Point(686, 81);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(120, 30);
            this.txtFornecedor.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(412, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Peça";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(583, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Valor";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(714, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Fornecedor";
            // 
            // btnSalvarLista
            // 
            this.btnSalvarLista.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSalvarLista.ImageOptions.SvgImage = global::PFC___StandBy_CSharp.Properties.Resources.save1;
            this.btnSalvarLista.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnSalvarLista.Location = new System.Drawing.Point(817, 81);
            this.btnSalvarLista.Name = "btnSalvarLista";
            this.btnSalvarLista.Size = new System.Drawing.Size(40, 31);
            this.btnSalvarLista.TabIndex = 11;
            this.btnSalvarLista.Click += new System.EventHandler(this.btnSalvarLista_Click);
            // 
            // cmbOrdemServico
            // 
            this.cmbOrdemServico.Location = new System.Drawing.Point(43, 81);
            this.cmbOrdemServico.Name = "cmbOrdemServico";
            this.cmbOrdemServico.Properties.Appearance.Options.UseTextOptions = true;
            this.cmbOrdemServico.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbOrdemServico.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbOrdemServico.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOrdemServico.Properties.DataSource = this.tb_servicosBindingSource;
            this.cmbOrdemServico.Properties.DisplayMember = "sv_ordem_serv";
            this.cmbOrdemServico.Properties.NullText = "";
            this.cmbOrdemServico.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbOrdemServico.Properties.ValueMember = "sv_ordem_serv";
            this.cmbOrdemServico.Size = new System.Drawing.Size(264, 30);
            this.cmbOrdemServico.TabIndex = 12;
            // 
            // tb_servicosBindingSource
            // 
            this.tb_servicosBindingSource.DataMember = "tb_servicos";
            this.tb_servicosBindingSource.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Principal";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression1.ColumnName = "sv_ordem_serv";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"644\" />";
            table1.Name = "tb_servicos";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "sv_aparelho";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "cl_nome";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"364\" />";
            table2.Name = "tb_clientes";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.FilterString = "[tb_servicos.sv_status] = 1";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "tb_servicos";
            relationColumnInfo1.NestedKeyColumn = "cl_id";
            relationColumnInfo1.ParentKeyColumn = "sv_cl_idcliente";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsv_ordem_serv,
            this.colsv_aparelho,
            this.colcl_nome});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colsv_ordem_serv
            // 
            this.colsv_ordem_serv.Caption = "O.S      ";
            this.colsv_ordem_serv.FieldName = "sv_ordem_serv";
            this.colsv_ordem_serv.Name = "colsv_ordem_serv";
            this.colsv_ordem_serv.Visible = true;
            this.colsv_ordem_serv.VisibleIndex = 0;
            this.colsv_ordem_serv.Width = 70;
            // 
            // colsv_aparelho
            // 
            this.colsv_aparelho.Caption = "APARELHO";
            this.colsv_aparelho.FieldName = "sv_aparelho";
            this.colsv_aparelho.Name = "colsv_aparelho";
            this.colsv_aparelho.Visible = true;
            this.colsv_aparelho.VisibleIndex = 1;
            this.colsv_aparelho.Width = 282;
            // 
            // colcl_nome
            // 
            this.colcl_nome.Caption = "NOME CLIENTE";
            this.colcl_nome.FieldName = "cl_nome";
            this.colcl_nome.Name = "colcl_nome";
            this.colcl_nome.Visible = true;
            this.colcl_nome.VisibleIndex = 2;
            this.colcl_nome.Width = 719;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "QueryCompras";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(4, 133);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(887, 330);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ID Servico";
            this.gridColumn8.FieldName = "cp_sv_id";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Compra";
            this.gridColumn1.FieldName = "cp_id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "O.S   ";
            this.gridColumn2.FieldName = "sv_ordem_serv";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 98;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "DATA";
            this.gridColumn3.FieldName = "cp_data";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 185;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CLIENTE";
            this.gridColumn4.FieldName = "cl_nome";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 277;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "PEÇA";
            this.gridColumn5.FieldName = "cp_peca_comprada";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 236;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "VALOR";
            this.gridColumn6.FieldName = "cp_valor_peca";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "FORNECEDOR";
            this.gridColumn7.FieldName = "cp_fornecedor";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 168;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoverCompra)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnRemoverCompra
            // 
            this.btnRemoverCompra.Caption = "Remover compra";
            this.btnRemoverCompra.Id = 0;
            this.btnRemoverCompra.ImageOptions.Image = global::PFC___StandBy_CSharp.Properties.Resources.cancel_16x16;
            this.btnRemoverCompra.ImageOptions.LargeImage = global::PFC___StandBy_CSharp.Properties.Resources.cancel_32x32;
            this.btnRemoverCompra.Name = "btnRemoverCompra";
            this.btnRemoverCompra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoverCompra_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRemoverCompra});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 479);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 479);
            // 
            // moverForm
            // 
            this.moverForm.Fixed = true;
            this.moverForm.Horizontal = true;
            this.moverForm.TargetControl = this;
            this.moverForm.Vertical = true;
            // 
            // moverPanel
            // 
            this.moverPanel.Fixed = true;
            this.moverPanel.Horizontal = true;
            this.moverPanel.TargetControl = this.panelTop;
            this.moverPanel.Vertical = true;
            // 
            // form_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 479);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cmbOrdemServico);
            this.Controls.Add(this.btnSalvarLista);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtPeca);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Compras";
            this.Load += new System.EventHandler(this.form_Compras_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Compras_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrdemServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelTop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPeca;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.TextEdit txtFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSalvarLista;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colsv_ordem_serv;
        private DevExpress.XtraGrid.Columns.GridColumn colsv_aparelho;
        private DevExpress.XtraGrid.Columns.GridColumn colcl_nome;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource tb_servicosBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        public DevExpress.XtraEditors.LabelControl lblIdServico;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbOrdemServico;
        public DevExpress.XtraEditors.LabelControl lblOrdemServico;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnRemoverCompra;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private Bunifu.Framework.UI.BunifuDragControl moverForm;
        private Bunifu.Framework.UI.BunifuDragControl moverPanel;
    }
}