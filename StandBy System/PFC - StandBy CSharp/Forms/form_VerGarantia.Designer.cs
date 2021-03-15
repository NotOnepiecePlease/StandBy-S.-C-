namespace PFC___StandBy_CSharp.Forms
{
    partial class form_VerGarantia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_VerGarantia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSemGarantia = new Guna.UI.WinForms.GunaLabel();
            this.lblDiasDeGarantia = new Guna.UI.WinForms.GunaLabel();
            this.lblIDServico = new Guna.UI.WinForms.GunaLabel();
            this.btnConfirmar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblDataFinal = new Guna.UI.WinForms.GunaLabel();
            this.lblDataInicial = new Guna.UI.WinForms.GunaLabel();
            this.lblServico = new Guna.UI.WinForms.GunaLabel();
            this.lblAparelho = new Guna.UI.WinForms.GunaLabel();
            this.lblNomeCliente = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblDiasQueFaltam = new Guna.UI.WinForms.GunaLabel();
            this.panelGarantia = new Guna.UI.WinForms.GunaLinePanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblDiasQueFaltam);
            this.panel1.Controls.Add(this.lblSemGarantia);
            this.panel1.Controls.Add(this.lblDiasDeGarantia);
            this.panel1.Controls.Add(this.lblIDServico);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.lblDataFinal);
            this.panel1.Controls.Add(this.lblDataInicial);
            this.panel1.Controls.Add(this.lblServico);
            this.panel1.Controls.Add(this.lblAparelho);
            this.panel1.Controls.Add(this.lblNomeCliente);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.panelGarantia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 516);
            this.panel1.TabIndex = 0;
            // 
            // lblSemGarantia
            // 
            this.lblSemGarantia.AutoSize = true;
            this.lblSemGarantia.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemGarantia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSemGarantia.Location = new System.Drawing.Point(39, 209);
            this.lblSemGarantia.Name = "lblSemGarantia";
            this.lblSemGarantia.Size = new System.Drawing.Size(265, 47);
            this.lblSemGarantia.TabIndex = 14;
            this.lblSemGarantia.Text = "SEM GARANTIA";
            // 
            // lblDiasDeGarantia
            // 
            this.lblDiasDeGarantia.AutoSize = true;
            this.lblDiasDeGarantia.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasDeGarantia.ForeColor = System.Drawing.Color.Lime;
            this.lblDiasDeGarantia.Location = new System.Drawing.Point(111, 404);
            this.lblDiasDeGarantia.Name = "lblDiasDeGarantia";
            this.lblDiasDeGarantia.Size = new System.Drawing.Size(41, 20);
            this.lblDiasDeGarantia.TabIndex = 13;
            this.lblDiasDeGarantia.Text = "teste";
            // 
            // lblIDServico
            // 
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblIDServico.Location = new System.Drawing.Point(254, 60);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(76, 21);
            this.lblIDServico.TabIndex = 12;
            this.lblIDServico.Text = "IDServico";
            this.lblIDServico.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AnimationHoverSpeed = 0.07F;
            this.btnConfirmar.AnimationSpeed = 0.03F;
            this.btnConfirmar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnConfirmar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.CheckedForeColor = System.Drawing.Color.White;
            this.btnConfirmar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.CheckedImage")));
            this.btnConfirmar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmar.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = null;
            this.btnConfirmar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirmar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConfirmar.Location = new System.Drawing.Point(81, 461);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmar.OnHoverImage = null;
            this.btnConfirmar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConfirmar.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmar.Size = new System.Drawing.Size(180, 42);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblDataFinal.Location = new System.Drawing.Point(124, 364);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(94, 21);
            this.lblDataFinal.TabIndex = 10;
            this.lblDataFinal.Text = "30/06/2020";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblDataInicial.Location = new System.Drawing.Point(124, 297);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(94, 21);
            this.lblDataInicial.TabIndex = 9;
            this.lblDataInicial.Text = "19/06/2020";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblServico.Location = new System.Drawing.Point(122, 230);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(98, 21);
            this.lblServico.TabIndex = 8;
            this.lblServico.Text = "Troca da Tela";
            // 
            // lblAparelho
            // 
            this.lblAparelho.AutoSize = true;
            this.lblAparelho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAparelho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblAparelho.Location = new System.Drawing.Point(92, 163);
            this.lblAparelho.Name = "lblAparelho";
            this.lblAparelho.Size = new System.Drawing.Size(158, 21);
            this.lblAparelho.TabIndex = 7;
            this.lblAparelho.Text = "Samsung Galaxy S8+";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(75, 96);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(192, 21);
            this.lblNomeCliente.TabIndex = 6;
            this.lblNomeCliente.Text = "Adriano Fraga de Andrade";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(100, 343);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(142, 21);
            this.gunaLabel6.TabIndex = 5;
            this.gunaLabel6.Text = "Garantia acaba em:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(108, 276);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(127, 21);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Data da Emissão:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(139, 209);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(64, 21);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Serviço:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(133, 142);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Aparelho:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(143, 75);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(56, 21);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Nome:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(28, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(286, 47);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Garantia StandBy";
            // 
            // lblDiasQueFaltam
            // 
            this.lblDiasQueFaltam.AutoSize = true;
            this.lblDiasQueFaltam.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasQueFaltam.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblDiasQueFaltam.Location = new System.Drawing.Point(111, 428);
            this.lblDiasQueFaltam.Name = "lblDiasQueFaltam";
            this.lblDiasQueFaltam.Size = new System.Drawing.Size(41, 20);
            this.lblDiasQueFaltam.TabIndex = 15;
            this.lblDiasQueFaltam.Text = "teste";
            // 
            // panelGarantia
            // 
            this.panelGarantia.LineBottom = 3;
            this.panelGarantia.LineColor = System.Drawing.Color.White;
            this.panelGarantia.LineLeft = 3;
            this.panelGarantia.LineRight = 3;
            this.panelGarantia.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.panelGarantia.LineTop = 3;
            this.panelGarantia.Location = new System.Drawing.Point(79, 400);
            this.panelGarantia.Name = "panelGarantia";
            this.panelGarantia.Size = new System.Drawing.Size(182, 53);
            this.panelGarantia.TabIndex = 16;
            // 
            // form_VerGarantia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_VerGarantia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_VerGarantia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_VerGarantia_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnConfirmar;
        public Guna.UI.WinForms.GunaLabel lblNomeCliente;
        public Guna.UI.WinForms.GunaLabel lblAparelho;
        public Guna.UI.WinForms.GunaLabel lblServico;
        public Guna.UI.WinForms.GunaLabel lblDataInicial;
        public Guna.UI.WinForms.GunaLabel lblDataFinal;
        public Guna.UI.WinForms.GunaLabel lblIDServico;
        public Guna.UI.WinForms.GunaLabel lblDiasDeGarantia;
        public Guna.UI.WinForms.GunaLabel lblSemGarantia;
        public Guna.UI.WinForms.GunaLabel lblDiasQueFaltam;
        private Guna.UI.WinForms.GunaLinePanel panelGarantia;
    }
}