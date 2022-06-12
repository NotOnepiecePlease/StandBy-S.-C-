
namespace StandBy___CLIENT.SERVER
{
    partial class form_PrincipalClientServer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PrincipalClientServer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNaoAtualizar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSimAtualizar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblDesejaAtualizar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblUpdate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEstadoConexao = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblVersion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.imgbuttonTitulo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelFundoMenus = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnLucros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTodosServicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServicosAndamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.arrastarForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backVerificarConexao = new System.ComponentModel.BackgroundWorker();
            this.backVerificarVersao = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbuttonTitulo)).BeginInit();
            this.panelFundoMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnNaoAtualizar);
            this.panel1.Controls.Add(this.btnSimAtualizar);
            this.panel1.Controls.Add(this.lblDesejaAtualizar);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.lblUpdate);
            this.panel1.Controls.Add(this.lblEstadoConexao);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblIp);
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
            // btnNaoAtualizar
            // 
            this.btnNaoAtualizar.AllowAnimations = true;
            this.btnNaoAtualizar.AllowMouseEffects = true;
            this.btnNaoAtualizar.AllowToggling = false;
            this.btnNaoAtualizar.AnimationSpeed = 200;
            this.btnNaoAtualizar.AutoGenerateColors = false;
            this.btnNaoAtualizar.AutoRoundBorders = false;
            this.btnNaoAtualizar.AutoSizeLeftIcon = true;
            this.btnNaoAtualizar.AutoSizeRightIcon = true;
            this.btnNaoAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnNaoAtualizar.BackColor1 = System.Drawing.Color.Gray;
            this.btnNaoAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNaoAtualizar.BackgroundImage")));
            this.btnNaoAtualizar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNaoAtualizar.ButtonText = "NAO";
            this.btnNaoAtualizar.ButtonTextMarginLeft = 0;
            this.btnNaoAtualizar.ColorContrastOnClick = 45;
            this.btnNaoAtualizar.ColorContrastOnHover = 45;
            this.btnNaoAtualizar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNaoAtualizar.CustomizableEdges = borderEdges1;
            this.btnNaoAtualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNaoAtualizar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNaoAtualizar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNaoAtualizar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNaoAtualizar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNaoAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNaoAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnNaoAtualizar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNaoAtualizar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNaoAtualizar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNaoAtualizar.IconMarginLeft = 11;
            this.btnNaoAtualizar.IconPadding = 10;
            this.btnNaoAtualizar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNaoAtualizar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNaoAtualizar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNaoAtualizar.IconSize = 25;
            this.btnNaoAtualizar.IdleBorderColor = System.Drawing.Color.Gray;
            this.btnNaoAtualizar.IdleBorderRadius = 1;
            this.btnNaoAtualizar.IdleBorderThickness = 1;
            this.btnNaoAtualizar.IdleFillColor = System.Drawing.Color.Gray;
            this.btnNaoAtualizar.IdleIconLeftImage = null;
            this.btnNaoAtualizar.IdleIconRightImage = null;
            this.btnNaoAtualizar.IndicateFocus = false;
            this.btnNaoAtualizar.Location = new System.Drawing.Point(1151, 9);
            this.btnNaoAtualizar.Name = "btnNaoAtualizar";
            this.btnNaoAtualizar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNaoAtualizar.OnDisabledState.BorderRadius = 1;
            this.btnNaoAtualizar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNaoAtualizar.OnDisabledState.BorderThickness = 1;
            this.btnNaoAtualizar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNaoAtualizar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNaoAtualizar.OnDisabledState.IconLeftImage = null;
            this.btnNaoAtualizar.OnDisabledState.IconRightImage = null;
            this.btnNaoAtualizar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNaoAtualizar.onHoverState.BorderRadius = 1;
            this.btnNaoAtualizar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNaoAtualizar.onHoverState.BorderThickness = 1;
            this.btnNaoAtualizar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNaoAtualizar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNaoAtualizar.onHoverState.IconLeftImage = null;
            this.btnNaoAtualizar.onHoverState.IconRightImage = null;
            this.btnNaoAtualizar.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnNaoAtualizar.OnIdleState.BorderRadius = 1;
            this.btnNaoAtualizar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNaoAtualizar.OnIdleState.BorderThickness = 1;
            this.btnNaoAtualizar.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnNaoAtualizar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNaoAtualizar.OnIdleState.IconLeftImage = null;
            this.btnNaoAtualizar.OnIdleState.IconRightImage = null;
            this.btnNaoAtualizar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNaoAtualizar.OnPressedState.BorderRadius = 1;
            this.btnNaoAtualizar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNaoAtualizar.OnPressedState.BorderThickness = 1;
            this.btnNaoAtualizar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNaoAtualizar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNaoAtualizar.OnPressedState.IconLeftImage = null;
            this.btnNaoAtualizar.OnPressedState.IconRightImage = null;
            this.btnNaoAtualizar.Size = new System.Drawing.Size(55, 18);
            this.btnNaoAtualizar.TabIndex = 26;
            this.btnNaoAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNaoAtualizar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNaoAtualizar.TextMarginLeft = 0;
            this.btnNaoAtualizar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNaoAtualizar.UseDefaultRadiusAndThickness = true;
            this.btnNaoAtualizar.Visible = false;
            this.btnNaoAtualizar.Click += new System.EventHandler(this.btnNaoAtualizar_Click);
            // 
            // btnSimAtualizar
            // 
            this.btnSimAtualizar.AllowAnimations = true;
            this.btnSimAtualizar.AllowMouseEffects = true;
            this.btnSimAtualizar.AllowToggling = false;
            this.btnSimAtualizar.AnimationSpeed = 200;
            this.btnSimAtualizar.AutoGenerateColors = false;
            this.btnSimAtualizar.AutoRoundBorders = false;
            this.btnSimAtualizar.AutoSizeLeftIcon = true;
            this.btnSimAtualizar.AutoSizeRightIcon = true;
            this.btnSimAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnSimAtualizar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSimAtualizar.BackgroundImage")));
            this.btnSimAtualizar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSimAtualizar.ButtonText = "SIM";
            this.btnSimAtualizar.ButtonTextMarginLeft = 0;
            this.btnSimAtualizar.ColorContrastOnClick = 45;
            this.btnSimAtualizar.ColorContrastOnHover = 45;
            this.btnSimAtualizar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSimAtualizar.CustomizableEdges = borderEdges2;
            this.btnSimAtualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSimAtualizar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSimAtualizar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSimAtualizar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSimAtualizar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSimAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnSimAtualizar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimAtualizar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSimAtualizar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSimAtualizar.IconMarginLeft = 11;
            this.btnSimAtualizar.IconPadding = 10;
            this.btnSimAtualizar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimAtualizar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSimAtualizar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSimAtualizar.IconSize = 25;
            this.btnSimAtualizar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.IdleBorderRadius = 1;
            this.btnSimAtualizar.IdleBorderThickness = 1;
            this.btnSimAtualizar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.IdleIconLeftImage = null;
            this.btnSimAtualizar.IdleIconRightImage = null;
            this.btnSimAtualizar.IndicateFocus = false;
            this.btnSimAtualizar.Location = new System.Drawing.Point(1087, 9);
            this.btnSimAtualizar.Name = "btnSimAtualizar";
            this.btnSimAtualizar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSimAtualizar.OnDisabledState.BorderRadius = 1;
            this.btnSimAtualizar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSimAtualizar.OnDisabledState.BorderThickness = 1;
            this.btnSimAtualizar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSimAtualizar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSimAtualizar.OnDisabledState.IconLeftImage = null;
            this.btnSimAtualizar.OnDisabledState.IconRightImage = null;
            this.btnSimAtualizar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.onHoverState.BorderRadius = 1;
            this.btnSimAtualizar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSimAtualizar.onHoverState.BorderThickness = 1;
            this.btnSimAtualizar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSimAtualizar.onHoverState.IconLeftImage = null;
            this.btnSimAtualizar.onHoverState.IconRightImage = null;
            this.btnSimAtualizar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.OnIdleState.BorderRadius = 1;
            this.btnSimAtualizar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSimAtualizar.OnIdleState.BorderThickness = 1;
            this.btnSimAtualizar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSimAtualizar.OnIdleState.IconLeftImage = null;
            this.btnSimAtualizar.OnIdleState.IconRightImage = null;
            this.btnSimAtualizar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.OnPressedState.BorderRadius = 1;
            this.btnSimAtualizar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSimAtualizar.OnPressedState.BorderThickness = 1;
            this.btnSimAtualizar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSimAtualizar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSimAtualizar.OnPressedState.IconLeftImage = null;
            this.btnSimAtualizar.OnPressedState.IconRightImage = null;
            this.btnSimAtualizar.Size = new System.Drawing.Size(55, 18);
            this.btnSimAtualizar.TabIndex = 25;
            this.btnSimAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimAtualizar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSimAtualizar.TextMarginLeft = 0;
            this.btnSimAtualizar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSimAtualizar.UseDefaultRadiusAndThickness = true;
            this.btnSimAtualizar.Visible = false;
            this.btnSimAtualizar.Click += new System.EventHandler(this.btnSimAtualizar_Click);
            // 
            // lblDesejaAtualizar
            // 
            this.lblDesejaAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesejaAtualizar.AutoSize = true;
            this.lblDesejaAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesejaAtualizar.ForeColor = System.Drawing.Color.White;
            this.lblDesejaAtualizar.Location = new System.Drawing.Point(982, 10);
            this.lblDesejaAtualizar.Name = "lblDesejaAtualizar";
            this.lblDesejaAtualizar.Size = new System.Drawing.Size(97, 15);
            this.lblDesejaAtualizar.TabIndex = 24;
            this.lblDesejaAtualizar.Text = "Deseja Atualizar?";
            this.lblDesejaAtualizar.Visible = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(333, 0);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator3.Size = new System.Drawing.Size(14, 34);
            this.bunifuSeparator3.TabIndex = 19;
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblUpdate.Location = new System.Drawing.Point(187, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(144, 15);
            this.lblUpdate.TabIndex = 18;
            this.lblUpdate.Text = "Verificando atualizações...";
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // lblEstadoConexao
            // 
            this.lblEstadoConexao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstadoConexao.AutoSize = true;
            this.lblEstadoConexao.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblEstadoConexao.Location = new System.Drawing.Point(350, 11);
            this.lblEstadoConexao.Name = "lblEstadoConexao";
            this.lblEstadoConexao.Size = new System.Drawing.Size(119, 13);
            this.lblEstadoConexao.TabIndex = 17;
            this.lblEstadoConexao.Text = "Conectado ao Servidor!";
            this.lblEstadoConexao.Click += new System.EventHandler(this.lblEstadoConexao_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(169, 0);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator2.Size = new System.Drawing.Size(14, 34);
            this.bunifuSeparator2.TabIndex = 16;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(46, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(14, 34);
            this.bunifuSeparator1.TabIndex = 15;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVersion.Location = new System.Drawing.Point(12, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(31, 13);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "3.1.1";
            // 
            // lblIp
            // 
            this.lblIp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIp.AutoSize = true;
            this.lblIp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIp.Location = new System.Drawing.Point(63, 9);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(103, 13);
            this.lblIp.TabIndex = 12;
            this.lblIp.Text = "999.999.9.999,1433";
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
            this.imgbuttonTitulo.Size = new System.Drawing.Size(229, 31);
            this.imgbuttonTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbuttonTitulo.TabIndex = 9;
            this.imgbuttonTitulo.TabStop = false;
            this.imgbuttonTitulo.Zoom = 10;
            this.imgbuttonTitulo.Click += new System.EventHandler(this.imgbuttonTitulo_Click);
            // 
            // panelFundoMenus
            // 
            this.panelFundoMenus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFundoMenus.BackgroundImage")));
            this.panelFundoMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundoMenus.Controls.Add(this.btnLucros);
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
            // btnLucros
            // 
            this.btnLucros.Active = false;
            this.btnLucros.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLucros.BackColor = System.Drawing.Color.Transparent;
            this.btnLucros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLucros.BorderRadius = 0;
            this.btnLucros.ButtonText = "LUCROS";
            this.btnLucros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLucros.DisabledColor = System.Drawing.Color.Gray;
            this.btnLucros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLucros.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLucros.Iconimage")));
            this.btnLucros.Iconimage_right = null;
            this.btnLucros.Iconimage_right_Selected = null;
            this.btnLucros.Iconimage_Selected = null;
            this.btnLucros.IconMarginLeft = 0;
            this.btnLucros.IconMarginRight = 0;
            this.btnLucros.IconRightVisible = true;
            this.btnLucros.IconRightZoom = 0D;
            this.btnLucros.IconVisible = false;
            this.btnLucros.IconZoom = 90D;
            this.btnLucros.IsTab = false;
            this.btnLucros.Location = new System.Drawing.Point(850, 0);
            this.btnLucros.Name = "btnLucros";
            this.btnLucros.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLucros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnLucros.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLucros.selected = false;
            this.btnLucros.Size = new System.Drawing.Size(433, 36);
            this.btnLucros.TabIndex = 2;
            this.btnLucros.Text = "LUCROS";
            this.btnLucros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLucros.Textcolor = System.Drawing.Color.White;
            this.btnLucros.TextFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            this.btnLucros.Click += new System.EventHandler(this.btnLucros_Click);
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
            this.btnTodosServicos.Location = new System.Drawing.Point(426, 0);
            this.btnTodosServicos.Name = "btnTodosServicos";
            this.btnTodosServicos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTodosServicos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnTodosServicos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTodosServicos.selected = false;
            this.btnTodosServicos.Size = new System.Drawing.Size(426, 36);
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
            this.btnServicosAndamento.Location = new System.Drawing.Point(-5, 0);
            this.btnServicosAndamento.Name = "btnServicosAndamento";
            this.btnServicosAndamento.Normalcolor = System.Drawing.Color.Transparent;
            this.btnServicosAndamento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnServicosAndamento.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServicosAndamento.selected = false;
            this.btnServicosAndamento.Size = new System.Drawing.Size(433, 36);
            this.btnServicosAndamento.TabIndex = 0;
            this.btnServicosAndamento.Text = "ANDAMENTO";
            this.btnServicosAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnServicosAndamento.Textcolor = System.Drawing.Color.White;
            this.btnServicosAndamento.TextFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            this.btnServicosAndamento.Click += new System.EventHandler(this.btnServicosAndamento_Click_1);
            // 
            // arrastarForm
            // 
            this.arrastarForm.Fixed = true;
            this.arrastarForm.Horizontal = true;
            this.arrastarForm.TargetControl = this.panel1;
            this.arrastarForm.Vertical = true;
            // 
            // backVerificarConexao
            // 
            this.backVerificarConexao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backVerificarConexao_DoWork);
            // 
            // backVerificarVersao
            // 
            this.backVerificarVersao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backVerificarVersao_DoWork);
            this.backVerificarVersao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backVerificarVersao_RunWorkerCompleted);
            // 
            // form_PrincipalClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_PrincipalClientServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientServer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbuttonTitulo)).EndInit();
            this.panelFundoMenus.ResumeLayout(false);
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
        public Bunifu.Framework.UI.BunifuCustomLabel lblIp;
        private Bunifu.Framework.UI.BunifuDragControl arrastarForm;
        public Bunifu.Framework.UI.BunifuCustomLabel lblVersion;
        private Bunifu.Framework.UI.BunifuFlatButton btnLucros;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        public Bunifu.Framework.UI.BunifuCustomLabel lblEstadoConexao;
        private System.ComponentModel.BackgroundWorker backVerificarConexao;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        public Bunifu.Framework.UI.BunifuCustomLabel lblUpdate;
        private System.ComponentModel.BackgroundWorker backVerificarVersao;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNaoAtualizar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSimAtualizar;
        public Bunifu.Framework.UI.BunifuCustomLabel lblDesejaAtualizar;
    }
}

