namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Orcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Orcamento));
            this.tabelaOrcamento = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.orc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submenuAdicionarNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLG = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMotorola = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLenovo = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnXiaomi = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAsus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAlcatel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnIphone = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSamsung = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblOrcStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOrcamento)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaOrcamento
            // 
            this.tabelaOrcamento.AllowUserToAddRows = false;
            this.tabelaOrcamento.AllowUserToDeleteRows = false;
            this.tabelaOrcamento.AllowUserToOrderColumns = true;
            this.tabelaOrcamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaOrcamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabelaOrcamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaOrcamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaOrcamento.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tabelaOrcamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaOrcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaOrcamento.ColumnHeadersHeight = 35;
            this.tabelaOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orc_id,
            this.orc_aparelho,
            this.orc_modelo,
            this.orc_peca,
            this.orc_valor,
            this.total});
            this.tabelaOrcamento.ContextMenuStrip = this.menu;
            this.tabelaOrcamento.DoubleBuffered = true;
            this.tabelaOrcamento.EnableHeadersVisualStyles = false;
            this.tabelaOrcamento.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.tabelaOrcamento.HeaderForeColor = System.Drawing.Color.Black;
            this.tabelaOrcamento.Location = new System.Drawing.Point(308, 51);
            this.tabelaOrcamento.Name = "tabelaOrcamento";
            this.tabelaOrcamento.ReadOnly = true;
            this.tabelaOrcamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaOrcamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaOrcamento.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaOrcamento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelaOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaOrcamento.Size = new System.Drawing.Size(494, 570);
            this.tabelaOrcamento.TabIndex = 12;
            // 
            // orc_id
            // 
            this.orc_id.DataPropertyName = "orc_id";
            this.orc_id.HeaderText = "orc_id";
            this.orc_id.Name = "orc_id";
            this.orc_id.ReadOnly = true;
            this.orc_id.Visible = false;
            // 
            // orc_aparelho
            // 
            this.orc_aparelho.DataPropertyName = "orc_aparelho";
            this.orc_aparelho.HeaderText = "Aparelho";
            this.orc_aparelho.Name = "orc_aparelho";
            this.orc_aparelho.ReadOnly = true;
            // 
            // orc_modelo
            // 
            this.orc_modelo.DataPropertyName = "orc_modelo";
            this.orc_modelo.HeaderText = "Modelo";
            this.orc_modelo.Name = "orc_modelo";
            this.orc_modelo.ReadOnly = true;
            this.orc_modelo.Width = 150;
            // 
            // orc_peca
            // 
            this.orc_peca.DataPropertyName = "orc_peca";
            this.orc_peca.HeaderText = "R$ Peça";
            this.orc_peca.Name = "orc_peca";
            this.orc_peca.ReadOnly = true;
            this.orc_peca.Width = 70;
            // 
            // orc_valor
            // 
            this.orc_valor.DataPropertyName = "orc_valor";
            this.orc_valor.HeaderText = "R$ Valor";
            this.orc_valor.Name = "orc_valor";
            this.orc_valor.ReadOnly = true;
            this.orc_valor.Width = 75;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "R$ Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 75;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuAdicionarNovo});
            this.menu.Name = "menu";
            this.menu.ShowImageMargin = false;
            this.menu.Size = new System.Drawing.Size(131, 26);
            // 
            // submenuAdicionarNovo
            // 
            this.submenuAdicionarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.submenuAdicionarNovo.Name = "submenuAdicionarNovo";
            this.submenuAdicionarNovo.Size = new System.Drawing.Size(130, 22);
            this.submenuAdicionarNovo.Text = "Adicionar novo";
            this.submenuAdicionarNovo.Click += new System.EventHandler(this.submenuAdicionarNovo_Click);
            // 
            // btnLG
            // 
            this.btnLG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLG.Animated = true;
            this.btnLG.AnimationHoverSpeed = 0.07F;
            this.btnLG.AnimationSpeed = 0.03F;
            this.btnLG.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnLG.BorderColor = System.Drawing.Color.Black;
            this.btnLG.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLG.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLG.CheckedForeColor = System.Drawing.Color.White;
            this.btnLG.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLG.CheckedImage")));
            this.btnLG.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLG.FocusedColor = System.Drawing.Color.Empty;
            this.btnLG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLG.ForeColor = System.Drawing.Color.White;
            this.btnLG.Image = global::PFC___StandBy_CSharp.Properties.Resources.lglogo;
            this.btnLG.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLG.ImageSize = new System.Drawing.Size(100, 42);
            this.btnLG.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLG.Location = new System.Drawing.Point(849, 411);
            this.btnLG.Name = "btnLG";
            this.btnLG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnLG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLG.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLG.OnHoverImage = null;
            this.btnLG.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLG.OnPressedColor = System.Drawing.Color.Black;
            this.btnLG.Size = new System.Drawing.Size(180, 42);
            this.btnLG.TabIndex = 20;
            this.btnLG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLG.Click += new System.EventHandler(this.gunaAdvenceButton7_Click);
            // 
            // btnMotorola
            // 
            this.btnMotorola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMotorola.Animated = true;
            this.btnMotorola.AnimationHoverSpeed = 0.07F;
            this.btnMotorola.AnimationSpeed = 0.03F;
            this.btnMotorola.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnMotorola.BorderColor = System.Drawing.Color.Black;
            this.btnMotorola.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMotorola.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMotorola.CheckedForeColor = System.Drawing.Color.White;
            this.btnMotorola.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMotorola.CheckedImage")));
            this.btnMotorola.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMotorola.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMotorola.FocusedColor = System.Drawing.Color.Empty;
            this.btnMotorola.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMotorola.ForeColor = System.Drawing.Color.White;
            this.btnMotorola.Image = global::PFC___StandBy_CSharp.Properties.Resources.motorola;
            this.btnMotorola.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMotorola.ImageSize = new System.Drawing.Size(180, 55);
            this.btnMotorola.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMotorola.Location = new System.Drawing.Point(849, 334);
            this.btnMotorola.Name = "btnMotorola";
            this.btnMotorola.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnMotorola.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMotorola.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMotorola.OnHoverImage = null;
            this.btnMotorola.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMotorola.OnPressedColor = System.Drawing.Color.Black;
            this.btnMotorola.Size = new System.Drawing.Size(180, 42);
            this.btnMotorola.TabIndex = 19;
            this.btnMotorola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMotorola.Click += new System.EventHandler(this.gunaAdvenceButton6_Click);
            // 
            // btnLenovo
            // 
            this.btnLenovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLenovo.Animated = true;
            this.btnLenovo.AnimationHoverSpeed = 0.07F;
            this.btnLenovo.AnimationSpeed = 0.03F;
            this.btnLenovo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnLenovo.BorderColor = System.Drawing.Color.Black;
            this.btnLenovo.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLenovo.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLenovo.CheckedForeColor = System.Drawing.Color.White;
            this.btnLenovo.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLenovo.CheckedImage")));
            this.btnLenovo.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLenovo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLenovo.FocusedColor = System.Drawing.Color.Empty;
            this.btnLenovo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLenovo.ForeColor = System.Drawing.Color.White;
            this.btnLenovo.Image = global::PFC___StandBy_CSharp.Properties.Resources.lenovo;
            this.btnLenovo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLenovo.ImageSize = new System.Drawing.Size(150, 35);
            this.btnLenovo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLenovo.Location = new System.Drawing.Point(849, 257);
            this.btnLenovo.Name = "btnLenovo";
            this.btnLenovo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnLenovo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLenovo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLenovo.OnHoverImage = null;
            this.btnLenovo.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLenovo.OnPressedColor = System.Drawing.Color.Black;
            this.btnLenovo.Size = new System.Drawing.Size(180, 42);
            this.btnLenovo.TabIndex = 18;
            this.btnLenovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLenovo.Click += new System.EventHandler(this.gunaAdvenceButton5_Click);
            // 
            // btnXiaomi
            // 
            this.btnXiaomi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXiaomi.Animated = true;
            this.btnXiaomi.AnimationHoverSpeed = 0.07F;
            this.btnXiaomi.AnimationSpeed = 0.03F;
            this.btnXiaomi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnXiaomi.BorderColor = System.Drawing.Color.Black;
            this.btnXiaomi.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnXiaomi.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnXiaomi.CheckedForeColor = System.Drawing.Color.White;
            this.btnXiaomi.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnXiaomi.CheckedImage")));
            this.btnXiaomi.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnXiaomi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXiaomi.FocusedColor = System.Drawing.Color.Empty;
            this.btnXiaomi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXiaomi.ForeColor = System.Drawing.Color.White;
            this.btnXiaomi.Image = global::PFC___StandBy_CSharp.Properties.Resources.xiaomi1;
            this.btnXiaomi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXiaomi.ImageSize = new System.Drawing.Size(160, 45);
            this.btnXiaomi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXiaomi.Location = new System.Drawing.Point(849, 180);
            this.btnXiaomi.Name = "btnXiaomi";
            this.btnXiaomi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnXiaomi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXiaomi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXiaomi.OnHoverImage = null;
            this.btnXiaomi.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXiaomi.OnPressedColor = System.Drawing.Color.Black;
            this.btnXiaomi.Size = new System.Drawing.Size(180, 42);
            this.btnXiaomi.TabIndex = 17;
            this.btnXiaomi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXiaomi.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // btnAsus
            // 
            this.btnAsus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAsus.Animated = true;
            this.btnAsus.AnimationHoverSpeed = 0.07F;
            this.btnAsus.AnimationSpeed = 0.03F;
            this.btnAsus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnAsus.BorderColor = System.Drawing.Color.Black;
            this.btnAsus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAsus.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAsus.CheckedForeColor = System.Drawing.Color.White;
            this.btnAsus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAsus.CheckedImage")));
            this.btnAsus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAsus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAsus.FocusedColor = System.Drawing.Color.Empty;
            this.btnAsus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAsus.ForeColor = System.Drawing.Color.White;
            this.btnAsus.Image = global::PFC___StandBy_CSharp.Properties.Resources.asus;
            this.btnAsus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAsus.ImageSize = new System.Drawing.Size(170, 40);
            this.btnAsus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAsus.Location = new System.Drawing.Point(53, 411);
            this.btnAsus.Name = "btnAsus";
            this.btnAsus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnAsus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAsus.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAsus.OnHoverImage = null;
            this.btnAsus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAsus.OnPressedColor = System.Drawing.Color.Black;
            this.btnAsus.Size = new System.Drawing.Size(180, 42);
            this.btnAsus.TabIndex = 16;
            this.btnAsus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAsus.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // btnAlcatel
            // 
            this.btnAlcatel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlcatel.Animated = true;
            this.btnAlcatel.AnimationHoverSpeed = 0.07F;
            this.btnAlcatel.AnimationSpeed = 0.03F;
            this.btnAlcatel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnAlcatel.BorderColor = System.Drawing.Color.Black;
            this.btnAlcatel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAlcatel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAlcatel.CheckedForeColor = System.Drawing.Color.White;
            this.btnAlcatel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAlcatel.CheckedImage")));
            this.btnAlcatel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAlcatel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAlcatel.FocusedColor = System.Drawing.Color.Empty;
            this.btnAlcatel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAlcatel.ForeColor = System.Drawing.Color.White;
            this.btnAlcatel.Image = ((System.Drawing.Image)(resources.GetObject("btnAlcatel.Image")));
            this.btnAlcatel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlcatel.ImageSize = new System.Drawing.Size(150, 45);
            this.btnAlcatel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAlcatel.Location = new System.Drawing.Point(53, 334);
            this.btnAlcatel.Name = "btnAlcatel";
            this.btnAlcatel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnAlcatel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAlcatel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAlcatel.OnHoverImage = null;
            this.btnAlcatel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAlcatel.OnPressedColor = System.Drawing.Color.Black;
            this.btnAlcatel.Size = new System.Drawing.Size(180, 42);
            this.btnAlcatel.TabIndex = 15;
            this.btnAlcatel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlcatel.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // btnIphone
            // 
            this.btnIphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIphone.Animated = true;
            this.btnIphone.AnimationHoverSpeed = 0.07F;
            this.btnIphone.AnimationSpeed = 0.03F;
            this.btnIphone.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnIphone.BorderColor = System.Drawing.Color.Black;
            this.btnIphone.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnIphone.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnIphone.CheckedForeColor = System.Drawing.Color.White;
            this.btnIphone.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnIphone.CheckedImage")));
            this.btnIphone.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnIphone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIphone.FocusedColor = System.Drawing.Color.Empty;
            this.btnIphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIphone.ForeColor = System.Drawing.Color.White;
            this.btnIphone.Image = global::PFC___StandBy_CSharp.Properties.Resources.iPhone_logo;
            this.btnIphone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIphone.ImageSize = new System.Drawing.Size(140, 60);
            this.btnIphone.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIphone.Location = new System.Drawing.Point(53, 257);
            this.btnIphone.Name = "btnIphone";
            this.btnIphone.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnIphone.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIphone.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIphone.OnHoverImage = null;
            this.btnIphone.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIphone.OnPressedColor = System.Drawing.Color.Black;
            this.btnIphone.Size = new System.Drawing.Size(180, 42);
            this.btnIphone.TabIndex = 14;
            this.btnIphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIphone.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSamsung.Animated = true;
            this.btnSamsung.AnimationHoverSpeed = 0.07F;
            this.btnSamsung.AnimationSpeed = 0.03F;
            this.btnSamsung.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.btnSamsung.BorderColor = System.Drawing.Color.Black;
            this.btnSamsung.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSamsung.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSamsung.CheckedForeColor = System.Drawing.Color.White;
            this.btnSamsung.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSamsung.CheckedImage")));
            this.btnSamsung.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSamsung.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSamsung.FocusedColor = System.Drawing.Color.Empty;
            this.btnSamsung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSamsung.ForeColor = System.Drawing.Color.White;
            this.btnSamsung.Image = global::PFC___StandBy_CSharp.Properties.Resources.samsung_logo_png_samsung_logo_png_2104;
            this.btnSamsung.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSamsung.ImageSize = new System.Drawing.Size(220, 70);
            this.btnSamsung.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSamsung.Location = new System.Drawing.Point(53, 180);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnSamsung.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSamsung.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSamsung.OnHoverImage = null;
            this.btnSamsung.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSamsung.OnPressedColor = System.Drawing.Color.Black;
            this.btnSamsung.Size = new System.Drawing.Size(180, 42);
            this.btnSamsung.TabIndex = 13;
            this.btnSamsung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // lblOrcStatus
            // 
            this.lblOrcStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrcStatus.AutoSize = true;
            this.lblOrcStatus.Font = new System.Drawing.Font("Consolas", 36F);
            this.lblOrcStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrcStatus.Location = new System.Drawing.Point(308, 286);
            this.lblOrcStatus.Name = "lblOrcStatus";
            this.lblOrcStatus.Size = new System.Drawing.Size(492, 56);
            this.lblOrcStatus.TabIndex = 24;
            this.lblOrcStatus.Text = "Nao Existem Dados!";
            // 
            // form_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.lblOrcStatus);
            this.Controls.Add(this.btnLG);
            this.Controls.Add(this.btnMotorola);
            this.Controls.Add(this.btnLenovo);
            this.Controls.Add(this.btnXiaomi);
            this.Controls.Add(this.btnAsus);
            this.Controls.Add(this.btnAlcatel);
            this.Controls.Add(this.btnIphone);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.tabelaOrcamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Orcamento";
            this.Text = "form_Orcamento";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOrcamento)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid tabelaOrcamento;
        private Guna.UI.WinForms.GunaAdvenceButton btnSamsung;
        private Guna.UI.WinForms.GunaAdvenceButton btnIphone;
        private Guna.UI.WinForms.GunaAdvenceButton btnAlcatel;
        private Guna.UI.WinForms.GunaAdvenceButton btnAsus;
        private Guna.UI.WinForms.GunaAdvenceButton btnXiaomi;
        private Guna.UI.WinForms.GunaAdvenceButton btnLenovo;
        private Guna.UI.WinForms.GunaAdvenceButton btnMotorola;
        private Guna.UI.WinForms.GunaAdvenceButton btnLG;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        public System.Windows.Forms.Label lblOrcStatus;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem submenuAdicionarNovo;
    }
}