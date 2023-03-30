namespace PFC___StandBy_CSharp.Forms
{
    partial class form_CadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CadastroClientes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listboxEstados = new System.Windows.Forms.ListBox();
            this.btnLimparCampos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.listboxCidades = new System.Windows.Forms.ListBox();
            this.btnCadastrarCliente = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.separatorESTADOS = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblCidades_Carregando = new System.Windows.Forms.Label();
            this.cmbEstados = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.separatorCIDADES = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtBairro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbCidades = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.txtComplemento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEndereco = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCEP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblQuantidadeClientes = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPesquisarCADCliente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.table_Clientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelRecado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Recado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parentesco_Recado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBotaoDireitoTabela = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txtTelefoneRecado = new System.Windows.Forms.TextBox();
            this.separatorTEL_RECADO = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.separatorTEL_CLIENTE = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.separatorDATA = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtNomeRecado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomeCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtParentescoRecado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTelefonePrincipal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCpf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTelefoneRecados = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkFeminino = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.chkMasculino = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.separatorCPF = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNascimento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpDataNascimento = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.autoCompleteCidades = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.panel1.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Clientes)).BeginInit();
            this.menuBotaoDireitoTabela.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.listboxEstados);
            this.panel1.Controls.Add(this.btnLimparCampos);
            this.panel1.Controls.Add(this.listboxCidades);
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Controls.Add(this.bunifuGroupBox2);
            this.panel1.Controls.Add(this.lblQuantidadeClientes);
            this.panel1.Controls.Add(this.txtPesquisarCADCliente);
            this.panel1.Controls.Add(this.table_Clientes);
            this.panel1.Controls.Add(this.bunifuGroupBox1);
            this.panel1.Controls.Add(this.dtpDataNascimento);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 651);
            this.panel1.TabIndex = 99999;
            // 
            // listboxEstados
            // 
            this.listboxEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.listboxEstados.ForeColor = System.Drawing.Color.Silver;
            this.listboxEstados.FormattingEnabled = true;
            this.listboxEstados.ItemHeight = 20;
            this.listboxEstados.Items.AddRange(new object[] {
            "BA",
            "AC",
            "AL",
            "AP",
            "AM",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.listboxEstados.Location = new System.Drawing.Point(12, 201);
            this.listboxEstados.Name = "listboxEstados";
            this.listboxEstados.Size = new System.Drawing.Size(120, 104);
            this.listboxEstados.TabIndex = 100001;
            this.listboxEstados.TabStop = false;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.AllowAnimations = true;
            this.btnLimparCampos.AllowMouseEffects = true;
            this.btnLimparCampos.AllowToggling = false;
            this.btnLimparCampos.AnimationSpeed = 200;
            this.btnLimparCampos.AutoGenerateColors = false;
            this.btnLimparCampos.AutoRoundBorders = false;
            this.btnLimparCampos.AutoSizeLeftIcon = true;
            this.btnLimparCampos.AutoSizeRightIcon = true;
            this.btnLimparCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparCampos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnLimparCampos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparCampos.BackgroundImage")));
            this.btnLimparCampos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimparCampos.ButtonText = "Limpar";
            this.btnLimparCampos.ButtonTextMarginLeft = 0;
            this.btnLimparCampos.ColorContrastOnClick = 45;
            this.btnLimparCampos.ColorContrastOnHover = 45;
            this.btnLimparCampos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLimparCampos.CustomizableEdges = borderEdges1;
            this.btnLimparCampos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimparCampos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLimparCampos.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLimparCampos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLimparCampos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimparCampos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLimparCampos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLimparCampos.IconMarginLeft = 11;
            this.btnLimparCampos.IconPadding = 10;
            this.btnLimparCampos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCampos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLimparCampos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLimparCampos.IconSize = 25;
            this.btnLimparCampos.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnLimparCampos.IdleBorderRadius = 1;
            this.btnLimparCampos.IdleBorderThickness = 1;
            this.btnLimparCampos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnLimparCampos.IdleIconLeftImage = null;
            this.btnLimparCampos.IdleIconRightImage = null;
            this.btnLimparCampos.IndicateFocus = false;
            this.btnLimparCampos.Location = new System.Drawing.Point(1008, 302);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLimparCampos.OnDisabledState.BorderRadius = 1;
            this.btnLimparCampos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimparCampos.OnDisabledState.BorderThickness = 1;
            this.btnLimparCampos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLimparCampos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLimparCampos.OnDisabledState.IconLeftImage = null;
            this.btnLimparCampos.OnDisabledState.IconRightImage = null;
            this.btnLimparCampos.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btnLimparCampos.onHoverState.BorderRadius = 1;
            this.btnLimparCampos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimparCampos.onHoverState.BorderThickness = 1;
            this.btnLimparCampos.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btnLimparCampos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLimparCampos.onHoverState.IconLeftImage = null;
            this.btnLimparCampos.onHoverState.IconRightImage = null;
            this.btnLimparCampos.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnLimparCampos.OnIdleState.BorderRadius = 1;
            this.btnLimparCampos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimparCampos.OnIdleState.BorderThickness = 1;
            this.btnLimparCampos.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnLimparCampos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLimparCampos.OnIdleState.IconLeftImage = null;
            this.btnLimparCampos.OnIdleState.IconRightImage = null;
            this.btnLimparCampos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnLimparCampos.OnPressedState.BorderRadius = 1;
            this.btnLimparCampos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLimparCampos.OnPressedState.BorderThickness = 1;
            this.btnLimparCampos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnLimparCampos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLimparCampos.OnPressedState.IconLeftImage = null;
            this.btnLimparCampos.OnPressedState.IconRightImage = null;
            this.btnLimparCampos.Size = new System.Drawing.Size(90, 32);
            this.btnLimparCampos.TabIndex = 100000;
            this.btnLimparCampos.TabStop = false;
            this.btnLimparCampos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimparCampos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimparCampos.TextMarginLeft = 0;
            this.btnLimparCampos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLimparCampos.UseDefaultRadiusAndThickness = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // listboxCidades
            // 
            this.listboxCidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.listboxCidades.ForeColor = System.Drawing.Color.Silver;
            this.listboxCidades.FormattingEnabled = true;
            this.listboxCidades.ItemHeight = 20;
            this.listboxCidades.Location = new System.Drawing.Point(12, 91);
            this.listboxCidades.Name = "listboxCidades";
            this.listboxCidades.Size = new System.Drawing.Size(120, 104);
            this.listboxCidades.TabIndex = 1003;
            this.listboxCidades.TabStop = false;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.AllowAnimations = true;
            this.btnCadastrarCliente.AllowMouseEffects = true;
            this.btnCadastrarCliente.AllowToggling = false;
            this.btnCadastrarCliente.AnimationSpeed = 200;
            this.btnCadastrarCliente.AutoGenerateColors = false;
            this.btnCadastrarCliente.AutoRoundBorders = false;
            this.btnCadastrarCliente.AutoSizeLeftIcon = true;
            this.btnCadastrarCliente.AutoSizeRightIcon = true;
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCliente.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCliente.BackgroundImage")));
            this.btnCadastrarCliente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarCliente.ButtonText = "Inserir Cliente";
            this.btnCadastrarCliente.ButtonTextMarginLeft = 0;
            this.btnCadastrarCliente.ColorContrastOnClick = 45;
            this.btnCadastrarCliente.ColorContrastOnHover = 45;
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCadastrarCliente.CustomizableEdges = borderEdges2;
            this.btnCadastrarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCadastrarCliente.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCadastrarCliente.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCadastrarCliente.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCadastrarCliente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarCliente.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarCliente.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCadastrarCliente.IconMarginLeft = 11;
            this.btnCadastrarCliente.IconPadding = 10;
            this.btnCadastrarCliente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarCliente.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarCliente.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCadastrarCliente.IconSize = 25;
            this.btnCadastrarCliente.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.IdleBorderRadius = 1;
            this.btnCadastrarCliente.IdleBorderThickness = 1;
            this.btnCadastrarCliente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.IdleIconLeftImage = null;
            this.btnCadastrarCliente.IdleIconRightImage = null;
            this.btnCadastrarCliente.IndicateFocus = false;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(912, 302);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCadastrarCliente.OnDisabledState.BorderRadius = 1;
            this.btnCadastrarCliente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarCliente.OnDisabledState.BorderThickness = 1;
            this.btnCadastrarCliente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCadastrarCliente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCadastrarCliente.OnDisabledState.IconLeftImage = null;
            this.btnCadastrarCliente.OnDisabledState.IconRightImage = null;
            this.btnCadastrarCliente.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.btnCadastrarCliente.onHoverState.BorderRadius = 1;
            this.btnCadastrarCliente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarCliente.onHoverState.BorderThickness = 1;
            this.btnCadastrarCliente.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btnCadastrarCliente.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.onHoverState.IconLeftImage = null;
            this.btnCadastrarCliente.onHoverState.IconRightImage = null;
            this.btnCadastrarCliente.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.OnIdleState.BorderRadius = 1;
            this.btnCadastrarCliente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarCliente.OnIdleState.BorderThickness = 1;
            this.btnCadastrarCliente.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.OnIdleState.IconLeftImage = null;
            this.btnCadastrarCliente.OnIdleState.IconRightImage = null;
            this.btnCadastrarCliente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.OnPressedState.BorderRadius = 1;
            this.btnCadastrarCliente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarCliente.OnPressedState.BorderThickness = 1;
            this.btnCadastrarCliente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.OnPressedState.IconLeftImage = null;
            this.btnCadastrarCliente.OnPressedState.IconRightImage = null;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(90, 32);
            this.btnCadastrarCliente.TabIndex = 16;
            this.btnCadastrarCliente.TabStop = false;
            this.btnCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrarCliente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCadastrarCliente.TextMarginLeft = 0;
            this.btnCadastrarCliente.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCadastrarCliente.UseDefaultRadiusAndThickness = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BorderColor = System.Drawing.SystemColors.Control;
            this.bunifuGroupBox2.BorderRadius = 1;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.separatorESTADOS);
            this.bunifuGroupBox2.Controls.Add(this.lblCidades_Carregando);
            this.bunifuGroupBox2.Controls.Add(this.cmbEstados);
            this.bunifuGroupBox2.Controls.Add(this.separatorCIDADES);
            this.bunifuGroupBox2.Controls.Add(this.txtBairro);
            this.bunifuGroupBox2.Controls.Add(this.cmbCidades);
            this.bunifuGroupBox2.Controls.Add(this.txtComplemento);
            this.bunifuGroupBox2.Controls.Add(this.txtEndereco);
            this.bunifuGroupBox2.Controls.Add(this.txtCEP);
            this.bunifuGroupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuGroupBox2.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuGroupBox2.Controls.Add(this.bunifuCustomLabel10);
            this.bunifuGroupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGroupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGroupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(183, 186);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(915, 105);
            this.bunifuGroupBox2.TabIndex = 99999;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "Endereço";
            // 
            // separatorESTADOS
            // 
            this.separatorESTADOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separatorESTADOS.BackColor = System.Drawing.Color.Transparent;
            this.separatorESTADOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorESTADOS.BackgroundImage")));
            this.separatorESTADOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorESTADOS.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separatorESTADOS.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.separatorESTADOS.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorESTADOS.LineThickness = 2;
            this.separatorESTADOS.Location = new System.Drawing.Point(734, 82);
            this.separatorESTADOS.Margin = new System.Windows.Forms.Padding(2);
            this.separatorESTADOS.Name = "separatorESTADOS";
            this.separatorESTADOS.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorESTADOS.Size = new System.Drawing.Size(149, 10);
            this.separatorESTADOS.TabIndex = 100000;
            this.separatorESTADOS.TabStop = false;
            // 
            // lblCidades_Carregando
            // 
            this.lblCidades_Carregando.AutoSize = true;
            this.lblCidades_Carregando.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblCidades_Carregando.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblCidades_Carregando.Location = new System.Drawing.Point(396, 66);
            this.lblCidades_Carregando.Name = "lblCidades_Carregando";
            this.lblCidades_Carregando.Size = new System.Drawing.Size(151, 20);
            this.lblCidades_Carregando.TabIndex = 1002;
            this.lblCidades_Carregando.Text = "Carregando cidades...";
            // 
            // cmbEstados
            // 
            this.cmbEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbEstados.BeforeTouchSize = new System.Drawing.Size(154, 24);
            this.cmbEstados.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbEstados.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cmbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.cmbEstados.ForeColor = System.Drawing.Color.Silver;
            this.cmbEstados.ListControl = this.listboxEstados;
            this.cmbEstados.Location = new System.Drawing.Point(729, 62);
            this.cmbEstados.MetroBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(154, 24);
            this.cmbEstados.TabIndex = 100000;
            this.cmbEstados.Text = "Ex: BA";
            this.cmbEstados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbEstados.Enter += new System.EventHandler(this.cmbEstados_Enter);
            this.cmbEstados.Leave += new System.EventHandler(this.cmbEstados_Leave);
            // 
            // separatorCIDADES
            // 
            this.separatorCIDADES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separatorCIDADES.BackColor = System.Drawing.Color.Transparent;
            this.separatorCIDADES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorCIDADES.BackgroundImage")));
            this.separatorCIDADES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorCIDADES.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separatorCIDADES.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.separatorCIDADES.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorCIDADES.LineThickness = 2;
            this.separatorCIDADES.Location = new System.Drawing.Point(353, 84);
            this.separatorCIDADES.Margin = new System.Windows.Forms.Padding(2);
            this.separatorCIDADES.Name = "separatorCIDADES";
            this.separatorCIDADES.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorCIDADES.Size = new System.Drawing.Size(234, 12);
            this.separatorCIDADES.TabIndex = 83;
            this.separatorCIDADES.TabStop = false;
            this.separatorCIDADES.MouseEnter += new System.EventHandler(this.separatorCIDADES_MouseEnter);
            this.separatorCIDADES.MouseLeave += new System.EventHandler(this.separatorCIDADES_MouseLeave);
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBairro.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtBairro.ForeColor = System.Drawing.Color.Silver;
            this.txtBairro.HintForeColor = System.Drawing.Color.Transparent;
            this.txtBairro.HintText = "";
            this.txtBairro.isPassword = false;
            this.txtBairro.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtBairro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtBairro.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtBairro.LineThickness = 2;
            this.txtBairro.Location = new System.Drawing.Point(91, 57);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(150, 34);
            this.txtBairro.TabIndex = 13;
            this.txtBairro.Text = "Ex: Gleba B";
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            this.txtBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // cmbCidades
            // 
            this.cmbCidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbCidades.BeforeTouchSize = new System.Drawing.Size(231, 24);
            this.cmbCidades.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbCidades.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cmbCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.cmbCidades.ForeColor = System.Drawing.Color.Silver;
            this.cmbCidades.ListControl = this.listboxCidades;
            this.cmbCidades.Location = new System.Drawing.Point(356, 62);
            this.cmbCidades.MetroBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbCidades.Name = "cmbCidades";
            this.cmbCidades.Size = new System.Drawing.Size(231, 24);
            this.cmbCidades.TabIndex = 14;
            this.cmbCidades.Text = "Ex: Camaçari";
            this.cmbCidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cmbCidades.Enter += new System.EventHandler(this.cmbCidades_Enter);
            this.cmbCidades.Leave += new System.EventHandler(this.cmbCidades_Leave);
            this.cmbCidades.MouseEnter += new System.EventHandler(this.cmbCidades_MouseEnter);
            this.cmbCidades.MouseLeave += new System.EventHandler(this.cmbCidades_MouseLeave);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtComplemento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtComplemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtComplemento.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtComplemento.ForeColor = System.Drawing.Color.Silver;
            this.txtComplemento.HintForeColor = System.Drawing.Color.Transparent;
            this.txtComplemento.HintText = "";
            this.txtComplemento.isPassword = false;
            this.txtComplemento.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtComplemento.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtComplemento.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtComplemento.LineThickness = 2;
            this.txtComplemento.Location = new System.Drawing.Point(734, 15);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(149, 34);
            this.txtComplemento.TabIndex = 12;
            this.txtComplemento.Text = "Ex: Casa";
            this.txtComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComplemento.Enter += new System.EventHandler(this.txtComplemento_Enter);
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtComplemento.Leave += new System.EventHandler(this.txtComplemento_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEndereco.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtEndereco.HintForeColor = System.Drawing.Color.Transparent;
            this.txtEndereco.HintText = "";
            this.txtEndereco.isPassword = false;
            this.txtEndereco.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtEndereco.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtEndereco.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtEndereco.LineThickness = 2;
            this.txtEndereco.Location = new System.Drawing.Point(353, 15);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(234, 34);
            this.txtEndereco.TabIndex = 11;
            this.txtEndereco.Text = "Ex: Rua Segundo Cendes, 197B";
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndereco.Enter += new System.EventHandler(this.txtRua_Enter);
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtEndereco.Leave += new System.EventHandler(this.txtRua_Leave);
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCEP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCEP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCEP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtCEP.ForeColor = System.Drawing.Color.Silver;
            this.txtCEP.HintForeColor = System.Drawing.Color.Transparent;
            this.txtCEP.HintText = "";
            this.txtCEP.isPassword = false;
            this.txtCEP.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtCEP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtCEP.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtCEP.LineThickness = 2;
            this.txtCEP.Location = new System.Drawing.Point(91, 15);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEP.MaxLength = 100;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(150, 34);
            this.txtCEP.TabIndex = 10;
            this.txtCEP.Text = "Ex: 42803317";
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Enter);
            this.txtCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel8.Image = global::PFC___StandBy_CSharp.Properties.Resources.skyscrapers_20px;
            this.bunifuCustomLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(615, 70);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(97, 25);
            this.bunifuCustomLabel8.TabIndex = 99999;
            this.bunifuCustomLabel8.Text = "Estado";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel9.Image = global::PFC___StandBy_CSharp.Properties.Resources.city_20px;
            this.bunifuCustomLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(268, 71);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(99, 25);
            this.bunifuCustomLabel9.TabIndex = 99999;
            this.bunifuCustomLabel9.Text = "Cidade";
            this.bunifuCustomLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel10.Image = global::PFC___StandBy_CSharp.Properties.Resources.residence_20px;
            this.bunifuCustomLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(19, 70);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(87, 25);
            this.bunifuCustomLabel10.TabIndex = 99999;
            this.bunifuCustomLabel10.Text = "Bairro";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel7.Image = global::PFC___StandBy_CSharp.Properties.Resources.map_pin_20px;
            this.bunifuCustomLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(610, 28);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(142, 25);
            this.bunifuCustomLabel7.TabIndex = 99999;
            this.bunifuCustomLabel7.Text = "Complemento";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel4.Image = global::PFC___StandBy_CSharp.Properties.Resources.road_20px;
            this.bunifuCustomLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(268, 27);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel4.TabIndex = 99999;
            this.bunifuCustomLabel4.Text = "Rua";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel2.Image = global::PFC___StandBy_CSharp.Properties.Resources.address_20px;
            this.bunifuCustomLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 28);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(74, 25);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "CEP";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantidadeClientes
            // 
            this.lblQuantidadeClientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantidadeClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuantidadeClientes.ForeColor = System.Drawing.Color.Lavender;
            this.lblQuantidadeClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuantidadeClientes.Location = new System.Drawing.Point(1186, 307);
            this.lblQuantidadeClientes.Name = "lblQuantidadeClientes";
            this.lblQuantidadeClientes.Size = new System.Drawing.Size(47, 25);
            this.lblQuantidadeClientes.TabIndex = 61;
            this.lblQuantidadeClientes.Text = "800";
            this.lblQuantidadeClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPesquisarCADCliente
            // 
            this.txtPesquisarCADCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisarCADCliente.BorderColorFocused = System.Drawing.Color.White;
            this.txtPesquisarCADCliente.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtPesquisarCADCliente.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtPesquisarCADCliente.BorderThickness = 2;
            this.txtPesquisarCADCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisarCADCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarCADCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtPesquisarCADCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisarCADCliente.isPassword = false;
            this.txtPesquisarCADCliente.Location = new System.Drawing.Point(183, 302);
            this.txtPesquisarCADCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisarCADCliente.MaxLength = 32767;
            this.txtPesquisarCADCliente.Name = "txtPesquisarCADCliente";
            this.txtPesquisarCADCliente.Size = new System.Drawing.Size(722, 32);
            this.txtPesquisarCADCliente.TabIndex = 999;
            this.txtPesquisarCADCliente.TabStop = false;
            this.txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            this.txtPesquisarCADCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarCADCliente.Enter += new System.EventHandler(this.txtPesquisarCADCliente_Enter);
            this.txtPesquisarCADCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarCADCliente_KeyUp);
            this.txtPesquisarCADCliente.Leave += new System.EventHandler(this.txtPesquisarCADCliente_Leave);
            // 
            // table_Clientes
            // 
            this.table_Clientes.AllowUserToAddRows = false;
            this.table_Clientes.AllowUserToDeleteRows = false;
            this.table_Clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_Clientes.ColumnHeadersHeight = 35;
            this.table_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id,
            this.Nome,
            this.Telefone,
            this.TelRecado,
            this.CPF,
            this.Nome_Recado,
            this.Parentesco_Recado,
            this.Sexo,
            this.Data_Nascimento,
            this.CEP,
            this.Endereco,
            this.Complemento,
            this.Bairro,
            this.Cidade,
            this.Estado});
            this.table_Clientes.ContextMenuStrip = this.menuBotaoDireitoTabela;
            this.table_Clientes.DoubleBuffered = true;
            this.table_Clientes.EnableHeadersVisualStyles = false;
            this.table_Clientes.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.table_Clientes.HeaderForeColor = System.Drawing.Color.Black;
            this.table_Clientes.Location = new System.Drawing.Point(53, 346);
            this.table_Clientes.Name = "table_Clientes";
            this.table_Clientes.ReadOnly = true;
            this.table_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_Clientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.table_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Clientes.Size = new System.Drawing.Size(1173, 283);
            this.table_Clientes.TabIndex = 0;
            this.table_Clientes.TabStop = false;
            this.table_Clientes.DoubleClick += new System.EventHandler(this.table_Clientes_DoubleClick);
            // 
            // cl_id
            // 
            this.cl_id.DataPropertyName = "cl_id";
            this.cl_id.HeaderText = "cl_id";
            this.cl_id.Name = "cl_id";
            this.cl_id.ReadOnly = true;
            this.cl_id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "cl_nome";
            this.Nome.FillWeight = 141.1765F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "cl_telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 110;
            // 
            // TelRecado
            // 
            this.TelRecado.DataPropertyName = "cl_telefone_recado";
            this.TelRecado.HeaderText = "Tel. Recado";
            this.TelRecado.Name = "TelRecado";
            this.TelRecado.ReadOnly = true;
            this.TelRecado.Width = 110;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cl_cpf";
            this.CPF.FillWeight = 58.82353F;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 130;
            // 
            // Nome_Recado
            // 
            this.Nome_Recado.DataPropertyName = "cl_nome_recado";
            this.Nome_Recado.HeaderText = "Nome R.";
            this.Nome_Recado.Name = "Nome_Recado";
            this.Nome_Recado.ReadOnly = true;
            this.Nome_Recado.Visible = false;
            // 
            // Parentesco_Recado
            // 
            this.Parentesco_Recado.DataPropertyName = "cl_parentesco_recado";
            this.Parentesco_Recado.HeaderText = "Parentesco";
            this.Parentesco_Recado.Name = "Parentesco_Recado";
            this.Parentesco_Recado.ReadOnly = true;
            this.Parentesco_Recado.Visible = false;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "cl_sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 50;
            // 
            // Data_Nascimento
            // 
            this.Data_Nascimento.DataPropertyName = "cl_data_nascimento";
            this.Data_Nascimento.HeaderText = "Data Nasc.";
            this.Data_Nascimento.Name = "Data_Nascimento";
            this.Data_Nascimento.ReadOnly = true;
            this.Data_Nascimento.Visible = false;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "cl_cep";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Width = 80;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "cl_endereco";
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 170;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "cl_complemento";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            this.Complemento.Visible = false;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "cl_bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "cl_cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "cl_estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // menuBotaoDireitoTabela
            // 
            this.menuBotaoDireitoTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.menuBotaoDireitoTabela.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuBotaoDireitoTabela.Name = "contextMenuStrip1";
            this.menuBotaoDireitoTabela.ShowImageMargin = false;
            this.menuBotaoDireitoTabela.Size = new System.Drawing.Size(85, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.SystemColors.Control;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.txtTelefoneRecado);
            this.bunifuGroupBox1.Controls.Add(this.separatorTEL_RECADO);
            this.bunifuGroupBox1.Controls.Add(this.txtTelefoneCliente);
            this.bunifuGroupBox1.Controls.Add(this.separatorTEL_CLIENTE);
            this.bunifuGroupBox1.Controls.Add(this.txtDataNascimento);
            this.bunifuGroupBox1.Controls.Add(this.separatorDATA);
            this.bunifuGroupBox1.Controls.Add(this.txtNomeRecado);
            this.bunifuGroupBox1.Controls.Add(this.txtNomeCliente);
            this.bunifuGroupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGroupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGroupBox1.Controls.Add(this.txtParentescoRecado);
            this.bunifuGroupBox1.Controls.Add(this.lblTelefonePrincipal);
            this.bunifuGroupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGroupBox1.Controls.Add(this.lblCpf);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel2);
            this.bunifuGroupBox1.Controls.Add(this.lblTelefoneRecados);
            this.bunifuGroupBox1.Controls.Add(this.chkFeminino);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox1.Controls.Add(this.txtCPFCliente);
            this.bunifuGroupBox1.Controls.Add(this.chkMasculino);
            this.bunifuGroupBox1.Controls.Add(this.separatorCPF);
            this.bunifuGroupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGroupBox1.Controls.Add(this.lblNascimento);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(183, 3);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(915, 177);
            this.bunifuGroupBox1.TabIndex = 99999;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Informações Pessoais";
            // 
            // txtTelefoneRecado
            // 
            this.txtTelefoneRecado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefoneRecado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTelefoneRecado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefoneRecado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTelefoneRecado.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefoneRecado.Location = new System.Drawing.Point(614, 56);
            this.txtTelefoneRecado.MaxLength = 15;
            this.txtTelefoneRecado.Name = "txtTelefoneRecado";
            this.txtTelefoneRecado.Size = new System.Drawing.Size(264, 16);
            this.txtTelefoneRecado.TabIndex = 7;
            this.txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            this.txtTelefoneRecado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefoneRecado.Enter += new System.EventHandler(this.txtTelefoneRecado_Enter);
            this.txtTelefoneRecado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtTelefoneRecado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneRecado_KeyPress);
            this.txtTelefoneRecado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTelefoneRecado_KeyUp);
            this.txtTelefoneRecado.Leave += new System.EventHandler(this.txtTelefoneRecado_Leave);
            // 
            // separatorTEL_RECADO
            // 
            this.separatorTEL_RECADO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separatorTEL_RECADO.BackColor = System.Drawing.Color.Transparent;
            this.separatorTEL_RECADO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorTEL_RECADO.BackgroundImage")));
            this.separatorTEL_RECADO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorTEL_RECADO.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separatorTEL_RECADO.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.separatorTEL_RECADO.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorTEL_RECADO.LineThickness = 2;
            this.separatorTEL_RECADO.Location = new System.Drawing.Point(619, 72);
            this.separatorTEL_RECADO.Margin = new System.Windows.Forms.Padding(2);
            this.separatorTEL_RECADO.Name = "separatorTEL_RECADO";
            this.separatorTEL_RECADO.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorTEL_RECADO.Size = new System.Drawing.Size(264, 14);
            this.separatorTEL_RECADO.TabIndex = 82;
            this.separatorTEL_RECADO.TabStop = false;
            this.separatorTEL_RECADO.MouseEnter += new System.EventHandler(this.separatorTEL_RECADO_MouseEnter);
            this.separatorTEL_RECADO.MouseLeave += new System.EventHandler(this.separatorTEL_RECADO_MouseLeave);
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefoneCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTelefoneCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTelefoneCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefoneCliente.Location = new System.Drawing.Point(619, 22);
            this.txtTelefoneCliente.MaxLength = 15;
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(264, 16);
            this.txtTelefoneCliente.TabIndex = 6;
            this.txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            this.txtTelefoneCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefoneCliente.Enter += new System.EventHandler(this.txtTelefoneCliente_Enter);
            this.txtTelefoneCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtTelefoneCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneCliente_KeyPress);
            this.txtTelefoneCliente.Leave += new System.EventHandler(this.txtTelefoneCliente_Leave);
            // 
            // separatorTEL_CLIENTE
            // 
            this.separatorTEL_CLIENTE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separatorTEL_CLIENTE.BackColor = System.Drawing.Color.Transparent;
            this.separatorTEL_CLIENTE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorTEL_CLIENTE.BackgroundImage")));
            this.separatorTEL_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorTEL_CLIENTE.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separatorTEL_CLIENTE.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.separatorTEL_CLIENTE.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorTEL_CLIENTE.LineThickness = 2;
            this.separatorTEL_CLIENTE.Location = new System.Drawing.Point(619, 40);
            this.separatorTEL_CLIENTE.Margin = new System.Windows.Forms.Padding(2);
            this.separatorTEL_CLIENTE.Name = "separatorTEL_CLIENTE";
            this.separatorTEL_CLIENTE.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorTEL_CLIENTE.Size = new System.Drawing.Size(264, 12);
            this.separatorTEL_CLIENTE.TabIndex = 80;
            this.separatorTEL_CLIENTE.TabStop = false;
            this.separatorTEL_CLIENTE.MouseEnter += new System.EventHandler(this.separatorTEL_CLIENTE_MouseEnter);
            this.separatorTEL_CLIENTE.MouseLeave += new System.EventHandler(this.separatorTEL_CLIENTE_MouseLeave);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtDataNascimento.ForeColor = System.Drawing.Color.Silver;
            this.txtDataNascimento.Location = new System.Drawing.Point(153, 88);
            this.txtDataNascimento.MaxLength = 10;
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(264, 16);
            this.txtDataNascimento.TabIndex = 3;
            this.txtDataNascimento.Text = "Data de Nascimento";
            this.txtDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataNascimento.Enter += new System.EventHandler(this.txtDataNascimento_Enter);
            this.txtDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtDataNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataNascimento_KeyPress);
            this.txtDataNascimento.Leave += new System.EventHandler(this.txtDataNascimento_Leave);
            // 
            // separatorDATA
            // 
            this.separatorDATA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separatorDATA.BackColor = System.Drawing.Color.Transparent;
            this.separatorDATA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorDATA.BackgroundImage")));
            this.separatorDATA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorDATA.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separatorDATA.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.separatorDATA.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorDATA.LineThickness = 2;
            this.separatorDATA.Location = new System.Drawing.Point(153, 102);
            this.separatorDATA.Margin = new System.Windows.Forms.Padding(2);
            this.separatorDATA.Name = "separatorDATA";
            this.separatorDATA.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorDATA.Size = new System.Drawing.Size(264, 12);
            this.separatorDATA.TabIndex = 78;
            this.separatorDATA.TabStop = false;
            this.separatorDATA.MouseEnter += new System.EventHandler(this.separatorDATA_MouseEnter);
            this.separatorDATA.MouseLeave += new System.EventHandler(this.separatorDATA_MouseLeave);
            // 
            // txtNomeRecado
            // 
            this.txtNomeRecado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeRecado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeRecado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeRecado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNomeRecado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeRecado.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeRecado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeRecado.Enabled = false;
            this.txtNomeRecado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtNomeRecado.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeRecado.HintForeColor = System.Drawing.Color.Transparent;
            this.txtNomeRecado.HintText = "";
            this.txtNomeRecado.isPassword = false;
            this.txtNomeRecado.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtNomeRecado.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtNomeRecado.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtNomeRecado.LineThickness = 2;
            this.txtNomeRecado.Location = new System.Drawing.Point(619, 115);
            this.txtNomeRecado.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeRecado.MaxLength = 100;
            this.txtNomeRecado.Name = "txtNomeRecado";
            this.txtNomeRecado.Size = new System.Drawing.Size(264, 32);
            this.txtNomeRecado.TabIndex = 9;
            this.txtNomeRecado.Text = "Nome de quem vai receber o recado";
            this.txtNomeRecado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeRecado.Enter += new System.EventHandler(this.txtNomeRecado_Enter);
            this.txtNomeRecado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtNomeRecado.Leave += new System.EventHandler(this.txtNomeRecado_Leave);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNomeCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeCliente.HintForeColor = System.Drawing.Color.Transparent;
            this.txtNomeCliente.HintText = "";
            this.txtNomeCliente.isPassword = false;
            this.txtNomeCliente.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtNomeCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtNomeCliente.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtNomeCliente.LineThickness = 2;
            this.txtNomeCliente.Location = new System.Drawing.Point(153, 18);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(264, 32);
            this.txtNomeCliente.TabIndex = 0;
            this.txtNomeCliente.Text = "Nome do Cliente";
            this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCliente.Enter += new System.EventHandler(this.txtNomeCliente_Enter);
            this.txtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtNomeCliente.Leave += new System.EventHandler(this.txtNomeCliente_Leave);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel5.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_user_20px;
            this.bunifuCustomLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(495, 127);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(72, 22);
            this.bunifuCustomLabel5.TabIndex = 99999;
            this.bunifuCustomLabel5.Text = "Nome";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel1.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_user_20px;
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 25);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Cliente";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtParentescoRecado
            // 
            this.txtParentescoRecado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtParentescoRecado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtParentescoRecado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtParentescoRecado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtParentescoRecado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtParentescoRecado.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtParentescoRecado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParentescoRecado.Enabled = false;
            this.txtParentescoRecado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtParentescoRecado.ForeColor = System.Drawing.Color.Silver;
            this.txtParentescoRecado.HintForeColor = System.Drawing.Color.Transparent;
            this.txtParentescoRecado.HintText = "";
            this.txtParentescoRecado.isPassword = false;
            this.txtParentescoRecado.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtParentescoRecado.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtParentescoRecado.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtParentescoRecado.LineThickness = 2;
            this.txtParentescoRecado.Location = new System.Drawing.Point(619, 82);
            this.txtParentescoRecado.Margin = new System.Windows.Forms.Padding(5);
            this.txtParentescoRecado.MaxLength = 15;
            this.txtParentescoRecado.Name = "txtParentescoRecado";
            this.txtParentescoRecado.Size = new System.Drawing.Size(264, 32);
            this.txtParentescoRecado.TabIndex = 8;
            this.txtParentescoRecado.Text = "Parentesco de quem vai receber o recado";
            this.txtParentescoRecado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParentescoRecado.Enter += new System.EventHandler(this.txtParentescoRecado_Enter);
            this.txtParentescoRecado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtParentescoRecado.Leave += new System.EventHandler(this.txtParentescoRecado_Leave);
            // 
            // lblTelefonePrincipal
            // 
            this.lblTelefonePrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefonePrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonePrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblTelefonePrincipal.ForeColor = System.Drawing.Color.Lavender;
            this.lblTelefonePrincipal.Image = global::PFC___StandBy_CSharp.Properties.Resources.phone_20px;
            this.lblTelefonePrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefonePrincipal.Location = new System.Drawing.Point(495, 33);
            this.lblTelefonePrincipal.Name = "lblTelefonePrincipal";
            this.lblTelefonePrincipal.Size = new System.Drawing.Size(106, 22);
            this.lblTelefonePrincipal.TabIndex = 99999;
            this.lblTelefonePrincipal.Text = "Número";
            this.lblTelefonePrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel6.Image = global::PFC___StandBy_CSharp.Properties.Resources.family_20px;
            this.bunifuCustomLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(495, 95);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(127, 22);
            this.bunifuCustomLabel6.TabIndex = 99999;
            this.bunifuCustomLabel6.Text = "Parentesco";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblCpf.ForeColor = System.Drawing.Color.Lavender;
            this.lblCpf.Image = global::PFC___StandBy_CSharp.Properties.Resources.identification_documents_20px;
            this.lblCpf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpf.Location = new System.Drawing.Point(29, 63);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(118, 22);
            this.lblCpf.TabIndex = 99999;
            this.lblCpf.Text = "CPF/CNPJ";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(356, 133);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(55, 16);
            this.bunifuLabel2.TabIndex = 72;
            this.bunifuLabel2.TabStop = false;
            this.bunifuLabel2.Text = "Feminino";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTelefoneRecados
            // 
            this.lblTelefoneRecados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefoneRecados.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneRecados.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblTelefoneRecados.ForeColor = System.Drawing.Color.Lavender;
            this.lblTelefoneRecados.Image = global::PFC___StandBy_CSharp.Properties.Resources.sms_20px;
            this.lblTelefoneRecados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefoneRecados.Location = new System.Drawing.Point(495, 63);
            this.lblTelefoneRecados.Name = "lblTelefoneRecados";
            this.lblTelefoneRecados.Size = new System.Drawing.Size(82, 22);
            this.lblTelefoneRecados.TabIndex = 99999;
            this.lblTelefoneRecados.Text = "Recado";
            this.lblTelefoneRecados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkFeminino
            // 
            this.chkFeminino.AllowBindingControlAnimation = true;
            this.chkFeminino.AllowBindingControlColorChanges = false;
            this.chkFeminino.AllowBindingControlLocation = true;
            this.chkFeminino.AllowCheckBoxAnimation = false;
            this.chkFeminino.AllowCheckmarkAnimation = false;
            this.chkFeminino.AllowOnHoverStates = true;
            this.chkFeminino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkFeminino.AutoCheck = true;
            this.chkFeminino.BackColor = System.Drawing.Color.Transparent;
            this.chkFeminino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkFeminino.BackgroundImage")));
            this.chkFeminino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkFeminino.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkFeminino.BorderRadius = 12;
            this.chkFeminino.Checked = false;
            this.chkFeminino.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkFeminino.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFeminino.CustomCheckmarkImage = null;
            this.chkFeminino.Location = new System.Drawing.Point(329, 128);
            this.chkFeminino.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkFeminino.Name = "chkFeminino";
            this.chkFeminino.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkFeminino.OnCheck.BorderRadius = 12;
            this.chkFeminino.OnCheck.BorderThickness = 2;
            this.chkFeminino.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkFeminino.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkFeminino.OnCheck.CheckmarkThickness = 2;
            this.chkFeminino.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkFeminino.OnDisable.BorderRadius = 12;
            this.chkFeminino.OnDisable.BorderThickness = 2;
            this.chkFeminino.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkFeminino.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkFeminino.OnDisable.CheckmarkThickness = 2;
            this.chkFeminino.OnHoverChecked.BorderColor = System.Drawing.Color.Silver;
            this.chkFeminino.OnHoverChecked.BorderRadius = 12;
            this.chkFeminino.OnHoverChecked.BorderThickness = 2;
            this.chkFeminino.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Silver;
            this.chkFeminino.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkFeminino.OnHoverChecked.CheckmarkThickness = 2;
            this.chkFeminino.OnHoverUnchecked.BorderColor = System.Drawing.Color.Silver;
            this.chkFeminino.OnHoverUnchecked.BorderRadius = 12;
            this.chkFeminino.OnHoverUnchecked.BorderThickness = 1;
            this.chkFeminino.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkFeminino.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.chkFeminino.OnUncheck.BorderRadius = 12;
            this.chkFeminino.OnUncheck.BorderThickness = 1;
            this.chkFeminino.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkFeminino.Size = new System.Drawing.Size(21, 21);
            this.chkFeminino.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkFeminino.TabIndex = 5;
            this.chkFeminino.ThreeState = false;
            this.chkFeminino.ToolTipText = null;
            this.chkFeminino.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkFeminino_CheckedChanged);
            this.chkFeminino.Click += new System.EventHandler(this.chkFeminino_Click);
            this.chkFeminino.Enter += new System.EventHandler(this.chkFeminino_Enter);
            this.chkFeminino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.chkFeminino.Leave += new System.EventHandler(this.chkFeminino_Leave);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(180, 132);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(61, 16);
            this.bunifuLabel1.TabIndex = 70;
            this.bunifuLabel1.TabStop = false;
            this.bunifuLabel1.Text = "Masculino";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCPFCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCPFCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtCPFCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtCPFCliente.Location = new System.Drawing.Point(153, 57);
            this.txtCPFCliente.MaxLength = 18;
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(264, 16);
            this.txtCPFCliente.TabIndex = 2;
            this.txtCPFCliente.Text = "CPF ou CNPJ do Cliente";
            this.txtCPFCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPFCliente.Enter += new System.EventHandler(this.txtCPFCliente_Enter);
            this.txtCPFCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.txtCPFCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFCliente_KeyPress);
            this.txtCPFCliente.Leave += new System.EventHandler(this.txtCPFCliente_Leave);
            this.txtCPFCliente.MouseEnter += new System.EventHandler(this.txtCPFCliente_MouseEnter);
            this.txtCPFCliente.MouseLeave += new System.EventHandler(this.txtCPFCliente_MouseLeave);
            // 
            // chkMasculino
            // 
            this.chkMasculino.AllowBindingControlAnimation = true;
            this.chkMasculino.AllowBindingControlColorChanges = false;
            this.chkMasculino.AllowBindingControlLocation = true;
            this.chkMasculino.AllowCheckBoxAnimation = false;
            this.chkMasculino.AllowCheckmarkAnimation = false;
            this.chkMasculino.AllowOnHoverStates = true;
            this.chkMasculino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkMasculino.AutoCheck = true;
            this.chkMasculino.BackColor = System.Drawing.Color.Transparent;
            this.chkMasculino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkMasculino.BackgroundImage")));
            this.chkMasculino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkMasculino.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkMasculino.BorderRadius = 12;
            this.chkMasculino.Checked = false;
            this.chkMasculino.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkMasculino.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMasculino.CustomCheckmarkImage = null;
            this.chkMasculino.Location = new System.Drawing.Point(153, 127);
            this.chkMasculino.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkMasculino.OnCheck.BorderRadius = 12;
            this.chkMasculino.OnCheck.BorderThickness = 2;
            this.chkMasculino.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkMasculino.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkMasculino.OnCheck.CheckmarkThickness = 2;
            this.chkMasculino.OnDisable.BorderColor = System.Drawing.Color.Silver;
            this.chkMasculino.OnDisable.BorderRadius = 12;
            this.chkMasculino.OnDisable.BorderThickness = 2;
            this.chkMasculino.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkMasculino.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkMasculino.OnDisable.CheckmarkThickness = 2;
            this.chkMasculino.OnHoverChecked.BorderColor = System.Drawing.Color.Silver;
            this.chkMasculino.OnHoverChecked.BorderRadius = 12;
            this.chkMasculino.OnHoverChecked.BorderThickness = 2;
            this.chkMasculino.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Silver;
            this.chkMasculino.OnHoverChecked.CheckmarkColor = System.Drawing.Color.Silver;
            this.chkMasculino.OnHoverChecked.CheckmarkThickness = 2;
            this.chkMasculino.OnHoverUnchecked.BorderColor = System.Drawing.Color.Silver;
            this.chkMasculino.OnHoverUnchecked.BorderRadius = 12;
            this.chkMasculino.OnHoverUnchecked.BorderThickness = 1;
            this.chkMasculino.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkMasculino.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.chkMasculino.OnUncheck.BorderRadius = 12;
            this.chkMasculino.OnUncheck.BorderThickness = 1;
            this.chkMasculino.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkMasculino.Size = new System.Drawing.Size(21, 21);
            this.chkMasculino.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkMasculino.TabIndex = 4;
            this.chkMasculino.ThreeState = false;
            this.chkMasculino.ToolTipText = null;
            this.chkMasculino.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkMasculino_CheckedChanged);
            this.chkMasculino.Click += new System.EventHandler(this.chkMasculino_Click);
            this.chkMasculino.Enter += new System.EventHandler(this.chkMasculino_Enter);
            this.chkMasculino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventoCadastrarClienteApertarEnter);
            this.chkMasculino.Leave += new System.EventHandler(this.chkMasculino_Leave);
            // 
            // separatorCPF
            // 
            this.separatorCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.separatorCPF.BackColor = System.Drawing.Color.Transparent;
            this.separatorCPF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separatorCPF.BackgroundImage")));
            this.separatorCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separatorCPF.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.separatorCPF.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.separatorCPF.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separatorCPF.LineThickness = 2;
            this.separatorCPF.Location = new System.Drawing.Point(153, 73);
            this.separatorCPF.Margin = new System.Windows.Forms.Padding(2);
            this.separatorCPF.Name = "separatorCPF";
            this.separatorCPF.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorCPF.Size = new System.Drawing.Size(264, 10);
            this.separatorCPF.TabIndex = 63;
            this.separatorCPF.TabStop = false;
            this.separatorCPF.MouseEnter += new System.EventHandler(this.separatorCPF_MouseEnter);
            this.separatorCPF.MouseLeave += new System.EventHandler(this.separatorCPF_MouseLeave);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel3.Image = global::PFC___StandBy_CSharp.Properties.Resources.toilet_20px;
            this.bunifuCustomLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(30, 127);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 22);
            this.bunifuCustomLabel3.TabIndex = 99999;
            this.bunifuCustomLabel3.Text = "Sexo";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNascimento
            // 
            this.lblNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblNascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblNascimento.ForeColor = System.Drawing.Color.Lavender;
            this.lblNascimento.Image = global::PFC___StandBy_CSharp.Properties.Resources.birthday_cake_20px;
            this.lblNascimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNascimento.Location = new System.Drawing.Point(27, 94);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(134, 22);
            this.lblNascimento.TabIndex = 99999;
            this.lblNascimento.Text = "Nascimento";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.dtpDataNascimento.BorderRadius = 5;
            this.dtpDataNascimento.Color = System.Drawing.Color.Transparent;
            this.dtpDataNascimento.CustomFormat = "";
            this.dtpDataNascimento.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtpDataNascimento.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpDataNascimento.DisabledColor = System.Drawing.Color.Gray;
            this.dtpDataNascimento.DisplayWeekNumbers = false;
            this.dtpDataNascimento.DPHeight = 0;
            this.dtpDataNascimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDataNascimento.FillDatePicker = false;
            this.dtpDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.dtpDataNascimento.ForeColor = System.Drawing.Color.White;
            this.dtpDataNascimento.Icon = ((System.Drawing.Image)(resources.GetObject("dtpDataNascimento.Icon")));
            this.dtpDataNascimento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.dtpDataNascimento.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpDataNascimento.LeftTextMargin = 25;
            this.dtpDataNascimento.Location = new System.Drawing.Point(12, 12);
            this.dtpDataNascimento.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(37, 32);
            this.dtpDataNascimento.TabIndex = 9999;
            this.dtpDataNascimento.Value = new System.DateTime(2022, 6, 12, 17, 51, 0, 0);
            this.dtpDataNascimento.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 60);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(37, 22);
            this.bunifuSeparator1.TabIndex = 66;
            this.bunifuSeparator1.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.table_Clientes;
            // 
            // autoCompleteCidades
            // 
            this.autoCompleteCidades.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoCompleteCidades.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoCompleteCidades.MaxNumberofSuggestion = 20;
            this.autoCompleteCidades.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoCompleteCidades.ParentForm = this;
            this.autoCompleteCidades.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Office2016DarkGray;
            this.autoCompleteCidades.ThemeName = "Office2016DarkGray";
            // 
            // form_CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 651);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_CadastroClientes";
            this.Text = "form_CadastroClientes";
            this.Load += new System.EventHandler(this.form_CadastroClientes_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Clientes)).EndInit();
            this.menuBotaoDireitoTabela.ResumeLayout(false);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCompleteCidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeCliente;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPesquisarCADCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCpf;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefonePrincipal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table_Clientes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip menuBotaoDireitoTabela;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefoneRecados;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQuantidadeClientes;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private Bunifu.UI.WinForms.BunifuSeparator separatorCPF;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpDataNascimento;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNascimento;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuCheckBox chkFeminino;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuCheckBox chkMasculino;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeRecado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtParentescoRecado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCEP;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtComplemento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEndereco;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBairro;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCadastrarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelRecado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Recado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parentesco_Recado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private Bunifu.UI.WinForms.BunifuSeparator separatorDATA;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private Bunifu.UI.WinForms.BunifuSeparator separatorTEL_CLIENTE;
        private System.Windows.Forms.TextBox txtTelefoneRecado;
        private Bunifu.UI.WinForms.BunifuSeparator separatorTEL_RECADO;
        private Syncfusion.Windows.Forms.Tools.AutoComplete autoCompleteCidades;
        private Syncfusion.Windows.Forms.Tools.ComboBoxBase cmbCidades;
        private System.Windows.Forms.Label lblCidades_Carregando;
        private System.Windows.Forms.ListBox listboxCidades;
        private Bunifu.UI.WinForms.BunifuSeparator separatorCIDADES;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLimparCampos;
        private System.Windows.Forms.ListBox listboxEstados;
        private Bunifu.UI.WinForms.BunifuSeparator separatorESTADOS;
        public Syncfusion.Windows.Forms.Tools.ComboBoxBase cmbEstados;
    }
}