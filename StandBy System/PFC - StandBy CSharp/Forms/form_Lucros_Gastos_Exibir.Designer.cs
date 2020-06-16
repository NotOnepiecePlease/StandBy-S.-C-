namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Lucros_Gastos_Exibir
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
            this.tabelaGastos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gst_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qst_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qst_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qst_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst_temporario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tornarTemporarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tornarRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGastos = new Guna.UI.WinForms.GunaLabel();
            this.checkGastos = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.panelTopColor = new Guna.UI.WinForms.GunaPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaGastos)).BeginInit();
            this.menu.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaGastos
            // 
            this.tabelaGastos.AllowUserToAddRows = false;
            this.tabelaGastos.AllowUserToDeleteRows = false;
            this.tabelaGastos.AllowUserToOrderColumns = true;
            this.tabelaGastos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabelaGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabelaGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaGastos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tabelaGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaGastos.ColumnHeadersHeight = 35;
            this.tabelaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabelaGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gst_id,
            this.qst_data,
            this.qst_produto,
            this.qst_valor,
            this.gst_temporario});
            this.tabelaGastos.ContextMenuStrip = this.menu;
            this.tabelaGastos.DoubleBuffered = true;
            this.tabelaGastos.EnableHeadersVisualStyles = false;
            this.tabelaGastos.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.tabelaGastos.HeaderForeColor = System.Drawing.Color.Black;
            this.tabelaGastos.Location = new System.Drawing.Point(12, 62);
            this.tabelaGastos.Name = "tabelaGastos";
            this.tabelaGastos.ReadOnly = true;
            this.tabelaGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabelaGastos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabelaGastos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabelaGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaGastos.Size = new System.Drawing.Size(362, 427);
            this.tabelaGastos.TabIndex = 24;
            this.tabelaGastos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaGastos_CellContentDoubleClick);
            // 
            // gst_id
            // 
            this.gst_id.DataPropertyName = "gst_id";
            this.gst_id.HeaderText = "id";
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
            this.qst_data.Width = 80;
            // 
            // qst_produto
            // 
            this.qst_produto.DataPropertyName = "gst_produto";
            this.qst_produto.HeaderText = "Produto";
            this.qst_produto.Name = "qst_produto";
            this.qst_produto.ReadOnly = true;
            this.qst_produto.Width = 202;
            // 
            // qst_valor
            // 
            this.qst_valor.DataPropertyName = "gst_valor";
            this.qst_valor.HeaderText = "Valor";
            this.qst_valor.Name = "qst_valor";
            this.qst_valor.ReadOnly = true;
            this.qst_valor.Width = 60;
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
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tornarTemporarioToolStripMenuItem,
            this.tornarRealToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.ShowImageMargin = false;
            this.menu.Size = new System.Drawing.Size(145, 70);
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
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGastos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGastos.Location = new System.Drawing.Point(157, 27);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(121, 15);
            this.lblGastos.TabIndex = 27;
            this.lblGastos.Text = "Exibindo Gastos Reais";
            // 
            // checkGastos
            // 
            this.checkGastos.BaseColor = System.Drawing.SystemColors.Control;
            this.checkGastos.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.checkGastos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.checkGastos.FillColor = System.Drawing.Color.White;
            this.checkGastos.Location = new System.Drawing.Point(118, 25);
            this.checkGastos.Name = "checkGastos";
            this.checkGastos.Size = new System.Drawing.Size(43, 20);
            this.checkGastos.TabIndex = 26;
            this.checkGastos.CheckedChanged += new System.EventHandler(this.checkGastos_CheckedChanged);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.gunaPanel1.Controls.Add(this.panelTopColor);
            this.gunaPanel1.Location = new System.Drawing.Point(-9, -4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(400, 506);
            this.gunaPanel1.TabIndex = 28;
            // 
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelTopColor.Location = new System.Drawing.Point(3, 0);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(397, 10);
            this.panelTopColor.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.gunaPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // form_Lucros_Gastos_Exibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(387, 501);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.checkGastos);
            this.Controls.Add(this.tabelaGastos);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_Lucros_Gastos_Exibir";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Lucros_Gastos_Exibir";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_Lucros_Gastos_Exibir_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaGastos)).EndInit();
            this.menu.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid tabelaGastos;
        private Guna.UI.WinForms.GunaLabel lblGastos;
        private Guna.UI.WinForms.GunaGoogleSwitch checkGastos;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI.WinForms.GunaPanel panelTopColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn qst_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn qst_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qst_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst_temporario;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tornarTemporarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tornarRealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
    }
}