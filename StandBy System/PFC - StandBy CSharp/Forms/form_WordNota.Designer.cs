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
            this.SaveDoc = new System.Windows.Forms.SaveFileDialog();
            this.LoadDoc = new System.Windows.Forms.OpenFileDialog();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.lblImpressoraPdrao = new Guna.UI.WinForms.GunaLabel();
            this.lblArquivoPadrao = new Guna.UI.WinForms.GunaLabel();
            this.btnPastaPadrao = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCarregarWord = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCriarWord = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
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
            this.panelDrag.Size = new System.Drawing.Size(333, 638);
            this.panelDrag.TabIndex = 2;
            // 
            // tFilename
            // 
            this.tFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tFilename.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.tFilename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tFilename.LineColor = System.Drawing.Color.Gainsboro;
            this.tFilename.Location = new System.Drawing.Point(5, 97);
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
            this.txtCPF.Location = new System.Drawing.Point(60, 365);
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
            this.txtCliente.Location = new System.Drawing.Point(60, 155);
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
            this.txtValor.Location = new System.Drawing.Point(60, 435);
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
            this.txtModelo.Location = new System.Drawing.Point(60, 295);
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
            this.txtServico.Location = new System.Drawing.Point(60, 225);
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
            this.gunaLabel5.Location = new System.Drawing.Point(57, 345);
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
            this.gunaLabel4.Location = new System.Drawing.Point(57, 135);
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
            this.gunaLabel3.Location = new System.Drawing.Point(57, 415);
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
            this.gunaLabel2.Location = new System.Drawing.Point(57, 275);
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
            this.gunaLabel1.Location = new System.Drawing.Point(57, 205);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 17);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Serviço:";
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
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(106, 570);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(123, 17);
            this.gunaLabel6.TabIndex = 15;
            this.gunaLabel6.Text = "Impressora Padrão:";
            // 
            // lblImpressoraPdrao
            // 
            this.lblImpressoraPdrao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImpressoraPdrao.AutoSize = true;
            this.lblImpressoraPdrao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpressoraPdrao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblImpressoraPdrao.Location = new System.Drawing.Point(106, 600);
            this.lblImpressoraPdrao.Name = "lblImpressoraPdrao";
            this.lblImpressoraPdrao.Size = new System.Drawing.Size(104, 17);
            this.lblImpressoraPdrao.TabIndex = 16;
            this.lblImpressoraPdrao.Text = "Doro PDF Writer";
            // 
            // lblArquivoPadrao
            // 
            this.lblArquivoPadrao.AutoSize = true;
            this.lblArquivoPadrao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoPadrao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArquivoPadrao.Location = new System.Drawing.Point(124, 73);
            this.lblArquivoPadrao.Name = "lblArquivoPadrao";
            this.lblArquivoPadrao.Size = new System.Drawing.Size(85, 17);
            this.lblArquivoPadrao.TabIndex = 17;
            this.lblArquivoPadrao.Text = "Pasta Padrao";
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
            this.btnCriarWord.Location = new System.Drawing.Point(137, 480);
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
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaPanel1.Location = new System.Drawing.Point(0, 553);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(333, 5);
            this.gunaPanel1.TabIndex = 18;
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
            // form_WordNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 638);
            this.Controls.Add(this.panelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}