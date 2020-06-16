namespace PFC___StandBy_CSharp.Forms
{
    partial class form_CadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CadastroClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefoneCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomeCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCPFCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPesquisarCADCliente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.table_Clientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Clientes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.txtTelefoneCliente);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.txtCPFCliente);
            this.panel1.Controls.Add(this.txtPesquisarCADCliente);
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.table_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 665);
            this.panel1.TabIndex = 1;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefoneCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefoneCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefoneCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTelefoneCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefoneCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefoneCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtTelefoneCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefoneCliente.HintForeColor = System.Drawing.Color.Transparent;
            this.txtTelefoneCliente.HintText = "";
            this.txtTelefoneCliente.isPassword = false;
            this.txtTelefoneCliente.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtTelefoneCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtTelefoneCliente.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtTelefoneCliente.LineThickness = 2;
            this.txtTelefoneCliente.Location = new System.Drawing.Point(261, 218);
            this.txtTelefoneCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefoneCliente.MaxLength = 15;
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(542, 32);
            this.txtTelefoneCliente.TabIndex = 3;
            this.txtTelefoneCliente.Text = "Telefone do Cliente";
            this.txtTelefoneCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefoneCliente.Enter += new System.EventHandler(this.txtTelefoneCliente_Enter);
            this.txtTelefoneCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefoneCliente_KeyDown);
            this.txtTelefoneCliente.Leave += new System.EventHandler(this.txtTelefoneCliente_Leave);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNomeCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeCliente.HintForeColor = System.Drawing.Color.Transparent;
            this.txtNomeCliente.HintText = "";
            this.txtNomeCliente.isPassword = false;
            this.txtNomeCliente.LineFocusedColor = System.Drawing.Color.Lavender;
            this.txtNomeCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtNomeCliente.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtNomeCliente.LineThickness = 2;
            this.txtNomeCliente.Location = new System.Drawing.Point(261, 44);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(542, 34);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.Text = "Nome do Cliente";
            this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCliente.Enter += new System.EventHandler(this.txtNomeCliente_Enter);
            this.txtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeCliente_KeyDown);
            this.txtNomeCliente.Leave += new System.EventHandler(this.txtNomeCliente_Leave);
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCPFCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCPFCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCPFCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtCPFCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCPFCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCPFCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPFCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtCPFCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtCPFCliente.HintForeColor = System.Drawing.Color.Transparent;
            this.txtCPFCliente.HintText = "";
            this.txtCPFCliente.isPassword = false;
            this.txtCPFCliente.LineFocusedColor = System.Drawing.Color.White;
            this.txtCPFCliente.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtCPFCliente.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.txtCPFCliente.LineThickness = 2;
            this.txtCPFCliente.Location = new System.Drawing.Point(261, 132);
            this.txtCPFCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFCliente.MaxLength = 11;
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(542, 32);
            this.txtCPFCliente.TabIndex = 2;
            this.txtCPFCliente.Text = "CPF do Cliente";
            this.txtCPFCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPFCliente.Enter += new System.EventHandler(this.txtCPFCliente_Enter);
            this.txtCPFCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPFCliente_KeyDown);
            this.txtCPFCliente.Leave += new System.EventHandler(this.txtCPFCliente_Leave);
            // 
            // txtPesquisarCADCliente
            // 
            this.txtPesquisarCADCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisarCADCliente.BorderColorFocused = System.Drawing.Color.White;
            this.txtPesquisarCADCliente.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtPesquisarCADCliente.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtPesquisarCADCliente.BorderThickness = 2;
            this.txtPesquisarCADCliente.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisarCADCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarCADCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtPesquisarCADCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisarCADCliente.isPassword = false;
            this.txtPesquisarCADCliente.Location = new System.Drawing.Point(261, 260);
            this.txtPesquisarCADCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisarCADCliente.MaxLength = 32767;
            this.txtPesquisarCADCliente.Name = "txtPesquisarCADCliente";
            this.txtPesquisarCADCliente.Size = new System.Drawing.Size(485, 46);
            this.txtPesquisarCADCliente.TabIndex = 4;
            this.txtPesquisarCADCliente.Text = "Digite o nome do cliente que deseja buscar os serviços";
            this.txtPesquisarCADCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarCADCliente.Enter += new System.EventHandler(this.txtPesquisarCADCliente_Enter);
            this.txtPesquisarCADCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarCADCliente_KeyDown);
            this.txtPesquisarCADCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarCADCliente_KeyUp);
            this.txtPesquisarCADCliente.Leave += new System.EventHandler(this.txtPesquisarCADCliente_Leave);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnCadastrarCliente.IconSize = 50;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(754, 261);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnCadastrarCliente.Rotation = 0D;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(49, 45);
            this.btnCadastrarCliente.TabIndex = 0;
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(469, 95);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(127, 33);
            this.bunifuCustomLabel3.TabIndex = 32;
            this.bunifuCustomLabel3.Text = "CPF";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(466, 180);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(133, 33);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "Telefone";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Lavender;
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(476, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(112, 22);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "Cliente";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table_Clientes
            // 
            this.table_Clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_Clientes.ColumnHeadersHeight = 35;
            this.table_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_id,
            this.Nome,
            this.Defeito,
            this.Situacao});
            this.table_Clientes.ContextMenuStrip = this.contextMenuStrip1;
            this.table_Clientes.DoubleBuffered = true;
            this.table_Clientes.EnableHeadersVisualStyles = false;
            this.table_Clientes.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.table_Clientes.HeaderForeColor = System.Drawing.Color.Black;
            this.table_Clientes.Location = new System.Drawing.Point(261, 314);
            this.table_Clientes.Name = "table_Clientes";
            this.table_Clientes.ReadOnly = true;
            this.table_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_Clientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.table_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Clientes.Size = new System.Drawing.Size(542, 339);
            this.table_Clientes.TabIndex = 0;
            this.table_Clientes.TabStop = false;
            // 
            // cl_id
            // 
            this.cl_id.DataPropertyName = "cl_id";
            this.cl_id.HeaderText = "cl_id";
            this.cl_id.Name = "cl_id";
            this.cl_id.ReadOnly = true;
            this.cl_id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "cl_nome";
            this.Nome.FillWeight = 141.1765F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Defeito
            // 
            this.Defeito.DataPropertyName = "cl_telefone";
            this.Defeito.HeaderText = "Telefone";
            this.Defeito.Name = "Defeito";
            this.Defeito.ReadOnly = true;
            this.Defeito.Width = 180;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "cl_cpf";
            this.Situacao.FillWeight = 58.82353F;
            this.Situacao.HeaderText = "CPF";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(85, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.table_Clientes;
            // 
            // form_CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_CadastroClientes";
            this.Text = "form_CadastroClientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_Clientes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeCliente;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCPFCliente;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPesquisarCADCliente;
        private FontAwesome.Sharp.IconButton btnCadastrarCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefoneCliente;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table_Clientes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Defeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}