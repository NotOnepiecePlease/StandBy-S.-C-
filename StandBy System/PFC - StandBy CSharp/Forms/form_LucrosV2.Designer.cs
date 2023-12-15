namespace PFC___StandBy_CSharp.Forms
{
    partial class form_LucrosV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LucrosV2));
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnLucroUltimos30Dias = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tabelaGastos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gst_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qst_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qst_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_temporario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSemDados = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnExecutarThread = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tabelaLucros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_defeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_valorservico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_valorpeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataConclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblGastosValor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.circleLucroLiquido = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblDesc3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDesc4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.circleLucroBruto = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.circleGastosTotais = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblLucroLiquido = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDesc1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLucro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGastosControle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddGastos = new Guna.UI.WinForms.GunaAdvenceButton();
            this.checkGastos = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.lblGastos = new Guna.UI.WinForms.GunaLabel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.backWork1 = new System.ComponentModel.BackgroundWorker();
            this.backWork3 = new System.ComponentModel.BackgroundWorker();
            this.animateCircle1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tornarTemporarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tornarRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animateCircle2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animateCircle3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backWork2 = new System.ComponentModel.BackgroundWorker();
            this.backWork4 = new System.ComponentModel.BackgroundWorker();
            this.animateCircle4 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblREAL1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblREAL2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblREAL3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLucros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.menu.SuspendLayout();
            this.menuTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.animateCircle4.SetDecoration(this.gunaPanel2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.gunaPanel2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.gunaPanel2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.gunaPanel2, BunifuAnimatorNS.DecorationType.None);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 377);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1278, 7);
            this.gunaPanel2.TabIndex = 44;
            // 
            // btnLucroUltimos30Dias
            // 
            this.btnLucroUltimos30Dias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLucroUltimos30Dias.AnimationHoverSpeed = 0.07F;
            this.btnLucroUltimos30Dias.AnimationSpeed = 0.03F;
            this.btnLucroUltimos30Dias.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnLucroUltimos30Dias.BorderColor = System.Drawing.Color.Black;
            this.btnLucroUltimos30Dias.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLucroUltimos30Dias.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLucroUltimos30Dias.CheckedForeColor = System.Drawing.Color.White;
            this.btnLucroUltimos30Dias.CheckedImage = null;
            this.btnLucroUltimos30Dias.CheckedLineColor = System.Drawing.Color.DimGray;
            this.animateCircle2.SetDecoration(this.btnLucroUltimos30Dias, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.btnLucroUltimos30Dias, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.btnLucroUltimos30Dias, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.btnLucroUltimos30Dias, BunifuAnimatorNS.DecorationType.None);
            this.btnLucroUltimos30Dias.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLucroUltimos30Dias.FocusedColor = System.Drawing.Color.Empty;
            this.btnLucroUltimos30Dias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLucroUltimos30Dias.ForeColor = System.Drawing.Color.White;
            this.btnLucroUltimos30Dias.Image = null;
            this.btnLucroUltimos30Dias.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLucroUltimos30Dias.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLucroUltimos30Dias.Location = new System.Drawing.Point(969, 392);
            this.btnLucroUltimos30Dias.Name = "btnLucroUltimos30Dias";
            this.btnLucroUltimos30Dias.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnLucroUltimos30Dias.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLucroUltimos30Dias.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLucroUltimos30Dias.OnHoverImage = null;
            this.btnLucroUltimos30Dias.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLucroUltimos30Dias.OnPressedColor = System.Drawing.Color.Black;
            this.btnLucroUltimos30Dias.Size = new System.Drawing.Size(178, 42);
            this.btnLucroUltimos30Dias.TabIndex = 42;
            this.btnLucroUltimos30Dias.Text = "Lucro do mes atual";
            this.btnLucroUltimos30Dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLucroUltimos30Dias.Click += new System.EventHandler(this.btnLucroUltimos30Dias_Click);
            // 
            // tabelaGastos
            // 
            this.tabelaGastos.AllowUserToAddRows = false;
            this.tabelaGastos.AllowUserToDeleteRows = false;
            this.tabelaGastos.AllowUserToOrderColumns = true;
            this.tabelaGastos.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.tabelaGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaGastos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tabelaGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tabelaGastos.ColumnHeadersHeight = 35;
            this.tabelaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gst_id,
            this.qst_data,
            this.qst_produto,
            this.gst_valor,
            this.gst_temporario});
            this.animateCircle3.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.tabelaGastos, BunifuAnimatorNS.DecorationType.None);
            this.tabelaGastos.DoubleBuffered = true;
            this.tabelaGastos.EnableHeadersVisualStyles = false;
            this.tabelaGastos.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.tabelaGastos.HeaderForeColor = System.Drawing.Color.Black;
            this.tabelaGastos.Location = new System.Drawing.Point(13, 12);
            this.tabelaGastos.Name = "tabelaGastos";
            this.tabelaGastos.ReadOnly = true;
            this.tabelaGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tabelaGastos.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tabelaGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaGastos.Size = new System.Drawing.Size(196, 286);
            this.tabelaGastos.TabIndex = 37;
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
            // lblSemDados
            // 
            this.lblSemDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemDados.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblSemDados, BunifuAnimatorNS.DecorationType.None);
            this.lblSemDados.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemDados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSemDados.Location = new System.Drawing.Point(414, 174);
            this.lblSemDados.Name = "lblSemDados";
            this.lblSemDados.Size = new System.Drawing.Size(492, 56);
            this.lblSemDados.TabIndex = 36;
            this.lblSemDados.Text = "Nao existem dados!";
            this.lblSemDados.Visible = false;
            // 
            // datepicker2
            // 
            this.datepicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datepicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.datepicker2.BorderRadius = 0;
            this.animateCircle4.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.datepicker2, BunifuAnimatorNS.DecorationType.None);
            this.datepicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker2.ForeColor = System.Drawing.Color.White;
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker2.FormatCustom = null;
            this.datepicker2.Location = new System.Drawing.Point(715, 392);
            this.datepicker2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(191, 42);
            this.datepicker2.TabIndex = 35;
            this.datepicker2.Value = new System.DateTime(2021, 6, 11, 0, 0, 0, 0);
            // 
            // datepicker1
            // 
            this.datepicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.datepicker1.BorderRadius = 0;
            this.animateCircle4.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.datepicker1, BunifuAnimatorNS.DecorationType.None);
            this.datepicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.datepicker1.ForeColor = System.Drawing.Color.White;
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker1.FormatCustom = null;
            this.datepicker1.Location = new System.Drawing.Point(372, 392);
            this.datepicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(191, 42);
            this.datepicker1.TabIndex = 34;
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
            this.animateCircle4.SetDecoration(this.btnExecutarThread, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.btnExecutarThread, BunifuAnimatorNS.DecorationType.None);
            this.btnExecutarThread.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExecutarThread.FocusedColor = System.Drawing.Color.Empty;
            this.btnExecutarThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExecutarThread.ForeColor = System.Drawing.Color.White;
            this.btnExecutarThread.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_search_500px;
            this.btnExecutarThread.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExecutarThread.ImageOffsetX = 1;
            this.btnExecutarThread.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExecutarThread.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExecutarThread.Location = new System.Drawing.Point(613, 390);
            this.btnExecutarThread.Name = "btnExecutarThread";
            this.btnExecutarThread.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnExecutarThread.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExecutarThread.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExecutarThread.OnHoverImage = null;
            this.btnExecutarThread.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExecutarThread.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExecutarThread.Size = new System.Drawing.Size(52, 46);
            this.btnExecutarThread.TabIndex = 33;
            this.btnExecutarThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExecutarThread.Click += new System.EventHandler(this.btnExecutarThread_Click);
            // 
            // tabelaLucros
            // 
            this.tabelaLucros.AllowUserToAddRows = false;
            this.tabelaLucros.AllowUserToDeleteRows = false;
            this.tabelaLucros.AllowUserToOrderColumns = true;
            this.tabelaLucros.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaLucros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tabelaLucros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaLucros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaLucros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaLucros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaLucros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tabelaLucros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaLucros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tabelaLucros.ColumnHeadersHeight = 35;
            this.tabelaLucros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaLucros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServico,
            this.sv_data,
            this.cl_nome,
            this.sv_aparelho,
            this.sv_defeito,
            this.sv_situacao,
            this.sv_valorservico,
            this.sv_valorpeca,
            this.sv_lucro,
            this.DataConclusao});
            this.animateCircle3.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.tabelaLucros, BunifuAnimatorNS.DecorationType.None);
            this.tabelaLucros.DoubleBuffered = true;
            this.tabelaLucros.EnableHeadersVisualStyles = false;
            this.tabelaLucros.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.tabelaLucros.HeaderForeColor = System.Drawing.Color.Black;
            this.tabelaLucros.Location = new System.Drawing.Point(215, 12);
            this.tabelaLucros.Name = "tabelaLucros";
            this.tabelaLucros.ReadOnly = true;
            this.tabelaLucros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaLucros.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tabelaLucros.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaLucros.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.tabelaLucros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaLucros.Size = new System.Drawing.Size(1052, 359);
            this.tabelaLucros.TabIndex = 32;
            this.tabelaLucros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaLucros_CellDoubleClick);
            this.tabelaLucros.DoubleClick += new System.EventHandler(this.tabelaLucros_DoubleClick);
            // 
            // idServico
            // 
            this.idServico.DataPropertyName = "sv_id";
            this.idServico.HeaderText = "idServico";
            this.idServico.Name = "idServico";
            this.idServico.ReadOnly = true;
            this.idServico.Visible = false;
            // 
            // sv_data
            // 
            this.sv_data.DataPropertyName = "sv_data";
            this.sv_data.HeaderText = "Entrada";
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
            this.sv_defeito.Visible = false;
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
            // DataConclusao
            // 
            this.DataConclusao.DataPropertyName = "sv_data_conclusao";
            this.DataConclusao.HeaderText = "Saida";
            this.DataConclusao.Name = "DataConclusao";
            this.DataConclusao.ReadOnly = true;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblREAL3);
            this.panelControl1.Controls.Add(this.lblREAL2);
            this.panelControl1.Controls.Add(this.lblREAL1);
            this.panelControl1.Controls.Add(this.lblGastosValor);
            this.panelControl1.Controls.Add(this.circleLucroLiquido);
            this.panelControl1.Controls.Add(this.lblDesc3);
            this.panelControl1.Controls.Add(this.lblDesc4);
            this.panelControl1.Controls.Add(this.circleLucroBruto);
            this.panelControl1.Controls.Add(this.circleGastosTotais);
            this.panelControl1.Controls.Add(this.lblLucroLiquido);
            this.panelControl1.Controls.Add(this.lblDesc1);
            this.panelControl1.Controls.Add(this.lblLucro);
            this.animateCircle4.SetDecoration(this.panelControl1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.panelControl1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.panelControl1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.panelControl1, BunifuAnimatorNS.DecorationType.None);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 457);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1278, 153);
            this.panelControl1.TabIndex = 38;
            // 
            // lblGastosValor
            // 
            this.lblGastosValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGastosValor.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblGastosValor, BunifuAnimatorNS.DecorationType.None);
            this.lblGastosValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosValor.ForeColor = System.Drawing.Color.Silver;
            this.lblGastosValor.Location = new System.Drawing.Point(791, 82);
            this.lblGastosValor.Name = "lblGastosValor";
            this.lblGastosValor.Size = new System.Drawing.Size(93, 24);
            this.lblGastosValor.TabIndex = 22;
            this.lblGastosValor.Text = "99999.99";
            this.lblGastosValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGastosValor.Visible = false;
            // 
            // circleLucroLiquido
            // 
            this.circleLucroLiquido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circleLucroLiquido.animated = false;
            this.circleLucroLiquido.animationIterval = 5;
            this.circleLucroLiquido.animationSpeed = 1;
            this.circleLucroLiquido.BackColor = System.Drawing.Color.Transparent;
            this.circleLucroLiquido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleLucroLiquido.BackgroundImage")));
            this.animateCircle4.SetDecoration(this.circleLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.circleLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.circleLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.circleLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.circleLucroLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleLucroLiquido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circleLucroLiquido.LabelVisible = false;
            this.circleLucroLiquido.LineProgressThickness = 5;
            this.circleLucroLiquido.LineThickness = 3;
            this.circleLucroLiquido.Location = new System.Drawing.Point(399, 6);
            this.circleLucroLiquido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.circleLucroLiquido.MaxValue = 100;
            this.circleLucroLiquido.Name = "circleLucroLiquido";
            this.circleLucroLiquido.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleLucroLiquido.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circleLucroLiquido.Size = new System.Drawing.Size(80, 80);
            this.circleLucroLiquido.TabIndex = 4;
            this.circleLucroLiquido.Value = 0;
            this.circleLucroLiquido.Visible = false;
            // 
            // lblDesc3
            // 
            this.lblDesc3.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblDesc3, BunifuAnimatorNS.DecorationType.None);
            this.lblDesc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDesc3.ForeColor = System.Drawing.Color.Silver;
            this.lblDesc3.Location = new System.Drawing.Point(602, 108);
            this.lblDesc3.Name = "lblDesc3";
            this.lblDesc3.Size = new System.Drawing.Size(73, 15);
            this.lblDesc3.TabIndex = 10;
            this.lblDesc3.Text = "Lucro Bruto:";
            this.lblDesc3.Visible = false;
            // 
            // lblDesc4
            // 
            this.lblDesc4.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblDesc4, BunifuAnimatorNS.DecorationType.None);
            this.lblDesc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDesc4.ForeColor = System.Drawing.Color.Silver;
            this.lblDesc4.Location = new System.Drawing.Point(795, 108);
            this.lblDesc4.Name = "lblDesc4";
            this.lblDesc4.Size = new System.Drawing.Size(84, 15);
            this.lblDesc4.TabIndex = 23;
            this.lblDesc4.Text = "Gastos Totais:";
            this.lblDesc4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc4.Visible = false;
            // 
            // circleLucroBruto
            // 
            this.circleLucroBruto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circleLucroBruto.animated = false;
            this.circleLucroBruto.animationIterval = 5;
            this.circleLucroBruto.animationSpeed = 1;
            this.circleLucroBruto.BackColor = System.Drawing.Color.Transparent;
            this.circleLucroBruto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleLucroBruto.BackgroundImage")));
            this.animateCircle4.SetDecoration(this.circleLucroBruto, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.circleLucroBruto, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.circleLucroBruto, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.circleLucroBruto, BunifuAnimatorNS.DecorationType.None);
            this.circleLucroBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.circleLucroBruto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circleLucroBruto.LabelVisible = false;
            this.circleLucroBruto.LineProgressThickness = 5;
            this.circleLucroBruto.LineThickness = 3;
            this.circleLucroBruto.Location = new System.Drawing.Point(598, 6);
            this.circleLucroBruto.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.circleLucroBruto.MaxValue = 100;
            this.circleLucroBruto.Name = "circleLucroBruto";
            this.circleLucroBruto.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleLucroBruto.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circleLucroBruto.Size = new System.Drawing.Size(80, 80);
            this.circleLucroBruto.TabIndex = 18;
            this.circleLucroBruto.Value = 0;
            this.circleLucroBruto.Visible = false;
            // 
            // circleGastosTotais
            // 
            this.circleGastosTotais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circleGastosTotais.animated = false;
            this.circleGastosTotais.animationIterval = 5;
            this.circleGastosTotais.animationSpeed = 1;
            this.circleGastosTotais.BackColor = System.Drawing.Color.Transparent;
            this.circleGastosTotais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleGastosTotais.BackgroundImage")));
            this.animateCircle4.SetDecoration(this.circleGastosTotais, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.circleGastosTotais, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.circleGastosTotais, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.circleGastosTotais, BunifuAnimatorNS.DecorationType.None);
            this.circleGastosTotais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.circleGastosTotais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circleGastosTotais.LabelVisible = false;
            this.circleGastosTotais.LineProgressThickness = 5;
            this.circleGastosTotais.LineThickness = 3;
            this.circleGastosTotais.Location = new System.Drawing.Point(797, 6);
            this.circleGastosTotais.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.circleGastosTotais.MaxValue = 100;
            this.circleGastosTotais.Name = "circleGastosTotais";
            this.circleGastosTotais.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleGastosTotais.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circleGastosTotais.Size = new System.Drawing.Size(80, 80);
            this.circleGastosTotais.TabIndex = 24;
            this.circleGastosTotais.Value = 0;
            this.circleGastosTotais.Visible = false;
            // 
            // lblLucroLiquido
            // 
            this.lblLucroLiquido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLucroLiquido.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblLucroLiquido, BunifuAnimatorNS.DecorationType.None);
            this.lblLucroLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucroLiquido.ForeColor = System.Drawing.Color.Silver;
            this.lblLucroLiquido.Location = new System.Drawing.Point(394, 82);
            this.lblLucroLiquido.Name = "lblLucroLiquido";
            this.lblLucroLiquido.Size = new System.Drawing.Size(93, 24);
            this.lblLucroLiquido.TabIndex = 5;
            this.lblLucroLiquido.Text = "99999.99";
            this.lblLucroLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLucroLiquido.Visible = false;
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblDesc1, BunifuAnimatorNS.DecorationType.None);
            this.lblDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc1.ForeColor = System.Drawing.Color.Silver;
            this.lblDesc1.Location = new System.Drawing.Point(397, 108);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(85, 15);
            this.lblDesc1.TabIndex = 9;
            this.lblDesc1.Text = "Lucro Liquido:";
            this.lblDesc1.Visible = false;
            // 
            // lblLucro
            // 
            this.lblLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLucro.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblLucro, BunifuAnimatorNS.DecorationType.None);
            this.lblLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.ForeColor = System.Drawing.Color.Silver;
            this.lblLucro.Location = new System.Drawing.Point(592, 82);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(93, 24);
            this.lblLucro.TabIndex = 7;
            this.lblLucro.Text = "99999.99";
            this.lblLucro.Visible = false;
            // 
            // btnGastosControle
            // 
            this.btnGastosControle.AnimationHoverSpeed = 0.07F;
            this.btnGastosControle.AnimationSpeed = 0.03F;
            this.btnGastosControle.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnGastosControle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnGastosControle.BorderSize = 1;
            this.btnGastosControle.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnGastosControle.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGastosControle.CheckedForeColor = System.Drawing.Color.White;
            this.btnGastosControle.CheckedImage = null;
            this.btnGastosControle.CheckedLineColor = System.Drawing.Color.DimGray;
            this.animateCircle2.SetDecoration(this.btnGastosControle, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.btnGastosControle, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.btnGastosControle, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.btnGastosControle, BunifuAnimatorNS.DecorationType.None);
            this.btnGastosControle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGastosControle.FocusedColor = System.Drawing.Color.Empty;
            this.btnGastosControle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGastosControle.ForeColor = System.Drawing.Color.White;
            this.btnGastosControle.Image = null;
            this.btnGastosControle.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGastosControle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGastosControle.Location = new System.Drawing.Point(13, 351);
            this.btnGastosControle.Name = "btnGastosControle";
            this.btnGastosControle.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnGastosControle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGastosControle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGastosControle.OnHoverImage = null;
            this.btnGastosControle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGastosControle.OnPressedColor = System.Drawing.Color.Black;
            this.btnGastosControle.Size = new System.Drawing.Size(196, 23);
            this.btnGastosControle.TabIndex = 43;
            this.btnGastosControle.Text = "Buscar Gastos";
            this.btnGastosControle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGastosControle.Click += new System.EventHandler(this.btnGastosControle_Click);
            // 
            // btnAddGastos
            // 
            this.btnAddGastos.AnimationHoverSpeed = 0.07F;
            this.btnAddGastos.AnimationSpeed = 0.03F;
            this.btnAddGastos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnAddGastos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnAddGastos.BorderSize = 1;
            this.btnAddGastos.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddGastos.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddGastos.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddGastos.CheckedImage = null;
            this.btnAddGastos.CheckedLineColor = System.Drawing.Color.DimGray;
            this.animateCircle2.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.btnAddGastos, BunifuAnimatorNS.DecorationType.None);
            this.btnAddGastos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddGastos.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddGastos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGastos.ForeColor = System.Drawing.Color.White;
            this.btnAddGastos.Image = null;
            this.btnAddGastos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddGastos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddGastos.Location = new System.Drawing.Point(13, 327);
            this.btnAddGastos.Name = "btnAddGastos";
            this.btnAddGastos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnAddGastos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddGastos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddGastos.OnHoverImage = null;
            this.btnAddGastos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddGastos.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddGastos.Size = new System.Drawing.Size(196, 23);
            this.btnAddGastos.TabIndex = 41;
            this.btnAddGastos.Text = "Adicionar Gastos";
            this.btnAddGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddGastos.Click += new System.EventHandler(this.btnAddGastos_Click);
            // 
            // checkGastos
            // 
            this.checkGastos.BaseColor = System.Drawing.SystemColors.Control;
            this.checkGastos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.checkGastos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.animateCircle3.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.checkGastos, BunifuAnimatorNS.DecorationType.None);
            this.checkGastos.FillColor = System.Drawing.Color.White;
            this.checkGastos.Location = new System.Drawing.Point(35, 303);
            this.checkGastos.Name = "checkGastos";
            this.checkGastos.Size = new System.Drawing.Size(43, 20);
            this.checkGastos.TabIndex = 39;
            this.checkGastos.CheckedChanged += new System.EventHandler(this.checkGastos_CheckedChanged);
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.animateCircle4.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.lblGastos, BunifuAnimatorNS.DecorationType.None);
            this.lblGastos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGastos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGastos.Location = new System.Drawing.Point(74, 305);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(121, 15);
            this.lblGastos.TabIndex = 40;
            this.lblGastos.Text = "Exibindo Gastos Reais";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnAddGastos);
            this.panelControl2.Controls.Add(this.btnGastosControle);
            this.panelControl2.Controls.Add(this.datepicker2);
            this.panelControl2.Controls.Add(this.btnLucroUltimos30Dias);
            this.panelControl2.Controls.Add(this.datepicker1);
            this.animateCircle4.SetDecoration(this.panelControl2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.panelControl2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.panelControl2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.panelControl2, BunifuAnimatorNS.DecorationType.None);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1278, 610);
            this.panelControl2.TabIndex = 39;
            // 
            // backWork1
            // 
            this.backWork1.WorkerReportsProgress = true;
            this.backWork1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWork1_DoWork);
            this.backWork1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWork1_RunWorkerCompleted);
            // 
            // backWork3
            // 
            this.backWork3.WorkerReportsProgress = true;
            this.backWork3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWork3_DoWork);
            this.backWork3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWork3_RunWorkerCompleted);
            // 
            // animateCircle1
            // 
            this.animateCircle1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle1.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 1F;
            this.animateCircle1.DefaultAnimation = animation7;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.animateCircle4.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
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
            // animateCircle2
            // 
            this.animateCircle2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle2.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.animateCircle2.DefaultAnimation = animation6;
            // 
            // animateCircle3
            // 
            this.animateCircle3.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle3.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.animateCircle3.DefaultAnimation = animation5;
            // 
            // backWork2
            // 
            this.backWork2.WorkerReportsProgress = true;
            // 
            // backWork4
            // 
            this.backWork4.WorkerReportsProgress = true;
            this.backWork4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWork4_DoWork);
            this.backWork4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWork4_RunWorkerCompleted);
            // 
            // animateCircle4
            // 
            this.animateCircle4.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateCircle4.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 1F;
            this.animateCircle4.DefaultAnimation = animation8;
            // 
            // menuTable
            // 
            this.menuTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.animateCircle4.SetDecoration(this.menuTable, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle3.SetDecoration(this.menuTable, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.menuTable, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.menuTable, BunifuAnimatorNS.DecorationType.None);
            this.menuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.menuTable.Name = "contextMenuStrip1";
            this.menuTable.ShowImageMargin = false;
            this.menuTable.Size = new System.Drawing.Size(80, 26);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // lblREAL1
            // 
            this.lblREAL1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblREAL1.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblREAL1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblREAL1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblREAL1, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblREAL1, BunifuAnimatorNS.DecorationType.None);
            this.lblREAL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREAL1.ForeColor = System.Drawing.Color.Silver;
            this.lblREAL1.Location = new System.Drawing.Point(422, 34);
            this.lblREAL1.Name = "lblREAL1";
            this.lblREAL1.Size = new System.Drawing.Size(35, 24);
            this.lblREAL1.TabIndex = 25;
            this.lblREAL1.Text = "R$";
            this.lblREAL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblREAL1.Visible = false;
            // 
            // lblREAL2
            // 
            this.lblREAL2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblREAL2.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblREAL2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblREAL2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblREAL2, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblREAL2, BunifuAnimatorNS.DecorationType.None);
            this.lblREAL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREAL2.ForeColor = System.Drawing.Color.Silver;
            this.lblREAL2.Location = new System.Drawing.Point(621, 34);
            this.lblREAL2.Name = "lblREAL2";
            this.lblREAL2.Size = new System.Drawing.Size(35, 24);
            this.lblREAL2.TabIndex = 26;
            this.lblREAL2.Text = "R$";
            this.lblREAL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblREAL2.Visible = false;
            // 
            // lblREAL3
            // 
            this.lblREAL3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblREAL3.AutoSize = true;
            this.animateCircle3.SetDecoration(this.lblREAL3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this.lblREAL3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this.lblREAL3, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this.lblREAL3, BunifuAnimatorNS.DecorationType.None);
            this.lblREAL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREAL3.ForeColor = System.Drawing.Color.Silver;
            this.lblREAL3.Location = new System.Drawing.Point(820, 34);
            this.lblREAL3.Name = "lblREAL3";
            this.lblREAL3.Size = new System.Drawing.Size(35, 24);
            this.lblREAL3.TabIndex = 27;
            this.lblREAL3.Text = "R$";
            this.lblREAL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblREAL3.Visible = false;
            // 
            // form_LucrosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 610);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.tabelaGastos);
            this.Controls.Add(this.lblSemDados);
            this.Controls.Add(this.btnExecutarThread);
            this.Controls.Add(this.tabelaLucros);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.checkGastos);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.panelControl2);
            this.animateCircle3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle4.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animateCircle2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_LucrosV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_LucrosV2";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaLucros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menuTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnLucroUltimos30Dias;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tabelaGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn qst_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn qst_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_temporario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSemDados;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker2;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker1;
        private Guna.UI.WinForms.GunaAdvenceButton btnExecutarThread;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tabelaLucros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_defeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_valorservico;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_valorpeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_lucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataConclusao;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleLucroLiquido;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGastosValor;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDesc3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleGastosTotais;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDesc4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleLucroBruto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLucroLiquido;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDesc1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLucro;
        private Guna.UI.WinForms.GunaAdvenceButton btnGastosControle;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddGastos;
        private Guna.UI.WinForms.GunaGoogleSwitch checkGastos;
        private Guna.UI.WinForms.GunaLabel lblGastos;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.ComponentModel.BackgroundWorker backWork1;
        private System.ComponentModel.BackgroundWorker backWork3;
        private BunifuAnimatorNS.BunifuTransition animateCircle1;
        public BunifuAnimatorNS.BunifuTransition animateCircle2;
        private BunifuAnimatorNS.BunifuTransition animateCircle3;
        private System.ComponentModel.BackgroundWorker backWork2;
        private System.ComponentModel.BackgroundWorker backWork4;
        private BunifuAnimatorNS.BunifuTransition animateCircle4;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tornarTemporarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tornarRealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuTable;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblREAL3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblREAL2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblREAL1;
    }
}