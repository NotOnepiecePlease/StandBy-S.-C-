namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Lucros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation13 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Lucros));
            BunifuAnimatorNS.Animation animation14 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation15 = new BunifuAnimatorNS.Animation();
            this.panelLucros = new Guna.UI.WinForms.GunaPanel();
            this.panelBarH = new Guna.UI.WinForms.GunaPanel();
            this.btnAddGastos = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblGastos = new Guna.UI.WinForms.GunaLabel();
            this.checkGastos = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.tabelaGastos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gst_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qst_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qst_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_temporario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tornarTemporarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tornarRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSemDados = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnExecutarThread = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tabelaLucros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sv_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_defeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_valorservico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_valorpeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.panelResults = new Guna.UI.WinForms.GunaPanel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.circle4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblDesc4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGastosValor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblValorServico = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.circle1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.circle3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblDesc1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.circle2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblDesc3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDesc2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLucro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblValorPeca = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.animateCircle1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animateCircle2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animateCircle3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backWork1 = new System.ComponentModel.BackgroundWorker();
            this.backWork2 = new System.ComponentModel.BackgroundWorker();
            this.backWork3 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.animateRealSimbol = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animateCircle4 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backWork4 = new System.ComponentModel.BackgroundWorker();
            this.panelLucros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaGastos)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLucros)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLucros
            // 
            this.panelLucros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelLucros.Controls.Add(this.panelBarH);
            this.panelLucros.Controls.Add(this.btnAddGastos);
            this.panelLucros.Controls.Add(this.lblGastos);
            this.panelLucros.Controls.Add(this.checkGastos);
            this.panelLucros.Controls.Add(this.tabelaGastos);
            this.panelLucros.Controls.Add(this.lblSemDados);
            this.panelLucros.Controls.Add(this.datepicker2);
            this.panelLucros.Controls.Add(this.datepicker1);
            this.panelLucros.Controls.Add(this.btnExecutarThread);
            this.panelLucros.Controls.Add(this.tabelaLucros);
            this.panelLucros.Controls.Add(this.gunaPanel1);
            this.animateCircle3.SetDecoration(this.panelLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.panelLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.panelLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.panelLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.panelLucros, BunifuAnimatorNS.DecorationType.None);
            this.panelLucros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLucros.Location = new System.Drawing.Point(0, 0);
            this.panelLucros.Name = "panelLucros";
            this.panelLucros.Size = new System.Drawing.Size(1081, 665);
            this.panelLucros.TabIndex = 0;
            // 
            // panelBarH
            // 
            this.panelBarH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.animateCircle3.SetDecoration(this.panelBarH, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.panelBarH, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.panelBarH, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.panelBarH, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.panelBarH, BunifuAnimatorNS.DecorationType.None);
            this.panelBarH.Location = new System.Drawing.Point(0, 436);
            this.panelBarH.Name = "panelBarH";
            this.panelBarH.Size = new System.Drawing.Size(1081, 6);
            this.panelBarH.TabIndex = 28;
            // 
            // btnAddGastos
            // 
            this.btnAddGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddGastos.AnimationHoverSpeed = 0.07F;
            this.btnAddGastos.AnimationSpeed = 0.03F;
            this.btnAddGastos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnAddGastos.BorderColor = System.Drawing.Color.Black;
            this.btnAddGastos.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddGastos.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddGastos.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddGastos.CheckedImage = null;
            this.btnAddGastos.CheckedLineColor = System.Drawing.Color.DimGray;
            this.animateCircle2.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.btnAddGastos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddGastos.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddGastos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGastos.ForeColor = System.Drawing.Color.White;
            this.btnAddGastos.Image = null;
            this.btnAddGastos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddGastos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddGastos.Location = new System.Drawing.Point(11, 396);
            this.btnAddGastos.Name = "btnAddGastos";
            this.btnAddGastos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnAddGastos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddGastos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddGastos.OnHoverImage = null;
            this.btnAddGastos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddGastos.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddGastos.Size = new System.Drawing.Size(178, 26);
            this.btnAddGastos.TabIndex = 26;
            this.btnAddGastos.Text = "Adicionar Gastos";
            this.btnAddGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddGastos.Click += new System.EventHandler(this.btnAddGastos_Click);
            // 
            // lblGastos
            // 
            this.lblGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGastos.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.lblGastos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGastos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGastos.Location = new System.Drawing.Point(50, 374);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(121, 15);
            this.lblGastos.TabIndex = 25;
            this.lblGastos.Text = "Exibindo Gastos Reais";
            // 
            // checkGastos
            // 
            this.checkGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkGastos.BaseColor = System.Drawing.SystemColors.Control;
            this.checkGastos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.checkGastos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.animateCircle4.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.checkGastos.FillColor = System.Drawing.Color.White;
            this.checkGastos.Location = new System.Drawing.Point(11, 372);
            this.checkGastos.Name = "checkGastos";
            this.checkGastos.Size = new System.Drawing.Size(43, 20);
            this.checkGastos.TabIndex = 24;
            this.checkGastos.CheckedChanged += new System.EventHandler(this.checkGastos_CheckedChanged);
            // 
            // tabelaGastos
            // 
            this.tabelaGastos.AllowUserToAddRows = false;
            this.tabelaGastos.AllowUserToDeleteRows = false;
            this.tabelaGastos.AllowUserToOrderColumns = true;
            this.tabelaGastos.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tabelaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabelaGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaGastos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tabelaGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tabelaGastos.ColumnHeadersHeight = 35;
            this.tabelaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gst_id,
            this.qst_data,
            this.qst_produto,
            this.gst_valor,
            this.gst_temporario});
            this.tabelaGastos.ContextMenuStrip = this.menu;
            this.animateCircle4.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.tabelaGastos.DoubleBuffered = true;
            this.tabelaGastos.EnableHeadersVisualStyles = false;
            this.tabelaGastos.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.tabelaGastos.HeaderForeColor = System.Drawing.Color.Black;
            this.tabelaGastos.Location = new System.Drawing.Point(12, 12);
            this.tabelaGastos.Name = "tabelaGastos";
            this.tabelaGastos.ReadOnly = true;
            this.tabelaGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tabelaGastos.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.tabelaGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaGastos.Size = new System.Drawing.Size(178, 354);
            this.tabelaGastos.TabIndex = 23;
            this.tabelaGastos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaGastos_CellDoubleClick);
            this.tabelaGastos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabelaGastos_MouseDown);
            // 
            // gst_id
            // 
            this.gst_id.DataPropertyName = "gst_id";
            this.gst_id.HeaderText = "gst_id";
            this.gst_id.Name = "gst_id";
            this.gst_id.ReadOnly = true;
            this.gst_id.Visible = false;
            // 
            // qst_data
            // 
            this.qst_data.DataPropertyName = "gst_data";
            this.qst_data.HeaderText = "Data";
            this.qst_data.Name = "qst_data";
            this.qst_data.ReadOnly = true;
            this.qst_data.Visible = false;
            this.qst_data.Width = 50;
            // 
            // qst_produto
            // 
            this.qst_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qst_produto.DataPropertyName = "gst_produto";
            this.qst_produto.HeaderText = "Produto";
            this.qst_produto.Name = "qst_produto";
            this.qst_produto.ReadOnly = true;
            // 
            // gst_valor
            // 
            this.gst_valor.DataPropertyName = "gst_valor";
            this.gst_valor.HeaderText = "Valor";
            this.gst_valor.Name = "gst_valor";
            this.gst_valor.ReadOnly = true;
            this.gst_valor.Width = 50;
            // 
            // gst_temporario
            // 
            this.gst_temporario.DataPropertyName = "gst_temporario";
            this.gst_temporario.HeaderText = "gst_temporario";
            this.gst_temporario.Name = "gst_temporario";
            this.gst_temporario.ReadOnly = true;
            this.gst_temporario.Visible = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.animateCircle4.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tornarTemporarioToolStripMenuItem,
            this.tornarRealToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.ShowImageMargin = false;
            this.menu.Size = new System.Drawing.Size(145, 92);
            // 
            // tornarTemporarioToolStripMenuItem
            // 
            this.tornarTemporarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.tornarTemporarioToolStripMenuItem.Name = "tornarTemporarioToolStripMenuItem";
            this.tornarTemporarioToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tornarTemporarioToolStripMenuItem.Text = "Tornar temporario";
            this.tornarTemporarioToolStripMenuItem.Click += new System.EventHandler(this.tornarTemporarioToolStripMenuItem_Click);
            // 
            // tornarRealToolStripMenuItem
            // 
            this.tornarRealToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.tornarRealToolStripMenuItem.Name = "tornarRealToolStripMenuItem";
            this.tornarRealToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tornarRealToolStripMenuItem.Text = "Tornar real";
            this.tornarRealToolStripMenuItem.Click += new System.EventHandler(this.tornarRealToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // lblSemDados
            // 
            this.lblSemDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemDados.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.lblSemDados.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemDados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSemDados.Location = new System.Drawing.Point(277, 194);
            this.lblSemDados.Name = "lblSemDados";
            this.lblSemDados.Size = new System.Drawing.Size(492, 56);
            this.lblSemDados.TabIndex = 22;
            this.lblSemDados.Text = "Nao existem dados!";
            this.lblSemDados.Visible = false;
            // 
            // datepicker2
            // 
            this.datepicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datepicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.datepicker2.BorderRadius = 0;
            this.animateCircle3.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.datepicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker2.ForeColor = System.Drawing.Color.White;
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker2.FormatCustom = null;
            this.datepicker2.Location = new System.Drawing.Point(584, 456);
            this.datepicker2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(191, 42);
            this.datepicker2.TabIndex = 21;
            this.datepicker2.Value = new System.DateTime(2021, 6, 11, 0, 0, 0, 0);
            // 
            // datepicker1
            // 
            this.datepicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.datepicker1.BorderRadius = 0;
            this.animateCircle3.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.datepicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.datepicker1.ForeColor = System.Drawing.Color.White;
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker1.FormatCustom = null;
            this.datepicker1.Location = new System.Drawing.Point(275, 456);
            this.datepicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(191, 42);
            this.datepicker1.TabIndex = 20;
            this.datepicker1.Value = new System.DateTime(2020, 6, 11, 0, 0, 0, 0);
            // 
            // btnExecutarThread
            // 
            this.btnExecutarThread.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExecutarThread.Animated = true;
            this.btnExecutarThread.AnimationHoverSpeed = 0.07F;
            this.btnExecutarThread.AnimationSpeed = 0.03F;
            this.btnExecutarThread.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnExecutarThread.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnExecutarThread.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExecutarThread.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExecutarThread.CheckedForeColor = System.Drawing.Color.White;
            this.btnExecutarThread.CheckedImage = null;
            this.btnExecutarThread.CheckedLineColor = System.Drawing.Color.DimGray;
            this.animateCircle2.SetDecoration(this.btnExecutarThread, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.btnExecutarThread, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.btnExecutarThread, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.btnExecutarThread, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.btnExecutarThread, BunifuAnimatorNS.DecorationType.None);
            this.btnExecutarThread.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExecutarThread.FocusedColor = System.Drawing.Color.Empty;
            this.btnExecutarThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExecutarThread.ForeColor = System.Drawing.Color.White;
            this.btnExecutarThread.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_search_500px;
            this.btnExecutarThread.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExecutarThread.ImageOffsetX = 1;
            this.btnExecutarThread.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExecutarThread.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExecutarThread.Location = new System.Drawing.Point(501, 454);
            this.btnExecutarThread.Name = "btnExecutarThread";
            this.btnExecutarThread.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnExecutarThread.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExecutarThread.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExecutarThread.OnHoverImage = null;
            this.btnExecutarThread.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExecutarThread.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExecutarThread.Size = new System.Drawing.Size(52, 46);
            this.btnExecutarThread.TabIndex = 13;
            this.btnExecutarThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExecutarThread.Click += new System.EventHandler(this.btnExecutarThread_Click);
            // 
            // tabelaLucros
            // 
            this.tabelaLucros.AllowUserToAddRows = false;
            this.tabelaLucros.AllowUserToDeleteRows = false;
            this.tabelaLucros.AllowUserToOrderColumns = true;
            this.tabelaLucros.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaLucros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tabelaLucros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaLucros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaLucros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaLucros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaLucros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tabelaLucros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaLucros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tabelaLucros.ColumnHeadersHeight = 35;
            this.tabelaLucros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaLucros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sv_data,
            this.cl_nome,
            this.sv_aparelho,
            this.sv_defeito,
            this.sv_situacao,
            this.sv_valorservico,
            this.sv_valorpeca,
            this.sv_lucro});
            this.animateCircle4.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.tabelaLucros.DoubleBuffered = true;
            this.tabelaLucros.EnableHeadersVisualStyles = false;
            this.tabelaLucros.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.tabelaLucros.HeaderForeColor = System.Drawing.Color.Black;
            this.tabelaLucros.Location = new System.Drawing.Point(196, 12);
            this.tabelaLucros.Name = "tabelaLucros";
            this.tabelaLucros.ReadOnly = true;
            this.tabelaLucros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaLucros.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tabelaLucros.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaLucros.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tabelaLucros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaLucros.Size = new System.Drawing.Size(873, 430);
            this.tabelaLucros.TabIndex = 11;
            // 
            // sv_data
            // 
            this.sv_data.DataPropertyName = "sv_data";
            this.sv_data.HeaderText = "Data";
            this.sv_data.Name = "sv_data";
            this.sv_data.ReadOnly = true;
            // 
            // cl_nome
            // 
            this.cl_nome.DataPropertyName = "cl_nome";
            this.cl_nome.HeaderText = "Cliente";
            this.cl_nome.Name = "cl_nome";
            this.cl_nome.ReadOnly = true;
            this.cl_nome.Width = 170;
            // 
            // sv_aparelho
            // 
            this.sv_aparelho.DataPropertyName = "sv_aparelho";
            this.sv_aparelho.HeaderText = "Aparelho";
            this.sv_aparelho.Name = "sv_aparelho";
            this.sv_aparelho.ReadOnly = true;
            // 
            // sv_defeito
            // 
            this.sv_defeito.DataPropertyName = "sv_defeito";
            this.sv_defeito.HeaderText = "Defeito";
            this.sv_defeito.Name = "sv_defeito";
            this.sv_defeito.ReadOnly = true;
            this.sv_defeito.Width = 150;
            // 
            // sv_situacao
            // 
            this.sv_situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sv_situacao.DataPropertyName = "sv_situacao";
            this.sv_situacao.HeaderText = "Situação";
            this.sv_situacao.Name = "sv_situacao";
            this.sv_situacao.ReadOnly = true;
            // 
            // sv_valorservico
            // 
            this.sv_valorservico.DataPropertyName = "sv_valorservico";
            this.sv_valorservico.HeaderText = "R$ Serviço";
            this.sv_valorservico.Name = "sv_valorservico";
            this.sv_valorservico.ReadOnly = true;
            this.sv_valorservico.Width = 60;
            // 
            // sv_valorpeca
            // 
            this.sv_valorpeca.DataPropertyName = "sv_valorpeca";
            this.sv_valorpeca.HeaderText = "R$ Peça";
            this.sv_valorpeca.Name = "sv_valorpeca";
            this.sv_valorpeca.ReadOnly = true;
            this.sv_valorpeca.Width = 60;
            // 
            // sv_lucro
            // 
            this.sv_lucro.DataPropertyName = "sv_lucro";
            this.sv_lucro.HeaderText = "R$ Lucro";
            this.sv_lucro.Name = "sv_lucro";
            this.sv_lucro.ReadOnly = true;
            this.sv_lucro.Width = 60;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.gunaPanel1.Controls.Add(this.panelResults);
            this.animateCircle3.SetDecoration(this.gunaPanel1, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.gunaPanel1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.gunaPanel1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.gunaPanel1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.gunaPanel1, BunifuAnimatorNS.DecorationType.None);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 510);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1081, 155);
            this.gunaPanel1.TabIndex = 22;
            // 
            // panelResults
            // 
            this.panelResults.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.panelResults.Controls.Add(this.bunifuCustomLabel4);
            this.panelResults.Controls.Add(this.circle4);
            this.panelResults.Controls.Add(this.lblDesc4);
            this.panelResults.Controls.Add(this.lblGastosValor);
            this.panelResults.Controls.Add(this.bunifuCustomLabel3);
            this.panelResults.Controls.Add(this.bunifuCustomLabel2);
            this.panelResults.Controls.Add(this.bunifuCustomLabel1);
            this.panelResults.Controls.Add(this.lblValorServico);
            this.panelResults.Controls.Add(this.circle1);
            this.panelResults.Controls.Add(this.circle3);
            this.panelResults.Controls.Add(this.lblDesc1);
            this.panelResults.Controls.Add(this.circle2);
            this.panelResults.Controls.Add(this.lblDesc3);
            this.panelResults.Controls.Add(this.lblDesc2);
            this.panelResults.Controls.Add(this.lblLucro);
            this.panelResults.Controls.Add(this.lblValorPeca);
            this.animateCircle3.SetDecoration(this.panelResults, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.panelResults, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.panelResults, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.panelResults, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.panelResults, BunifuAnimatorNS.DecorationType.None);
            this.panelResults.Location = new System.Drawing.Point(0, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(1081, 155);
            this.panelResults.TabIndex = 19;
            this.panelResults.Visible = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.animateCircle3.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(168, 40);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(35, 24);
            this.bunifuCustomLabel4.TabIndex = 25;
            this.bunifuCustomLabel4.Text = "R$";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circle4
            // 
            this.circle4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.circle4.animated = false;
            this.circle4.animationIterval = 5;
            this.circle4.animationSpeed = 1;
            this.circle4.BackColor = System.Drawing.Color.Transparent;
            this.circle4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle4.BackgroundImage")));
            this.animateCircle3.SetDecoration(this.circle4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.circle4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.circle4, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.circle4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.circle4, BunifuAnimatorNS.DecorationType.None);
            this.circle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.circle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circle4.LabelVisible = false;
            this.circle4.LineProgressThickness = 5;
            this.circle4.LineThickness = 3;
            this.circle4.Location = new System.Drawing.Point(143, 8);
            this.circle4.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.circle4.MaxValue = 100;
            this.circle4.Name = "circle4";
            this.circle4.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circle4.Size = new System.Drawing.Size(84, 84);
            this.circle4.TabIndex = 24;
            this.circle4.Value = 0;
            this.circle4.Visible = false;
            // 
            // lblDesc4
            // 
            this.lblDesc4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDesc4.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.lblDesc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDesc4.ForeColor = System.Drawing.Color.Silver;
            this.lblDesc4.Location = new System.Drawing.Point(145, 118);
            this.lblDesc4.Name = "lblDesc4";
            this.lblDesc4.Size = new System.Drawing.Size(81, 15);
            this.lblDesc4.TabIndex = 23;
            this.lblDesc4.Text = "Gastos Totais";
            this.lblDesc4.Visible = false;
            // 
            // lblGastosValor
            // 
            this.lblGastosValor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblGastosValor.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.lblGastosValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosValor.ForeColor = System.Drawing.Color.Silver;
            this.lblGastosValor.Location = new System.Drawing.Point(155, 94);
            this.lblGastosValor.Name = "lblGastosValor";
            this.lblGastosValor.Size = new System.Drawing.Size(60, 24);
            this.lblGastosValor.TabIndex = 22;
            this.lblGastosValor.Text = "00.00";
            this.lblGastosValor.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.animateCircle3.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(868, 40);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(35, 24);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "R$";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.animateCircle3.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(630, 40);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(35, 24);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "R$";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.animateCircle3.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(390, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(35, 24);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "R$";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorServico
            // 
            this.lblValorServico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblValorServico.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblValorServico, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblValorServico, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblValorServico, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblValorServico, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblValorServico, BunifuAnimatorNS.DecorationType.None);
            this.lblValorServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorServico.ForeColor = System.Drawing.Color.Silver;
            this.lblValorServico.Location = new System.Drawing.Point(377, 94);
            this.lblValorServico.Name = "lblValorServico";
            this.lblValorServico.Size = new System.Drawing.Size(60, 24);
            this.lblValorServico.TabIndex = 5;
            this.lblValorServico.Text = "00.00";
            this.lblValorServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValorServico.Visible = false;
            // 
            // circle1
            // 
            this.circle1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.circle1.animated = false;
            this.circle1.animationIterval = 5;
            this.circle1.animationSpeed = 1;
            this.circle1.BackColor = System.Drawing.Color.Transparent;
            this.circle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle1.BackgroundImage")));
            this.animateCircle3.SetDecoration(this.circle1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.circle1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.circle1, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.circle1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.circle1, BunifuAnimatorNS.DecorationType.None);
            this.circle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circle1.LabelVisible = false;
            this.circle1.LineProgressThickness = 5;
            this.circle1.LineThickness = 3;
            this.circle1.Location = new System.Drawing.Point(365, 8);
            this.circle1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.circle1.MaxValue = 100;
            this.circle1.Name = "circle1";
            this.circle1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circle1.Size = new System.Drawing.Size(84, 84);
            this.circle1.TabIndex = 4;
            this.circle1.Value = 0;
            this.circle1.Visible = false;
            // 
            // circle3
            // 
            this.circle3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.circle3.animated = false;
            this.circle3.animationIterval = 5;
            this.circle3.animationSpeed = 1;
            this.circle3.BackColor = System.Drawing.Color.Transparent;
            this.circle3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle3.BackgroundImage")));
            this.animateCircle3.SetDecoration(this.circle3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.circle3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.circle3, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.circle3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.circle3, BunifuAnimatorNS.DecorationType.None);
            this.circle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.circle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circle3.LabelVisible = false;
            this.circle3.LineProgressThickness = 5;
            this.circle3.LineThickness = 3;
            this.circle3.Location = new System.Drawing.Point(843, 8);
            this.circle3.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.circle3.MaxValue = 100;
            this.circle3.Name = "circle3";
            this.circle3.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circle3.Size = new System.Drawing.Size(84, 84);
            this.circle3.TabIndex = 18;
            this.circle3.Value = 0;
            this.circle3.Visible = false;
            // 
            // lblDesc1
            // 
            this.lblDesc1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDesc1.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.lblDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc1.ForeColor = System.Drawing.Color.Silver;
            this.lblDesc1.Location = new System.Drawing.Point(363, 118);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(89, 15);
            this.lblDesc1.TabIndex = 9;
            this.lblDesc1.Text = "Serviços Totais";
            this.lblDesc1.Visible = false;
            // 
            // circle2
            // 
            this.circle2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.circle2.animated = false;
            this.circle2.animationIterval = 5;
            this.circle2.animationSpeed = 1;
            this.circle2.BackColor = System.Drawing.Color.Transparent;
            this.circle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle2.BackgroundImage")));
            this.animateCircle3.SetDecoration(this.circle2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.circle2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.circle2, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.circle2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.circle2, BunifuAnimatorNS.DecorationType.None);
            this.circle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.circle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circle2.LabelVisible = false;
            this.circle2.LineProgressThickness = 5;
            this.circle2.LineThickness = 3;
            this.circle2.Location = new System.Drawing.Point(605, 8);
            this.circle2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.circle2.MaxValue = 100;
            this.circle2.Name = "circle2";
            this.circle2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circle2.Size = new System.Drawing.Size(84, 84);
            this.circle2.TabIndex = 17;
            this.circle2.Value = 0;
            this.circle2.Visible = false;
            // 
            // lblDesc3
            // 
            this.lblDesc3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDesc3.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.lblDesc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDesc3.ForeColor = System.Drawing.Color.Silver;
            this.lblDesc3.Location = new System.Drawing.Point(851, 118);
            this.lblDesc3.Name = "lblDesc3";
            this.lblDesc3.Size = new System.Drawing.Size(68, 15);
            this.lblDesc3.TabIndex = 10;
            this.lblDesc3.Text = "Lucro Total";
            this.lblDesc3.Visible = false;
            // 
            // lblDesc2
            // 
            this.lblDesc2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDesc2.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblDesc2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblDesc2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblDesc2, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblDesc2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblDesc2, BunifuAnimatorNS.DecorationType.None);
            this.lblDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDesc2.ForeColor = System.Drawing.Color.Silver;
            this.lblDesc2.Location = new System.Drawing.Point(609, 118);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(77, 15);
            this.lblDesc2.TabIndex = 16;
            this.lblDesc2.Text = "Peças Totais";
            this.lblDesc2.Visible = false;
            // 
            // lblLucro
            // 
            this.lblLucro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLucro.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.lblLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.ForeColor = System.Drawing.Color.Silver;
            this.lblLucro.Location = new System.Drawing.Point(855, 94);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(60, 24);
            this.lblLucro.TabIndex = 7;
            this.lblLucro.Text = "00.00";
            this.lblLucro.Visible = false;
            // 
            // lblValorPeca
            // 
            this.lblValorPeca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblValorPeca.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblValorPeca, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblValorPeca, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblValorPeca, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this.lblValorPeca, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblValorPeca, BunifuAnimatorNS.DecorationType.None);
            this.lblValorPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPeca.ForeColor = System.Drawing.Color.Silver;
            this.lblValorPeca.Location = new System.Drawing.Point(617, 94);
            this.lblValorPeca.Name = "lblValorPeca";
            this.lblValorPeca.Size = new System.Drawing.Size(60, 24);
            this.lblValorPeca.TabIndex = 15;
            this.lblValorPeca.Text = "00.00";
            this.lblValorPeca.Visible = false;
            // 
            // animateCircle1
            // 
            this.animateCircle1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle1.Cursor = null;
            animation13.AnimateOnlyDifferences = true;
            animation13.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.BlindCoeff")));
            animation13.LeafCoeff = 0F;
            animation13.MaxTime = 1F;
            animation13.MinTime = 0F;
            animation13.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicCoeff")));
            animation13.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicShift")));
            animation13.MosaicSize = 0;
            animation13.Padding = new System.Windows.Forms.Padding(0);
            animation13.RotateCoeff = 0F;
            animation13.RotateLimit = 0F;
            animation13.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.ScaleCoeff")));
            animation13.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.SlideCoeff")));
            animation13.TimeCoeff = 0F;
            animation13.TransparencyCoeff = 1F;
            this.animateCircle1.DefaultAnimation = animation13;
            // 
            // animateCircle2
            // 
            this.animateCircle2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle2.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 1F;
            this.animateCircle2.DefaultAnimation = animation12;
            // 
            // animateCircle3
            // 
            this.animateCircle3.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle3.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 1F;
            this.animateCircle3.DefaultAnimation = animation11;
            // 
            // backWork1
            // 
            this.backWork1.WorkerReportsProgress = true;
            this.backWork1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWork1_DoWork);
            this.backWork1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backWork1_ProgressChanged);
            this.backWork1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWork1_RunWorkerCompleted);
            // 
            // backWork2
            // 
            this.backWork2.WorkerReportsProgress = true;
            this.backWork2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWork2_DoWork);
            this.backWork2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWork2_RunWorkerCompleted);
            // 
            // backWork3
            // 
            this.backWork3.WorkerReportsProgress = true;
            this.backWork3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWork3_DoWork);
            this.backWork3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWork3_RunWorkerCompleted);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this.panelResults;
            // 
            // animateRealSimbol
            // 
            this.animateRealSimbol.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateRealSimbol.Cursor = null;
            animation14.AnimateOnlyDifferences = true;
            animation14.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.BlindCoeff")));
            animation14.LeafCoeff = 0F;
            animation14.MaxTime = 1F;
            animation14.MinTime = 0F;
            animation14.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicCoeff")));
            animation14.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicShift")));
            animation14.MosaicSize = 0;
            animation14.Padding = new System.Windows.Forms.Padding(0);
            animation14.RotateCoeff = 0F;
            animation14.RotateLimit = 0F;
            animation14.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.ScaleCoeff")));
            animation14.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.SlideCoeff")));
            animation14.TimeCoeff = 0F;
            animation14.TransparencyCoeff = 1F;
            this.animateRealSimbol.DefaultAnimation = animation14;
            // 
            // animateCircle4
            // 
            this.animateCircle4.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle4.Cursor = null;
            animation15.AnimateOnlyDifferences = true;
            animation15.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.BlindCoeff")));
            animation15.LeafCoeff = 0F;
            animation15.MaxTime = 1F;
            animation15.MinTime = 0F;
            animation15.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicCoeff")));
            animation15.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicShift")));
            animation15.MosaicSize = 0;
            animation15.Padding = new System.Windows.Forms.Padding(0);
            animation15.RotateCoeff = 0F;
            animation15.RotateLimit = 0F;
            animation15.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.ScaleCoeff")));
            animation15.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.SlideCoeff")));
            animation15.TimeCoeff = 0F;
            animation15.TransparencyCoeff = 1F;
            this.animateCircle4.DefaultAnimation = animation15;
            // 
            // backWork4
            // 
            this.backWork4.WorkerReportsProgress = true;
            this.backWork4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWork4_DoWork);
            this.backWork4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWork4_RunWorkerCompleted);
            // 
            // form_Lucros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.panelLucros);
            this.animateCircle3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animateRealSimbol.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Lucros";
            this.Text = "form_Lucros";
            this.panelLucros.ResumeLayout(false);
            this.panelLucros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaGastos)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLucros)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelLucros;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDesc3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDesc1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLucro;
        private Bunifu.Framework.UI.BunifuCustomLabel lblValorServico;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circle1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tabelaLucros;
        private Guna.UI.WinForms.GunaAdvenceButton btnExecutarThread;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDesc2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblValorPeca;
        private BunifuAnimatorNS.BunifuTransition animateCircle1;
        private BunifuAnimatorNS.BunifuTransition animateCircle3;
        public BunifuAnimatorNS.BunifuTransition animateCircle2;
        private System.ComponentModel.BackgroundWorker backWork1;
        private System.ComponentModel.BackgroundWorker backWork2;
        private System.ComponentModel.BackgroundWorker backWork3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circle3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circle2;
        private Guna.UI.WinForms.GunaPanel panelResults;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public BunifuAnimatorNS.BunifuTransition animateRealSimbol;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker1;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSemDados;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tabelaGastos;
        private Guna.UI.WinForms.GunaLabel lblGastos;
        private Guna.UI.WinForms.GunaGoogleSwitch checkGastos;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddGastos;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_defeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_valorservico;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_valorpeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_lucro;
        private Guna.UI.WinForms.GunaPanel panelBarH;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tornarTemporarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tornarRealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private BunifuAnimatorNS.BunifuTransition animateCircle4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circle4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDesc4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGastosValor;
        private System.ComponentModel.BackgroundWorker backWork4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn qst_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn qst_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_temporario;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
    }
}