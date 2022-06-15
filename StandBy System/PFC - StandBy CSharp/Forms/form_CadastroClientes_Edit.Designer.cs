namespace PFC___StandBy_CSharp.Forms
{
    partial class form_CadastroClientes_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CadastroClientes_Edit));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cardFundo = new Bunifu.Framework.UI.BunifuCards();
            this.groupEndereco = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txtBairro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCidade = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtComplemento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRua = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCEP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupInfoPessoal = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txtDataNascimento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnZerarDataBotao = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtNomeRecado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomeCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtParentescoRecado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTelefonePrincipal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCpf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTelefone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTelefoneRecados = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkFeminino = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.txtTelefoneRecados = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.chkMasculino = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.separatorCPF = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNascimento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.btnEditar = new Guna.UI.WinForms.GunaGradientButton();
            this.dtpDataNascimento = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnZerarData = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.dragPanelFundo = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dragGroupBoxInfoPessoais = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.dragEndereco = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.cardFundo.SuspendLayout();
            this.groupEndereco.SuspendLayout();
            this.groupInfoPessoal.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardFundo
            // 
            this.cardFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.cardFundo.BorderRadius = 5;
            this.cardFundo.BottomSahddow = true;
            this.cardFundo.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.cardFundo.Controls.Add(this.groupEndereco);
            this.cardFundo.Controls.Add(this.groupInfoPessoal);
            this.cardFundo.Controls.Add(this.lblID);
            this.cardFundo.Controls.Add(this.btnEditar);
            this.cardFundo.Controls.Add(this.dtpDataNascimento);
            this.cardFundo.Controls.Add(this.bunifuSeparator1);
            this.cardFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardFundo.LeftSahddow = false;
            this.cardFundo.Location = new System.Drawing.Point(0, 0);
            this.cardFundo.Name = "cardFundo";
            this.cardFundo.RightSahddow = true;
            this.cardFundo.ShadowDepth = 20;
            this.cardFundo.Size = new System.Drawing.Size(965, 364);
            this.cardFundo.TabIndex = 0;
            // 
            // groupEndereco
            // 
            this.groupEndereco.BorderColor = System.Drawing.SystemColors.Control;
            this.groupEndereco.BorderRadius = 1;
            this.groupEndereco.BorderThickness = 1;
            this.groupEndereco.Controls.Add(this.txtBairro);
            this.groupEndereco.Controls.Add(this.bunifuMaterialTextbox3);
            this.groupEndereco.Controls.Add(this.txtEstado);
            this.groupEndereco.Controls.Add(this.txtCidade);
            this.groupEndereco.Controls.Add(this.txtComplemento);
            this.groupEndereco.Controls.Add(this.txtRua);
            this.groupEndereco.Controls.Add(this.txtCEP);
            this.groupEndereco.Controls.Add(this.bunifuCustomLabel8);
            this.groupEndereco.Controls.Add(this.bunifuCustomLabel9);
            this.groupEndereco.Controls.Add(this.bunifuCustomLabel10);
            this.groupEndereco.Controls.Add(this.bunifuCustomLabel7);
            this.groupEndereco.Controls.Add(this.bunifuCustomLabel4);
            this.groupEndereco.Controls.Add(this.bunifuCustomLabel2);
            this.groupEndereco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupEndereco.ForeColor = System.Drawing.SystemColors.Control;
            this.groupEndereco.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.groupEndereco.LabelIndent = 10;
            this.groupEndereco.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.groupEndereco.Location = new System.Drawing.Point(14, 206);
            this.groupEndereco.Name = "groupEndereco";
            this.groupEndereco.Size = new System.Drawing.Size(935, 105);
            this.groupEndereco.TabIndex = 82;
            this.groupEndereco.TabStop = false;
            this.groupEndereco.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBairro.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtBairro.ForeColor = System.Drawing.Color.White;
            this.txtBairro.HintForeColor = System.Drawing.Color.Transparent;
            this.txtBairro.HintText = "";
            this.txtBairro.isPassword = false;
            this.txtBairro.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtBairro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtBairro.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtBairro.LineThickness = 2;
            this.txtBairro.Location = new System.Drawing.Point(109, 54);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(150, 34);
            this.txtBairro.TabIndex = 83;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.bunifuMaterialTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Transparent;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Lavender;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.bunifuMaterialTextbox3.LineThickness = 2;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(752, 54);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.MaxLength = 100;
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(149, 34);
            this.bunifuMaterialTextbox3.TabIndex = 87;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEstado.BackColor = System.Drawing.Color.Black;
            this.txtEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEstado.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtEstado.ForeColor = System.Drawing.Color.White;
            this.txtEstado.HintForeColor = System.Drawing.Color.Transparent;
            this.txtEstado.HintText = "";
            this.txtEstado.isPassword = false;
            this.txtEstado.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtEstado.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtEstado.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtEstado.LineThickness = 2;
            this.txtEstado.Location = new System.Drawing.Point(752, 54);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.MaxLength = 100;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(149, 34);
            this.txtEstado.TabIndex = 87;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCidade.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtCidade.ForeColor = System.Drawing.Color.White;
            this.txtCidade.HintForeColor = System.Drawing.Color.Transparent;
            this.txtCidade.HintText = "";
            this.txtCidade.isPassword = false;
            this.txtCidade.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtCidade.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtCidade.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtCidade.LineThickness = 2;
            this.txtCidade.Location = new System.Drawing.Point(371, 54);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(234, 34);
            this.txtCidade.TabIndex = 85;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtComplemento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtComplemento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtComplemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtComplemento.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtComplemento.ForeColor = System.Drawing.Color.White;
            this.txtComplemento.HintForeColor = System.Drawing.Color.Transparent;
            this.txtComplemento.HintText = "";
            this.txtComplemento.isPassword = false;
            this.txtComplemento.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtComplemento.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtComplemento.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtComplemento.LineThickness = 2;
            this.txtComplemento.Location = new System.Drawing.Point(752, 12);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(149, 34);
            this.txtComplemento.TabIndex = 81;
            this.txtComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRua.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtRua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRua.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtRua.ForeColor = System.Drawing.Color.White;
            this.txtRua.HintForeColor = System.Drawing.Color.Transparent;
            this.txtRua.HintText = "";
            this.txtRua.isPassword = false;
            this.txtRua.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtRua.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtRua.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtRua.LineThickness = 2;
            this.txtRua.Location = new System.Drawing.Point(371, 12);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(234, 34);
            this.txtRua.TabIndex = 79;
            this.txtRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCEP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCEP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCEP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtCEP.ForeColor = System.Drawing.Color.White;
            this.txtCEP.HintForeColor = System.Drawing.Color.Transparent;
            this.txtCEP.HintText = "";
            this.txtCEP.isPassword = false;
            this.txtCEP.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtCEP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtCEP.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtCEP.LineThickness = 2;
            this.txtCEP.Location = new System.Drawing.Point(109, 12);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEP.MaxLength = 100;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(150, 34);
            this.txtCEP.TabIndex = 77;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel8.Image = global::PFC___StandBy_CSharp.Properties.Resources.skyscrapers_20px;
            this.bunifuCustomLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(633, 67);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(97, 25);
            this.bunifuCustomLabel8.TabIndex = 86;
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
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(286, 68);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(99, 25);
            this.bunifuCustomLabel9.TabIndex = 84;
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
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(37, 67);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(87, 25);
            this.bunifuCustomLabel10.TabIndex = 82;
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
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(628, 25);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(142, 25);
            this.bunifuCustomLabel7.TabIndex = 80;
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
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(286, 24);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel4.TabIndex = 78;
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(74, 25);
            this.bunifuCustomLabel2.TabIndex = 77;
            this.bunifuCustomLabel2.Text = "CEP";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupInfoPessoal
            // 
            this.groupInfoPessoal.BorderColor = System.Drawing.SystemColors.Control;
            this.groupInfoPessoal.BorderRadius = 1;
            this.groupInfoPessoal.BorderThickness = 1;
            this.groupInfoPessoal.Controls.Add(this.txtDataNascimento);
            this.groupInfoPessoal.Controls.Add(this.btnZerarDataBotao);
            this.groupInfoPessoal.Controls.Add(this.txtNomeRecado);
            this.groupInfoPessoal.Controls.Add(this.txtNomeCliente);
            this.groupInfoPessoal.Controls.Add(this.bunifuCustomLabel5);
            this.groupInfoPessoal.Controls.Add(this.bunifuCustomLabel1);
            this.groupInfoPessoal.Controls.Add(this.txtParentescoRecado);
            this.groupInfoPessoal.Controls.Add(this.lblTelefonePrincipal);
            this.groupInfoPessoal.Controls.Add(this.bunifuCustomLabel6);
            this.groupInfoPessoal.Controls.Add(this.lblCpf);
            this.groupInfoPessoal.Controls.Add(this.txtTelefone);
            this.groupInfoPessoal.Controls.Add(this.bunifuLabel2);
            this.groupInfoPessoal.Controls.Add(this.lblTelefoneRecados);
            this.groupInfoPessoal.Controls.Add(this.chkFeminino);
            this.groupInfoPessoal.Controls.Add(this.txtTelefoneRecados);
            this.groupInfoPessoal.Controls.Add(this.bunifuLabel1);
            this.groupInfoPessoal.Controls.Add(this.txtCpf);
            this.groupInfoPessoal.Controls.Add(this.chkMasculino);
            this.groupInfoPessoal.Controls.Add(this.separatorCPF);
            this.groupInfoPessoal.Controls.Add(this.bunifuCustomLabel3);
            this.groupInfoPessoal.Controls.Add(this.lblNascimento);
            this.groupInfoPessoal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupInfoPessoal.ForeColor = System.Drawing.SystemColors.Control;
            this.groupInfoPessoal.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.groupInfoPessoal.LabelIndent = 10;
            this.groupInfoPessoal.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.groupInfoPessoal.Location = new System.Drawing.Point(14, 23);
            this.groupInfoPessoal.Name = "groupInfoPessoal";
            this.groupInfoPessoal.Size = new System.Drawing.Size(935, 177);
            this.groupInfoPessoal.TabIndex = 81;
            this.groupInfoPessoal.TabStop = false;
            this.groupInfoPessoal.Text = "Informações Pessoais";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataNascimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDataNascimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtDataNascimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDataNascimento.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDataNascimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtDataNascimento.ForeColor = System.Drawing.Color.White;
            this.txtDataNascimento.HintForeColor = System.Drawing.Color.Transparent;
            this.txtDataNascimento.HintText = "";
            this.txtDataNascimento.isPassword = false;
            this.txtDataNascimento.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtDataNascimento.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtDataNascimento.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtDataNascimento.LineThickness = 2;
            this.txtDataNascimento.Location = new System.Drawing.Point(163, 80);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataNascimento.MaxLength = 100;
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(292, 34);
            this.txtDataNascimento.TabIndex = 78;
            this.txtDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataNascimento.Enter += new System.EventHandler(this.txtDataNascimento_Enter);
            this.txtDataNascimento.Leave += new System.EventHandler(this.txtDataNascimento_Leave);
            this.txtDataNascimento.MouseLeave += new System.EventHandler(this.txtDataNascimento_MouseLeave);
            // 
            // btnZerarDataBotao
            // 
            this.btnZerarDataBotao.AllowAnimations = true;
            this.btnZerarDataBotao.AllowMouseEffects = true;
            this.btnZerarDataBotao.AllowToggling = false;
            this.btnZerarDataBotao.AnimationSpeed = 200;
            this.btnZerarDataBotao.AutoGenerateColors = false;
            this.btnZerarDataBotao.AutoRoundBorders = false;
            this.btnZerarDataBotao.AutoSizeLeftIcon = true;
            this.btnZerarDataBotao.AutoSizeRightIcon = true;
            this.btnZerarDataBotao.BackColor = System.Drawing.Color.Transparent;
            this.btnZerarDataBotao.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnZerarDataBotao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZerarDataBotao.BackgroundImage")));
            this.btnZerarDataBotao.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnZerarDataBotao.ButtonText = "zerar data";
            this.btnZerarDataBotao.ButtonTextMarginLeft = 0;
            this.btnZerarDataBotao.ColorContrastOnClick = 45;
            this.btnZerarDataBotao.ColorContrastOnHover = 45;
            this.btnZerarDataBotao.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnZerarDataBotao.CustomizableEdges = borderEdges1;
            this.btnZerarDataBotao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnZerarDataBotao.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnZerarDataBotao.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnZerarDataBotao.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnZerarDataBotao.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnZerarDataBotao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnZerarDataBotao.ForeColor = System.Drawing.Color.White;
            this.btnZerarDataBotao.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZerarDataBotao.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnZerarDataBotao.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnZerarDataBotao.IconMarginLeft = 11;
            this.btnZerarDataBotao.IconPadding = 10;
            this.btnZerarDataBotao.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZerarDataBotao.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnZerarDataBotao.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnZerarDataBotao.IconSize = 25;
            this.btnZerarDataBotao.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnZerarDataBotao.IdleBorderRadius = 1;
            this.btnZerarDataBotao.IdleBorderThickness = 1;
            this.btnZerarDataBotao.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnZerarDataBotao.IdleIconLeftImage = null;
            this.btnZerarDataBotao.IdleIconRightImage = null;
            this.btnZerarDataBotao.IndicateFocus = false;
            this.btnZerarDataBotao.Location = new System.Drawing.Point(386, 115);
            this.btnZerarDataBotao.Name = "btnZerarDataBotao";
            this.btnZerarDataBotao.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnZerarDataBotao.OnDisabledState.BorderRadius = 1;
            this.btnZerarDataBotao.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnZerarDataBotao.OnDisabledState.BorderThickness = 1;
            this.btnZerarDataBotao.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnZerarDataBotao.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnZerarDataBotao.OnDisabledState.IconLeftImage = null;
            this.btnZerarDataBotao.OnDisabledState.IconRightImage = null;
            this.btnZerarDataBotao.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnZerarDataBotao.onHoverState.BorderRadius = 1;
            this.btnZerarDataBotao.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnZerarDataBotao.onHoverState.BorderThickness = 1;
            this.btnZerarDataBotao.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnZerarDataBotao.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnZerarDataBotao.onHoverState.IconLeftImage = null;
            this.btnZerarDataBotao.onHoverState.IconRightImage = null;
            this.btnZerarDataBotao.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnZerarDataBotao.OnIdleState.BorderRadius = 1;
            this.btnZerarDataBotao.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnZerarDataBotao.OnIdleState.BorderThickness = 1;
            this.btnZerarDataBotao.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnZerarDataBotao.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnZerarDataBotao.OnIdleState.IconLeftImage = null;
            this.btnZerarDataBotao.OnIdleState.IconRightImage = null;
            this.btnZerarDataBotao.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnZerarDataBotao.OnPressedState.BorderRadius = 1;
            this.btnZerarDataBotao.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnZerarDataBotao.OnPressedState.BorderThickness = 1;
            this.btnZerarDataBotao.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnZerarDataBotao.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnZerarDataBotao.OnPressedState.IconLeftImage = null;
            this.btnZerarDataBotao.OnPressedState.IconRightImage = null;
            this.btnZerarDataBotao.Size = new System.Drawing.Size(69, 16);
            this.btnZerarDataBotao.TabIndex = 77;
            this.btnZerarDataBotao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZerarDataBotao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnZerarDataBotao.TextMarginLeft = 0;
            this.btnZerarDataBotao.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnZerarDataBotao.UseDefaultRadiusAndThickness = true;
            this.btnZerarDataBotao.Click += new System.EventHandler(this.btnZerarDataBotao_Click);
            // 
            // txtNomeRecado
            // 
            this.txtNomeRecado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeRecado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeRecado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeRecado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtNomeRecado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeRecado.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeRecado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeRecado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtNomeRecado.ForeColor = System.Drawing.Color.White;
            this.txtNomeRecado.HintForeColor = System.Drawing.Color.Transparent;
            this.txtNomeRecado.HintText = "";
            this.txtNomeRecado.isPassword = false;
            this.txtNomeRecado.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtNomeRecado.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtNomeRecado.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtNomeRecado.LineThickness = 2;
            this.txtNomeRecado.Location = new System.Drawing.Point(621, 115);
            this.txtNomeRecado.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeRecado.MaxLength = 100;
            this.txtNomeRecado.Name = "txtNomeRecado";
            this.txtNomeRecado.Size = new System.Drawing.Size(292, 32);
            this.txtNomeRecado.TabIndex = 74;
            this.txtNomeRecado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtNomeCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtNomeCliente.ForeColor = System.Drawing.Color.White;
            this.txtNomeCliente.HintForeColor = System.Drawing.Color.Transparent;
            this.txtNomeCliente.HintText = "";
            this.txtNomeCliente.isPassword = false;
            this.txtNomeCliente.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtNomeCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtNomeCliente.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtNomeCliente.LineThickness = 2;
            this.txtNomeCliente.Location = new System.Drawing.Point(163, 13);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(292, 34);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCliente_KeyDown);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel5.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_user_20px;
            this.bunifuCustomLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(505, 127);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(72, 22);
            this.bunifuCustomLabel5.TabIndex = 76;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 25);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Cliente";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtParentescoRecado
            // 
            this.txtParentescoRecado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtParentescoRecado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtParentescoRecado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtParentescoRecado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtParentescoRecado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtParentescoRecado.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtParentescoRecado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParentescoRecado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtParentescoRecado.ForeColor = System.Drawing.Color.White;
            this.txtParentescoRecado.HintForeColor = System.Drawing.Color.Transparent;
            this.txtParentescoRecado.HintText = "";
            this.txtParentescoRecado.isPassword = false;
            this.txtParentescoRecado.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtParentescoRecado.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtParentescoRecado.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtParentescoRecado.LineThickness = 2;
            this.txtParentescoRecado.Location = new System.Drawing.Point(621, 82);
            this.txtParentescoRecado.Margin = new System.Windows.Forms.Padding(5);
            this.txtParentescoRecado.MaxLength = 15;
            this.txtParentescoRecado.Name = "txtParentescoRecado";
            this.txtParentescoRecado.Size = new System.Drawing.Size(292, 32);
            this.txtParentescoRecado.TabIndex = 73;
            this.txtParentescoRecado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefonePrincipal
            // 
            this.lblTelefonePrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefonePrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonePrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblTelefonePrincipal.ForeColor = System.Drawing.Color.Lavender;
            this.lblTelefonePrincipal.Image = global::PFC___StandBy_CSharp.Properties.Resources.phone_20px;
            this.lblTelefonePrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefonePrincipal.Location = new System.Drawing.Point(505, 33);
            this.lblTelefonePrincipal.Name = "lblTelefonePrincipal";
            this.lblTelefonePrincipal.Size = new System.Drawing.Size(106, 22);
            this.lblTelefonePrincipal.TabIndex = 31;
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
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(505, 95);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(127, 22);
            this.bunifuCustomLabel6.TabIndex = 75;
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
            this.lblCpf.Location = new System.Drawing.Point(39, 63);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(118, 22);
            this.lblCpf.TabIndex = 32;
            this.lblCpf.Text = "CPF/CNPJ";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTelefone.ForeColor = System.Drawing.Color.White;
            this.txtTelefone.HintForeColor = System.Drawing.Color.Transparent;
            this.txtTelefone.HintText = "";
            this.txtTelefone.isPassword = false;
            this.txtTelefone.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtTelefone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtTelefone.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtTelefone.LineThickness = 2;
            this.txtTelefone.Location = new System.Drawing.Point(621, 15);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(292, 32);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(366, 133);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(55, 16);
            this.bunifuLabel2.TabIndex = 72;
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
            this.lblTelefoneRecados.Location = new System.Drawing.Point(505, 63);
            this.lblTelefoneRecados.Name = "lblTelefoneRecados";
            this.lblTelefoneRecados.Size = new System.Drawing.Size(82, 22);
            this.lblTelefoneRecados.TabIndex = 38;
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
            this.chkFeminino.Location = new System.Drawing.Point(339, 128);
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
            this.chkFeminino.TabIndex = 71;
            this.chkFeminino.ThreeState = false;
            this.chkFeminino.ToolTipText = null;
            this.chkFeminino.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkFeminino_CheckedChanged);
            // 
            // txtTelefoneRecados
            // 
            this.txtTelefoneRecados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefoneRecados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefoneRecados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefoneRecados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtTelefoneRecados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefoneRecados.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefoneRecados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefoneRecados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTelefoneRecados.ForeColor = System.Drawing.Color.White;
            this.txtTelefoneRecados.HintForeColor = System.Drawing.Color.Transparent;
            this.txtTelefoneRecados.HintText = "";
            this.txtTelefoneRecados.isPassword = false;
            this.txtTelefoneRecados.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtTelefoneRecados.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtTelefoneRecados.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtTelefoneRecados.LineThickness = 2;
            this.txtTelefoneRecados.Location = new System.Drawing.Point(621, 48);
            this.txtTelefoneRecados.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefoneRecados.MaxLength = 100;
            this.txtTelefoneRecados.Name = "txtTelefoneRecados";
            this.txtTelefoneRecados.Size = new System.Drawing.Size(292, 32);
            this.txtTelefoneRecados.TabIndex = 7;
            this.txtTelefoneRecados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefoneRecados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefone_KeyDown);
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
            this.bunifuLabel1.Location = new System.Drawing.Point(190, 132);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(61, 16);
            this.bunifuLabel1.TabIndex = 70;
            this.bunifuLabel1.Text = "Masculino";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtCpf.ForeColor = System.Drawing.Color.White;
            this.txtCpf.Location = new System.Drawing.Point(163, 57);
            this.txtCpf.MaxLength = 18;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(292, 16);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
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
            this.chkMasculino.Location = new System.Drawing.Point(163, 127);
            this.chkMasculino.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkMasculino.OnCheck.BorderRadius = 12;
            this.chkMasculino.OnCheck.BorderThickness = 2;
            this.chkMasculino.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkMasculino.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkMasculino.OnCheck.CheckmarkThickness = 2;
            this.chkMasculino.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkMasculino.OnDisable.BorderRadius = 12;
            this.chkMasculino.OnDisable.BorderThickness = 2;
            this.chkMasculino.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkMasculino.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkMasculino.OnDisable.CheckmarkThickness = 2;
            this.chkMasculino.OnHoverChecked.BorderColor = System.Drawing.Color.Silver;
            this.chkMasculino.OnHoverChecked.BorderRadius = 12;
            this.chkMasculino.OnHoverChecked.BorderThickness = 2;
            this.chkMasculino.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Silver;
            this.chkMasculino.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
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
            this.chkMasculino.TabIndex = 68;
            this.chkMasculino.ThreeState = false;
            this.chkMasculino.ToolTipText = null;
            this.chkMasculino.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkMasculino_CheckedChanged);
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
            this.separatorCPF.Location = new System.Drawing.Point(163, 73);
            this.separatorCPF.Margin = new System.Windows.Forms.Padding(2);
            this.separatorCPF.Name = "separatorCPF";
            this.separatorCPF.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separatorCPF.Size = new System.Drawing.Size(292, 10);
            this.separatorCPF.TabIndex = 63;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel3.Image = global::PFC___StandBy_CSharp.Properties.Resources.toilet_20px;
            this.bunifuCustomLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 127);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(87, 22);
            this.bunifuCustomLabel3.TabIndex = 67;
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
            this.lblNascimento.Location = new System.Drawing.Point(37, 94);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(134, 22);
            this.lblNascimento.TabIndex = 65;
            this.lblNascimento.Text = "Nascimento";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(3, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnEditar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_edit_account_512px;
            this.btnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(782, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnEditar.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Size = new System.Drawing.Size(160, 32);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.dtpDataNascimento.BorderRadius = 5;
            this.dtpDataNascimento.Color = System.Drawing.Color.Transparent;
            this.dtpDataNascimento.ContextMenuStrip = this.contextMenuStrip1;
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
            this.dtpDataNascimento.Location = new System.Drawing.Point(14, 320);
            this.dtpDataNascimento.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(44, 32);
            this.dtpDataNascimento.TabIndex = 64;
            this.dtpDataNascimento.Value = new System.DateTime(2022, 6, 12, 17, 51, 0, 0);
            this.dtpDataNascimento.Visible = false;
            this.dtpDataNascimento.MouseEnter += new System.EventHandler(this.dtpDataNascimento_MouseEnter);
            this.dtpDataNascimento.MouseLeave += new System.EventHandler(this.dtpDataNascimento_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZerarData});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // btnZerarData
            // 
            this.btnZerarData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnZerarData.Name = "btnZerarData";
            this.btnZerarData.Size = new System.Drawing.Size(102, 22);
            this.btnZerarData.Text = "Zerar data";
            this.btnZerarData.Click += new System.EventHandler(this.btnZerarData_Click);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 345);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(250, 14);
            this.bunifuSeparator1.TabIndex = 66;
            this.bunifuSeparator1.Visible = false;
            // 
            // dragPanelFundo
            // 
            this.dragPanelFundo.TargetControl = this.cardFundo;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 3;
            this.gunaElipse1.TargetControl = this.btnEditar;
            // 
            // dragGroupBoxInfoPessoais
            // 
            this.dragGroupBoxInfoPessoais.TargetControl = this.groupInfoPessoal;
            // 
            // dragEndereco
            // 
            this.dragEndereco.TargetControl = this.groupEndereco;
            // 
            // form_CadastroClientes_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(965, 364);
            this.Controls.Add(this.cardFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_CadastroClientes_Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CadastroClientes_Edit";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_CadastroClientes_Edit_KeyDown);
            this.cardFundo.ResumeLayout(false);
            this.cardFundo.PerformLayout();
            this.groupEndereco.ResumeLayout(false);
            this.groupInfoPessoal.ResumeLayout(false);
            this.groupInfoPessoal.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardFundo;
        private Guna.UI.WinForms.GunaDragControl dragPanelFundo;
        private Guna.UI.WinForms.GunaGradientButton btnEditar;
        public Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Bunifu.UI.WinForms.BunifuGroupBox groupEndereco;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuGroupBox groupInfoPessoal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefonePrincipal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCpf;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefoneRecados;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator separatorCPF;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNascimento;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeCliente;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefone;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefoneRecados;
        public System.Windows.Forms.TextBox txtCpf;
        private Guna.UI.WinForms.GunaDragControl dragGroupBoxInfoPessoais;
        private Guna.UI.WinForms.GunaDragControl dragEndereco;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtBairro;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCidade;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtComplemento;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtRua;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCEP;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeRecado;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtParentescoRecado;
        public Bunifu.UI.WinForms.BunifuCheckBox chkFeminino;
        public Bunifu.UI.WinForms.BunifuCheckBox chkMasculino;
        public Bunifu.UI.WinForms.BunifuDatePicker dtpDataNascimento;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnZerarDataBotao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnZerarData;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDataNascimento;
    }
}