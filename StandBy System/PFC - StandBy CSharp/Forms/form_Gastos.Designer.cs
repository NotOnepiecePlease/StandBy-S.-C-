
namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Gastos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.table_Gastos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtPesquisarGastos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.datepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.datepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnPesquisarGastos = new Guna.UI.WinForms.GunaAdvenceButton();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.gst_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_temporario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.iconClose);
            this.panel1.Controls.Add(this.table_Gastos);
            this.panel1.Controls.Add(this.txtPesquisarGastos);
            this.panel1.Controls.Add(this.datepicker2);
            this.panel1.Controls.Add(this.datepicker1);
            this.panel1.Controls.Add(this.btnPesquisarGastos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 665);
            this.panel1.TabIndex = 0;
            // 
            // table_Gastos
            // 
            this.table_Gastos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_Gastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_Gastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Gastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.table_Gastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_Gastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_Gastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Gastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_Gastos.ColumnHeadersHeight = 35;
            this.table_Gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_Gastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gst_id,
            this.gst_data,
            this.gst_produto,
            this.gst_valor,
            this.gst_temporario});
            this.table_Gastos.DoubleBuffered = true;
            this.table_Gastos.EnableHeadersVisualStyles = false;
            this.table_Gastos.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.table_Gastos.HeaderForeColor = System.Drawing.Color.Black;
            this.table_Gastos.Location = new System.Drawing.Point(68, 134);
            this.table_Gastos.Name = "table_Gastos";
            this.table_Gastos.ReadOnly = true;
            this.table_Gastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Gastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_Gastos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.table_Gastos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_Gastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Gastos.Size = new System.Drawing.Size(521, 480);
            this.table_Gastos.TabIndex = 26;
            this.table_Gastos.TabStop = false;
            // 
            // txtPesquisarGastos
            // 
            this.txtPesquisarGastos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisarGastos.BorderColorFocused = System.Drawing.Color.White;
            this.txtPesquisarGastos.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtPesquisarGastos.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtPesquisarGastos.BorderThickness = 2;
            this.txtPesquisarGastos.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisarGastos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtPesquisarGastos.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisarGastos.isPassword = false;
            this.txtPesquisarGastos.Location = new System.Drawing.Point(68, 66);
            this.txtPesquisarGastos.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisarGastos.MaxLength = 32767;
            this.txtPesquisarGastos.Name = "txtPesquisarGastos";
            this.txtPesquisarGastos.Size = new System.Drawing.Size(500, 46);
            this.txtPesquisarGastos.TabIndex = 25;
            this.txtPesquisarGastos.Text = "Digite o gasto que deseja buscar";
            this.txtPesquisarGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarGastos.Enter += new System.EventHandler(this.txtPesquisarGastos_Enter);
            this.txtPesquisarGastos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarGastos_KeyUp);
            this.txtPesquisarGastos.Leave += new System.EventHandler(this.txtPesquisarGastos_Leave);
            // 
            // datepicker2
            // 
            this.datepicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datepicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.datepicker2.BorderRadius = 0;
            this.datepicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker2.ForeColor = System.Drawing.Color.White;
            this.datepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker2.FormatCustom = null;
            this.datepicker2.Location = new System.Drawing.Point(377, 12);
            this.datepicker2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datepicker2.Name = "datepicker2";
            this.datepicker2.Size = new System.Drawing.Size(191, 42);
            this.datepicker2.TabIndex = 24;
            this.datepicker2.Value = new System.DateTime(2021, 6, 11, 0, 0, 0, 0);
            // 
            // datepicker1
            // 
            this.datepicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.datepicker1.BorderRadius = 0;
            this.datepicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.datepicker1.ForeColor = System.Drawing.Color.White;
            this.datepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker1.FormatCustom = null;
            this.datepicker1.Location = new System.Drawing.Point(68, 12);
            this.datepicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datepicker1.Name = "datepicker1";
            this.datepicker1.Size = new System.Drawing.Size(191, 42);
            this.datepicker1.TabIndex = 23;
            this.datepicker1.Value = new System.DateTime(2020, 6, 11, 0, 0, 0, 0);
            // 
            // btnPesquisarGastos
            // 
            this.btnPesquisarGastos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPesquisarGastos.Animated = true;
            this.btnPesquisarGastos.AnimationHoverSpeed = 0.07F;
            this.btnPesquisarGastos.AnimationSpeed = 0.03F;
            this.btnPesquisarGastos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnPesquisarGastos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPesquisarGastos.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPesquisarGastos.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPesquisarGastos.CheckedForeColor = System.Drawing.Color.White;
            this.btnPesquisarGastos.CheckedImage = null;
            this.btnPesquisarGastos.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPesquisarGastos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPesquisarGastos.FocusedColor = System.Drawing.Color.Empty;
            this.btnPesquisarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPesquisarGastos.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarGastos.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_search_500px;
            this.btnPesquisarGastos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPesquisarGastos.ImageOffsetX = 1;
            this.btnPesquisarGastos.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPesquisarGastos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPesquisarGastos.Location = new System.Drawing.Point(292, 12);
            this.btnPesquisarGastos.Name = "btnPesquisarGastos";
            this.btnPesquisarGastos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.btnPesquisarGastos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPesquisarGastos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPesquisarGastos.OnHoverImage = null;
            this.btnPesquisarGastos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPesquisarGastos.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPesquisarGastos.Size = new System.Drawing.Size(52, 46);
            this.btnPesquisarGastos.TabIndex = 22;
            this.btnPesquisarGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPesquisarGastos.Click += new System.EventHandler(this.btnPesquisarGastos_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.iconClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.iconClose.IconSize = 29;
            this.iconClose.Location = new System.Drawing.Point(605, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconClose.Size = new System.Drawing.Size(29, 29);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconClose.TabIndex = 27;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // gst_id
            // 
            this.gst_id.DataPropertyName = "gst_id";
            this.gst_id.HeaderText = "cl_id";
            this.gst_id.Name = "gst_id";
            this.gst_id.ReadOnly = true;
            this.gst_id.Visible = false;
            this.gst_id.Width = 5;
            // 
            // gst_data
            // 
            this.gst_data.DataPropertyName = "gst_data";
            this.gst_data.HeaderText = "Data";
            this.gst_data.Name = "gst_data";
            this.gst_data.ReadOnly = true;
            // 
            // gst_produto
            // 
            this.gst_produto.DataPropertyName = "gst_produto";
            this.gst_produto.HeaderText = "Gasto/Produto";
            this.gst_produto.Name = "gst_produto";
            this.gst_produto.ReadOnly = true;
            this.gst_produto.Width = 320;
            // 
            // gst_valor
            // 
            this.gst_valor.DataPropertyName = "gst_valor";
            this.gst_valor.HeaderText = "Valor";
            this.gst_valor.Name = "gst_valor";
            this.gst_valor.ReadOnly = true;
            this.gst_valor.Width = 80;
            // 
            // gst_temporario
            // 
            this.gst_temporario.DataPropertyName = "gst_temporario";
            this.gst_temporario.HeaderText = "gst_temporario";
            this.gst_temporario.Name = "gst_temporario";
            this.gst_temporario.ReadOnly = true;
            this.gst_temporario.Visible = false;
            // 
            // form_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "form_Gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle dos Gastos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Gastos_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker2;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker1;
        private Guna.UI.WinForms.GunaAdvenceButton btnPesquisarGastos;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPesquisarGastos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table_Gastos;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_temporario;
    }
}