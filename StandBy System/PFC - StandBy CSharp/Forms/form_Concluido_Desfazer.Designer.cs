namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Concluido_Desfazer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Concluido_Desfazer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblData = new Guna.UI.WinForms.GunaLabel();
            this.lblNomeCliente = new Guna.UI.WinForms.GunaLabel();
            this.lblAparelho = new Guna.UI.WinForms.GunaLabel();
            this.lblDefeito = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnConfirmar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNegar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblIDServico = new Guna.UI.WinForms.GunaLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Controls.Add(this.panelBottom);
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Controls.Add(this.lblIDServico);
            this.panel1.Controls.Add(this.btnNegar);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.lblDefeito);
            this.panel1.Controls.Add(this.lblAparelho);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 485);
            this.panel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(32, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(377, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Deseja desfazer a conclusão desse serviço?";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(161, 77);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(118, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Data do Serviço:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(191, 142);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(58, 20);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Cliente:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(184, 207);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(73, 20);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Aparelho:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(189, 272);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(62, 20);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Defeito:";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblData.Location = new System.Drawing.Point(174, 97);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 21);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "18/06/2020";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(119, 162);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(202, 21);
            this.lblNomeCliente.TabIndex = 7;
            this.lblNomeCliente.Text = "Adriano Fraga de Andrade";
            // 
            // lblAparelho
            // 
            this.lblAparelho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAparelho.AutoSize = true;
            this.lblAparelho.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAparelho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblAparelho.Location = new System.Drawing.Point(146, 227);
            this.lblAparelho.Name = "lblAparelho";
            this.lblAparelho.Size = new System.Drawing.Size(149, 21);
            this.lblAparelho.TabIndex = 8;
            this.lblAparelho.Text = "Samsung Galaxy S8";
            // 
            // lblDefeito
            // 
            this.lblDefeito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefeito.AutoSize = true;
            this.lblDefeito.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefeito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblDefeito.Location = new System.Drawing.Point(164, 292);
            this.lblDefeito.Name = "lblDefeito";
            this.lblDefeito.Size = new System.Drawing.Size(112, 21);
            this.lblDefeito.TabIndex = 9;
            this.lblDefeito.Text = "Tela quebrada";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Yellow;
            this.gunaLabel6.Location = new System.Drawing.Point(7, 410);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(426, 63);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "Desfazer um serviço cancela automaticamente a garantia,\r\nou seja, ela deixará de " +
    "existir no banco de dados, \r\ntem certeza que deseja desfazer?";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AnimationHoverSpeed = 0.07F;
            this.btnConfirmar.AnimationSpeed = 0.03F;
            this.btnConfirmar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnConfirmar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.CheckedForeColor = System.Drawing.Color.White;
            this.btnConfirmar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.CheckedImage")));
            this.btnConfirmar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmar.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = null;
            this.btnConfirmar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirmar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConfirmar.Location = new System.Drawing.Point(113, 349);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmar.OnHoverImage = null;
            this.btnConfirmar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConfirmar.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmar.Size = new System.Drawing.Size(69, 42);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "SIM";
            this.btnConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNegar
            // 
            this.btnNegar.AnimationHoverSpeed = 0.07F;
            this.btnNegar.AnimationSpeed = 0.03F;
            this.btnNegar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnNegar.BorderColor = System.Drawing.Color.Black;
            this.btnNegar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnNegar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnNegar.CheckedForeColor = System.Drawing.Color.White;
            this.btnNegar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnNegar.CheckedImage")));
            this.btnNegar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnNegar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNegar.FocusedColor = System.Drawing.Color.Empty;
            this.btnNegar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegar.ForeColor = System.Drawing.Color.White;
            this.btnNegar.Image = null;
            this.btnNegar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNegar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNegar.Location = new System.Drawing.Point(256, 349);
            this.btnNegar.Name = "btnNegar";
            this.btnNegar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnNegar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNegar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNegar.OnHoverImage = null;
            this.btnNegar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnNegar.OnPressedColor = System.Drawing.Color.Black;
            this.btnNegar.Size = new System.Drawing.Size(69, 42);
            this.btnNegar.TabIndex = 12;
            this.btnNegar.Text = "NÃO";
            this.btnNegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNegar.Click += new System.EventHandler(this.btnNegar_Click);
            // 
            // lblIDServico
            // 
            this.lblIDServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblIDServico.Location = new System.Drawing.Point(356, 54);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(81, 21);
            this.lblIDServico.TabIndex = 13;
            this.lblIDServico.Text = "IDServico";
            this.lblIDServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIDServico.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelTop.Location = new System.Drawing.Point(0, -5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(446, 10);
            this.panelTop.TabIndex = 14;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelLeft.Location = new System.Drawing.Point(-6, -5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 491);
            this.panelLeft.TabIndex = 15;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelBottom.Location = new System.Drawing.Point(-1, 480);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(446, 10);
            this.panelBottom.TabIndex = 15;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelRight.Location = new System.Drawing.Point(437, -5);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(10, 491);
            this.panelRight.TabIndex = 16;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // form_Concluido_Desfazer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 485);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_Concluido_Desfazer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Concluido_Desfazer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Concluido_Desfazer_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnNegar;
        private Guna.UI.WinForms.GunaAdvenceButton btnConfirmar;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        public Guna.UI.WinForms.GunaLabel lblIDServico;
        public Guna.UI.WinForms.GunaLabel lblDefeito;
        public Guna.UI.WinForms.GunaLabel lblAparelho;
        public Guna.UI.WinForms.GunaLabel lblNomeCliente;
        public Guna.UI.WinForms.GunaLabel lblData;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}