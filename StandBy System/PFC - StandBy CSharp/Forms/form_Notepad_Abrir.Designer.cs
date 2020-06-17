namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Notepad_Abrir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Notepad_Abrir));
            this.btnPastaPadrao = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnBuscarPasta = new Guna.UI.WinForms.GunaAdvenceButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelCenter = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPastaPadrao
            // 
            this.btnPastaPadrao.AnimationHoverSpeed = 0.07F;
            this.btnPastaPadrao.AnimationSpeed = 0.03F;
            this.btnPastaPadrao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
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
            this.btnPastaPadrao.Image = ((System.Drawing.Image)(resources.GetObject("btnPastaPadrao.Image")));
            this.btnPastaPadrao.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPastaPadrao.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPastaPadrao.Location = new System.Drawing.Point(263, 472);
            this.btnPastaPadrao.Name = "btnPastaPadrao";
            this.btnPastaPadrao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPastaPadrao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPastaPadrao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPastaPadrao.OnHoverImage = null;
            this.btnPastaPadrao.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPastaPadrao.OnPressedColor = System.Drawing.Color.Black;
            this.btnPastaPadrao.Size = new System.Drawing.Size(171, 34);
            this.btnPastaPadrao.TabIndex = 9;
            this.btnPastaPadrao.Text = "Pasta Padrao";
            this.btnPastaPadrao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPastaPadrao.Click += new System.EventHandler(this.btnPastaPadrao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "F:\\@C Sharp\\TCC - Sistema StandBy - C#\\PFC - StandBy CSharp\\PFC - StandBy CSharp\\" +
    "bin\\Debug\\Anotacoes";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(5, 42);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Pasta: ";
            // 
            // btnBuscarPasta
            // 
            this.btnBuscarPasta.AnimationHoverSpeed = 0.07F;
            this.btnBuscarPasta.AnimationSpeed = 0.03F;
            this.btnBuscarPasta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscarPasta.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarPasta.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBuscarPasta.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBuscarPasta.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscarPasta.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPasta.CheckedImage")));
            this.btnBuscarPasta.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBuscarPasta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarPasta.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarPasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarPasta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPasta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPasta.Image")));
            this.btnBuscarPasta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscarPasta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuscarPasta.Location = new System.Drawing.Point(5, 472);
            this.btnBuscarPasta.Name = "btnBuscarPasta";
            this.btnBuscarPasta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscarPasta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarPasta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarPasta.OnHoverImage = null;
            this.btnBuscarPasta.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuscarPasta.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarPasta.Size = new System.Drawing.Size(171, 34);
            this.btnBuscarPasta.TabIndex = 6;
            this.btnBuscarPasta.Text = "Buscar Pasta";
            this.btnBuscarPasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscarPasta.Click += new System.EventHandler(this.btnBuscarPasta_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "ArquivoSalvo.txt",
            "AAAAAAAAAAAAAAAAAAA.txt",
            "UmArquivoae.txt",
            "TesteTESTETESTEETET.txt"});
            this.listBox1.Location = new System.Drawing.Point(5, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 390);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.panelCenter.Controls.Add(this.gunaPanel2);
            this.panelCenter.Controls.Add(this.label1);
            this.panelCenter.Controls.Add(this.gunaLabel1);
            this.panelCenter.Controls.Add(this.btnPastaPadrao);
            this.panelCenter.Controls.Add(this.btnBuscarPasta);
            this.panelCenter.Controls.Add(this.listBox1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(443, 518);
            this.panelCenter.TabIndex = 10;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaPanel2.Location = new System.Drawing.Point(0, -5);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(444, 10);
            this.gunaPanel2.TabIndex = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelCenter;
            this.bunifuDragControl1.Vertical = true;
            // 
            // form_Notepad_Abrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 518);
            this.Controls.Add(this.panelCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_Notepad_Abrir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Notepad_Abrir";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Notepad_Abrir_KeyDown);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnPastaPadrao;
        private Guna.UI.WinForms.GunaLabel label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnBuscarPasta;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI.WinForms.GunaPanel panelCenter;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}