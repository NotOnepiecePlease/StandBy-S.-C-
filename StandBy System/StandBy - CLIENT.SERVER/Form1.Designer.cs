﻿
namespace StandBy___CLIENT.SERVER
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.imgbuttonTitulo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelFundoMenus = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnTodosServicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServicosAndamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbuttonTitulo)).BeginInit();
            this.panelFundoMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panelCentral);
            this.panel1.Controls.Add(this.imgbuttonTitulo);
            this.panel1.Controls.Add(this.panelFundoMenus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 720);
            this.panel1.TabIndex = 0;
            // 
            // panelCentral
            // 
            this.panelCentral.Location = new System.Drawing.Point(0, 71);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1280, 646);
            this.panelCentral.TabIndex = 10;
            // 
            // imgbuttonTitulo
            // 
            this.imgbuttonTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgbuttonTitulo.Image = ((System.Drawing.Image)(resources.GetObject("imgbuttonTitulo.Image")));
            this.imgbuttonTitulo.ImageActive = null;
            this.imgbuttonTitulo.Location = new System.Drawing.Point(543, 0);
            this.imgbuttonTitulo.Name = "imgbuttonTitulo";
            this.imgbuttonTitulo.Size = new System.Drawing.Size(194, 31);
            this.imgbuttonTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbuttonTitulo.TabIndex = 9;
            this.imgbuttonTitulo.TabStop = false;
            this.imgbuttonTitulo.Zoom = 10;
            // 
            // panelFundoMenus
            // 
            this.panelFundoMenus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFundoMenus.BackgroundImage")));
            this.panelFundoMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundoMenus.Controls.Add(this.btnTodosServicos);
            this.panelFundoMenus.Controls.Add(this.btnServicosAndamento);
            this.panelFundoMenus.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelFundoMenus.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelFundoMenus.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelFundoMenus.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelFundoMenus.Location = new System.Drawing.Point(0, 34);
            this.panelFundoMenus.Name = "panelFundoMenus";
            this.panelFundoMenus.Quality = 10;
            this.panelFundoMenus.Size = new System.Drawing.Size(1280, 35);
            this.panelFundoMenus.TabIndex = 0;
            // 
            // btnTodosServicos
            // 
            this.btnTodosServicos.Active = false;
            this.btnTodosServicos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTodosServicos.BackColor = System.Drawing.Color.Transparent;
            this.btnTodosServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTodosServicos.BorderRadius = 0;
            this.btnTodosServicos.ButtonText = "TODOS SERVIÇOS";
            this.btnTodosServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosServicos.DisabledColor = System.Drawing.Color.Gray;
            this.btnTodosServicos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTodosServicos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTodosServicos.Iconimage")));
            this.btnTodosServicos.Iconimage_right = null;
            this.btnTodosServicos.Iconimage_right_Selected = null;
            this.btnTodosServicos.Iconimage_Selected = null;
            this.btnTodosServicos.IconMarginLeft = 0;
            this.btnTodosServicos.IconMarginRight = 0;
            this.btnTodosServicos.IconRightVisible = true;
            this.btnTodosServicos.IconRightZoom = 0D;
            this.btnTodosServicos.IconVisible = false;
            this.btnTodosServicos.IconZoom = 90D;
            this.btnTodosServicos.IsTab = false;
            this.btnTodosServicos.Location = new System.Drawing.Point(642, 0);
            this.btnTodosServicos.Name = "btnTodosServicos";
            this.btnTodosServicos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTodosServicos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnTodosServicos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTodosServicos.selected = false;
            this.btnTodosServicos.Size = new System.Drawing.Size(639, 36);
            this.btnTodosServicos.TabIndex = 1;
            this.btnTodosServicos.Text = "TODOS SERVIÇOS";
            this.btnTodosServicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTodosServicos.Textcolor = System.Drawing.Color.White;
            this.btnTodosServicos.TextFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            this.btnTodosServicos.Click += new System.EventHandler(this.btnTodosServicos_Click);
            // 
            // btnServicosAndamento
            // 
            this.btnServicosAndamento.Active = false;
            this.btnServicosAndamento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnServicosAndamento.BackColor = System.Drawing.Color.Transparent;
            this.btnServicosAndamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicosAndamento.BorderRadius = 0;
            this.btnServicosAndamento.ButtonText = "ANDAMENTO";
            this.btnServicosAndamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicosAndamento.DisabledColor = System.Drawing.Color.Gray;
            this.btnServicosAndamento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServicosAndamento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnServicosAndamento.Iconimage")));
            this.btnServicosAndamento.Iconimage_right = null;
            this.btnServicosAndamento.Iconimage_right_Selected = null;
            this.btnServicosAndamento.Iconimage_Selected = null;
            this.btnServicosAndamento.IconMarginLeft = 0;
            this.btnServicosAndamento.IconMarginRight = 0;
            this.btnServicosAndamento.IconRightVisible = true;
            this.btnServicosAndamento.IconRightZoom = 0D;
            this.btnServicosAndamento.IconVisible = false;
            this.btnServicosAndamento.IconZoom = 90D;
            this.btnServicosAndamento.IsTab = false;
            this.btnServicosAndamento.Location = new System.Drawing.Point(0, 0);
            this.btnServicosAndamento.Name = "btnServicosAndamento";
            this.btnServicosAndamento.Normalcolor = System.Drawing.Color.Transparent;
            this.btnServicosAndamento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnServicosAndamento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServicosAndamento.selected = false;
            this.btnServicosAndamento.Size = new System.Drawing.Size(642, 36);
            this.btnServicosAndamento.TabIndex = 0;
            this.btnServicosAndamento.Text = "ANDAMENTO";
            this.btnServicosAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnServicosAndamento.Textcolor = System.Drawing.Color.White;
            this.btnServicosAndamento.TextFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            this.btnServicosAndamento.Click += new System.EventHandler(this.btnServicosAndamento_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 29;
            this.btnExit.Location = new System.Drawing.Point(1246, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgbuttonTitulo)).EndInit();
            this.panelFundoMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelFundoMenus;
        private Bunifu.Framework.UI.BunifuImageButton imgbuttonTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton btnTodosServicos;
        private Bunifu.Framework.UI.BunifuFlatButton btnServicosAndamento;
        private System.Windows.Forms.Panel panelCentral;
        private FontAwesome.Sharp.IconPictureBox btnExit;
    }
}

