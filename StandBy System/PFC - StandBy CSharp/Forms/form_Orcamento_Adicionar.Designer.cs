namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Orcamento_Adicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Orcamento_Adicionar));
            this.panelCentral = new Guna.UI.WinForms.GunaPanel();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtTotal = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtValor = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPeca = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtModelo = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cmbMarca = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.panelCentral.Controls.Add(this.btnAdd);
            this.panelCentral.Controls.Add(this.txtTotal);
            this.panelCentral.Controls.Add(this.gunaLabel5);
            this.panelCentral.Controls.Add(this.txtValor);
            this.panelCentral.Controls.Add(this.txtPeca);
            this.panelCentral.Controls.Add(this.txtModelo);
            this.panelCentral.Controls.Add(this.gunaLabel4);
            this.panelCentral.Controls.Add(this.gunaLabel3);
            this.panelCentral.Controls.Add(this.gunaLabel2);
            this.panelCentral.Controls.Add(this.cmbMarca);
            this.panelCentral.Controls.Add(this.gunaLabel1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(253, 417);
            this.panelCentral.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.Black;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_add_512px;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(103, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(48, 42);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTotal.Location = new System.Drawing.Point(37, 317);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(181, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(33, 294);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(45, 20);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Total:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValor.LineColor = System.Drawing.Color.Gainsboro;
            this.txtValor.Location = new System.Drawing.Point(37, 251);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(181, 26);
            this.txtValor.TabIndex = 7;
            // 
            // txtPeca
            // 
            this.txtPeca.BackColor = System.Drawing.Color.White;
            this.txtPeca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeca.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPeca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPeca.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPeca.Location = new System.Drawing.Point(37, 185);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.PasswordChar = '\0';
            this.txtPeca.SelectedText = "";
            this.txtPeca.Size = new System.Drawing.Size(181, 26);
            this.txtPeca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.White;
            this.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelo.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModelo.LineColor = System.Drawing.Color.Gainsboro;
            this.txtModelo.Location = new System.Drawing.Point(37, 119);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.SelectedText = "";
            this.txtModelo.Size = new System.Drawing.Size(181, 26);
            this.txtModelo.TabIndex = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(33, 228);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(46, 20);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Valor:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(33, 162);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(42, 20);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Peça:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(33, 96);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Modelo:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.Color.Transparent;
            this.cmbMarca.BaseColor = System.Drawing.Color.White;
            this.cmbMarca.BorderColor = System.Drawing.Color.Silver;
            this.cmbMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMarca.ForeColor = System.Drawing.Color.Black;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "SAMSUNG",
            "ALCATEL",
            "XIAOMI",
            "IPHONE",
            "LG",
            "MOTOROLA",
            "ASUS",
            "LENOVO"});
            this.cmbMarca.Location = new System.Drawing.Point(37, 53);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbMarca.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbMarca.Size = new System.Drawing.Size(181, 26);
            this.cmbMarca.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(33, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Marca:";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelCentral;
            // 
            // form_Orcamento_Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 417);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_Orcamento_Adicionar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Orcamento_Adicionar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Orcamento_Adicionar_KeyDown);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelCentral;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaComboBox cmbMarca;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        public Guna.UI.WinForms.GunaLineTextBox txtTotal;
        public Guna.UI.WinForms.GunaLineTextBox txtValor;
        public Guna.UI.WinForms.GunaLineTextBox txtPeca;
        public Guna.UI.WinForms.GunaLineTextBox txtModelo;
    }
}