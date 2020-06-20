namespace PFC___StandBy_CSharp.Forms
{
    partial class form_WordNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_WordNota));
            this.panelDrag = new Guna.UI.WinForms.GunaPanel();
            this.lblIDCliente = new Guna.UI.WinForms.GunaLabel();
            this.lblIDServico = new Guna.UI.WinForms.GunaLabel();
            this.lblGarantiaStatus = new Guna.UI.WinForms.GunaLabel();
            this.switchGarantia = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.lblMes3 = new Guna.UI.WinForms.GunaLabel();
            this.checkboxTresMeses = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.lblMes2 = new Guna.UI.WinForms.GunaLabel();
            this.checkboxDoisMeses = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.lblMes1 = new Guna.UI.WinForms.GunaLabel();
            this.checkboxUmMes = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.txtGarantia = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblGarantia = new Guna.UI.WinForms.GunaLabel();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblArquivoPadrao = new Guna.UI.WinForms.GunaLabel();
            this.lblImpressoraPdrao = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnPastaPadrao = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tFilename = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCPF = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtCliente = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtValor = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtModelo = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtServico = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnCarregarWord = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCriarWord = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SaveDoc = new System.Windows.Forms.SaveFileDialog();
            this.LoadDoc = new System.Windows.Forms.OpenFileDialog();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelDrag.Controls.Add(this.lblIDCliente);
            this.panelDrag.Controls.Add(this.lblIDServico);
            this.panelDrag.Controls.Add(this.lblGarantiaStatus);
            this.panelDrag.Controls.Add(this.switchGarantia);
            this.panelDrag.Controls.Add(this.lblMes3);
            this.panelDrag.Controls.Add(this.checkboxTresMeses);
            this.panelDrag.Controls.Add(this.lblMes2);
            this.panelDrag.Controls.Add(this.checkboxDoisMeses);
            this.panelDrag.Controls.Add(this.lblMes1);
            this.panelDrag.Controls.Add(this.checkboxUmMes);
            this.panelDrag.Controls.Add(this.txtGarantia);
            this.panelDrag.Controls.Add(this.lblGarantia);
            this.panelDrag.Controls.Add(this.iconClose);
            this.panelDrag.Controls.Add(this.gunaPanel1);
            this.panelDrag.Controls.Add(this.lblArquivoPadrao);
            this.panelDrag.Controls.Add(this.lblImpressoraPdrao);
            this.panelDrag.Controls.Add(this.gunaLabel6);
            this.panelDrag.Controls.Add(this.btnPastaPadrao);
            this.panelDrag.Controls.Add(this.tFilename);
            this.panelDrag.Controls.Add(this.txtCPF);
            this.panelDrag.Controls.Add(this.txtCliente);
            this.panelDrag.Controls.Add(this.txtValor);
            this.panelDrag.Controls.Add(this.txtModelo);
            this.panelDrag.Controls.Add(this.txtServico);
            this.panelDrag.Controls.Add(this.gunaLabel5);
            this.panelDrag.Controls.Add(this.gunaLabel4);
            this.panelDrag.Controls.Add(this.gunaLabel3);
            this.panelDrag.Controls.Add(this.gunaLabel2);
            this.panelDrag.Controls.Add(this.gunaLabel1);
            this.panelDrag.Controls.Add(this.btnCarregarWord);
            this.panelDrag.Controls.Add(this.btnCriarWord);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(333, 679);
            this.panelDrag.TabIndex = 2;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblIDCliente.Location = new System.Drawing.Point(71, 9);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(59, 17);
            this.lblIDCliente.TabIndex = 35;
            this.lblIDCliente.Text = "IDCliente";
            this.lblIDCliente.Visible = false;
            // 
            // lblIDServico
            // 
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblIDServico.Location = new System.Drawing.Point(3, 9);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(62, 17);
            this.lblIDServico.TabIndex = 34;
            this.lblIDServico.Text = "IDServico";
            this.lblIDServico.Visible = false;
            // 
            // lblGarantiaStatus
            // 
            this.lblGarantiaStatus.AutoSize = true;
            this.lblGarantiaStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantiaStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGarantiaStatus.Location = new System.Drawing.Point(166, 459);
            this.lblGarantiaStatus.Name = "lblGarantiaStatus";
            this.lblGarantiaStatus.Size = new System.Drawing.Size(85, 17);
            this.lblGarantiaStatus.TabIndex = 33;
            this.lblGarantiaStatus.Text = "Sem garantia";
            // 
            // switchGarantia
            // 
            this.switchGarantia.BaseColor = System.Drawing.SystemColors.Control;
            this.switchGarantia.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.switchGarantia.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.switchGarantia.FillColor = System.Drawing.Color.White;
            this.switchGarantia.Location = new System.Drawing.Point(123, 460);
            this.switchGarantia.Name = "switchGarantia";
            this.switchGarantia.Size = new System.Drawing.Size(38, 20);
            this.switchGarantia.TabIndex = 31;
            this.switchGarantia.CheckedChanged += new System.EventHandler(this.switchGarantia_CheckedChanged);
            // 
            // lblMes3
            // 
            this.lblMes3.AutoSize = true;
            this.lblMes3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes3.ForeColor = System.Drawing.Color.White;
            this.lblMes3.Location = new System.Drawing.Point(228, 489);
            this.lblMes3.Name = "lblMes3";
            this.lblMes3.Size = new System.Drawing.Size(57, 17);
            this.lblMes3.TabIndex = 27;
            this.lblMes3.Text = "3 Meses";
            // 
            // checkboxTresMeses
            // 
            this.checkboxTresMeses.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.checkboxTresMeses.Checked = true;
            this.checkboxTresMeses.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkboxTresMeses.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkboxTresMeses.FillColor = System.Drawing.Color.White;
            this.checkboxTresMeses.Location = new System.Drawing.Point(206, 487);
            this.checkboxTresMeses.Name = "checkboxTresMeses";
            this.checkboxTresMeses.Size = new System.Drawing.Size(20, 20);
            this.checkboxTresMeses.TabIndex = 26;
            this.checkboxTresMeses.Click += new System.EventHandler(this.checkboxTresMeses_Click);
            // 
            // lblMes2
            // 
            this.lblMes2.AutoSize = true;
            this.lblMes2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes2.ForeColor = System.Drawing.Color.White;
            this.lblMes2.Location = new System.Drawing.Point(152, 488);
            this.lblMes2.Name = "lblMes2";
            this.lblMes2.Size = new System.Drawing.Size(57, 17);
            this.lblMes2.TabIndex = 25;
            this.lblMes2.Text = "2 Meses";
            // 
            // checkboxDoisMeses
            // 
            this.checkboxDoisMeses.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.checkboxDoisMeses.Checked = true;
            this.checkboxDoisMeses.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkboxDoisMeses.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkboxDoisMeses.FillColor = System.Drawing.Color.White;
            this.checkboxDoisMeses.Location = new System.Drawing.Point(133, 487);
            this.checkboxDoisMeses.Name = "checkboxDoisMeses";
            this.checkboxDoisMeses.Size = new System.Drawing.Size(20, 20);
            this.checkboxDoisMeses.TabIndex = 24;
            this.checkboxDoisMeses.Click += new System.EventHandler(this.checkboxDoisMeses_Click);
            // 
            // lblMes1
            // 
            this.lblMes1.AutoSize = true;
            this.lblMes1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes1.ForeColor = System.Drawing.Color.White;
            this.lblMes1.Location = new System.Drawing.Point(81, 489);
            this.lblMes1.Name = "lblMes1";
            this.lblMes1.Size = new System.Drawing.Size(44, 17);
            this.lblMes1.TabIndex = 23;
            this.lblMes1.Text = "1 Mes";
            // 
            // checkboxUmMes
            // 
            this.checkboxUmMes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.checkboxUmMes.Checked = true;
            this.checkboxUmMes.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkboxUmMes.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkboxUmMes.FillColor = System.Drawing.Color.White;
            this.checkboxUmMes.Location = new System.Drawing.Point(60, 487);
            this.checkboxUmMes.Name = "checkboxUmMes";
            this.checkboxUmMes.Size = new System.Drawing.Size(20, 20);
            this.checkboxUmMes.TabIndex = 22;
            this.checkboxUmMes.Click += new System.EventHandler(this.checkboxUmMes_Click);
            // 
            // txtGarantia
            // 
            this.txtGarantia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtGarantia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGarantia.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.txtGarantia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.ForeColor = System.Drawing.Color.Silver;
            this.txtGarantia.LineColor = System.Drawing.Color.Gainsboro;
            this.txtGarantia.Location = new System.Drawing.Point(60, 513);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.PasswordChar = '\0';
            this.txtGarantia.SelectedText = "";
            this.txtGarantia.Size = new System.Drawing.Size(213, 32);
            this.txtGarantia.TabIndex = 21;
            this.txtGarantia.Text = "Nenhuma acima? especifique aqui";
            this.txtGarantia.Enter += new System.EventHandler(this.txtGarantia_Enter);
            this.txtGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGarantia_KeyPress);
            this.txtGarantia.Leave += new System.EventHandler(this.txtGarantia_Leave);
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblGarantia.Location = new System.Drawing.Point(57, 460);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(60, 17);
            this.lblGarantia.TabIndex = 20;
            this.lblGarantia.Text = "Garantia:";
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.iconClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.iconClose.IconSize = 29;
            this.iconClose.Location = new System.Drawing.Point(304, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconClose.Size = new System.Drawing.Size(29, 29);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconClose.TabIndex = 19;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaPanel1.Location = new System.Drawing.Point(0, 622);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(333, 5);
            this.gunaPanel1.TabIndex = 18;
            // 
            // lblArquivoPadrao
            // 
            this.lblArquivoPadrao.AutoSize = true;
            this.lblArquivoPadrao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoPadrao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArquivoPadrao.Location = new System.Drawing.Point(124, 57);
            this.lblArquivoPadrao.Name = "lblArquivoPadrao";
            this.lblArquivoPadrao.Size = new System.Drawing.Size(85, 17);
            this.lblArquivoPadrao.TabIndex = 17;
            this.lblArquivoPadrao.Text = "Pasta Padrao";
            // 
            // lblImpressoraPdrao
            // 
            this.lblImpressoraPdrao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpressoraPdrao.AutoSize = true;
            this.lblImpressoraPdrao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpressoraPdrao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblImpressoraPdrao.Location = new System.Drawing.Point(106, 654);
            this.lblImpressoraPdrao.Name = "lblImpressoraPdrao";
            this.lblImpressoraPdrao.Size = new System.Drawing.Size(104, 17);
            this.lblImpressoraPdrao.TabIndex = 16;
            this.lblImpressoraPdrao.Text = "Doro PDF Writer";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(106, 634);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(123, 17);
            this.gunaLabel6.TabIndex = 15;
            this.gunaLabel6.Text = "Impressora Padrão:";
            // 
            // btnPastaPadrao
            // 
            this.btnPastaPadrao.AnimationHoverSpeed = 0.07F;
            this.btnPastaPadrao.AnimationSpeed = 0.03F;
            this.btnPastaPadrao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnPastaPadrao.BorderColor = System.Drawing.Color.Black;
            this.btnPastaPadrao.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPastaPadrao.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPastaPadrao.CheckedForeColor = System.Drawing.Color.White;
            this.btnPastaPadrao.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPastaPadrao.CheckedImage")));
            this.btnPastaPadrao.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPastaPadrao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPastaPadrao.FocusedColor = System.Drawing.Color.Empty;
            this.btnPastaPadrao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPastaPadrao.ForeColor = System.Drawing.Color.White;
            this.btnPastaPadrao.Image = null;
            this.btnPastaPadrao.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPastaPadrao.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPastaPadrao.Location = new System.Drawing.Point(178, 28);
            this.btnPastaPadrao.Name = "btnPastaPadrao";
            this.btnPastaPadrao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPastaPadrao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPastaPadrao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPastaPadrao.OnHoverImage = null;
            this.btnPastaPadrao.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPastaPadrao.OnPressedColor = System.Drawing.Color.Black;
            this.btnPastaPadrao.Size = new System.Drawing.Size(152, 27);
            this.btnPastaPadrao.TabIndex = 14;
            this.btnPastaPadrao.Text = "Restaurar Pasta Padrao";
            this.btnPastaPadrao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPastaPadrao.Click += new System.EventHandler(this.btnPastaPadrao_Click);
            // 
            // tFilename
            // 
            this.tFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tFilename.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.tFilename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tFilename.LineColor = System.Drawing.Color.Gainsboro;
            this.tFilename.Location = new System.Drawing.Point(5, 79);
            this.tFilename.Name = "tFilename";
            this.tFilename.PasswordChar = '\0';
            this.tFilename.SelectedText = "";
            this.tFilename.Size = new System.Drawing.Size(324, 26);
            this.tFilename.TabIndex = 13;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPF.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.White;
            this.txtCPF.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCPF.Location = new System.Drawing.Point(60, 340);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.SelectedText = "";
            this.txtCPF.Size = new System.Drawing.Size(213, 32);
            this.txtCPF.TabIndex = 12;
            this.txtCPF.Text = "000.222.333-99";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCliente.Location = new System.Drawing.Point(60, 130);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.SelectedText = "";
            this.txtCliente.Size = new System.Drawing.Size(213, 32);
            this.txtCliente.TabIndex = 11;
            this.txtCliente.Text = "Cleison me Paga!!";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.LineColor = System.Drawing.Color.Gainsboro;
            this.txtValor.Location = new System.Drawing.Point(60, 410);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(213, 32);
            this.txtValor.TabIndex = 10;
            this.txtValor.Text = "R$ 3.000,00";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.LineColor = System.Drawing.Color.Gainsboro;
            this.txtModelo.Location = new System.Drawing.Point(60, 270);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.SelectedText = "";
            this.txtModelo.Size = new System.Drawing.Size(213, 32);
            this.txtModelo.TabIndex = 9;
            this.txtModelo.Text = "Pode ser só 3mil reais";
            // 
            // txtServico
            // 
            this.txtServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtServico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServico.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.txtServico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.ForeColor = System.Drawing.Color.White;
            this.txtServico.LineColor = System.Drawing.Color.Gainsboro;
            this.txtServico.Location = new System.Drawing.Point(60, 200);
            this.txtServico.Name = "txtServico";
            this.txtServico.PasswordChar = '\0';
            this.txtServico.SelectedText = "";
            this.txtServico.Size = new System.Drawing.Size(213, 32);
            this.txtServico.TabIndex = 8;
            this.txtServico.Text = "To Sofrendo!";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaLabel5.Location = new System.Drawing.Point(57, 320);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(32, 17);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "CPF:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaLabel4.Location = new System.Drawing.Point(57, 110);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(50, 17);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Cliente:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaLabel3.Location = new System.Drawing.Point(57, 390);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(41, 17);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Valor:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaLabel2.Location = new System.Drawing.Point(57, 250);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 17);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Aparelho:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaLabel1.Location = new System.Drawing.Point(57, 180);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 17);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Serviço:";
            // 
            // btnCarregarWord
            // 
            this.btnCarregarWord.AnimationHoverSpeed = 0.07F;
            this.btnCarregarWord.AnimationSpeed = 0.03F;
            this.btnCarregarWord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnCarregarWord.BorderColor = System.Drawing.Color.Black;
            this.btnCarregarWord.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCarregarWord.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCarregarWord.CheckedForeColor = System.Drawing.Color.White;
            this.btnCarregarWord.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCarregarWord.CheckedImage")));
            this.btnCarregarWord.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCarregarWord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCarregarWord.FocusedColor = System.Drawing.Color.Empty;
            this.btnCarregarWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCarregarWord.ForeColor = System.Drawing.Color.White;
            this.btnCarregarWord.Image = null;
            this.btnCarregarWord.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCarregarWord.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCarregarWord.Location = new System.Drawing.Point(6, 28);
            this.btnCarregarWord.Name = "btnCarregarWord";
            this.btnCarregarWord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCarregarWord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCarregarWord.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCarregarWord.OnHoverImage = null;
            this.btnCarregarWord.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCarregarWord.OnPressedColor = System.Drawing.Color.Black;
            this.btnCarregarWord.Size = new System.Drawing.Size(152, 27);
            this.btnCarregarWord.TabIndex = 2;
            this.btnCarregarWord.Text = "Carregar Template Word";
            this.btnCarregarWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCarregarWord.Click += new System.EventHandler(this.btnCarregarWord_Click);
            // 
            // btnCriarWord
            // 
            this.btnCriarWord.AccessibleDescription = "Imprimir nota para cliente";
            this.btnCriarWord.Animated = true;
            this.btnCriarWord.AnimationHoverSpeed = 0.07F;
            this.btnCriarWord.AnimationSpeed = 0.03F;
            this.btnCriarWord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnCriarWord.BorderColor = System.Drawing.Color.Black;
            this.btnCriarWord.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCriarWord.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCriarWord.CheckedForeColor = System.Drawing.Color.White;
            this.btnCriarWord.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCriarWord.CheckedImage")));
            this.btnCriarWord.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCriarWord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCriarWord.FocusedColor = System.Drawing.Color.Empty;
            this.btnCriarWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCriarWord.ForeColor = System.Drawing.Color.White;
            this.btnCriarWord.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_print_512px;
            this.btnCriarWord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCriarWord.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCriarWord.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCriarWord.Location = new System.Drawing.Point(137, 554);
            this.btnCriarWord.Name = "btnCriarWord";
            this.btnCriarWord.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnCriarWord.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCriarWord.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCriarWord.OnHoverImage = null;
            this.btnCriarWord.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCriarWord.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnCriarWord.Size = new System.Drawing.Size(59, 60);
            this.btnCriarWord.TabIndex = 1;
            this.btnCriarWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCriarWord.Click += new System.EventHandler(this.btnCriarWord_Click);
            // 
            // LoadDoc
            // 
            this.LoadDoc.FileName = "openFileDialog1";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // form_WordNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 679);
            this.Controls.Add(this.panelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_WordNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_WordNota";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_WordNota_FormClosing);
            this.Load += new System.EventHandler(this.form_WordNota_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_WordNota_KeyDown);
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btnCriarWord;
        private Guna.UI.WinForms.GunaPanel panelDrag;
        private Guna.UI.WinForms.GunaAdvenceButton btnCarregarWord;
        private System.Windows.Forms.SaveFileDialog SaveDoc;
        private System.Windows.Forms.OpenFileDialog LoadDoc;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox tFilename;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaAdvenceButton btnPastaPadrao;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI.WinForms.GunaLabel lblImpressoraPdrao;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        public Guna.UI.WinForms.GunaLineTextBox txtServico;
        public Guna.UI.WinForms.GunaLineTextBox txtCPF;
        public Guna.UI.WinForms.GunaLineTextBox txtCliente;
        public Guna.UI.WinForms.GunaLineTextBox txtValor;
        public Guna.UI.WinForms.GunaLineTextBox txtModelo;
        private Guna.UI.WinForms.GunaLabel lblArquivoPadrao;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private Guna.UI.WinForms.GunaMediumCheckBox checkboxUmMes;
        public Guna.UI.WinForms.GunaLineTextBox txtGarantia;
        private Guna.UI.WinForms.GunaLabel lblGarantia;
        private Guna.UI.WinForms.GunaLabel lblMes3;
        private Guna.UI.WinForms.GunaMediumCheckBox checkboxTresMeses;
        private Guna.UI.WinForms.GunaLabel lblMes2;
        private Guna.UI.WinForms.GunaMediumCheckBox checkboxDoisMeses;
        private Guna.UI.WinForms.GunaLabel lblMes1;
        private Guna.UI.WinForms.GunaGoogleSwitch switchGarantia;
        private Guna.UI.WinForms.GunaLabel lblGarantiaStatus;
        public Guna.UI.WinForms.GunaLabel lblIDCliente;
        public Guna.UI.WinForms.GunaLabel lblIDServico;
    }
}