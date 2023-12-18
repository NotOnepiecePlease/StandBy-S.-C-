namespace PFC___StandBy_CSharp.Forms.UserControl
{
    partial class ucTelaPrincipal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTelaPrincipal));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            this.btnCelular = new DevExpress.XtraEditors.SimpleButton();
            this.gridctrlServicos = new DevExpress.XtraGrid.GridControl();
            this.dataSourceGridServicos = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridviewServicos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsv_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsv_ordem_serv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsv_data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcol_Prazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcl_nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsv_aparelho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsv_previsao_entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnEditarOrdemServicoEntrada = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoverServico = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarServico = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarOrdemServicoSaida = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarListaPeçasCompradas = new DevExpress.XtraBars.BarButtonItem();
            this.popupServicos = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCelular
            // 
            this.btnCelular.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelular.Appearance.Options.UseFont = true;
            this.btnCelular.Appearance.Options.UseTextOptions = true;
            this.btnCelular.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCelular.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCelular.ImageOptions.SvgImage")));
            this.btnCelular.Location = new System.Drawing.Point(12, 20);
            this.btnCelular.Name = "btnCelular";
            this.btnCelular.Size = new System.Drawing.Size(155, 31);
            this.btnCelular.TabIndex = 38;
            this.btnCelular.Text = "CELULAR";
            this.btnCelular.Click += new System.EventHandler(this.btnCelular_Click);
            // 
            // gridctrlServicos
            // 
            this.gridctrlServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.behaviorManager1.SetBehaviors(this.gridctrlServicos, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForControl), "C:\\StandBy_Config\\mylayout.xml", DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.Default)))});
            this.gridctrlServicos.DataMember = "Query";
            this.gridctrlServicos.DataSource = this.dataSourceGridServicos;
            this.gridctrlServicos.Location = new System.Drawing.Point(12, 63);
            this.gridctrlServicos.MainView = this.gridviewServicos;
            this.gridctrlServicos.Name = "gridctrlServicos";
            this.gridctrlServicos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridctrlServicos.Size = new System.Drawing.Size(1254, 528);
            this.gridctrlServicos.TabIndex = 37;
            this.gridctrlServicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewServicos});
            this.gridctrlServicos.DoubleClick += new System.EventHandler(this.gridctrlServicos_DoubleClick);
            // 
            // dataSourceGridServicos
            // 
            this.dataSourceGridServicos.ConnectionName = "standby_MainConn";
            this.dataSourceGridServicos.Name = "dataSourceGridServicos";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.dataSourceGridServicos.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.dataSourceGridServicos.ResultSchemaSerializable = resources.GetString("dataSourceGridServicos.ResultSchemaSerializable");
            // 
            // gridviewServicos
            // 
            this.gridviewServicos.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridviewServicos.Appearance.Row.Options.UseFont = true;
            this.gridviewServicos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridviewServicos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsv_id,
            this.colsv_ordem_serv,
            this.colsv_data,
            this.gridcol_Prazo,
            this.colcl_nome,
            this.colsv_aparelho,
            this.colsv_previsao_entrega});
            this.gridviewServicos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridviewServicos.FormatRules.Add(gridFormatRule1);
            this.gridviewServicos.GridControl = this.gridctrlServicos;
            this.gridviewServicos.Name = "gridviewServicos";
            this.gridviewServicos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridviewServicos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridviewServicos.OptionsBehavior.Editable = false;
            this.gridviewServicos.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridviewServicos.OptionsDetail.EnableMasterViewMode = false;
            this.gridviewServicos.OptionsLayout.StoreFormatRules = true;
            this.gridviewServicos.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridviewServicos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridviewServicos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridviewServicos.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridviewServicos.OptionsView.ShowIndicator = false;
            this.gridviewServicos.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridviewServicos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridcol_Prazo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridviewServicos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridviewServicos_RowCellStyle);
            this.gridviewServicos.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridviewServicos_PopupMenuShowing);
            // 
            // colsv_id
            // 
            this.colsv_id.FieldName = "sv_id";
            this.colsv_id.Name = "colsv_id";
            this.colsv_id.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // colsv_ordem_serv
            // 
            this.colsv_ordem_serv.AppearanceCell.Options.HighPriority = true;
            this.colsv_ordem_serv.AppearanceCell.Options.UseTextOptions = true;
            this.colsv_ordem_serv.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colsv_ordem_serv.Caption = "OS";
            this.colsv_ordem_serv.FieldName = "sv_ordem_serv";
            this.colsv_ordem_serv.Name = "colsv_ordem_serv";
            this.colsv_ordem_serv.UnboundDataType = typeof(int);
            this.colsv_ordem_serv.Visible = true;
            this.colsv_ordem_serv.VisibleIndex = 0;
            this.colsv_ordem_serv.Width = 200;
            // 
            // colsv_data
            // 
            this.colsv_data.Caption = "Data";
            this.colsv_data.FieldName = "sv_data";
            this.colsv_data.Name = "colsv_data";
            this.colsv_data.Visible = true;
            this.colsv_data.VisibleIndex = 1;
            this.colsv_data.Width = 203;
            // 
            // gridcol_Prazo
            // 
            this.gridcol_Prazo.Caption = "Prazo";
            this.gridcol_Prazo.FieldName = "gridcol_Prazo";
            this.gridcol_Prazo.Name = "gridcol_Prazo";
            this.gridcol_Prazo.UnboundDataType = typeof(string);
            this.gridcol_Prazo.Visible = true;
            this.gridcol_Prazo.VisibleIndex = 2;
            this.gridcol_Prazo.Width = 203;
            // 
            // colcl_nome
            // 
            this.colcl_nome.Caption = "Nome";
            this.colcl_nome.FieldName = "cl_nome";
            this.colcl_nome.Name = "colcl_nome";
            this.colcl_nome.Visible = true;
            this.colcl_nome.VisibleIndex = 3;
            this.colcl_nome.Width = 203;
            // 
            // colsv_aparelho
            // 
            this.colsv_aparelho.Caption = "Aparelho";
            this.colsv_aparelho.FieldName = "sv_aparelho";
            this.colsv_aparelho.Name = "colsv_aparelho";
            this.colsv_aparelho.Visible = true;
            this.colsv_aparelho.VisibleIndex = 4;
            this.colsv_aparelho.Width = 203;
            // 
            // colsv_previsao_entrega
            // 
            this.colsv_previsao_entrega.Caption = "Prev. Entrega";
            this.colsv_previsao_entrega.DisplayFormat.FormatString = "g";
            this.colsv_previsao_entrega.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsv_previsao_entrega.FieldName = "sv_previsao_entrega";
            this.colsv_previsao_entrega.GroupFormat.FormatString = "d";
            this.colsv_previsao_entrega.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colsv_previsao_entrega.Name = "colsv_previsao_entrega";
            this.colsv_previsao_entrega.Visible = true;
            this.colsv_previsao_entrega.VisibleIndex = 5;
            this.colsv_previsao_entrega.Width = 242;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnEditarOrdemServicoEntrada,
            this.btnRemoverServico,
            this.btnEditarServico,
            this.barButtonItem1,
            this.btnEditarOrdemServicoSaida,
            this.barButtonItem3,
            this.btnEditarListaPeçasCompradas});
            this.barManager1.MaxItemId = 9;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 610);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 610);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 610);
            // 
            // btnEditarOrdemServicoEntrada
            // 
            this.btnEditarOrdemServicoEntrada.Caption = "O.S - ENTRADA";
            this.btnEditarOrdemServicoEntrada.Id = 0;
            this.btnEditarOrdemServicoEntrada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarOrdemServicoEntrada.ImageOptions.Image")));
            this.btnEditarOrdemServicoEntrada.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditarOrdemServicoEntrada.ImageOptions.LargeImage")));
            this.btnEditarOrdemServicoEntrada.Name = "btnEditarOrdemServicoEntrada";
            this.btnEditarOrdemServicoEntrada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarOrdemServicoEntrada_ItemClick);
            // 
            // btnRemoverServico
            // 
            this.btnRemoverServico.Caption = "Remover Serviço";
            this.btnRemoverServico.Id = 1;
            this.btnRemoverServico.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverServico.ImageOptions.Image")));
            this.btnRemoverServico.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemoverServico.ImageOptions.LargeImage")));
            this.btnRemoverServico.Name = "btnRemoverServico";
            this.btnRemoverServico.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoverServico_ItemClick);
            // 
            // btnEditarServico
            // 
            this.btnEditarServico.Caption = "Editar Serviço";
            this.btnEditarServico.Id = 3;
            this.btnEditarServico.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarServico.ImageOptions.Image")));
            this.btnEditarServico.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditarServico.ImageOptions.LargeImage")));
            this.btnEditarServico.Name = "btnEditarServico";
            this.btnEditarServico.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarServico_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnEditarOrdemServicoSaida
            // 
            this.btnEditarOrdemServicoSaida.Caption = "O.S - SAIDA";
            this.btnEditarOrdemServicoSaida.Id = 6;
            this.btnEditarOrdemServicoSaida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarOrdemServicoSaida.ImageOptions.Image")));
            this.btnEditarOrdemServicoSaida.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditarOrdemServicoSaida.ImageOptions.LargeImage")));
            this.btnEditarOrdemServicoSaida.Name = "btnEditarOrdemServicoSaida";
            this.btnEditarOrdemServicoSaida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarOrdemServicoSaida_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Remover Serviço";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnEditarListaPeçasCompradas
            // 
            this.btnEditarListaPeçasCompradas.Caption = "Editar lista peças compradas";
            this.btnEditarListaPeçasCompradas.Id = 8;
            this.btnEditarListaPeçasCompradas.ImageOptions.LargeImage = global::PFC___StandBy_CSharp.Properties.Resources.pageorientationportrait_32x32;
            this.btnEditarListaPeçasCompradas.Name = "btnEditarListaPeçasCompradas";
            this.btnEditarListaPeçasCompradas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarListaPeçasCompradas_ItemClick);
            // 
            // popupServicos
            // 
            this.popupServicos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditarServico),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoverServico),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditarListaPeçasCompradas),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditarOrdemServicoEntrada, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditarOrdemServicoSaida)});
            this.popupServicos.Manager = this.barManager1;
            this.popupServicos.Name = "popupServicos";
            // 
            // ucTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCelular);
            this.Controls.Add(this.gridctrlServicos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucTelaPrincipal";
            this.Size = new System.Drawing.Size(1278, 610);
            ((System.ComponentModel.ISupportInitialize)(this.gridctrlServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCelular;
        private DevExpress.XtraGrid.GridControl gridctrlServicos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewServicos;
        private DevExpress.XtraGrid.Columns.GridColumn colsv_id;
        private DevExpress.XtraGrid.Columns.GridColumn colsv_ordem_serv;
        private DevExpress.XtraGrid.Columns.GridColumn colsv_data;
        private DevExpress.XtraGrid.Columns.GridColumn gridcol_Prazo;
        private DevExpress.XtraGrid.Columns.GridColumn colcl_nome;
        private DevExpress.XtraGrid.Columns.GridColumn colsv_aparelho;
        private DevExpress.XtraGrid.Columns.GridColumn colsv_previsao_entrega;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.DataAccess.Sql.SqlDataSource dataSourceGridServicos;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEditarOrdemServicoEntrada;
        private DevExpress.XtraBars.BarButtonItem btnRemoverServico;
        private DevExpress.XtraBars.BarButtonItem btnEditarServico;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnEditarOrdemServicoSaida;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnEditarListaPeçasCompradas;
        private DevExpress.XtraBars.PopupMenu popupServicos;
    }
}
