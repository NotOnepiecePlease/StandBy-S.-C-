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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Orcamento));
            this.tabelaOrcamento = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunaAdvenceButton7 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton5 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSamsung = new Guna.UI.WinForms.GunaAdvenceButton();
            this.orc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_peca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orc_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrcStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOrcamento)).BeginInit();
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
            this.tabelaOrcamento.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.tabelaOrcamento.DoubleBuffered = true;
            this.tabelaOrcamento.EnableHeadersVisualStyles = false;
            this.tabelaOrcamento.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.tabelaOrcamento.HeaderForeColor = System.Drawing.Color.Black;
            this.tabelaOrcamento.Location = new System.Drawing.Point(308, 40);
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
            this.tabelaOrcamento.Size = new System.Drawing.Size(494, 581);
            this.tabelaOrcamento.TabIndex = 12;
            // 
            // gunaAdvenceButton7
            // 
            this.gunaAdvenceButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton7.Animated = true;
            this.gunaAdvenceButton7.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton7.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.gunaAdvenceButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton7.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton7.CheckedImage")));
            this.gunaAdvenceButton7.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton7.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.Image = global::PFC___StandBy_CSharp.Properties.Resources.lglogo;
            this.gunaAdvenceButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton7.ImageSize = new System.Drawing.Size(100, 42);
            this.gunaAdvenceButton7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton7.Location = new System.Drawing.Point(849, 411);
            this.gunaAdvenceButton7.Name = "gunaAdvenceButton7";
            this.gunaAdvenceButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaAdvenceButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton7.OnHoverImage = null;
            this.gunaAdvenceButton7.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton7.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton7.TabIndex = 20;
            this.gunaAdvenceButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton7.Click += new System.EventHandler(this.gunaAdvenceButton7_Click);
            // 
            // gunaAdvenceButton6
            // 
            this.gunaAdvenceButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton6.Animated = true;
            this.gunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.gunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton6.CheckedImage")));
            this.gunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton6.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.Image = global::PFC___StandBy_CSharp.Properties.Resources.motorola;
            this.gunaAdvenceButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton6.ImageSize = new System.Drawing.Size(180, 55);
            this.gunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.Location = new System.Drawing.Point(849, 334);
            this.gunaAdvenceButton6.Name = "gunaAdvenceButton6";
            this.gunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.OnHoverImage = null;
            this.gunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton6.TabIndex = 19;
            this.gunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton6.Click += new System.EventHandler(this.gunaAdvenceButton6_Click);
            // 
            // gunaAdvenceButton5
            // 
            this.gunaAdvenceButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton5.Animated = true;
            this.gunaAdvenceButton5.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton5.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.gunaAdvenceButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton5.CheckedImage")));
            this.gunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton5.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.Image = global::PFC___StandBy_CSharp.Properties.Resources.lenovo;
            this.gunaAdvenceButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton5.ImageSize = new System.Drawing.Size(150, 35);
            this.gunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton5.Location = new System.Drawing.Point(849, 257);
            this.gunaAdvenceButton5.Name = "gunaAdvenceButton5";
            this.gunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.OnHoverImage = null;
            this.gunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton5.TabIndex = 18;
            this.gunaAdvenceButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton5.Click += new System.EventHandler(this.gunaAdvenceButton5_Click);
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton4.Animated = true;
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = global::PFC___StandBy_CSharp.Properties.Resources.xiaomi1;
            this.gunaAdvenceButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(160, 45);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(849, 180);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton4.TabIndex = 17;
            this.gunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton4.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton3.Animated = true;
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = global::PFC___StandBy_CSharp.Properties.Resources.asus;
            this.gunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(170, 40);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(53, 411);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton3.TabIndex = 16;
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton2.Animated = true;
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(150, 45);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(53, 334);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton2.TabIndex = 15;
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::PFC___StandBy_CSharp.Properties.Resources.iPhone_logo;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(140, 60);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(53, 257);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton1.TabIndex = 14;
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
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
            this.Controls.Add(this.gunaAdvenceButton7);
            this.Controls.Add(this.gunaAdvenceButton6);
            this.Controls.Add(this.gunaAdvenceButton5);
            this.Controls.Add(this.gunaAdvenceButton4);
            this.Controls.Add(this.gunaAdvenceButton3);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.tabelaOrcamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Orcamento";
            this.Text = "form_Orcamento";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid tabelaOrcamento;
        private Guna.UI.WinForms.GunaAdvenceButton btnSamsung;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton5;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton6;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton7;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_peca;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        public System.Windows.Forms.Label lblOrcStatus;
    }
}