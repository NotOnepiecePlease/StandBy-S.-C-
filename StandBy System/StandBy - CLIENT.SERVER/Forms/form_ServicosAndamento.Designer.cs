
namespace StandBy___CLIENT.SERVER.Forms
{
    partial class form_ServicosAndamento
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.table_ServicosAndamento = new Bunifu.Framework.UI.BunifuCustomDataGrid();
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
            this.previsao_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existe_um_prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_acessorios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_cor_tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv_tempo_para_entregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolsANALISAR = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAtualizarTabela = new System.Windows.Forms.Timer(this.components);
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_ServicosAndamento)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelBackground.Controls.Add(this.table_ServicosAndamento);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1280, 646);
            this.panelBackground.TabIndex = 0;
            // 
            // table_ServicosAndamento
            // 
            this.table_ServicosAndamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            this.table_ServicosAndamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_ServicosAndamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_ServicosAndamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.table_ServicosAndamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_ServicosAndamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_ServicosAndamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_ServicosAndamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_ServicosAndamento.ColumnHeadersHeight = 35;
            this.table_ServicosAndamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_ServicosAndamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.previsao_entrega,
            this.existe_um_prazo,
            this.sv_acessorios,
            this.sv_cor_tempo,
            this.sv_tempo_para_entregar});
            this.table_ServicosAndamento.ContextMenuStrip = this.contextMenuStrip1;
            this.table_ServicosAndamento.DoubleBuffered = true;
            this.table_ServicosAndamento.EnableHeadersVisualStyles = false;
            this.table_ServicosAndamento.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.table_ServicosAndamento.HeaderForeColor = System.Drawing.Color.Black;
            this.table_ServicosAndamento.Location = new System.Drawing.Point(8, 12);
            this.table_ServicosAndamento.Name = "table_ServicosAndamento";
            this.table_ServicosAndamento.ReadOnly = true;
            this.table_ServicosAndamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_ServicosAndamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_ServicosAndamento.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.table_ServicosAndamento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_ServicosAndamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_ServicosAndamento.Size = new System.Drawing.Size(1265, 622);
            this.table_ServicosAndamento.TabIndex = 1;
            this.table_ServicosAndamento.TabStop = false;
            this.table_ServicosAndamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.table_ServicosAndamento_CellFormatting);
            this.table_ServicosAndamento.MouseEnter += new System.EventHandler(this.table_ServicosAndamento_MouseEnter);
            this.table_ServicosAndamento.MouseLeave += new System.EventHandler(this.table_ServicosAndamento_MouseLeave);
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
            this.Senha.Visible = false;
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
            // previsao_entrega
            // 
            this.previsao_entrega.DataPropertyName = "sv_previsao_entrega";
            this.previsao_entrega.HeaderText = "previsao_entrega";
            this.previsao_entrega.Name = "previsao_entrega";
            this.previsao_entrega.ReadOnly = true;
            this.previsao_entrega.Visible = false;
            // 
            // existe_um_prazo
            // 
            this.existe_um_prazo.DataPropertyName = "sv_existe_um_prazo";
            this.existe_um_prazo.HeaderText = "existe_um_prazo";
            this.existe_um_prazo.Name = "existe_um_prazo";
            this.existe_um_prazo.ReadOnly = true;
            this.existe_um_prazo.Visible = false;
            // 
            // sv_acessorios
            // 
            this.sv_acessorios.DataPropertyName = "sv_acessorios";
            this.sv_acessorios.HeaderText = "sv_acessorios";
            this.sv_acessorios.Name = "sv_acessorios";
            this.sv_acessorios.ReadOnly = true;
            this.sv_acessorios.Visible = false;
            // 
            // sv_cor_tempo
            // 
            this.sv_cor_tempo.DataPropertyName = "sv_cor_tempo";
            this.sv_cor_tempo.HeaderText = "sv_cor_tempo";
            this.sv_cor_tempo.Name = "sv_cor_tempo";
            this.sv_cor_tempo.ReadOnly = true;
            this.sv_cor_tempo.Visible = false;
            // 
            // sv_tempo_para_entregar
            // 
            this.sv_tempo_para_entregar.DataPropertyName = "sv_tempo_para_entregar";
            this.sv_tempo_para_entregar.HeaderText = "Tempo";
            this.sv_tempo_para_entregar.Name = "sv_tempo_para_entregar";
            this.sv_tempo_para_entregar.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsANALISAR});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // toolsANALISAR
            // 
            this.toolsANALISAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.toolsANALISAR.Name = "toolsANALISAR";
            this.toolsANALISAR.Size = new System.Drawing.Size(106, 22);
            this.toolsANALISAR.Text = "Ver Serviço";
            this.toolsANALISAR.Click += new System.EventHandler(this.toolsANALISAR_Click);
            // 
            // timerAtualizarTabela
            // 
            this.timerAtualizarTabela.Interval = 2000;
            this.timerAtualizarTabela.Tick += new System.EventHandler(this.timerAtualizarTabela_Tick);
            // 
            // form_ServicosAndamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 646);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ServicosAndamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ServicosAndamento";
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_ServicosAndamento)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsANALISAR;
        public Bunifu.Framework.UI.BunifuCustomDataGrid table_ServicosAndamento;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn previsao_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn existe_um_prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_acessorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_cor_tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv_tempo_para_entregar;
        private System.Windows.Forms.Timer timerAtualizarTabela;
    }
}