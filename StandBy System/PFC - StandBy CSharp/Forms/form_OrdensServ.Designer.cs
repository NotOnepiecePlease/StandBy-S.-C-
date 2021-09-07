namespace PFC___StandBy_CSharp.Forms
{
    partial class form_OrdensServ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_OrdensServ));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSituacaoOrdens = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAcessoriosOrdens = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAcessoriosOrdens = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnInvisivel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSenhaPadrao = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSenhaOrdens = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDefeitoOrdens = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnPesquisarCliente = new FontAwesome.Sharp.IconButton();
            this.txtPesquisarCliente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCadastrarOrdem = new FontAwesome.Sharp.IconButton();
            this.lblSituacao = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDefeito = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAparelho = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCliente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAparelhoOrdens = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.table_OrdensServicos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSenhaPadrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisivel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.arredondarTabelaServ = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.arredondarComboboxCliente = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.arredondarBotaoCadastrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.arredondarBotaoPesquisarCliente = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.standbyDataSet = new PFC___StandBy_CSharp.standbyDataSet();
            this.standbyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previsao_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existe_um_prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_acessorios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_OrdensServicos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standbyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standbyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.txtSituacaoOrdens);
            this.panel1.Controls.Add(this.txtAcessoriosOrdens);
            this.panel1.Controls.Add(this.lblAcessoriosOrdens);
            this.panel1.Controls.Add(this.btnInvisivel);
            this.panel1.Controls.Add(this.btnSenhaPadrao);
            this.panel1.Controls.Add(this.txtSenhaOrdens);
            this.panel1.Controls.Add(this.txtDefeitoOrdens);
            this.panel1.Controls.Add(this.cmbClientes);
            this.panel1.Controls.Add(this.btnPesquisarCliente);
            this.panel1.Controls.Add(this.txtPesquisarCliente);
            this.panel1.Controls.Add(this.btnCadastrarOrdem);
            this.panel1.Controls.Add(this.lblSituacao);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblDefeito);
            this.panel1.Controls.Add(this.lblAparelho);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.txtAparelhoOrdens);
            this.panel1.Controls.Add(this.table_OrdensServicos);
            this.panel1.Controls.Add(this.btnVisivel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 665);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // txtSituacaoOrdens
            // 
            this.txtSituacaoOrdens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSituacaoOrdens.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSituacaoOrdens.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSituacaoOrdens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtSituacaoOrdens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSituacaoOrdens.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSituacaoOrdens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSituacaoOrdens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtSituacaoOrdens.ForeColor = System.Drawing.Color.Silver;
            this.txtSituacaoOrdens.HintForeColor = System.Drawing.Color.Transparent;
            this.txtSituacaoOrdens.HintText = "";
            this.txtSituacaoOrdens.isPassword = false;
            this.txtSituacaoOrdens.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtSituacaoOrdens.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtSituacaoOrdens.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtSituacaoOrdens.LineThickness = 2;
            this.txtSituacaoOrdens.Location = new System.Drawing.Point(4, 129);
            this.txtSituacaoOrdens.Margin = new System.Windows.Forms.Padding(4);
            this.txtSituacaoOrdens.MaxLength = 500;
            this.txtSituacaoOrdens.Name = "txtSituacaoOrdens";
            this.txtSituacaoOrdens.Size = new System.Drawing.Size(583, 34);
            this.txtSituacaoOrdens.TabIndex = 43;
            this.txtSituacaoOrdens.Text = "Situação do aparelho";
            this.txtSituacaoOrdens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSituacaoOrdens.Enter += new System.EventHandler(this.txtSituacaoOrdens_Enter);
            this.txtSituacaoOrdens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSituacaoOrdens_KeyDown);
            this.txtSituacaoOrdens.Leave += new System.EventHandler(this.txtSituacaoOrdens_Leave);
            // 
            // txtAcessoriosOrdens
            // 
            this.txtAcessoriosOrdens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcessoriosOrdens.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAcessoriosOrdens.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAcessoriosOrdens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtAcessoriosOrdens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAcessoriosOrdens.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAcessoriosOrdens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcessoriosOrdens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtAcessoriosOrdens.ForeColor = System.Drawing.Color.Silver;
            this.txtAcessoriosOrdens.HintForeColor = System.Drawing.Color.Transparent;
            this.txtAcessoriosOrdens.HintText = "";
            this.txtAcessoriosOrdens.isPassword = false;
            this.txtAcessoriosOrdens.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtAcessoriosOrdens.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtAcessoriosOrdens.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtAcessoriosOrdens.LineThickness = 2;
            this.txtAcessoriosOrdens.Location = new System.Drawing.Point(609, 129);
            this.txtAcessoriosOrdens.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcessoriosOrdens.MaxLength = 500;
            this.txtAcessoriosOrdens.Name = "txtAcessoriosOrdens";
            this.txtAcessoriosOrdens.Size = new System.Drawing.Size(406, 34);
            this.txtAcessoriosOrdens.TabIndex = 41;
            this.txtAcessoriosOrdens.Text = "Acessorios que vieram junto c/ aparelho";
            this.txtAcessoriosOrdens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAcessoriosOrdens.Enter += new System.EventHandler(this.txtAcessoriosOrdens_Enter);
            this.txtAcessoriosOrdens.Leave += new System.EventHandler(this.txtAcessoriosOrdens_Leave);
            // 
            // lblAcessoriosOrdens
            // 
            this.lblAcessoriosOrdens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcessoriosOrdens.BackColor = System.Drawing.Color.Transparent;
            this.lblAcessoriosOrdens.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAcessoriosOrdens.ForeColor = System.Drawing.Color.Lavender;
            this.lblAcessoriosOrdens.Image = global::PFC___StandBy_CSharp.Properties.Resources.electrical_20px;
            this.lblAcessoriosOrdens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcessoriosOrdens.Location = new System.Drawing.Point(755, 92);
            this.lblAcessoriosOrdens.Name = "lblAcessoriosOrdens";
            this.lblAcessoriosOrdens.Size = new System.Drawing.Size(143, 33);
            this.lblAcessoriosOrdens.TabIndex = 40;
            this.lblAcessoriosOrdens.Text = "Acessorios";
            this.lblAcessoriosOrdens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInvisivel
            // 
            this.btnInvisivel.Active = false;
            this.btnInvisivel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnInvisivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnInvisivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvisivel.BorderRadius = 0;
            this.btnInvisivel.ButtonText = "";
            this.btnInvisivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvisivel.DisabledColor = System.Drawing.Color.Gray;
            this.btnInvisivel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInvisivel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInvisivel.Iconimage")));
            this.btnInvisivel.Iconimage_right = null;
            this.btnInvisivel.Iconimage_right_Selected = null;
            this.btnInvisivel.Iconimage_Selected = null;
            this.btnInvisivel.IconMarginLeft = 0;
            this.btnInvisivel.IconMarginRight = 0;
            this.btnInvisivel.IconRightVisible = true;
            this.btnInvisivel.IconRightZoom = 0D;
            this.btnInvisivel.IconVisible = true;
            this.btnInvisivel.IconZoom = 50D;
            this.btnInvisivel.IsTab = false;
            this.btnInvisivel.Location = new System.Drawing.Point(0, 0);
            this.btnInvisivel.Name = "btnInvisivel";
            this.btnInvisivel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnInvisivel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnInvisivel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInvisivel.selected = false;
            this.btnInvisivel.Size = new System.Drawing.Size(34, 35);
            this.btnInvisivel.TabIndex = 36;
            this.btnInvisivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvisivel.Textcolor = System.Drawing.Color.White;
            this.btnInvisivel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvisivel.Click += new System.EventHandler(this.btnInvisivel_Click);
            // 
            // btnSenhaPadrao
            // 
            this.btnSenhaPadrao.AllowToggling = false;
            this.btnSenhaPadrao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSenhaPadrao.AnimationSpeed = 200;
            this.btnSenhaPadrao.AutoGenerateColors = false;
            this.btnSenhaPadrao.BackColor = System.Drawing.Color.Transparent;
            this.btnSenhaPadrao.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaPadrao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSenhaPadrao.BackgroundImage")));
            this.btnSenhaPadrao.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaPadrao.ButtonText = "Padrão";
            this.btnSenhaPadrao.ButtonTextMarginLeft = 0;
            this.btnSenhaPadrao.ColorContrastOnClick = 45;
            this.btnSenhaPadrao.ColorContrastOnHover = 45;
            this.btnSenhaPadrao.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSenhaPadrao.CustomizableEdges = borderEdges1;
            this.btnSenhaPadrao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSenhaPadrao.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSenhaPadrao.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSenhaPadrao.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSenhaPadrao.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSenhaPadrao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSenhaPadrao.ForeColor = System.Drawing.Color.White;
            this.btnSenhaPadrao.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaPadrao.IconMarginLeft = 11;
            this.btnSenhaPadrao.IconPadding = 10;
            this.btnSenhaPadrao.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaPadrao.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaPadrao.IdleBorderRadius = 3;
            this.btnSenhaPadrao.IdleBorderThickness = 1;
            this.btnSenhaPadrao.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaPadrao.IdleIconLeftImage = null;
            this.btnSenhaPadrao.IdleIconRightImage = null;
            this.btnSenhaPadrao.IndicateFocus = false;
            this.btnSenhaPadrao.Location = new System.Drawing.Point(959, 10);
            this.btnSenhaPadrao.Name = "btnSenhaPadrao";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSenhaPadrao.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSenhaPadrao.OnPressedState = stateProperties2;
            this.btnSenhaPadrao.Size = new System.Drawing.Size(56, 22);
            this.btnSenhaPadrao.TabIndex = 35;
            this.btnSenhaPadrao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSenhaPadrao.TextMarginLeft = 0;
            this.btnSenhaPadrao.UseDefaultRadiusAndThickness = true;
            this.btnSenhaPadrao.Click += new System.EventHandler(this.btnSenhaPadrao_Click);
            // 
            // txtSenhaOrdens
            // 
            this.txtSenhaOrdens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenhaOrdens.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenhaOrdens.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenhaOrdens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtSenhaOrdens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSenhaOrdens.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenhaOrdens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenhaOrdens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtSenhaOrdens.ForeColor = System.Drawing.Color.Silver;
            this.txtSenhaOrdens.HintForeColor = System.Drawing.Color.Transparent;
            this.txtSenhaOrdens.HintText = "";
            this.txtSenhaOrdens.isPassword = false;
            this.txtSenhaOrdens.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtSenhaOrdens.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtSenhaOrdens.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtSenhaOrdens.LineThickness = 2;
            this.txtSenhaOrdens.Location = new System.Drawing.Point(850, 36);
            this.txtSenhaOrdens.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaOrdens.MaxLength = 100;
            this.txtSenhaOrdens.Name = "txtSenhaOrdens";
            this.txtSenhaOrdens.Size = new System.Drawing.Size(165, 32);
            this.txtSenhaOrdens.TabIndex = 4;
            this.txtSenhaOrdens.Text = "Digite a senha do celular";
            this.txtSenhaOrdens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaOrdens.Enter += new System.EventHandler(this.txtSenhaOrdens_Enter);
            this.txtSenhaOrdens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenhaOrdens_KeyDown);
            this.txtSenhaOrdens.Leave += new System.EventHandler(this.txtSenhaOrdens_Leave);
            // 
            // txtDefeitoOrdens
            // 
            this.txtDefeitoOrdens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDefeitoOrdens.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDefeitoOrdens.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDefeitoOrdens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtDefeitoOrdens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDefeitoOrdens.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDefeitoOrdens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefeitoOrdens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtDefeitoOrdens.ForeColor = System.Drawing.Color.Silver;
            this.txtDefeitoOrdens.HintForeColor = System.Drawing.Color.Transparent;
            this.txtDefeitoOrdens.HintText = "";
            this.txtDefeitoOrdens.isPassword = false;
            this.txtDefeitoOrdens.LineFocusedColor = System.Drawing.Color.White;
            this.txtDefeitoOrdens.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtDefeitoOrdens.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtDefeitoOrdens.LineThickness = 2;
            this.txtDefeitoOrdens.Location = new System.Drawing.Point(531, 36);
            this.txtDefeitoOrdens.Margin = new System.Windows.Forms.Padding(4);
            this.txtDefeitoOrdens.MaxLength = 100;
            this.txtDefeitoOrdens.Name = "txtDefeitoOrdens";
            this.txtDefeitoOrdens.Size = new System.Drawing.Size(299, 32);
            this.txtDefeitoOrdens.TabIndex = 3;
            this.txtDefeitoOrdens.Text = "Digite o defeito";
            this.txtDefeitoOrdens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDefeitoOrdens.Enter += new System.EventHandler(this.txtDefeitoOrdens_Enter);
            this.txtDefeitoOrdens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefeitoOrdens_KeyDown);
            this.txtDefeitoOrdens.Leave += new System.EventHandler(this.txtDefeitoOrdens_Leave);
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientes.BackColor = System.Drawing.SystemColors.Control;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbClientes.ForeColor = System.Drawing.Color.Black;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(3, 36);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(275, 32);
            this.cmbClientes.TabIndex = 1;
            this.cmbClientes.Text = "Adriano Fraga de Andrade";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPesquisarCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnPesquisarCliente.IconSize = 50;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(1023, 185);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnPesquisarCliente.Rotation = 0D;
            this.btnPesquisarCliente.Size = new System.Drawing.Size(49, 45);
            this.btnPesquisarCliente.TabIndex = 0;
            this.btnPesquisarCliente.TabStop = false;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarCliente.BorderColorFocused = System.Drawing.Color.White;
            this.txtPesquisarCliente.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtPesquisarCliente.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtPesquisarCliente.BorderThickness = 2;
            this.txtPesquisarCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtPesquisarCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisarCliente.isPassword = false;
            this.txtPesquisarCliente.Location = new System.Drawing.Point(3, 185);
            this.txtPesquisarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisarCliente.MaxLength = 32767;
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(1012, 46);
            this.txtPesquisarCliente.TabIndex = 6;
            this.txtPesquisarCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            this.txtPesquisarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarCliente.Enter += new System.EventHandler(this.txtPesquisarCliente_Enter);
            this.txtPesquisarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarCliente_KeyUp);
            this.txtPesquisarCliente.Leave += new System.EventHandler(this.txtPesquisarCliente_Leave);
            // 
            // btnCadastrarOrdem
            // 
            this.btnCadastrarOrdem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarOrdem.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarOrdem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarOrdem.FlatAppearance.BorderSize = 0;
            this.btnCadastrarOrdem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarOrdem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCadastrarOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarOrdem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCadastrarOrdem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarOrdem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnCadastrarOrdem.IconSize = 50;
            this.btnCadastrarOrdem.Location = new System.Drawing.Point(1023, 117);
            this.btnCadastrarOrdem.Name = "btnCadastrarOrdem";
            this.btnCadastrarOrdem.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnCadastrarOrdem.Rotation = 0D;
            this.btnCadastrarOrdem.Size = new System.Drawing.Size(49, 45);
            this.btnCadastrarOrdem.TabIndex = 0;
            this.btnCadastrarOrdem.TabStop = false;
            this.btnCadastrarOrdem.UseVisualStyleBackColor = false;
            this.btnCadastrarOrdem.Click += new System.EventHandler(this.btnCadastrarOrdem_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSituacao.BackColor = System.Drawing.Color.Transparent;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSituacao.ForeColor = System.Drawing.Color.Lavender;
            this.lblSituacao.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_comments_20px;
            this.lblSituacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSituacao.Location = new System.Drawing.Point(145, 92);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(143, 33);
            this.lblSituacao.TabIndex = 34;
            this.lblSituacao.Text = "Situação";
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSenha.ForeColor = System.Drawing.Color.Lavender;
            this.lblSenha.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_password_20px;
            this.lblSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSenha.Location = new System.Drawing.Point(874, 5);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(114, 33);
            this.lblSenha.TabIndex = 33;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDefeito
            // 
            this.lblDefeito.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDefeito.BackColor = System.Drawing.Color.Transparent;
            this.lblDefeito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblDefeito.ForeColor = System.Drawing.Color.Lavender;
            this.lblDefeito.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_error_20px;
            this.lblDefeito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDefeito.Location = new System.Drawing.Point(619, 5);
            this.lblDefeito.Name = "lblDefeito";
            this.lblDefeito.Size = new System.Drawing.Size(127, 33);
            this.lblDefeito.TabIndex = 32;
            this.lblDefeito.Text = "Defeito";
            this.lblDefeito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAparelho
            // 
            this.lblAparelho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAparelho.BackColor = System.Drawing.Color.Transparent;
            this.lblAparelho.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAparelho.ForeColor = System.Drawing.Color.Lavender;
            this.lblAparelho.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_android_20px_3;
            this.lblAparelho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAparelho.Location = new System.Drawing.Point(347, 5);
            this.lblAparelho.Name = "lblAparelho";
            this.lblAparelho.Size = new System.Drawing.Size(133, 33);
            this.lblAparelho.TabIndex = 31;
            this.lblAparelho.Text = "Aparelho";
            this.lblAparelho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblCliente.ForeColor = System.Drawing.Color.Lavender;
            this.lblCliente.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_user_20px;
            this.lblCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCliente.Location = new System.Drawing.Point(83, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(112, 22);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAparelhoOrdens
            // 
            this.txtAparelhoOrdens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAparelhoOrdens.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAparelhoOrdens.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAparelhoOrdens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtAparelhoOrdens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAparelhoOrdens.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAparelhoOrdens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAparelhoOrdens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtAparelhoOrdens.ForeColor = System.Drawing.Color.Silver;
            this.txtAparelhoOrdens.HintForeColor = System.Drawing.Color.Transparent;
            this.txtAparelhoOrdens.HintText = "";
            this.txtAparelhoOrdens.isPassword = false;
            this.txtAparelhoOrdens.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtAparelhoOrdens.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtAparelhoOrdens.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtAparelhoOrdens.LineThickness = 2;
            this.txtAparelhoOrdens.Location = new System.Drawing.Point(300, 36);
            this.txtAparelhoOrdens.Margin = new System.Windows.Forms.Padding(5);
            this.txtAparelhoOrdens.MaxLength = 50;
            this.txtAparelhoOrdens.Name = "txtAparelhoOrdens";
            this.txtAparelhoOrdens.Size = new System.Drawing.Size(211, 32);
            this.txtAparelhoOrdens.TabIndex = 2;
            this.txtAparelhoOrdens.Text = "Modelo do aparelho";
            this.txtAparelhoOrdens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAparelhoOrdens.Enter += new System.EventHandler(this.txtAparelhoOrdens_Enter);
            this.txtAparelhoOrdens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAparelhoOrdens_KeyDown);
            this.txtAparelhoOrdens.Leave += new System.EventHandler(this.txtAparelhoOrdens_Leave);
            // 
            // table_OrdensServicos
            // 
            this.table_OrdensServicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            this.table_OrdensServicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_OrdensServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_OrdensServicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_OrdensServicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_OrdensServicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_OrdensServicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_OrdensServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_OrdensServicos.ColumnHeadersHeight = 35;
            this.table_OrdensServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_OrdensServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServico,
            this.idCliente,
            this.Data,
            this.Nome,
            this.Aparelho,
            this.Defeito,
            this.Situacao,
            this.Senha,
            this.valorServico,
            this.valorPeca,
            this.lucro,
            this.servico,
            this.previsao_entrega,
            this.existe_um_prazo,
            this.sv_acessorios});
            this.table_OrdensServicos.ContextMenuStrip = this.contextMenuStrip1;
            this.table_OrdensServicos.DoubleBuffered = true;
            this.table_OrdensServicos.EnableHeadersVisualStyles = false;
            this.table_OrdensServicos.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.table_OrdensServicos.HeaderForeColor = System.Drawing.Color.Black;
            this.table_OrdensServicos.Location = new System.Drawing.Point(3, 239);
            this.table_OrdensServicos.Name = "table_OrdensServicos";
            this.table_OrdensServicos.ReadOnly = true;
            this.table_OrdensServicos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_OrdensServicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_OrdensServicos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.table_OrdensServicos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_OrdensServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_OrdensServicos.Size = new System.Drawing.Size(1066, 407);
            this.table_OrdensServicos.TabIndex = 0;
            this.table_OrdensServicos.TabStop = false;
            this.table_OrdensServicos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.table_OrdensServicos_CellFormatting_1);
            this.table_OrdensServicos.DoubleClick += new System.EventHandler(this.table_OrdensServicos_DoubleClick);
            this.table_OrdensServicos.MouseEnter += new System.EventHandler(this.table_OrdensServicos_MouseEnter);
            this.table_OrdensServicos.MouseLeave += new System.EventHandler(this.table_OrdensServicos_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.deletarToolStripMenuItem,
            this.verSenhaPadrãoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 70);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // verSenhaPadrãoToolStripMenuItem
            // 
            this.verSenhaPadrãoToolStripMenuItem.Name = "verSenhaPadrãoToolStripMenuItem";
            this.verSenhaPadrãoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.verSenhaPadrãoToolStripMenuItem.Text = "Ver Senha Padrão";
            this.verSenhaPadrãoToolStripMenuItem.Click += new System.EventHandler(this.verSenhaPadrãoToolStripMenuItem_Click);
            // 
            // btnVisivel
            // 
            this.btnVisivel.Active = false;
            this.btnVisivel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnVisivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnVisivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisivel.BorderRadius = 0;
            this.btnVisivel.ButtonText = "";
            this.btnVisivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisivel.DisabledColor = System.Drawing.Color.Gray;
            this.btnVisivel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVisivel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVisivel.Iconimage")));
            this.btnVisivel.Iconimage_right = null;
            this.btnVisivel.Iconimage_right_Selected = null;
            this.btnVisivel.Iconimage_Selected = null;
            this.btnVisivel.IconMarginLeft = 0;
            this.btnVisivel.IconMarginRight = 0;
            this.btnVisivel.IconRightVisible = true;
            this.btnVisivel.IconRightZoom = 0D;
            this.btnVisivel.IconVisible = true;
            this.btnVisivel.IconZoom = 50D;
            this.btnVisivel.IsTab = false;
            this.btnVisivel.Location = new System.Drawing.Point(0, 0);
            this.btnVisivel.Name = "btnVisivel";
            this.btnVisivel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnVisivel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnVisivel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVisivel.selected = false;
            this.btnVisivel.Size = new System.Drawing.Size(34, 35);
            this.btnVisivel.TabIndex = 37;
            this.btnVisivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVisivel.Textcolor = System.Drawing.Color.White;
            this.btnVisivel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisivel.Visible = false;
            this.btnVisivel.Click += new System.EventHandler(this.btnVisivel_Click);
            // 
            // arredondarTabelaServ
            // 
            this.arredondarTabelaServ.ElipseRadius = 1;
            this.arredondarTabelaServ.TargetControl = this.table_OrdensServicos;
            // 
            // arredondarComboboxCliente
            // 
            this.arredondarComboboxCliente.ElipseRadius = 10;
            this.arredondarComboboxCliente.TargetControl = this.cmbClientes;
            // 
            // arredondarBotaoCadastrar
            // 
            this.arredondarBotaoCadastrar.ElipseRadius = 20;
            this.arredondarBotaoCadastrar.TargetControl = this.btnCadastrarOrdem;
            // 
            // arredondarBotaoPesquisarCliente
            // 
            this.arredondarBotaoPesquisarCliente.ElipseRadius = 20;
            this.arredondarBotaoPesquisarCliente.TargetControl = this.btnPesquisarCliente;
            // 
            // standbyDataSet
            // 
            this.standbyDataSet.DataSetName = "standbyDataSet";
            this.standbyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // standbyDataSetBindingSource
            // 
            this.standbyDataSetBindingSource.DataSource = this.standbyDataSet;
            this.standbyDataSetBindingSource.Position = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idServico
            // 
            this.idServico.DataPropertyName = "sv_id";
            this.idServico.HeaderText = "idServico";
            this.idServico.Name = "idServico";
            this.idServico.ReadOnly = true;
            this.idServico.Visible = false;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "sv_cl_idcliente";
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "sv_data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "cl_nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Aparelho
            // 
            this.Aparelho.DataPropertyName = "sv_aparelho";
            this.Aparelho.HeaderText = "Aparelho";
            this.Aparelho.Name = "Aparelho";
            this.Aparelho.ReadOnly = true;
            this.Aparelho.Width = 150;
            // 
            // Defeito
            // 
            this.Defeito.DataPropertyName = "sv_defeito";
            this.Defeito.HeaderText = "Defeito";
            this.Defeito.Name = "Defeito";
            this.Defeito.ReadOnly = true;
            this.Defeito.Width = 180;
            // 
            // Situacao
            // 
            this.Situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Situacao.DataPropertyName = "sv_situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "sv_senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Width = 60;
            // 
            // valorServico
            // 
            this.valorServico.DataPropertyName = "sv_valorservico";
            this.valorServico.HeaderText = "valorServico";
            this.valorServico.Name = "valorServico";
            this.valorServico.ReadOnly = true;
            this.valorServico.Visible = false;
            // 
            // valorPeca
            // 
            this.valorPeca.DataPropertyName = "sv_valorpeca";
            this.valorPeca.HeaderText = "valorPeca";
            this.valorPeca.Name = "valorPeca";
            this.valorPeca.ReadOnly = true;
            this.valorPeca.Visible = false;
            // 
            // lucro
            // 
            this.lucro.DataPropertyName = "sv_lucro";
            this.lucro.HeaderText = "lucro";
            this.lucro.Name = "lucro";
            this.lucro.ReadOnly = true;
            this.lucro.Visible = false;
            // 
            // servico
            // 
            this.servico.DataPropertyName = "sv_servico";
            this.servico.HeaderText = "servico";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            this.servico.Visible = false;
            // 
            // previsao_entrega
            // 
            this.previsao_entrega.DataPropertyName = "sv_previsao_entrega";
            this.previsao_entrega.HeaderText = "previsao_entrega";
            this.previsao_entrega.Name = "previsao_entrega";
            this.previsao_entrega.ReadOnly = true;
            this.previsao_entrega.Visible = false;
            // 
            // existe_um_prazo
            // 
            this.existe_um_prazo.DataPropertyName = "sv_existe_um_prazo";
            this.existe_um_prazo.HeaderText = "existe_um_prazo";
            this.existe_um_prazo.Name = "existe_um_prazo";
            this.existe_um_prazo.ReadOnly = true;
            this.existe_um_prazo.Visible = false;
            // 
            // sv_acessorios
            // 
            this.sv_acessorios.DataPropertyName = "sv_acessorios";
            this.sv_acessorios.HeaderText = "sv_acessorios";
            this.sv_acessorios.Name = "sv_acessorios";
            this.sv_acessorios.ReadOnly = true;
            this.sv_acessorios.Visible = false;
            // 
            // form_OrdensServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_OrdensServ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_OrdensServ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_OrdensServicos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.standbyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standbyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPesquisarCliente;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPesquisarCliente;
        private FontAwesome.Sharp.IconButton btnCadastrarOrdem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSenha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDefeito;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAparelho;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCliente;
        public Bunifu.Framework.UI.BunifuCustomLabel lblSituacao;
        private Bunifu.Framework.UI.BunifuElipse arredondarTabelaServ;
        private Bunifu.Framework.UI.BunifuElipse arredondarComboboxCliente;
        private Bunifu.Framework.UI.BunifuElipse arredondarBotaoCadastrar;
        private Bunifu.Framework.UI.BunifuElipse arredondarBotaoPesquisarCliente;
        public Bunifu.Framework.UI.BunifuCustomDataGrid table_OrdensServicos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private standbyDataSet standbyDataSet;
        private System.Windows.Forms.BindingSource standbyDataSetBindingSource;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAparelhoOrdens;
        public System.Windows.Forms.ComboBox cmbClientes;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDefeitoOrdens;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSenhaOrdens;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSenhaPadrao;
        private Bunifu.Framework.UI.BunifuFlatButton btnInvisivel;
        private Bunifu.Framework.UI.BunifuFlatButton btnVisivel;
        private System.Windows.Forms.ToolStripMenuItem verSenhaPadrãoToolStripMenuItem;
        public Bunifu.Framework.UI.BunifuCustomLabel lblAcessoriosOrdens;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAcessoriosOrdens;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSituacaoOrdens;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Defeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn previsao_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn existe_um_prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_acessorios;
    }
}