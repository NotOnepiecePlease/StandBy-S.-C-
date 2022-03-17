namespace PFC___StandBy_CSharp.Forms
{
    partial class form_Concluidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Concluidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnArrowLeft = new FontAwesome.Sharp.IconPictureBox();
            this.btnArrowRight = new FontAwesome.Sharp.IconPictureBox();
            this.lblResultadosExibidos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblResultadosTotais = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPesquisarConcluidos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnPesquisarConcluidos = new FontAwesome.Sharp.IconButton();
            this.table_ServicosConcluidos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataConclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_acessorios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_previsao_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.naoConcluidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerGarantia = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ServicosConcluidos)).BeginInit();
            this.menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnArrowLeft);
            this.panel1.Controls.Add(this.btnArrowRight);
            this.panel1.Controls.Add(this.lblResultadosExibidos);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.lblResultadosTotais);
            this.panel1.Controls.Add(this.txtPesquisarConcluidos);
            this.panel1.Controls.Add(this.btnPesquisarConcluidos);
            this.panel1.Controls.Add(this.table_ServicosConcluidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 665);
            this.panel1.TabIndex = 0;
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArrowLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowLeft.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnArrowLeft.IconColor = System.Drawing.Color.White;
            this.btnArrowLeft.IconSize = 28;
            this.btnArrowLeft.Location = new System.Drawing.Point(532, 45);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnArrowLeft.Size = new System.Drawing.Size(28, 31);
            this.btnArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnArrowLeft.TabIndex = 14;
            this.btnArrowLeft.TabStop = false;
            this.btnArrowLeft.Click += new System.EventHandler(this.btnArrowLeft_Click);
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArrowRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnArrowRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowRight.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnArrowRight.IconColor = System.Drawing.Color.White;
            this.btnArrowRight.IconSize = 28;
            this.btnArrowRight.Location = new System.Drawing.Point(566, 45);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnArrowRight.Size = new System.Drawing.Size(28, 31);
            this.btnArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnArrowRight.TabIndex = 13;
            this.btnArrowRight.TabStop = false;
            this.btnArrowRight.Click += new System.EventHandler(this.btnArrowRight_Click);
            // 
            // lblResultadosExibidos
            // 
            this.lblResultadosExibidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadosExibidos.AutoSize = true;
            this.lblResultadosExibidos.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblResultadosExibidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultadosExibidos.Location = new System.Drawing.Point(479, 46);
            this.lblResultadosExibidos.Name = "lblResultadosExibidos";
            this.lblResultadosExibidos.Size = new System.Drawing.Size(45, 28);
            this.lblResultadosExibidos.TabIndex = 11;
            this.lblResultadosExibidos.Text = "999";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(384, 48);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(89, 25);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Exibindo:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(601, 48);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(82, 25);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Total de:";
            // 
            // lblResultadosTotais
            // 
            this.lblResultadosTotais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultadosTotais.AutoSize = true;
            this.lblResultadosTotais.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblResultadosTotais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultadosTotais.Location = new System.Drawing.Point(682, 46);
            this.lblResultadosTotais.Name = "lblResultadosTotais";
            this.lblResultadosTotais.Size = new System.Drawing.Size(56, 28);
            this.lblResultadosTotais.TabIndex = 8;
            this.lblResultadosTotais.Text = "9999";
            // 
            // txtPesquisarConcluidos
            // 
            this.txtPesquisarConcluidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarConcluidos.BorderColorFocused = System.Drawing.Color.White;
            this.txtPesquisarConcluidos.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.txtPesquisarConcluidos.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.txtPesquisarConcluidos.BorderThickness = 2;
            this.txtPesquisarConcluidos.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisarConcluidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisarConcluidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.txtPesquisarConcluidos.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisarConcluidos.isPassword = false;
            this.txtPesquisarConcluidos.Location = new System.Drawing.Point(5, 6);
            this.txtPesquisarConcluidos.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisarConcluidos.MaxLength = 32767;
            this.txtPesquisarConcluidos.Name = "txtPesquisarConcluidos";
            this.txtPesquisarConcluidos.Size = new System.Drawing.Size(1071, 36);
            this.txtPesquisarConcluidos.TabIndex = 7;
            this.txtPesquisarConcluidos.Text = "Digite o nome do cliente que deseja buscar os serviços";
            this.txtPesquisarConcluidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarConcluidos.Enter += new System.EventHandler(this.txtPesquisarConcluidos_Enter);
            this.txtPesquisarConcluidos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarConcluidos_KeyUp);
            this.txtPesquisarConcluidos.Leave += new System.EventHandler(this.txtPesquisarConcluidos_Leave);
            // 
            // btnPesquisarConcluidos
            // 
            this.btnPesquisarConcluidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarConcluidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarConcluidos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisarConcluidos.FlatAppearance.BorderSize = 0;
            this.btnPesquisarConcluidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarConcluidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPesquisarConcluidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarConcluidos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPesquisarConcluidos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisarConcluidos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.btnPesquisarConcluidos.IconSize = 50;
            this.btnPesquisarConcluidos.Location = new System.Drawing.Point(875, 50);
            this.btnPesquisarConcluidos.Name = "btnPesquisarConcluidos";
            this.btnPesquisarConcluidos.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnPesquisarConcluidos.Rotation = 0D;
            this.btnPesquisarConcluidos.Size = new System.Drawing.Size(49, 23);
            this.btnPesquisarConcluidos.TabIndex = 3;
            this.btnPesquisarConcluidos.TabStop = false;
            this.btnPesquisarConcluidos.UseVisualStyleBackColor = false;
            this.btnPesquisarConcluidos.Visible = false;
            this.btnPesquisarConcluidos.Click += new System.EventHandler(this.btnPesquisarConcluidos_Click);
            // 
            // table_ServicosConcluidos
            // 
            this.table_ServicosConcluidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_ServicosConcluidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_ServicosConcluidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_ServicosConcluidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_ServicosConcluidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_ServicosConcluidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_ServicosConcluidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_ServicosConcluidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_ServicosConcluidos.ColumnHeadersHeight = 35;
            this.table_ServicosConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_ServicosConcluidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServico,
            this.idCliente,
            this.Data,
            this.Nome,
            this.Aparelho,
            this.Defeito,
            this.Situacao,
            this.Senha,
            this.valorServico,
            this.valorPeca,
            this.lucro,
            this.servico,
            this.sv_status,
            this.DataConclusao,
            this.sv_acessorios,
            this.sv_previsao_entrega});
            this.table_ServicosConcluidos.ContextMenuStrip = this.menu;
            this.table_ServicosConcluidos.DoubleBuffered = true;
            this.table_ServicosConcluidos.EnableHeadersVisualStyles = false;
            this.table_ServicosConcluidos.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.table_ServicosConcluidos.HeaderForeColor = System.Drawing.Color.Black;
            this.table_ServicosConcluidos.Location = new System.Drawing.Point(3, 80);
            this.table_ServicosConcluidos.Name = "table_ServicosConcluidos";
            this.table_ServicosConcluidos.ReadOnly = true;
            this.table_ServicosConcluidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_ServicosConcluidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_ServicosConcluidos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.table_ServicosConcluidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_ServicosConcluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_ServicosConcluidos.Size = new System.Drawing.Size(1075, 582);
            this.table_ServicosConcluidos.TabIndex = 1;
            this.table_ServicosConcluidos.TabStop = false;
            this.table_ServicosConcluidos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.table_ServicosConcluidos_DataBindingComplete);
            // 
            // idServico
            // 
            this.idServico.DataPropertyName = "sv_id";
            this.idServico.HeaderText = "idServico";
            this.idServico.Name = "idServico";
            this.idServico.ReadOnly = true;
            this.idServico.Visible = false;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "sv_cl_idcliente";
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "sv_data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "cl_nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Aparelho
            // 
            this.Aparelho.DataPropertyName = "sv_aparelho";
            this.Aparelho.HeaderText = "Aparelho";
            this.Aparelho.Name = "Aparelho";
            this.Aparelho.ReadOnly = true;
            this.Aparelho.Width = 150;
            // 
            // Defeito
            // 
            this.Defeito.DataPropertyName = "sv_defeito";
            this.Defeito.HeaderText = "Defeito";
            this.Defeito.Name = "Defeito";
            this.Defeito.ReadOnly = true;
            this.Defeito.Width = 180;
            // 
            // Situacao
            // 
            this.Situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Situacao.DataPropertyName = "sv_situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "sv_senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Width = 60;
            // 
            // valorServico
            // 
            this.valorServico.DataPropertyName = "sv_valorservico";
            this.valorServico.HeaderText = "valorServico";
            this.valorServico.Name = "valorServico";
            this.valorServico.ReadOnly = true;
            this.valorServico.Visible = false;
            // 
            // valorPeca
            // 
            this.valorPeca.DataPropertyName = "sv_valorpeca";
            this.valorPeca.HeaderText = "valorPeca";
            this.valorPeca.Name = "valorPeca";
            this.valorPeca.ReadOnly = true;
            this.valorPeca.Visible = false;
            // 
            // lucro
            // 
            this.lucro.DataPropertyName = "sv_lucro";
            this.lucro.HeaderText = "lucro";
            this.lucro.Name = "lucro";
            this.lucro.ReadOnly = true;
            this.lucro.Visible = false;
            // 
            // servico
            // 
            this.servico.DataPropertyName = "sv_servico";
            this.servico.HeaderText = "servico";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            this.servico.Visible = false;
            // 
            // sv_status
            // 
            this.sv_status.DataPropertyName = "sv_status";
            this.sv_status.HeaderText = "STATUS";
            this.sv_status.Name = "sv_status";
            this.sv_status.ReadOnly = true;
            this.sv_status.Visible = false;
            // 
            // DataConclusao
            // 
            this.DataConclusao.DataPropertyName = "sv_data_conclusao";
            this.DataConclusao.HeaderText = "Data Conclusao";
            this.DataConclusao.Name = "DataConclusao";
            this.DataConclusao.ReadOnly = true;
            this.DataConclusao.Width = 97;
            // 
            // sv_acessorios
            // 
            this.sv_acessorios.DataPropertyName = "sv_acessorios";
            this.sv_acessorios.HeaderText = "sv_acessorios";
            this.sv_acessorios.Name = "sv_acessorios";
            this.sv_acessorios.ReadOnly = true;
            this.sv_acessorios.Visible = false;
            // 
            // sv_previsao_entrega
            // 
            this.sv_previsao_entrega.DataPropertyName = "sv_previsao_entrega";
            this.sv_previsao_entrega.HeaderText = "sv_previsao_entrega";
            this.sv_previsao_entrega.Name = "sv_previsao_entrega";
            this.sv_previsao_entrega.ReadOnly = true;
            this.sv_previsao_entrega.Visible = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naoConcluidoToolStripMenuItem1,
            this.menuVerGarantia,
            this.editarToolStripMenuItem1});
            this.menu.Name = "menu";
            this.menu.ShowImageMargin = false;
            this.menu.Size = new System.Drawing.Size(128, 70);
            // 
            // naoConcluidoToolStripMenuItem1
            // 
            this.naoConcluidoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.naoConcluidoToolStripMenuItem1.Name = "naoConcluidoToolStripMenuItem1";
            this.naoConcluidoToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.naoConcluidoToolStripMenuItem1.Text = "Nao concluido";
            this.naoConcluidoToolStripMenuItem1.Click += new System.EventHandler(this.naoConcluidoToolStripMenuItem1_Click);
            // 
            // menuVerGarantia
            // 
            this.menuVerGarantia.Name = "menuVerGarantia";
            this.menuVerGarantia.Size = new System.Drawing.Size(127, 22);
            this.menuVerGarantia.Text = "Ver garantia";
            this.menuVerGarantia.Click += new System.EventHandler(this.menuVerGarantia_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(80, 26);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // form_Concluidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Concluidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Concluidos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_ServicosConcluidos)).EndInit();
            this.menu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid table_ServicosConcluidos;
        private FontAwesome.Sharp.IconButton btnPesquisarConcluidos;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPesquisarConcluidos;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem naoConcluidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuVerGarantia;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel lblResultadosExibidos;
        public Bunifu.Framework.UI.BunifuCustomLabel lblResultadosTotais;
        private FontAwesome.Sharp.IconPictureBox btnArrowRight;
        private FontAwesome.Sharp.IconPictureBox btnArrowLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Defeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataConclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_acessorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_previsao_entrega;
    }
}