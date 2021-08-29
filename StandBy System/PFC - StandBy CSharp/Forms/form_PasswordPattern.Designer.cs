
namespace PFC___StandBy_CSharp.Forms
{
    partial class form_PasswordPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PasswordPattern));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnSenhaCorreta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSenhaIncorreta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPasswordIsCorrect = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPasswordInNumbers = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lockScreenControl1 = new GestureLockApp.GestureLockControl.LockScreenControl();
            this.lblIDServico = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSenhaCorreta
            // 
            this.btnSenhaCorreta.AllowToggling = false;
            this.btnSenhaCorreta.AnimationSpeed = 200;
            this.btnSenhaCorreta.AutoGenerateColors = false;
            this.btnSenhaCorreta.BackColor = System.Drawing.Color.Transparent;
            this.btnSenhaCorreta.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSenhaCorreta.BackgroundImage")));
            this.btnSenhaCorreta.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaCorreta.ButtonText = "Sim";
            this.btnSenhaCorreta.ButtonTextMarginLeft = 0;
            this.btnSenhaCorreta.ColorContrastOnClick = 45;
            this.btnSenhaCorreta.ColorContrastOnHover = 45;
            this.btnSenhaCorreta.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSenhaCorreta.CustomizableEdges = borderEdges1;
            this.btnSenhaCorreta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSenhaCorreta.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSenhaCorreta.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSenhaCorreta.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSenhaCorreta.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSenhaCorreta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSenhaCorreta.ForeColor = System.Drawing.Color.White;
            this.btnSenhaCorreta.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaCorreta.IconMarginLeft = 11;
            this.btnSenhaCorreta.IconPadding = 10;
            this.btnSenhaCorreta.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaCorreta.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.IdleBorderRadius = 3;
            this.btnSenhaCorreta.IdleBorderThickness = 1;
            this.btnSenhaCorreta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.IdleIconLeftImage = null;
            this.btnSenhaCorreta.IdleIconRightImage = null;
            this.btnSenhaCorreta.IndicateFocus = false;
            this.btnSenhaCorreta.Location = new System.Drawing.Point(24, 300);
            this.btnSenhaCorreta.Name = "btnSenhaCorreta";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSenhaCorreta.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSenhaCorreta.OnPressedState = stateProperties2;
            this.btnSenhaCorreta.Size = new System.Drawing.Size(84, 28);
            this.btnSenhaCorreta.TabIndex = 1;
            this.btnSenhaCorreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSenhaCorreta.TextMarginLeft = 0;
            this.btnSenhaCorreta.UseDefaultRadiusAndThickness = true;
            this.btnSenhaCorreta.Click += new System.EventHandler(this.btnSenhaCorreta_Click);
            // 
            // btnSenhaIncorreta
            // 
            this.btnSenhaIncorreta.AllowToggling = false;
            this.btnSenhaIncorreta.AnimationSpeed = 200;
            this.btnSenhaIncorreta.AutoGenerateColors = false;
            this.btnSenhaIncorreta.BackColor = System.Drawing.Color.Transparent;
            this.btnSenhaIncorreta.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSenhaIncorreta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSenhaIncorreta.BackgroundImage")));
            this.btnSenhaIncorreta.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaIncorreta.ButtonText = "Nao";
            this.btnSenhaIncorreta.ButtonTextMarginLeft = 0;
            this.btnSenhaIncorreta.ColorContrastOnClick = 45;
            this.btnSenhaIncorreta.ColorContrastOnHover = 45;
            this.btnSenhaIncorreta.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSenhaIncorreta.CustomizableEdges = borderEdges2;
            this.btnSenhaIncorreta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSenhaIncorreta.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSenhaIncorreta.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSenhaIncorreta.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSenhaIncorreta.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSenhaIncorreta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSenhaIncorreta.ForeColor = System.Drawing.Color.White;
            this.btnSenhaIncorreta.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaIncorreta.IconMarginLeft = 11;
            this.btnSenhaIncorreta.IconPadding = 10;
            this.btnSenhaIncorreta.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaIncorreta.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSenhaIncorreta.IdleBorderRadius = 3;
            this.btnSenhaIncorreta.IdleBorderThickness = 1;
            this.btnSenhaIncorreta.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSenhaIncorreta.IdleIconLeftImage = null;
            this.btnSenhaIncorreta.IdleIconRightImage = null;
            this.btnSenhaIncorreta.IndicateFocus = false;
            this.btnSenhaIncorreta.Location = new System.Drawing.Point(151, 300);
            this.btnSenhaIncorreta.Name = "btnSenhaIncorreta";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnSenhaIncorreta.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnSenhaIncorreta.OnPressedState = stateProperties4;
            this.btnSenhaIncorreta.Size = new System.Drawing.Size(84, 28);
            this.btnSenhaIncorreta.TabIndex = 2;
            this.btnSenhaIncorreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSenhaIncorreta.TextMarginLeft = 0;
            this.btnSenhaIncorreta.UseDefaultRadiusAndThickness = true;
            this.btnSenhaIncorreta.Click += new System.EventHandler(this.btnSenhaIncorreta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 264);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblPasswordIsCorrect
            // 
            this.lblPasswordIsCorrect.AutoSize = true;
            this.lblPasswordIsCorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordIsCorrect.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPasswordIsCorrect.Location = new System.Drawing.Point(29, 272);
            this.lblPasswordIsCorrect.Name = "lblPasswordIsCorrect";
            this.lblPasswordIsCorrect.Size = new System.Drawing.Size(196, 25);
            this.lblPasswordIsCorrect.TabIndex = 4;
            this.lblPasswordIsCorrect.Text = "A Senha esta correta?";
            this.lblPasswordIsCorrect.Visible = false;
            // 
            // lblPasswordInNumbers
            // 
            this.lblPasswordInNumbers.AutoSize = true;
            this.lblPasswordInNumbers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInNumbers.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPasswordInNumbers.Location = new System.Drawing.Point(49, 239);
            this.lblPasswordInNumbers.Name = "lblPasswordInNumbers";
            this.lblPasswordInNumbers.Size = new System.Drawing.Size(163, 25);
            this.lblPasswordInNumbers.TabIndex = 5;
            this.lblPasswordInNumbers.Text = "0 1 2 3 4 5 6 7 8 9";
            this.lblPasswordInNumbers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPasswordInNumbers.Visible = false;
            // 
            // lockScreenControl1
            // 
            this.lockScreenControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lockScreenControl1.Location = new System.Drawing.Point(0, 0);
            this.lockScreenControl1.Name = "lockScreenControl1";
            this.lockScreenControl1.Size = new System.Drawing.Size(261, 239);
            this.lockScreenControl1.TabIndex = 0;
            this.lockScreenControl1.Text = "lockScreenControl1";
            this.lockScreenControl1.PassCodeSubmitted += new System.EventHandler<GestureLockApp.GestureLockControl.PassCodeSubmittedEventArgs>(this.lockScreenControl1_PassCodeSubmitted);
            // 
            // lblIDServico
            // 
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDServico.Location = new System.Drawing.Point(-3, 267);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(64, 13);
            this.lblIDServico.TabIndex = 6;
            this.lblIDServico.Text = "lblIDServico";
            this.lblIDServico.Visible = false;
            // 
            // form_PasswordPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(261, 337);
            this.Controls.Add(this.lblIDServico);
            this.Controls.Add(this.lblPasswordInNumbers);
            this.Controls.Add(this.lblPasswordIsCorrect);
            this.Controls.Add(this.btnSenhaIncorreta);
            this.Controls.Add(this.btnSenhaCorreta);
            this.Controls.Add(this.lockScreenControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_PasswordPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_PasswordPattern";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_PasswordPattern_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GestureLockApp.GestureLockControl.LockScreenControl lockScreenControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSenhaCorreta;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSenhaIncorreta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordIsCorrect;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordInNumbers;
        public Bunifu.Framework.UI.BunifuCustomLabel lblIDServico;
    }
}