namespace PFC___StandBy_CSharp.Forms._1___Ordems_Servico
{
    partial class form_RichTextboxExterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RichTextboxExterno));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtRichtextExterna = new System.Windows.Forms.RichTextBox();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.iconClose);
            this.bunifuPanel1.Controls.Add(this.txtRichtextExterna);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // txtRichtextExterna
            // 
            this.txtRichtextExterna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRichtextExterna.BackColor = System.Drawing.Color.DimGray;
            this.txtRichtextExterna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRichtextExterna.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtRichtextExterna.ForeColor = System.Drawing.Color.White;
            this.txtRichtextExterna.Location = new System.Drawing.Point(16, 30);
            this.txtRichtextExterna.MaxLength = 4000;
            this.txtRichtextExterna.Name = "txtRichtextExterna";
            this.txtRichtextExterna.Size = new System.Drawing.Size(768, 400);
            this.txtRichtextExterna.TabIndex = 6;
            this.txtRichtextExterna.Text = "";
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.Transparent;
            this.iconClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.iconClose.IconSize = 29;
            this.iconClose.Location = new System.Drawing.Point(769, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconClose.Size = new System.Drawing.Size(29, 29);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconClose.TabIndex = 7;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // form_RichTextboxExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_RichTextboxExterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_RichTextboxExterno";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_RichTextboxExterno_KeyDown);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public System.Windows.Forms.RichTextBox txtRichtextExterna;
        private FontAwesome.Sharp.IconPictureBox iconClose;
    }
}