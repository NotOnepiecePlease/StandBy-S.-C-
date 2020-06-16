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
            this.cardFundo = new Bunifu.Framework.UI.BunifuCards();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.btnEditar = new Guna.UI.WinForms.GunaGradientButton();
            this.sep3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.iconTelefone = new FontAwesome.Sharp.IconPictureBox();
            this.sep2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.iconCPF = new FontAwesome.Sharp.IconPictureBox();
            this.sep1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.iconCliente = new FontAwesome.Sharp.IconPictureBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.cardFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFundo
            // 
            this.cardFundo.BackColor = System.Drawing.Color.Black;
            this.cardFundo.BorderRadius = 5;
            this.cardFundo.BottomSahddow = true;
            this.cardFundo.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.cardFundo.Controls.Add(this.lblID);
            this.cardFundo.Controls.Add(this.btnEditar);
            this.cardFundo.Controls.Add(this.sep3);
            this.cardFundo.Controls.Add(this.iconTelefone);
            this.cardFundo.Controls.Add(this.sep2);
            this.cardFundo.Controls.Add(this.txtTelefone);
            this.cardFundo.Controls.Add(this.iconCPF);
            this.cardFundo.Controls.Add(this.sep1);
            this.cardFundo.Controls.Add(this.txtCpf);
            this.cardFundo.Controls.Add(this.iconCliente);
            this.cardFundo.Controls.Add(this.txtNomeCliente);
            this.cardFundo.LeftSahddow = false;
            this.cardFundo.Location = new System.Drawing.Point(0, 0);
            this.cardFundo.Name = "cardFundo";
            this.cardFundo.RightSahddow = true;
            this.cardFundo.ShadowDepth = 20;
            this.cardFundo.Size = new System.Drawing.Size(393, 329);
            this.cardFundo.TabIndex = 0;
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
            this.btnEditar.Location = new System.Drawing.Point(110, 246);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.btnEditar.OnHoverBaseColor2 = System.Drawing.Color.White;
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Size = new System.Drawing.Size(160, 42);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // sep3
            // 
            this.sep3.BackColor = System.Drawing.Color.Transparent;
            this.sep3.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.sep3.GradientColor2 = System.Drawing.Color.DeepPink;
            this.sep3.Location = new System.Drawing.Point(69, 210);
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(243, 2);
            this.sep3.TabIndex = 6;
            // 
            // iconTelefone
            // 
            this.iconTelefone.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconTelefone.IconColor = System.Drawing.Color.White;
            this.iconTelefone.Location = new System.Drawing.Point(65, 181);
            this.iconTelefone.Name = "iconTelefone";
            this.iconTelefone.Size = new System.Drawing.Size(32, 32);
            this.iconTelefone.TabIndex = 5;
            this.iconTelefone.TabStop = false;
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.Color.Transparent;
            this.sep2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.sep2.GradientColor2 = System.Drawing.Color.DeepPink;
            this.sep2.Location = new System.Drawing.Point(69, 148);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(243, 2);
            this.sep2.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.Black;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTelefone.Location = new System.Drawing.Point(101, 186);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(205, 22);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.Text = "71992855223";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconCPF
            // 
            this.iconCPF.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconCPF.IconColor = System.Drawing.Color.White;
            this.iconCPF.Location = new System.Drawing.Point(65, 119);
            this.iconCPF.Name = "iconCPF";
            this.iconCPF.Size = new System.Drawing.Size(32, 32);
            this.iconCPF.TabIndex = 5;
            this.iconCPF.TabStop = false;
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.Color.Transparent;
            this.sep1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.sep1.GradientColor2 = System.Drawing.Color.DeepPink;
            this.sep1.Location = new System.Drawing.Point(69, 89);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(243, 2);
            this.sep1.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.Black;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCpf.Location = new System.Drawing.Point(101, 124);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(205, 22);
            this.txtCpf.TabIndex = 4;
            this.txtCpf.Text = "071.548.258-96";
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconCliente
            // 
            this.iconCliente.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconCliente.IconColor = System.Drawing.Color.White;
            this.iconCliente.Location = new System.Drawing.Point(65, 60);
            this.iconCliente.Name = "iconCliente";
            this.iconCliente.Size = new System.Drawing.Size(32, 32);
            this.iconCliente.TabIndex = 2;
            this.iconCliente.TabStop = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.Black;
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtNomeCliente.Location = new System.Drawing.Point(101, 65);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(205, 22);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.Text = "Adriano Andrade";
            this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.cardFundo;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 3;
            this.gunaElipse1.TargetControl = this.btnEditar;
            // 
            // form_CadastroClientes_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 329);
            this.Controls.Add(this.cardFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_CadastroClientes_Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CadastroClientes_Edit";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_CadastroClientes_Edit_KeyDown);
            this.cardFundo.ResumeLayout(false);
            this.cardFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardFundo;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private FontAwesome.Sharp.IconPictureBox iconCliente;
        private Guna.UI.WinForms.GunaGradient2Panel sep1;
        private Guna.UI.WinForms.GunaGradientButton btnEditar;
        private Guna.UI.WinForms.GunaGradient2Panel sep3;
        private FontAwesome.Sharp.IconPictureBox iconTelefone;
        private Guna.UI.WinForms.GunaGradient2Panel sep2;
        private FontAwesome.Sharp.IconPictureBox iconCPF;
        public System.Windows.Forms.TextBox txtNomeCliente;
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.TextBox txtCpf;
        public Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}