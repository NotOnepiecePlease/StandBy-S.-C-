namespace PFC___StandBy_CSharp.Forms.Configurações
{
    partial class form_PainelCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PainelCentral));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnBancoDados = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescricaoFuncao = new DevExpress.XtraEditors.MemoEdit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoFuncao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txtDescricaoFuncao);
            this.bunifuPanel1.Controls.Add(this.btnBancoDados);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(853, 395);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // btnBancoDados
            // 
            this.btnBancoDados.Location = new System.Drawing.Point(11, 12);
            this.btnBancoDados.Name = "btnBancoDados";
            this.btnBancoDados.Size = new System.Drawing.Size(246, 39);
            this.btnBancoDados.TabIndex = 0;
            this.btnBancoDados.Text = "Banco de Dados";
            // 
            // txtDescricaoFuncao
            // 
            this.txtDescricaoFuncao.EditValue = "Configuração de conexão, logins, senhas e banco de dados.\r\n\r\nVoce tambem pode exe" +
    "cutar querys basicas de busca no banco.";
            this.txtDescricaoFuncao.Location = new System.Drawing.Point(305, 12);
            this.txtDescricaoFuncao.Name = "txtDescricaoFuncao";
            this.txtDescricaoFuncao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFuncao.Properties.Appearance.Options.UseFont = true;
            this.txtDescricaoFuncao.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricaoFuncao.Size = new System.Drawing.Size(536, 371);
            this.txtDescricaoFuncao.TabIndex = 3;
            // 
            // form_PainelCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(853, 395);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_PainelCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_PainelCentral";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoFuncao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private DevExpress.XtraEditors.SimpleButton btnBancoDados;
        private DevExpress.XtraEditors.MemoEdit txtDescricaoFuncao;
    }
}