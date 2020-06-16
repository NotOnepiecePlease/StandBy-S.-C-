namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Lucros_Gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Lucros_Gastos));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnInserirGasto = new Guna.UI.WinForms.GunaAdvenceButton();
            this.radioGastoTemp = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.radioGastoReal = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.lblGastos = new Guna.UI.WinForms.GunaLabel();
            this.txtValor = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtProduto = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.btnInserirGasto);
            this.gunaPanel1.Controls.Add(this.radioGastoTemp);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.radioGastoReal);
            this.gunaPanel1.Controls.Add(this.lblGastos);
            this.gunaPanel1.Controls.Add(this.txtValor);
            this.gunaPanel1.Controls.Add(this.txtProduto);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(253, 265);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(33, 94);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel3.TabIndex = 33;
            this.gunaLabel3.Text = "Valor R$";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(33, 16);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(50, 15);
            this.gunaLabel2.TabIndex = 32;
            this.gunaLabel2.Text = "Produto";
            // 
            // btnInserirGasto
            // 
            this.btnInserirGasto.AnimationHoverSpeed = 0.07F;
            this.btnInserirGasto.AnimationSpeed = 0.03F;
            this.btnInserirGasto.BaseColor = System.Drawing.Color.Black;
            this.btnInserirGasto.BorderColor = System.Drawing.Color.Black;
            this.btnInserirGasto.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnInserirGasto.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnInserirGasto.CheckedForeColor = System.Drawing.Color.White;
            this.btnInserirGasto.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnInserirGasto.CheckedImage")));
            this.btnInserirGasto.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnInserirGasto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInserirGasto.FocusedColor = System.Drawing.Color.Empty;
            this.btnInserirGasto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInserirGasto.ForeColor = System.Drawing.Color.White;
            this.btnInserirGasto.Image = null;
            this.btnInserirGasto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInserirGasto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInserirGasto.Location = new System.Drawing.Point(36, 189);
            this.btnInserirGasto.Name = "btnInserirGasto";
            this.btnInserirGasto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnInserirGasto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInserirGasto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInserirGasto.OnHoverImage = null;
            this.btnInserirGasto.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInserirGasto.OnPressedColor = System.Drawing.Color.Black;
            this.btnInserirGasto.Size = new System.Drawing.Size(184, 42);
            this.btnInserirGasto.TabIndex = 31;
            this.btnInserirGasto.Text = "Inserir Gasto";
            this.btnInserirGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInserirGasto.Click += new System.EventHandler(this.btnInserirGasto_Click);
            // 
            // radioGastoTemp
            // 
            this.radioGastoTemp.BaseColor = System.Drawing.Color.White;
            this.radioGastoTemp.Checked = true;
            this.radioGastoTemp.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioGastoTemp.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.radioGastoTemp.FillColor = System.Drawing.Color.White;
            this.radioGastoTemp.Location = new System.Drawing.Point(127, 149);
            this.radioGastoTemp.Name = "radioGastoTemp";
            this.radioGastoTemp.Size = new System.Drawing.Size(20, 20);
            this.radioGastoTemp.TabIndex = 30;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(153, 152);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 15);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Gasto Temp";
            // 
            // radioGastoReal
            // 
            this.radioGastoReal.BaseColor = System.Drawing.Color.White;
            this.radioGastoReal.CheckedOffColor = System.Drawing.Color.Gray;
            this.radioGastoReal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.radioGastoReal.FillColor = System.Drawing.Color.White;
            this.radioGastoReal.Location = new System.Drawing.Point(32, 149);
            this.radioGastoReal.Name = "radioGastoReal";
            this.radioGastoReal.Size = new System.Drawing.Size(20, 20);
            this.radioGastoReal.TabIndex = 28;
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGastos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGastos.Location = new System.Drawing.Point(55, 152);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(62, 15);
            this.lblGastos.TabIndex = 27;
            this.lblGastos.Text = "Gasto Real";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValor.ForeColor = System.Drawing.SystemColors.Control;
            this.txtValor.LineColor = System.Drawing.Color.Gainsboro;
            this.txtValor.Location = new System.Drawing.Point(36, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.Size = new System.Drawing.Size(184, 26);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "R$ 0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.txtProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProduto.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProduto.ForeColor = System.Drawing.SystemColors.Control;
            this.txtProduto.LineColor = System.Drawing.Color.Gainsboro;
            this.txtProduto.Location = new System.Drawing.Point(36, 35);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.PasswordChar = '\0';
            this.txtProduto.SelectedText = "";
            this.txtProduto.Size = new System.Drawing.Size(184, 26);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // form_Lucros_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 265);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_Lucros_Gastos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Gastos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Lucros_Gastos_KeyDown);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLineTextBox txtProduto;
        private Guna.UI.WinForms.GunaLineTextBox txtValor;
        private Guna.UI.WinForms.GunaMediumRadioButton radioGastoTemp;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaMediumRadioButton radioGastoReal;
        private Guna.UI.WinForms.GunaLabel lblGastos;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnInserirGasto;
    }
}