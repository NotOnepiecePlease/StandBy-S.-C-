
using PFC___StandBy_CSharp.LockScreenAndroid;

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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.btnSenhaCorreta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSenhaIncorreta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPasswordIsCorrect = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPasswordInNumbers = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lockScreenControl1 = new PFC___StandBy_CSharp.LockScreenAndroid.LockScreenControl();
            this.lblIDServico = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSenhaCorreta
            // 
            this.btnSenhaCorreta.AllowAnimations = true;
            this.btnSenhaCorreta.AllowMouseEffects = true;
            this.btnSenhaCorreta.AllowToggling = false;
            this.btnSenhaCorreta.AnimationSpeed = 200;
            this.btnSenhaCorreta.AutoGenerateColors = false;
            this.btnSenhaCorreta.AutoRoundBorders = false;
            this.btnSenhaCorreta.AutoSizeLeftIcon = true;
            this.btnSenhaCorreta.AutoSizeRightIcon = true;
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
            this.btnSenhaCorreta.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenhaCorreta.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaCorreta.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSenhaCorreta.IconMarginLeft = 11;
            this.btnSenhaCorreta.IconPadding = 10;
            this.btnSenhaCorreta.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSenhaCorreta.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaCorreta.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSenhaCorreta.IconSize = 25;
            this.btnSenhaCorreta.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.IdleBorderRadius = 3;
            this.btnSenhaCorreta.IdleBorderThickness = 1;
            this.btnSenhaCorreta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.IdleIconLeftImage = null;
            this.btnSenhaCorreta.IdleIconRightImage = null;
            this.btnSenhaCorreta.IndicateFocus = false;
            this.btnSenhaCorreta.Location = new System.Drawing.Point(37, 310);
            this.btnSenhaCorreta.Name = "btnSenhaCorreta";
            this.btnSenhaCorreta.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.btnSenhaCorreta.OnDisabledState.BorderRadius = 3;
            this.btnSenhaCorreta.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaCorreta.OnDisabledState.BorderThickness = 1;
            this.btnSenhaCorreta.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSenhaCorreta.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSenhaCorreta.OnDisabledState.IconLeftImage = null;
            this.btnSenhaCorreta.OnDisabledState.IconRightImage = null;
            this.btnSenhaCorreta.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.onHoverState.BorderRadius = 3;
            this.btnSenhaCorreta.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaCorreta.onHoverState.BorderThickness = 1;
            this.btnSenhaCorreta.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSenhaCorreta.onHoverState.IconLeftImage = null;
            this.btnSenhaCorreta.onHoverState.IconRightImage = null;
            this.btnSenhaCorreta.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.OnIdleState.BorderRadius = 3;
            this.btnSenhaCorreta.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaCorreta.OnIdleState.BorderThickness = 1;
            this.btnSenhaCorreta.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSenhaCorreta.OnIdleState.IconLeftImage = null;
            this.btnSenhaCorreta.OnIdleState.IconRightImage = null;
            this.btnSenhaCorreta.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.OnPressedState.BorderRadius = 3;
            this.btnSenhaCorreta.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaCorreta.OnPressedState.BorderThickness = 1;
            this.btnSenhaCorreta.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnSenhaCorreta.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSenhaCorreta.OnPressedState.IconLeftImage = null;
            this.btnSenhaCorreta.OnPressedState.IconRightImage = null;
            this.btnSenhaCorreta.Size = new System.Drawing.Size(84, 28);
            this.btnSenhaCorreta.TabIndex = 1;
            this.btnSenhaCorreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSenhaCorreta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSenhaCorreta.TextMarginLeft = 0;
            this.btnSenhaCorreta.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSenhaCorreta.UseDefaultRadiusAndThickness = true;
            this.btnSenhaCorreta.Click += new System.EventHandler(this.btnSenhaCorreta_Click);
            // 
            // btnSenhaIncorreta
            // 
            this.btnSenhaIncorreta.AllowAnimations = true;
            this.btnSenhaIncorreta.AllowMouseEffects = true;
            this.btnSenhaIncorreta.AllowToggling = false;
            this.btnSenhaIncorreta.AnimationSpeed = 200;
            this.btnSenhaIncorreta.AutoGenerateColors = false;
            this.btnSenhaIncorreta.AutoRoundBorders = false;
            this.btnSenhaIncorreta.AutoSizeLeftIcon = true;
            this.btnSenhaIncorreta.AutoSizeRightIcon = true;
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
            this.btnSenhaIncorreta.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenhaIncorreta.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaIncorreta.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSenhaIncorreta.IconMarginLeft = 11;
            this.btnSenhaIncorreta.IconPadding = 10;
            this.btnSenhaIncorreta.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSenhaIncorreta.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenhaIncorreta.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSenhaIncorreta.IconSize = 25;
            this.btnSenhaIncorreta.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSenhaIncorreta.IdleBorderRadius = 3;
            this.btnSenhaIncorreta.IdleBorderThickness = 1;
            this.btnSenhaIncorreta.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSenhaIncorreta.IdleIconLeftImage = null;
            this.btnSenhaIncorreta.IdleIconRightImage = null;
            this.btnSenhaIncorreta.IndicateFocus = false;
            this.btnSenhaIncorreta.Location = new System.Drawing.Point(144, 310);
            this.btnSenhaIncorreta.Name = "btnSenhaIncorreta";
            this.btnSenhaIncorreta.OnDisabledState.BorderColor = System.Drawing.Color.Empty;
            this.btnSenhaIncorreta.OnDisabledState.BorderRadius = 3;
            this.btnSenhaIncorreta.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaIncorreta.OnDisabledState.BorderThickness = 1;
            this.btnSenhaIncorreta.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSenhaIncorreta.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSenhaIncorreta.OnDisabledState.IconLeftImage = null;
            this.btnSenhaIncorreta.OnDisabledState.IconRightImage = null;
            this.btnSenhaIncorreta.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSenhaIncorreta.onHoverState.BorderRadius = 3;
            this.btnSenhaIncorreta.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaIncorreta.onHoverState.BorderThickness = 1;
            this.btnSenhaIncorreta.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSenhaIncorreta.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSenhaIncorreta.onHoverState.IconLeftImage = null;
            this.btnSenhaIncorreta.onHoverState.IconRightImage = null;
            this.btnSenhaIncorreta.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSenhaIncorreta.OnIdleState.BorderRadius = 3;
            this.btnSenhaIncorreta.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaIncorreta.OnIdleState.BorderThickness = 1;
            this.btnSenhaIncorreta.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSenhaIncorreta.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSenhaIncorreta.OnIdleState.IconLeftImage = null;
            this.btnSenhaIncorreta.OnIdleState.IconRightImage = null;
            this.btnSenhaIncorreta.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSenhaIncorreta.OnPressedState.BorderRadius = 3;
            this.btnSenhaIncorreta.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSenhaIncorreta.OnPressedState.BorderThickness = 1;
            this.btnSenhaIncorreta.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSenhaIncorreta.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSenhaIncorreta.OnPressedState.IconLeftImage = null;
            this.btnSenhaIncorreta.OnPressedState.IconRightImage = null;
            this.btnSenhaIncorreta.Size = new System.Drawing.Size(84, 28);
            this.btnSenhaIncorreta.TabIndex = 2;
            this.btnSenhaIncorreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSenhaIncorreta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSenhaIncorreta.TextMarginLeft = 0;
            this.btnSenhaIncorreta.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSenhaIncorreta.UseDefaultRadiusAndThickness = true;
            this.btnSenhaIncorreta.Click += new System.EventHandler(this.btnSenhaIncorreta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 241);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblPasswordIsCorrect
            // 
            this.lblPasswordIsCorrect.AutoSize = true;
            this.lblPasswordIsCorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordIsCorrect.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPasswordIsCorrect.Location = new System.Drawing.Point(32, 279);
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
            this.lblPasswordInNumbers.Location = new System.Drawing.Point(49, 247);
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
            this.lockScreenControl1.PassCodeSubmitted += new System.EventHandler<PFC___StandBy_CSharp.LockScreenAndroid.PassCodeSubmittedEventArgs>(this.lockScreenControl1_PassCodeSubmitted);
            // 
            // lblIDServico
            // 
            this.lblIDServico.AutoSize = true;
            this.lblIDServico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDServico.Location = new System.Drawing.Point(-2, 244);
            this.lblIDServico.Name = "lblIDServico";
            this.lblIDServico.Size = new System.Drawing.Size(64, 13);
            this.lblIDServico.TabIndex = 6;
            this.lblIDServico.Text = "lblIDServico";
            this.lblIDServico.Visible = false;
            // 
            // form_PasswordPattern
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(261, 348);
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

        private LockScreenControl lockScreenControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSenhaCorreta;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSenhaIncorreta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordIsCorrect;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPasswordInNumbers;
        public Bunifu.Framework.UI.BunifuCustomLabel lblIDServico;
    }
}