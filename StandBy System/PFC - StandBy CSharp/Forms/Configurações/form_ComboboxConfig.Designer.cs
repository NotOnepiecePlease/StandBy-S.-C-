namespace PFC___StandBy_CSharp.Forms
{
    partial class form_ComboboxConfig
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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ComboboxConfig));
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCampo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Texto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Tela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Editavel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTela = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAdicionarRegistro = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoverRegistro = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCampo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTela.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.labelControl3);
            this.bunifuPanel1.Controls.Add(this.cmbCampo);
            this.bunifuPanel1.Controls.Add(this.labelControl2);
            this.bunifuPanel1.Controls.Add(this.cmbGrupo);
            this.bunifuPanel1.Controls.Add(this.labelControl1);
            this.bunifuPanel1.Controls.Add(this.gridControl1);
            this.bunifuPanel1.Controls.Add(this.cmbTela);
            this.bunifuPanel1.Location = new System.Drawing.Point(-3, -4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(830, 669);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(370, 169);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 25);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "CAMPO";
            // 
            // cmbCampo
            // 
            this.cmbCampo.EditValue = "teste";
            this.cmbCampo.Enabled = false;
            this.cmbCampo.Location = new System.Drawing.Point(37, 203);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.cmbCampo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampo.Properties.Appearance.Options.UseBorderColor = true;
            this.cmbCampo.Properties.Appearance.Options.UseFont = true;
            this.cmbCampo.Properties.Appearance.Options.UseTextOptions = true;
            this.cmbCampo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbCampo.Properties.AutoComplete = false;
            this.cmbCampo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmbCampo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCampo.Size = new System.Drawing.Size(754, 36);
            this.cmbCampo.TabIndex = 9;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(369, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 25);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "GRUPO";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.EditValue = "teste";
            this.cmbGrupo.Enabled = false;
            this.cmbGrupo.Location = new System.Drawing.Point(37, 128);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.cmbGrupo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupo.Properties.Appearance.Options.UseBorderColor = true;
            this.cmbGrupo.Properties.Appearance.Options.UseFont = true;
            this.cmbGrupo.Properties.Appearance.Options.UseTextOptions = true;
            this.cmbGrupo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbGrupo.Properties.AutoComplete = false;
            this.cmbGrupo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGrupo.Size = new System.Drawing.Size(754, 36);
            this.cmbGrupo.TabIndex = 7;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(380, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 25);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "TELA";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(37, 259);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 355);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id,
            this.col_Texto,
            this.col_Grupo,
            this.col_Tela,
            this.col_Nome,
            this.col_Editavel});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // col_Id
            // 
            this.col_Id.Caption = "ID";
            this.col_Id.FieldName = "item_id";
            this.col_Id.Name = "col_Id";
            // 
            // col_Texto
            // 
            this.col_Texto.Caption = "TEXTO";
            this.col_Texto.FieldName = "item_texto";
            this.col_Texto.Name = "col_Texto";
            this.col_Texto.Visible = true;
            this.col_Texto.VisibleIndex = 0;
            // 
            // col_Grupo
            // 
            this.col_Grupo.Caption = "GRUPO";
            this.col_Grupo.FieldName = "item_grupo";
            this.col_Grupo.Name = "col_Grupo";
            this.col_Grupo.OptionsColumn.AllowEdit = false;
            this.col_Grupo.OptionsColumn.AllowFocus = false;
            this.col_Grupo.OptionsColumn.ReadOnly = true;
            this.col_Grupo.Visible = true;
            this.col_Grupo.VisibleIndex = 1;
            // 
            // col_Tela
            // 
            this.col_Tela.Caption = "TELA";
            this.col_Tela.FieldName = "item_tela";
            this.col_Tela.Name = "col_Tela";
            this.col_Tela.OptionsColumn.AllowEdit = false;
            this.col_Tela.OptionsColumn.AllowFocus = false;
            this.col_Tela.OptionsColumn.ReadOnly = true;
            this.col_Tela.Visible = true;
            this.col_Tela.VisibleIndex = 2;
            // 
            // col_Nome
            // 
            this.col_Nome.Caption = "CAMPO";
            this.col_Nome.FieldName = "item_nome";
            this.col_Nome.Name = "col_Nome";
            this.col_Nome.OptionsColumn.AllowEdit = false;
            this.col_Nome.OptionsColumn.AllowFocus = false;
            this.col_Nome.OptionsColumn.ReadOnly = true;
            this.col_Nome.Visible = true;
            this.col_Nome.VisibleIndex = 3;
            // 
            // col_Editavel
            // 
            this.col_Editavel.Caption = "EDITAVEL";
            this.col_Editavel.FieldName = "item_editavel";
            this.col_Editavel.Name = "col_Editavel";
            this.col_Editavel.OptionsColumn.AllowEdit = false;
            this.col_Editavel.OptionsColumn.AllowFocus = false;
            this.col_Editavel.OptionsColumn.ReadOnly = true;
            this.col_Editavel.Visible = true;
            this.col_Editavel.VisibleIndex = 4;
            // 
            // cmbTela
            // 
            this.cmbTela.EditValue = "teste";
            this.cmbTela.Location = new System.Drawing.Point(37, 50);
            this.cmbTela.Name = "cmbTela";
            this.cmbTela.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.cmbTela.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTela.Properties.Appearance.Options.UseBorderColor = true;
            this.cmbTela.Properties.Appearance.Options.UseFont = true;
            this.cmbTela.Properties.Appearance.Options.UseTextOptions = true;
            this.cmbTela.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbTela.Properties.AutoComplete = false;
            this.cmbTela.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmbTela.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTela.Size = new System.Drawing.Size(754, 36);
            this.cmbTela.TabIndex = 3;
            this.cmbTela.SelectedIndexChanged += new System.EventHandler(this.cmbTela_SelectedIndexChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdicionarRegistro,
            this.btnRemoverRegistro});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(820, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(820, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 631);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(820, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 631);
            // 
            // btnAdicionarRegistro
            // 
            this.btnAdicionarRegistro.Caption = "Adicionar novo item";
            this.btnAdicionarRegistro.Id = 0;
            this.btnAdicionarRegistro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarRegistro.ImageOptions.Image")));
            this.btnAdicionarRegistro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarRegistro.ImageOptions.LargeImage")));
            this.btnAdicionarRegistro.Name = "btnAdicionarRegistro";
            this.btnAdicionarRegistro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdicionarRegistro_ItemClick);
            // 
            // btnRemoverRegistro
            // 
            this.btnRemoverRegistro.Caption = "Remover item";
            this.btnRemoverRegistro.Id = 1;
            this.btnRemoverRegistro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverRegistro.ImageOptions.Image")));
            this.btnRemoverRegistro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemoverRegistro.ImageOptions.LargeImage")));
            this.btnRemoverRegistro.Name = "btnRemoverRegistro";
            this.btnRemoverRegistro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoverRegistro_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdicionarRegistro),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoverRegistro)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // form_ComboboxConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 658);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_ComboboxConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Configuracao";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_ComboboxConfig_KeyDown);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCampo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTela.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTela;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCampo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Texto;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdicionarRegistro;
        private DevExpress.XtraBars.BarButtonItem btnRemoverRegistro;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Tela;
        private DevExpress.XtraGrid.Columns.GridColumn col_Grupo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nome;
        private DevExpress.XtraGrid.Columns.GridColumn col_Editavel;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id;
    }
}