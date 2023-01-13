namespace PFC___StandBy_CSharp.Forms.Pagamento
{
    partial class form_Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Pagamento));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Sorting sorting1 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.bunifuSeparator5 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtServicoExecutado = new DevExpress.XtraEditors.TextEdit();
            this.bunifuSeparator6 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtLucroTotal = new DevExpress.XtraEditors.TextEdit();
            this.bunifuSeparator7 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtValorPeca = new DevExpress.XtraEditors.TextEdit();
            this.bunifuSeparator10 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtValorServico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnConcluirServicoPagamento = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpag_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpag_sv_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpag_forma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMetodosPagamento = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colpag_parcelas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpag_valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lblIdServico = new DevExpress.XtraEditors.LabelControl();
            this.btnAbrirListaCompras = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoExecutado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLucroTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPeca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorServico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodosPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrirListaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator5.BackgroundImage")));
            this.bunifuSeparator5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator5.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator5.ForeColor = System.Drawing.Color.Gray;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.Gray;
            this.bunifuSeparator5.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator5.LineThickness = 3;
            this.bunifuSeparator5.Location = new System.Drawing.Point(24, 228);
            this.bunifuSeparator5.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator5.Size = new System.Drawing.Size(453, 10);
            this.bunifuSeparator5.TabIndex = 97;
            this.bunifuSeparator5.TabStop = false;
            // 
            // txtServicoExecutado
            // 
            this.txtServicoExecutado.EditValue = "";
            this.txtServicoExecutado.Location = new System.Drawing.Point(24, 203);
            this.txtServicoExecutado.Name = "txtServicoExecutado";
            this.txtServicoExecutado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.txtServicoExecutado.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtServicoExecutado.Properties.Appearance.Options.UseBackColor = true;
            this.txtServicoExecutado.Properties.Appearance.Options.UseFont = true;
            this.txtServicoExecutado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtServicoExecutado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtServicoExecutado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtServicoExecutado.Properties.ReadOnly = true;
            this.txtServicoExecutado.Size = new System.Drawing.Size(453, 34);
            this.txtServicoExecutado.TabIndex = 96;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator6.BackgroundImage")));
            this.bunifuSeparator6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator6.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator6.ForeColor = System.Drawing.Color.Gray;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.Gray;
            this.bunifuSeparator6.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator6.LineThickness = 3;
            this.bunifuSeparator6.Location = new System.Drawing.Point(24, 174);
            this.bunifuSeparator6.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator6.Size = new System.Drawing.Size(453, 10);
            this.bunifuSeparator6.TabIndex = 95;
            this.bunifuSeparator6.TabStop = false;
            // 
            // txtLucroTotal
            // 
            this.txtLucroTotal.EditValue = "";
            this.txtLucroTotal.Location = new System.Drawing.Point(24, 148);
            this.txtLucroTotal.Name = "txtLucroTotal";
            this.txtLucroTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.txtLucroTotal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucroTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtLucroTotal.Properties.Appearance.Options.UseFont = true;
            this.txtLucroTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLucroTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLucroTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtLucroTotal.Properties.ReadOnly = true;
            this.txtLucroTotal.Size = new System.Drawing.Size(453, 34);
            this.txtLucroTotal.TabIndex = 94;
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator7.BackgroundImage")));
            this.bunifuSeparator7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator7.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator7.ForeColor = System.Drawing.Color.Gray;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.Gray;
            this.bunifuSeparator7.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator7.LineThickness = 3;
            this.bunifuSeparator7.Location = new System.Drawing.Point(24, 119);
            this.bunifuSeparator7.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator7.Size = new System.Drawing.Size(410, 10);
            this.bunifuSeparator7.TabIndex = 93;
            this.bunifuSeparator7.TabStop = false;
            // 
            // txtValorPeca
            // 
            this.txtValorPeca.EditValue = "";
            this.txtValorPeca.Location = new System.Drawing.Point(67, 93);
            this.txtValorPeca.Name = "txtValorPeca";
            this.txtValorPeca.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.txtValorPeca.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtValorPeca.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorPeca.Properties.Appearance.Options.UseFont = true;
            this.txtValorPeca.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorPeca.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtValorPeca.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtValorPeca.Properties.ReadOnly = true;
            this.txtValorPeca.Size = new System.Drawing.Size(367, 34);
            this.txtValorPeca.TabIndex = 92;
            this.txtValorPeca.TextChanged += new System.EventHandler(this.txtValorPeca_TextChanged);
            // 
            // bunifuSeparator10
            // 
            this.bunifuSeparator10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator10.BackgroundImage")));
            this.bunifuSeparator10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator10.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator10.ForeColor = System.Drawing.Color.Gray;
            this.bunifuSeparator10.LineColor = System.Drawing.Color.Gray;
            this.bunifuSeparator10.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator10.LineThickness = 3;
            this.bunifuSeparator10.Location = new System.Drawing.Point(24, 63);
            this.bunifuSeparator10.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuSeparator10.Name = "bunifuSeparator10";
            this.bunifuSeparator10.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator10.Size = new System.Drawing.Size(453, 10);
            this.bunifuSeparator10.TabIndex = 89;
            this.bunifuSeparator10.TabStop = false;
            // 
            // txtValorServico
            // 
            this.txtValorServico.EditValue = "";
            this.txtValorServico.Location = new System.Drawing.Point(24, 38);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.txtValorServico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtValorServico.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorServico.Properties.Appearance.Options.UseFont = true;
            this.txtValorServico.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorServico.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtValorServico.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtValorServico.Properties.ReadOnly = true;
            this.txtValorServico.Size = new System.Drawing.Size(453, 34);
            this.txtValorServico.TabIndex = 88;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageOptions.SvgImage = global::PFC___StandBy_CSharp.Properties.Resources.business_dollar;
            this.labelControl1.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.labelControl1.Location = new System.Drawing.Point(24, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 19);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "VALOR DO SERVIÇO:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.ImageOptions.SvgImage = global::PFC___StandBy_CSharp.Properties.Resources.card_green;
            this.labelControl2.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.labelControl2.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.labelControl2.Location = new System.Drawing.Point(24, 241);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 19);
            this.labelControl2.TabIndex = 99;
            this.labelControl2.Text = "FORMA DE PAGAMENTO:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl3.ImageOptions.SvgImage = global::PFC___StandBy_CSharp.Properties.Resources.business_dollar;
            this.labelControl3.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.labelControl3.Location = new System.Drawing.Point(24, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 19);
            this.labelControl3.TabIndex = 100;
            this.labelControl3.Text = "VALOR DA PEÇA:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl4.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl4.ImageOptions.SvgImage = global::PFC___StandBy_CSharp.Properties.Resources.business_dollar;
            this.labelControl4.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.labelControl4.Location = new System.Drawing.Point(24, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 19);
            this.labelControl4.TabIndex = 101;
            this.labelControl4.Text = "LUCRO TOTAL:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl5.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl5.ImageOptions.SvgImage = global::PFC___StandBy_CSharp.Properties.Resources.task;
            this.labelControl5.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.labelControl5.Location = new System.Drawing.Point(24, 187);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 19);
            this.labelControl5.TabIndex = 102;
            this.labelControl5.Text = "SERVIÇO EXECUTADO:";
            // 
            // btnConcluirServicoPagamento
            // 
            this.btnConcluirServicoPagamento.Location = new System.Drawing.Point(24, 539);
            this.btnConcluirServicoPagamento.Name = "btnConcluirServicoPagamento";
            this.btnConcluirServicoPagamento.Size = new System.Drawing.Size(453, 33);
            this.btnConcluirServicoPagamento.TabIndex = 103;
            this.btnConcluirServicoPagamento.Text = "Concluir Serviço";
            this.btnConcluirServicoPagamento.Click += new System.EventHandler(this.btnConcluirServicoPagamento_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseForeColor = true;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.gridControl1.Location = new System.Drawing.Point(24, 265);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbMetodosPagamento});
            this.gridControl1.Size = new System.Drawing.Size(453, 256);
            this.gridControl1.TabIndex = 104;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl1_ProcessGridKey);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpag_id,
            this.colpag_sv_id,
            this.colpag_forma,
            this.colpag_parcelas,
            this.colpag_valor});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colpag_id
            // 
            this.colpag_id.FieldName = "pag_id";
            this.colpag_id.Name = "colpag_id";
            this.colpag_id.OptionsColumn.AllowEdit = false;
            this.colpag_id.OptionsColumn.AllowFocus = false;
            // 
            // colpag_sv_id
            // 
            this.colpag_sv_id.Caption = "ID Serv";
            this.colpag_sv_id.FieldName = "pag_sv_id";
            this.colpag_sv_id.Name = "colpag_sv_id";
            this.colpag_sv_id.OptionsColumn.AllowEdit = false;
            this.colpag_sv_id.OptionsColumn.AllowFocus = false;
            // 
            // colpag_forma
            // 
            this.colpag_forma.Caption = "FORMA PAG.";
            this.colpag_forma.ColumnEdit = this.cmbMetodosPagamento;
            this.colpag_forma.FieldName = "pag_forma";
            this.colpag_forma.Name = "colpag_forma";
            this.colpag_forma.Visible = true;
            this.colpag_forma.VisibleIndex = 0;
            // 
            // cmbMetodosPagamento
            // 
            this.cmbMetodosPagamento.Appearance.Options.UseTextOptions = true;
            this.cmbMetodosPagamento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbMetodosPagamento.AutoHeight = false;
            this.cmbMetodosPagamento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMetodosPagamento.ImmediatePopup = true;
            this.cmbMetodosPagamento.Items.AddRange(new object[] {
            "CRÉDITO",
            "DÉBITO",
            "DINHEIRO",
            "PIX"});
            this.cmbMetodosPagamento.Name = "cmbMetodosPagamento";
            this.cmbMetodosPagamento.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colpag_parcelas
            // 
            this.colpag_parcelas.Caption = "x VEZES";
            this.colpag_parcelas.FieldName = "pag_parcelas";
            this.colpag_parcelas.Name = "colpag_parcelas";
            this.colpag_parcelas.Visible = true;
            this.colpag_parcelas.VisibleIndex = 1;
            // 
            // colpag_valor
            // 
            this.colpag_valor.Caption = "VALOR";
            this.colpag_valor.FieldName = "pag_valor";
            this.colpag_valor.Name = "colpag_valor";
            this.colpag_valor.OptionsColumn.AllowEdit = false;
            this.colpag_valor.OptionsColumn.AllowFocus = false;
            this.colpag_valor.OptionsColumn.ReadOnly = true;
            this.colpag_valor.Visible = true;
            this.colpag_valor.VisibleIndex = 2;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Principal";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "pag_id";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"164\" />";
            table1.Name = "tb_pagamento";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "pag_sv_id";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "pag_forma";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "pag_parcelas";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "pag_valor";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.FilterString = "[tb_pagamento.pag_sv_id] = ?IDServico";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "tb_pagamento";
            queryParameter1.Name = "IDServico";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "0";
            selectQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            columnExpression6.ColumnName = "pag_id";
            columnExpression6.Table = table1;
            sorting1.Expression = columnExpression6;
            selectQuery1.Sorting.Add(sorting1);
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // lblIdServico
            // 
            this.lblIdServico.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdServico.Appearance.Options.UseForeColor = true;
            this.lblIdServico.Location = new System.Drawing.Point(442, 578);
            this.lblIdServico.Name = "lblIdServico";
            this.lblIdServico.Size = new System.Drawing.Size(52, 16);
            this.lblIdServico.TabIndex = 105;
            this.lblIdServico.Text = "idServico";
            this.lblIdServico.Visible = false;
            // 
            // btnAbrirListaCompras
            // 
            this.btnAbrirListaCompras.Image = global::PFC___StandBy_CSharp.Properties.Resources.bill_512px;
            this.btnAbrirListaCompras.ImageActive = global::PFC___StandBy_CSharp.Properties.Resources.bill_512px_active;
            this.btnAbrirListaCompras.Location = new System.Drawing.Point(440, 91);
            this.btnAbrirListaCompras.Name = "btnAbrirListaCompras";
            this.btnAbrirListaCompras.Size = new System.Drawing.Size(37, 38);
            this.btnAbrirListaCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAbrirListaCompras.TabIndex = 106;
            this.btnAbrirListaCompras.TabStop = false;
            this.btnAbrirListaCompras.Zoom = 15;
            this.btnAbrirListaCompras.Click += new System.EventHandler(this.btnAbrirListaCompras_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(313, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(164, 16);
            this.labelControl6.TabIndex = 107;
            this.labelControl6.Text = "Valor que o cliente vai pagar";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(353, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(124, 16);
            this.labelControl7.TabIndex = 108;
            this.labelControl7.Text = "Valor total dos gastos";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(407, 134);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 16);
            this.labelControl8.TabIndex = 109;
            this.labelControl8.Text = "Lucro obtido";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(324, 187);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(153, 16);
            this.labelControl9.TabIndex = 110;
            this.labelControl9.Text = "Serviço feito para o cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.panel1.Location = new System.Drawing.Point(24, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 34);
            this.panel1.TabIndex = 111;
            // 
            // form_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(506, 592);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnAbrirListaCompras);
            this.Controls.Add(this.lblIdServico);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnConcluirServicoPagamento);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.txtServicoExecutado);
            this.Controls.Add(this.bunifuSeparator6);
            this.Controls.Add(this.txtLucroTotal);
            this.Controls.Add(this.bunifuSeparator7);
            this.Controls.Add(this.txtValorPeca);
            this.Controls.Add(this.bunifuSeparator10);
            this.Controls.Add(this.txtValorServico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Pagamento";
            this.Shown += new System.EventHandler(this.form_Pagamento_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Pagamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtServicoExecutado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLucroTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPeca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorServico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodosPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrirListaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator5;
        public DevExpress.XtraEditors.TextEdit txtServicoExecutado;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator6;
        public DevExpress.XtraEditors.TextEdit txtLucroTotal;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator7;
        public DevExpress.XtraEditors.TextEdit txtValorPeca;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator10;
        public DevExpress.XtraEditors.TextEdit txtValorServico;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnConcluirServicoPagamento;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbMetodosPagamento;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colpag_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpag_sv_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpag_forma;
        private DevExpress.XtraGrid.Columns.GridColumn colpag_parcelas;
        private DevExpress.XtraGrid.Columns.GridColumn colpag_valor;
        private System.Windows.Forms.BindingSource bindingSource1;
        public DevExpress.XtraEditors.LabelControl lblIdServico;
        private Bunifu.Framework.UI.BunifuImageButton btnAbrirListaCompras;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.Panel panel1;
    }
}