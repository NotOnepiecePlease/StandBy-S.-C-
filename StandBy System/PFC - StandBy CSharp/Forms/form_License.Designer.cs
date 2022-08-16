
namespace PFC___StandBy_CSharp.Forms
{
    partial class form_License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_License));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.progressCarregando = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblCarregamento = new System.Windows.Forms.Label();
            this.txtLicense = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAtivarLicense = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 111;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(-12, 38);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(222, 222);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 207;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(216, -97);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(414, 414);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 1;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // progressCarregando
            // 
            this.progressCarregando.AllowAnimations = false;
            this.progressCarregando.Animation = 0;
            this.progressCarregando.AnimationSpeed = 220;
            this.progressCarregando.AnimationStep = 10;
            this.progressCarregando.BackColor = System.Drawing.Color.Transparent;
            this.progressCarregando.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressCarregando.BackgroundImage")));
            this.progressCarregando.BorderColor = System.Drawing.Color.Transparent;
            this.progressCarregando.BorderRadius = 10;
            this.progressCarregando.BorderThickness = 1;
            this.progressCarregando.Location = new System.Drawing.Point(216, 235);
            this.progressCarregando.Maximum = 100;
            this.progressCarregando.MaximumValue = 100;
            this.progressCarregando.Minimum = 0;
            this.progressCarregando.MinimumValue = 0;
            this.progressCarregando.Name = "progressCarregando";
            this.progressCarregando.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.progressCarregando.ProgressBackColor = System.Drawing.Color.Transparent;
            this.progressCarregando.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.progressCarregando.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(113)))));
            this.progressCarregando.Size = new System.Drawing.Size(466, 25);
            this.progressCarregando.TabIndex = 2;
            this.progressCarregando.Value = 0;
            this.progressCarregando.ValueByTransition = 0;
            // 
            // lblCarregamento
            // 
            this.lblCarregamento.AutoSize = true;
            this.lblCarregamento.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregamento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCarregamento.Location = new System.Drawing.Point(272, 205);
            this.lblCarregamento.Name = "lblCarregamento";
            this.lblCarregamento.Size = new System.Drawing.Size(323, 24);
            this.lblCarregamento.TabIndex = 3;
            this.lblCarregamento.Text = "Licença expirada dia: 26/08/2022";
            // 
            // txtLicense
            // 
            this.txtLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLicense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLicense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.txtLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLicense.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLicense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicense.Font = new System.Drawing.Font("Tw Cen MT", 12.25F);
            this.txtLicense.ForeColor = System.Drawing.Color.Silver;
            this.txtLicense.HintForeColor = System.Drawing.Color.Transparent;
            this.txtLicense.HintText = "";
            this.txtLicense.isPassword = false;
            this.txtLicense.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtLicense.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtLicense.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtLicense.LineThickness = 3;
            this.txtLicense.Location = new System.Drawing.Point(216, 233);
            this.txtLicense.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicense.MaxLength = 100;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(435, 32);
            this.txtLicense.TabIndex = 4;
            this.txtLicense.Text = "XXXXX-XXXXXX-XXXXXX-XXXXXX";
            this.txtLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLicense.Visible = false;
            // 
            // btnAtivarLicense
            // 
            this.btnAtivarLicense.AllowAnimations = true;
            this.btnAtivarLicense.AllowMouseEffects = true;
            this.btnAtivarLicense.AllowToggling = false;
            this.btnAtivarLicense.AnimationSpeed = 200;
            this.btnAtivarLicense.AutoGenerateColors = false;
            this.btnAtivarLicense.AutoRoundBorders = false;
            this.btnAtivarLicense.AutoSizeLeftIcon = true;
            this.btnAtivarLicense.AutoSizeRightIcon = true;
            this.btnAtivarLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnAtivarLicense.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnAtivarLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtivarLicense.BackgroundImage")));
            this.btnAtivarLicense.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtivarLicense.ButtonText = "Ativar";
            this.btnAtivarLicense.ButtonTextMarginLeft = 0;
            this.btnAtivarLicense.ColorContrastOnClick = 45;
            this.btnAtivarLicense.ColorContrastOnHover = 45;
            this.btnAtivarLicense.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAtivarLicense.CustomizableEdges = borderEdges1;
            this.btnAtivarLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtivarLicense.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAtivarLicense.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAtivarLicense.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAtivarLicense.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAtivarLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtivarLicense.ForeColor = System.Drawing.Color.White;
            this.btnAtivarLicense.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivarLicense.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAtivarLicense.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAtivarLicense.IconMarginLeft = 11;
            this.btnAtivarLicense.IconPadding = 10;
            this.btnAtivarLicense.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtivarLicense.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAtivarLicense.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAtivarLicense.IconSize = 25;
            this.btnAtivarLicense.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnAtivarLicense.IdleBorderRadius = 1;
            this.btnAtivarLicense.IdleBorderThickness = 1;
            this.btnAtivarLicense.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnAtivarLicense.IdleIconLeftImage = null;
            this.btnAtivarLicense.IdleIconRightImage = null;
            this.btnAtivarLicense.IndicateFocus = false;
            this.btnAtivarLicense.Location = new System.Drawing.Point(658, 233);
            this.btnAtivarLicense.Name = "btnAtivarLicense";
            this.btnAtivarLicense.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAtivarLicense.OnDisabledState.BorderRadius = 1;
            this.btnAtivarLicense.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtivarLicense.OnDisabledState.BorderThickness = 1;
            this.btnAtivarLicense.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAtivarLicense.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAtivarLicense.OnDisabledState.IconLeftImage = null;
            this.btnAtivarLicense.OnDisabledState.IconRightImage = null;
            this.btnAtivarLicense.onHoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnAtivarLicense.onHoverState.BorderRadius = 1;
            this.btnAtivarLicense.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtivarLicense.onHoverState.BorderThickness = 1;
            this.btnAtivarLicense.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnAtivarLicense.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAtivarLicense.onHoverState.IconLeftImage = null;
            this.btnAtivarLicense.onHoverState.IconRightImage = null;
            this.btnAtivarLicense.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnAtivarLicense.OnIdleState.BorderRadius = 1;
            this.btnAtivarLicense.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtivarLicense.OnIdleState.BorderThickness = 1;
            this.btnAtivarLicense.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnAtivarLicense.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAtivarLicense.OnIdleState.IconLeftImage = null;
            this.btnAtivarLicense.OnIdleState.IconRightImage = null;
            this.btnAtivarLicense.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.btnAtivarLicense.OnPressedState.BorderRadius = 1;
            this.btnAtivarLicense.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtivarLicense.OnPressedState.BorderThickness = 1;
            this.btnAtivarLicense.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btnAtivarLicense.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAtivarLicense.OnPressedState.IconLeftImage = null;
            this.btnAtivarLicense.OnPressedState.IconRightImage = null;
            this.btnAtivarLicense.Size = new System.Drawing.Size(53, 32);
            this.btnAtivarLicense.TabIndex = 5;
            this.btnAtivarLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtivarLicense.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAtivarLicense.TextMarginLeft = 0;
            this.btnAtivarLicense.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAtivarLicense.UseDefaultRadiusAndThickness = true;
            this.btnAtivarLicense.Visible = false;
            this.btnAtivarLicense.Click += new System.EventHandler(this.btnAtivarLicense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite sua licença abaixo";
            this.label1.Visible = false;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 20;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // form_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(737, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtivarLicense);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.lblCarregamento);
            this.Controls.Add(this.progressCarregando);
            this.Controls.Add(this.bunifuPictureBox2);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_License";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.form_License_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuProgressBar progressCarregando;
        private System.Windows.Forms.Label lblCarregamento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLicense;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAtivarLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}