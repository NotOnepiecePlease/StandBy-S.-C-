namespace PFC___StandBy_CSharp.Forms
{
    partial class form_QntdGarantia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_QntdGarantia));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblIDCliente = new Guna.UI.WinForms.GunaLabel();
            this.lblIDServico = new Guna.UI.WinForms.GunaLabel();
            this.btnConcluirServico = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtGarantiaDias = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.gunaPanel1.Controls.Add(this.lblIDCliente);
            this.gunaPanel1.Controls.Add(this.lblIDServico);
            this.gunaPanel1.Controls.Add(this.btnConcluirServico);
            this.gunaPanel1.Controls.Add(this.txtGarantiaDias);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(283, 181);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblIDCliente.Location = new System.Drawing.Point(146, 9);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(59, 17);
            this.lblIDCliente.TabIndex = 37;
            this.lblIDCliente.Text = "IDCliente";
            this.lblIDCliente.Visible = false;
            // 
            // lblIDServico
            // 
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.lblIDServico.Location = new System.Drawing.Point(78, 9);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(62, 17);
            this.lblIDServico.TabIndex = 36;
            this.lblIDServico.Text = "IDServico";
            this.lblIDServico.Visible = false;
            // 
            // btnConcluirServico
            // 
            this.btnConcluirServico.AccessibleDescription = "GerarImpressaoNota nota para cliente";
            this.btnConcluirServico.Animated = true;
            this.btnConcluirServico.AnimationHoverSpeed = 0.07F;
            this.btnConcluirServico.AnimationSpeed = 0.03F;
            this.btnConcluirServico.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnConcluirServico.BorderColor = System.Drawing.Color.Black;
            this.btnConcluirServico.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnConcluirServico.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnConcluirServico.CheckedForeColor = System.Drawing.Color.White;
            this.btnConcluirServico.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnConcluirServico.CheckedImage")));
            this.btnConcluirServico.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnConcluirServico.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConcluirServico.FocusedColor = System.Drawing.Color.Empty;
            this.btnConcluirServico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConcluirServico.ForeColor = System.Drawing.Color.White;
            this.btnConcluirServico.Image = null;
            this.btnConcluirServico.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConcluirServico.ImageSize = new System.Drawing.Size(40, 40);
            this.btnConcluirServico.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConcluirServico.Location = new System.Drawing.Point(77, 125);
            this.btnConcluirServico.Name = "btnConcluirServico";
            this.btnConcluirServico.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnConcluirServico.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConcluirServico.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConcluirServico.OnHoverImage = null;
            this.btnConcluirServico.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConcluirServico.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnConcluirServico.Size = new System.Drawing.Size(128, 32);
            this.btnConcluirServico.TabIndex = 2;
            this.btnConcluirServico.Text = "Concluir Serviço";
            this.btnConcluirServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConcluirServico.Click += new System.EventHandler(this.btnConcluirServico_Click);
            // 
            // txtGarantiaDias
            // 
            this.txtGarantiaDias.BackColor = System.Drawing.Color.White;
            this.txtGarantiaDias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGarantiaDias.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGarantiaDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGarantiaDias.LineColor = System.Drawing.Color.Gainsboro;
            this.txtGarantiaDias.Location = new System.Drawing.Point(61, 76);
            this.txtGarantiaDias.Name = "txtGarantiaDias";
            this.txtGarantiaDias.PasswordChar = '\0';
            this.txtGarantiaDias.SelectedText = "";
            this.txtGarantiaDias.Size = new System.Drawing.Size(160, 26);
            this.txtGarantiaDias.TabIndex = 1;
            this.txtGarantiaDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(25, 32);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(232, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Quantos dias de garantia?";
            // 
            // form_QntdGarantia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 181);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_QntdGarantia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_QntdGarantia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_QntdGarantia_KeyDown);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtGarantiaDias;
        private Guna.UI.WinForms.GunaAdvenceButton btnConcluirServico;
        public Guna.UI.WinForms.GunaLabel lblIDCliente;
        public Guna.UI.WinForms.GunaLabel lblIDServico;
    }
}