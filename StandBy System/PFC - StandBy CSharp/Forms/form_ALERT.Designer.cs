namespace PFC___StandBy_CSharp.Forms
{
    partial class form_ALERT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ALERT));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMensagem = new System.Windows.Forms.Panel();
            this.tiniFecharForm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.timerout = new System.Windows.Forms.Timer(this.components);
            this.closeform = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panelMensagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMensagem);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 82);
            this.panel1.TabIndex = 0;
            // 
            // panelMensagem
            // 
            this.panelMensagem.BackColor = System.Drawing.Color.White;
            this.panelMensagem.Controls.Add(this.tiniFecharForm);
            this.panelMensagem.Controls.Add(this.lblMensagem);
            this.panelMensagem.Location = new System.Drawing.Point(130, 0);
            this.panelMensagem.Name = "panelMensagem";
            this.panelMensagem.Size = new System.Drawing.Size(172, 82);
            this.panelMensagem.TabIndex = 1;
            // 
            // tiniFecharForm
            // 
            this.tiniFecharForm.ActiveBorderThickness = 1;
            this.tiniFecharForm.ActiveCornerRadius = 20;
            this.tiniFecharForm.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.tiniFecharForm.ActiveForecolor = System.Drawing.Color.White;
            this.tiniFecharForm.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.tiniFecharForm.BackColor = System.Drawing.Color.White;
            this.tiniFecharForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tiniFecharForm.BackgroundImage")));
            this.tiniFecharForm.ButtonText = "X";
            this.tiniFecharForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tiniFecharForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiniFecharForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.tiniFecharForm.IdleBorderThickness = 1;
            this.tiniFecharForm.IdleCornerRadius = 20;
            this.tiniFecharForm.IdleFillColor = System.Drawing.Color.White;
            this.tiniFecharForm.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.tiniFecharForm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.tiniFecharForm.Location = new System.Drawing.Point(150, -6);
            this.tiniFecharForm.Margin = new System.Windows.Forms.Padding(4);
            this.tiniFecharForm.Name = "tiniFecharForm";
            this.tiniFecharForm.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.tiniFecharForm.Size = new System.Drawing.Size(21, 31);
            this.tiniFecharForm.TabIndex = 1;
            this.tiniFecharForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tiniFecharForm.Click += new System.EventHandler(this.tiniFecharForm_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("CorisandeLight", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(3, 0);
            this.lblMensagem.MaximumSize = new System.Drawing.Size(162, 72);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(137, 13);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Inserido com Sucesso";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.BackgroundImage = global::PFC___StandBy_CSharp.Properties.Resources.Sucesso;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 82;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(302, 82);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.iconPictureBox1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // show
            // 
            this.show.Interval = 50;
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // timerout
            // 
            this.timerout.Enabled = true;
            this.timerout.Interval = 3000;
            this.timerout.Tick += new System.EventHandler(this.timerout_Tick);
            // 
            // closeform
            // 
            this.closeform.Interval = 50;
            this.closeform.Tick += new System.EventHandler(this.closeform_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.tiniFecharForm;
            // 
            // form_ALERT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 82);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ALERT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "form_ALERT";
            this.Load += new System.EventHandler(this.form_ALERT_Load);
            this.panel1.ResumeLayout(false);
            this.panelMensagem.ResumeLayout(false);
            this.panelMensagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Timer timerout;
        private System.Windows.Forms.Timer closeform;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuThinButton2 tiniFecharForm;
    }
}