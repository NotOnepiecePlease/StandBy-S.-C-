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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuantidadeClientes = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTratarCom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkTelRecados = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.txtTelefoneRecado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTelefoneRecados = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkCnpj = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkSemCPF = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.txtTelefoneCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomeCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCPFCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPesquisarCADCliente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.lblCpf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTelefonePrincipal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.table_Clientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelRecado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Clientes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblQuantidadeClientes);
            this.panel1.Controls.Add(this.txtTratarCom);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.chkTelRecados);
            this.panel1.Controls.Add(this.txtTelefoneRecado);
            this.panel1.Controls.Add(this.lblTelefoneRecados);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.chkCnpj);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.chkSemCPF);
            this.panel1.Controls.Add(this.txtTelefoneCliente);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.txtCPFCliente);
            this.panel1.Controls.Add(this.txtPesquisarCADCliente);
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Controls.Add(this.lblCpf);
            this.panel1.Controls.Add(this.lblTelefonePrincipal);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.table_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 665);
            this.panel1.TabIndex = 1;
            // 
            // lblQuantidadeClientes
            // 
            this.lblQuantidadeClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuantidadeClientes.ForeColor = System.Drawing.Color.Lavender;
            this.lblQuantidadeClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuantidadeClientes.Location = new System.Drawing.Point(12, 9);
            this.lblQuantidadeClientes.Name = "lblQuantidadeClientes";
            this.lblQuantidadeClientes.Size = new System.Drawing.Size(47, 25);
            this.lblQuantidadeClientes.TabIndex = 61;
            this.lblQuantidadeClientes.Text = "800";
            this.lblQuantidadeClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTratarCom
            // 
            this.txtTratarCom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTratarCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTratarCom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTratarCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTratarCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTratarCom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTratarCom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTratarCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTratarCom.ForeColor = System.Drawing.Color.Silver;
            this.txtTratarCom.HintForeColor = System.Drawing.Color.Transparent;
            this.txtTratarCom.HintText = "";
            this.txtTratarCom.isPassword = false;
            this.txtTratarCom.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtTratarCom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtTratarCom.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtTratarCom.LineThickness = 2;
            this.txtTratarCom.Location = new System.Drawing.Point(1013, 121);
            this.txtTratarCom.Margin = new System.Windows.Forms.Padding(5);
            this.txtTratarCom.MaxLength = 100;
            this.txtTratarCom.Name = "txtTratarCom";
            this.txtTratarCom.Size = new System.Drawing.Size(54, 32);
            this.txtTratarCom.TabIndex = 8;
            this.txtTratarCom.Text = "Quem recebe o recado";
            this.txtTratarCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTratarCom.Visible = false;
            this.txtTratarCom.Enter += new System.EventHandler(this.txtTratarCom_Enter);
            this.txtTratarCom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTratarCom_KeyDown);
            this.txtTratarCom.Leave += new System.EventHandler(this.txtTratarCom_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1014, 90);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 21);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Tel Recado";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel2.Visible = false;
            // 
            // chkTelRecados
            // 
            this.chkTelRecados.AllowBindingControlAnimation = true;
            this.chkTelRecados.AllowBindingControlColorChanges = false;
            this.chkTelRecados.AllowBindingControlLocation = true;
            this.chkTelRecados.AllowCheckBoxAnimation = false;
            this.chkTelRecados.AllowCheckmarkAnimation = true;
            this.chkTelRecados.AllowOnHoverStates = true;
            this.chkTelRecados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTelRecados.AutoCheck = true;
            this.chkTelRecados.BackColor = System.Drawing.Color.Transparent;
            this.chkTelRecados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkTelRecados.BackgroundImage")));
            this.chkTelRecados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkTelRecados.BindingControl = null;
            this.chkTelRecados.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkTelRecados.Checked = false;
            this.chkTelRecados.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkTelRecados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTelRecados.CustomCheckmarkImage = null;
            this.chkTelRecados.Location = new System.Drawing.Point(990, 90);
            this.chkTelRecados.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkTelRecados.Name = "chkTelRecados";
            this.chkTelRecados.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkTelRecados.OnCheck.BorderRadius = 2;
            this.chkTelRecados.OnCheck.BorderThickness = 2;
            this.chkTelRecados.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkTelRecados.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkTelRecados.OnCheck.CheckmarkThickness = 2;
            this.chkTelRecados.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkTelRecados.OnDisable.BorderRadius = 2;
            this.chkTelRecados.OnDisable.BorderThickness = 2;
            this.chkTelRecados.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkTelRecados.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkTelRecados.OnDisable.CheckmarkThickness = 2;
            this.chkTelRecados.OnHoverChecked.BorderColor = System.Drawing.Color.Silver;
            this.chkTelRecados.OnHoverChecked.BorderRadius = 2;
            this.chkTelRecados.OnHoverChecked.BorderThickness = 2;
            this.chkTelRecados.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Silver;
            this.chkTelRecados.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkTelRecados.OnHoverChecked.CheckmarkThickness = 2;
            this.chkTelRecados.OnHoverUnchecked.BorderColor = System.Drawing.Color.Silver;
            this.chkTelRecados.OnHoverUnchecked.BorderRadius = 2;
            this.chkTelRecados.OnHoverUnchecked.BorderThickness = 2;
            this.chkTelRecados.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkTelRecados.OnUncheck.BorderColor = System.Drawing.Color.White;
            this.chkTelRecados.OnUncheck.BorderRadius = 2;
            this.chkTelRecados.OnUncheck.BorderThickness = 2;
            this.chkTelRecados.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkTelRecados.Size = new System.Drawing.Size(21, 21);
            this.chkTelRecados.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkTelRecados.TabIndex = 6;
            this.chkTelRecados.ThreeState = false;
            this.chkTelRecados.ToolTipText = null;
            this.chkTelRecados.Visible = false;
            this.chkTelRecados.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkTelRecados_CheckedChanged);
            // 
            // txtTelefoneRecado
            // 
            this.txtTelefoneRecado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefoneRecado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefoneRecado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefoneRecado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTelefoneRecado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefoneRecado.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefoneRecado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefoneRecado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTelefoneRecado.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefoneRecado.HintForeColor = System.Drawing.Color.Transparent;
            this.txtTelefoneRecado.HintText = "";
            this.txtTelefoneRecado.isPassword = false;
            this.txtTelefoneRecado.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtTelefoneRecado.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtTelefoneRecado.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtTelefoneRecado.LineThickness = 2;
            this.txtTelefoneRecado.Location = new System.Drawing.Point(372, 229);
            this.txtTelefoneRecado.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefoneRecado.MaxLength = 100;
            this.txtTelefoneRecado.Name = "txtTelefoneRecado";
            this.txtTelefoneRecado.Size = new System.Drawing.Size(431, 32);
            this.txtTelefoneRecado.TabIndex = 7;
            this.txtTelefoneRecado.Text = "Telefone de Recados do Cliente";
            this.txtTelefoneRecado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefoneRecado.Enter += new System.EventHandler(this.txtTelefoneRecado_Enter);
            this.txtTelefoneRecado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefoneRecado_KeyDown);
            this.txtTelefoneRecado.Leave += new System.EventHandler(this.txtTelefoneRecado_Leave);
            // 
            // lblTelefoneRecados
            // 
            this.lblTelefoneRecados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefoneRecados.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneRecados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTelefoneRecados.ForeColor = System.Drawing.Color.Lavender;
            this.lblTelefoneRecados.Image = global::PFC___StandBy_CSharp.Properties.Resources.sms_20px;
            this.lblTelefoneRecados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefoneRecados.Location = new System.Drawing.Point(256, 239);
            this.lblTelefoneRecados.Name = "lblTelefoneRecados";
            this.lblTelefoneRecados.Size = new System.Drawing.Size(100, 22);
            this.lblTelefoneRecados.TabIndex = 38;
            this.lblTelefoneRecados.Text = "Recado";
            this.lblTelefoneRecados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(846, 121);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(55, 21);
            this.bunifuCustomLabel5.TabIndex = 36;
            this.bunifuCustomLabel5.Text = "CNPJ";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkCnpj
            // 
            this.chkCnpj.AllowBindingControlAnimation = true;
            this.chkCnpj.AllowBindingControlColorChanges = false;
            this.chkCnpj.AllowBindingControlLocation = true;
            this.chkCnpj.AllowCheckBoxAnimation = false;
            this.chkCnpj.AllowCheckmarkAnimation = true;
            this.chkCnpj.AllowOnHoverStates = true;
            this.chkCnpj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkCnpj.AutoCheck = true;
            this.chkCnpj.BackColor = System.Drawing.Color.Transparent;
            this.chkCnpj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkCnpj.BackgroundImage")));
            this.chkCnpj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkCnpj.BindingControl = null;
            this.chkCnpj.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkCnpj.Checked = false;
            this.chkCnpj.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkCnpj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCnpj.CustomCheckmarkImage = null;
            this.chkCnpj.Location = new System.Drawing.Point(822, 121);
            this.chkCnpj.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkCnpj.Name = "chkCnpj";
            this.chkCnpj.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkCnpj.OnCheck.BorderRadius = 2;
            this.chkCnpj.OnCheck.BorderThickness = 2;
            this.chkCnpj.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkCnpj.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkCnpj.OnCheck.CheckmarkThickness = 2;
            this.chkCnpj.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkCnpj.OnDisable.BorderRadius = 2;
            this.chkCnpj.OnDisable.BorderThickness = 2;
            this.chkCnpj.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkCnpj.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkCnpj.OnDisable.CheckmarkThickness = 2;
            this.chkCnpj.OnHoverChecked.BorderColor = System.Drawing.Color.Silver;
            this.chkCnpj.OnHoverChecked.BorderRadius = 2;
            this.chkCnpj.OnHoverChecked.BorderThickness = 2;
            this.chkCnpj.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Silver;
            this.chkCnpj.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkCnpj.OnHoverChecked.CheckmarkThickness = 2;
            this.chkCnpj.OnHoverUnchecked.BorderColor = System.Drawing.Color.Silver;
            this.chkCnpj.OnHoverUnchecked.BorderRadius = 2;
            this.chkCnpj.OnHoverUnchecked.BorderThickness = 2;
            this.chkCnpj.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkCnpj.OnUncheck.BorderColor = System.Drawing.Color.White;
            this.chkCnpj.OnUncheck.BorderRadius = 2;
            this.chkCnpj.OnUncheck.BorderThickness = 2;
            this.chkCnpj.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkCnpj.Size = new System.Drawing.Size(21, 21);
            this.chkCnpj.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkCnpj.TabIndex = 3;
            this.chkCnpj.ThreeState = false;
            this.chkCnpj.ToolTipText = null;
            this.chkCnpj.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkCnpj_CheckedChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(1014, 60);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(55, 21);
            this.bunifuCustomLabel4.TabIndex = 34;
            this.bunifuCustomLabel4.Text = "SEM CPF";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel4.Visible = false;
            // 
            // chkSemCPF
            // 
            this.chkSemCPF.AllowBindingControlAnimation = true;
            this.chkSemCPF.AllowBindingControlColorChanges = false;
            this.chkSemCPF.AllowBindingControlLocation = true;
            this.chkSemCPF.AllowCheckBoxAnimation = false;
            this.chkSemCPF.AllowCheckmarkAnimation = true;
            this.chkSemCPF.AllowOnHoverStates = true;
            this.chkSemCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkSemCPF.AutoCheck = true;
            this.chkSemCPF.BackColor = System.Drawing.Color.Transparent;
            this.chkSemCPF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkSemCPF.BackgroundImage")));
            this.chkSemCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkSemCPF.BindingControl = null;
            this.chkSemCPF.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkSemCPF.Checked = false;
            this.chkSemCPF.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.chkSemCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSemCPF.CustomCheckmarkImage = null;
            this.chkSemCPF.Location = new System.Drawing.Point(990, 59);
            this.chkSemCPF.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkSemCPF.Name = "chkSemCPF";
            this.chkSemCPF.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkSemCPF.OnCheck.BorderRadius = 2;
            this.chkSemCPF.OnCheck.BorderThickness = 2;
            this.chkSemCPF.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.chkSemCPF.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkSemCPF.OnCheck.CheckmarkThickness = 2;
            this.chkSemCPF.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkSemCPF.OnDisable.BorderRadius = 2;
            this.chkSemCPF.OnDisable.BorderThickness = 2;
            this.chkSemCPF.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkSemCPF.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkSemCPF.OnDisable.CheckmarkThickness = 2;
            this.chkSemCPF.OnHoverChecked.BorderColor = System.Drawing.Color.Silver;
            this.chkSemCPF.OnHoverChecked.BorderRadius = 2;
            this.chkSemCPF.OnHoverChecked.BorderThickness = 2;
            this.chkSemCPF.OnHoverChecked.CheckBoxColor = System.Drawing.Color.Silver;
            this.chkSemCPF.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkSemCPF.OnHoverChecked.CheckmarkThickness = 2;
            this.chkSemCPF.OnHoverUnchecked.BorderColor = System.Drawing.Color.Silver;
            this.chkSemCPF.OnHoverUnchecked.BorderRadius = 2;
            this.chkSemCPF.OnHoverUnchecked.BorderThickness = 2;
            this.chkSemCPF.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkSemCPF.OnUncheck.BorderColor = System.Drawing.Color.White;
            this.chkSemCPF.OnUncheck.BorderRadius = 2;
            this.chkSemCPF.OnUncheck.BorderThickness = 2;
            this.chkSemCPF.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkSemCPF.Size = new System.Drawing.Size(21, 21);
            this.chkSemCPF.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkSemCPF.TabIndex = 60;
            this.chkSemCPF.ThreeState = false;
            this.chkSemCPF.ToolTipText = null;
            this.chkSemCPF.Visible = false;
            this.chkSemCPF.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkSemCPF_CheckedChanged);
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefoneCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefoneCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefoneCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTelefoneCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefoneCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefoneCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTelefoneCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefoneCliente.HintForeColor = System.Drawing.Color.Transparent;
            this.txtTelefoneCliente.HintText = "";
            this.txtTelefoneCliente.isPassword = false;
            this.txtTelefoneCliente.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtTelefoneCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtTelefoneCliente.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtTelefoneCliente.LineThickness = 2;
            this.txtTelefoneCliente.Location = new System.Drawing.Point(372, 168);
            this.txtTelefoneCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefoneCliente.MaxLength = 15;
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(431, 32);
            this.txtTelefoneCliente.TabIndex = 4;
            this.txtTelefoneCliente.Text = "Telefone Principal do Cliente";
            this.txtTelefoneCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefoneCliente.Enter += new System.EventHandler(this.txtTelefoneCliente_Enter);
            this.txtTelefoneCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefoneCliente_KeyDown);
            this.txtTelefoneCliente.Leave += new System.EventHandler(this.txtTelefoneCliente_Leave);
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
            this.txtNomeCliente.Location = new System.Drawing.Point(372, 44);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(431, 34);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.Text = "Nome do Cliente";
            this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCliente.Enter += new System.EventHandler(this.txtNomeCliente_Enter);
            this.txtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCliente_KeyDown);
            this.txtNomeCliente.Leave += new System.EventHandler(this.txtNomeCliente_Leave);
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCPFCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCPFCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCPFCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCPFCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCPFCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCPFCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtCPFCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtCPFCliente.HintForeColor = System.Drawing.Color.Transparent;
            this.txtCPFCliente.HintText = "";
            this.txtCPFCliente.isPassword = false;
            this.txtCPFCliente.LineFocusedColor = System.Drawing.Color.White;
            this.txtCPFCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtCPFCliente.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtCPFCliente.LineThickness = 2;
            this.txtCPFCliente.Location = new System.Drawing.Point(372, 107);
            this.txtCPFCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFCliente.MaxLength = 11;
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(431, 32);
            this.txtCPFCliente.TabIndex = 2;
            this.txtCPFCliente.Text = "CPF do Cliente";
            this.txtCPFCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPFCliente.Enter += new System.EventHandler(this.txtCPFCliente_Enter);
            this.txtCPFCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPFCliente_KeyDown);
            this.txtCPFCliente.Leave += new System.EventHandler(this.txtCPFCliente_Leave);
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
            this.txtPesquisarCADCliente.Location = new System.Drawing.Point(261, 282);
            this.txtPesquisarCADCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisarCADCliente.MaxLength = 32767;
            this.txtPesquisarCADCliente.Name = "txtPesquisarCADCliente";
            this.txtPesquisarCADCliente.Size = new System.Drawing.Size(542, 32);
            this.txtPesquisarCADCliente.TabIndex = 9;
            this.txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            this.txtPesquisarCADCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarCADCliente.Enter += new System.EventHandler(this.txtPesquisarCADCliente_Enter);
            //this.txtPesquisarCADCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarCADCliente_KeyDown);
            this.txtPesquisarCADCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarCADCliente_KeyUp);
            this.txtPesquisarCADCliente.Leave += new System.EventHandler(this.txtPesquisarCADCliente_Leave);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(103)))));
            this.btnCadastrarCliente.IconSize = 40;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(822, 282);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnCadastrarCliente.Rotation = 0D;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(37, 32);
            this.btnCadastrarCliente.TabIndex = 10;
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblCpf.ForeColor = System.Drawing.Color.Lavender;
            this.lblCpf.Image = global::PFC___StandBy_CSharp.Properties.Resources.identification_documents_20px;
            this.lblCpf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCpf.Location = new System.Drawing.Point(256, 117);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(72, 22);
            this.lblCpf.TabIndex = 32;
            this.lblCpf.Text = "CPF";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelefonePrincipal
            // 
            this.lblTelefonePrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefonePrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonePrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTelefonePrincipal.ForeColor = System.Drawing.Color.Lavender;
            this.lblTelefonePrincipal.Image = global::PFC___StandBy_CSharp.Properties.Resources.phone_20px;
            this.lblTelefonePrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTelefonePrincipal.Location = new System.Drawing.Point(256, 178);
            this.lblTelefonePrincipal.Name = "lblTelefonePrincipal";
            this.lblTelefonePrincipal.Size = new System.Drawing.Size(108, 22);
            this.lblTelefonePrincipal.TabIndex = 31;
            this.lblTelefonePrincipal.Text = "Número";
            this.lblTelefonePrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel1.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_user_20px;
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(256, 56);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(98, 25);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Cliente";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // table_Clientes
            // 
            this.table_Clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.table_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table_Clientes.ColumnHeadersHeight = 35;
            this.table_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id,
            this.Nome,
            this.Telefone,
            this.TelRecado,
            this.Situacao});
            this.table_Clientes.ContextMenuStrip = this.contextMenuStrip1;
            this.table_Clientes.DoubleBuffered = true;
            this.table_Clientes.EnableHeadersVisualStyles = false;
            this.table_Clientes.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.table_Clientes.HeaderForeColor = System.Drawing.Color.Black;
            this.table_Clientes.Location = new System.Drawing.Point(261, 322);
            this.table_Clientes.Name = "table_Clientes";
            this.table_Clientes.ReadOnly = true;
            this.table_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.table_Clientes.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Snow;
            this.table_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.table_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Clientes.Size = new System.Drawing.Size(542, 331);
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
            this.Telefone.Width = 130;
            // 
            // TelRecado
            // 
            this.TelRecado.DataPropertyName = "cl_telefone_recado";
            this.TelRecado.HeaderText = "TelRecado";
            this.TelRecado.Name = "TelRecado";
            this.TelRecado.ReadOnly = true;
            this.TelRecado.Width = 150;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "cl_cpf";
            this.Situacao.FillWeight = 58.82353F;
            this.Situacao.HeaderText = "CPF";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(85, 48);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.table_Clientes;
            // 
            // form_CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_CadastroClientes";
            this.Text = "form_CadastroClientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Clientes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeCliente;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCPFCliente;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPesquisarCADCliente;
        private FontAwesome.Sharp.IconButton btnCadastrarCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCpf;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefonePrincipal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefoneCliente;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table_Clientes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.UI.WinForms.BunifuCheckBox chkSemCPF;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.UI.WinForms.BunifuCheckBox chkCnpj;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefoneRecado;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefoneRecados;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuCheckBox chkTelRecados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelRecado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTratarCom;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQuantidadeClientes;
    }
}