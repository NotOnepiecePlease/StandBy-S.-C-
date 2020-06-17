namespace PFC___StandBy_CSharp.Forms
{
    partial class form_OrdensServ_Edit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIDservico = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSituacaoEdit = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIDcliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServicoEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLucroValorEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPecaValorEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtServicoValorEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataEdit = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSenhaEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAparelhoEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDefeitoEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelNome = new System.Windows.Forms.Panel();
            this.lblClienteNome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnConcluirImprimir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnConcluirServico = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEditarServico = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConcluirImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConcluirServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarServico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.btnConcluirImprimir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblIDservico);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnConcluirServico);
            this.panel1.Controls.Add(this.btnEditarServico);
            this.panel1.Controls.Add(this.lblIDcliente);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panelNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 566);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(2)))), ((int)(((byte)(102)))));
            this.panel2.Location = new System.Drawing.Point(0, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 10);
            this.panel2.TabIndex = 18;
            // 
            // lblIDservico
            // 
            this.lblIDservico.AutoSize = true;
            this.lblIDservico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDservico.Location = new System.Drawing.Point(791, 102);
            this.lblIDservico.Name = "lblIDservico";
            this.lblIDservico.Size = new System.Drawing.Size(70, 16);
            this.lblIDservico.TabIndex = 20;
            this.lblIDservico.Text = "ID Servico";
            this.lblIDservico.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.groupBox3.Controls.Add(this.txtSituacaoEdit);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.groupBox3.Location = new System.Drawing.Point(25, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 246);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação do Aparelho";
            // 
            // txtSituacaoEdit
            // 
            this.txtSituacaoEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.txtSituacaoEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSituacaoEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtSituacaoEdit.ForeColor = System.Drawing.Color.White;
            this.txtSituacaoEdit.Location = new System.Drawing.Point(29, 44);
            this.txtSituacaoEdit.MaxLength = 500;
            this.txtSituacaoEdit.Name = "txtSituacaoEdit";
            this.txtSituacaoEdit.Size = new System.Drawing.Size(705, 181);
            this.txtSituacaoEdit.TabIndex = 5;
            this.txtSituacaoEdit.Text = "Foi passado um orçamento para o cliente de 200 reais, o pagamento vai ser parcela" +
    "do em 12 vezes, o cliente ficou de trazer mais.";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(344, 18);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(75, 23);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Situação";
            // 
            // lblIDcliente
            // 
            this.lblIDcliente.AutoSize = true;
            this.lblIDcliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIDcliente.Location = new System.Drawing.Point(793, 86);
            this.lblIDcliente.Name = "lblIDcliente";
            this.lblIDcliente.Size = new System.Drawing.Size(65, 16);
            this.lblIDcliente.TabIndex = 6;
            this.lblIDcliente.Text = "ID Cliente";
            this.lblIDcliente.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.groupBox2.Controls.Add(this.txtServicoEdit);
            this.groupBox2.Controls.Add(this.txtLucroValorEdit);
            this.groupBox2.Controls.Add(this.txtPecaValorEdit);
            this.groupBox2.Controls.Add(this.txtServicoValorEdit);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.groupBox2.Location = new System.Drawing.Point(412, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 241);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Concluir Serviço";
            // 
            // txtServicoEdit
            // 
            this.txtServicoEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtServicoEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtServicoEdit.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtServicoEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicoEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicoEdit.ForeColor = System.Drawing.Color.White;
            this.txtServicoEdit.HintForeColor = System.Drawing.Color.Empty;
            this.txtServicoEdit.HintText = "";
            this.txtServicoEdit.isPassword = false;
            this.txtServicoEdit.LineFocusedColor = System.Drawing.Color.White;
            this.txtServicoEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServicoEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.txtServicoEdit.LineThickness = 3;
            this.txtServicoEdit.Location = new System.Drawing.Point(97, 176);
            this.txtServicoEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServicoEdit.MaxLength = 32767;
            this.txtServicoEdit.Name = "txtServicoEdit";
            this.txtServicoEdit.Size = new System.Drawing.Size(277, 35);
            this.txtServicoEdit.TabIndex = 9;
            this.txtServicoEdit.Text = "Troca da tela";
            this.txtServicoEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLucroValorEdit
            // 
            this.txtLucroValorEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLucroValorEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLucroValorEdit.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLucroValorEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLucroValorEdit.Enabled = false;
            this.txtLucroValorEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLucroValorEdit.ForeColor = System.Drawing.Color.White;
            this.txtLucroValorEdit.HintForeColor = System.Drawing.Color.Empty;
            this.txtLucroValorEdit.HintText = "";
            this.txtLucroValorEdit.isPassword = false;
            this.txtLucroValorEdit.LineFocusedColor = System.Drawing.Color.White;
            this.txtLucroValorEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLucroValorEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.txtLucroValorEdit.LineThickness = 3;
            this.txtLucroValorEdit.Location = new System.Drawing.Point(97, 125);
            this.txtLucroValorEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLucroValorEdit.MaxLength = 32767;
            this.txtLucroValorEdit.Name = "txtLucroValorEdit";
            this.txtLucroValorEdit.Size = new System.Drawing.Size(277, 35);
            this.txtLucroValorEdit.TabIndex = 8;
            this.txtLucroValorEdit.Text = "R$ 50,00";
            this.txtLucroValorEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPecaValorEdit
            // 
            this.txtPecaValorEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPecaValorEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPecaValorEdit.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPecaValorEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPecaValorEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPecaValorEdit.ForeColor = System.Drawing.Color.White;
            this.txtPecaValorEdit.HintForeColor = System.Drawing.Color.Empty;
            this.txtPecaValorEdit.HintText = "";
            this.txtPecaValorEdit.isPassword = false;
            this.txtPecaValorEdit.LineFocusedColor = System.Drawing.Color.White;
            this.txtPecaValorEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPecaValorEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.txtPecaValorEdit.LineThickness = 3;
            this.txtPecaValorEdit.Location = new System.Drawing.Point(97, 74);
            this.txtPecaValorEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPecaValorEdit.MaxLength = 32767;
            this.txtPecaValorEdit.Name = "txtPecaValorEdit";
            this.txtPecaValorEdit.Size = new System.Drawing.Size(277, 35);
            this.txtPecaValorEdit.TabIndex = 7;
            this.txtPecaValorEdit.Text = "R$ 150,00";
            this.txtPecaValorEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPecaValorEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPecaValorEdit_KeyUp);
            // 
            // txtServicoValorEdit
            // 
            this.txtServicoValorEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtServicoValorEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtServicoValorEdit.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtServicoValorEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicoValorEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicoValorEdit.ForeColor = System.Drawing.Color.White;
            this.txtServicoValorEdit.HintForeColor = System.Drawing.Color.Empty;
            this.txtServicoValorEdit.HintText = "";
            this.txtServicoValorEdit.isPassword = false;
            this.txtServicoValorEdit.LineFocusedColor = System.Drawing.Color.White;
            this.txtServicoValorEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServicoValorEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.txtServicoValorEdit.LineThickness = 3;
            this.txtServicoValorEdit.Location = new System.Drawing.Point(97, 23);
            this.txtServicoValorEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServicoValorEdit.MaxLength = 32767;
            this.txtServicoValorEdit.Name = "txtServicoValorEdit";
            this.txtServicoValorEdit.Size = new System.Drawing.Size(277, 35);
            this.txtServicoValorEdit.TabIndex = 6;
            this.txtServicoValorEdit.Text = "R$ 200,00";
            this.txtServicoValorEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtServicoValorEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtServicoValorEdit_KeyUp);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(26, 188);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(73, 23);
            this.bunifuCustomLabel8.TabIndex = 15;
            this.bunifuCustomLabel8.Text = "Serviço: ";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(14, 137);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(85, 23);
            this.bunifuCustomLabel7.TabIndex = 14;
            this.bunifuCustomLabel7.Text = "Lucro R$: ";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(21, 86);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(78, 23);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "Peça R$: ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(2, 35);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(97, 23);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Serviço R$: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.groupBox1.Controls.Add(this.dtpDataEdit);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Controls.Add(this.txtSenhaEdit);
            this.groupBox1.Controls.Add(this.txtAparelhoEdit);
            this.groupBox1.Controls.Add(this.txtDefeitoEdit);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Em Andamento";
            // 
            // dtpDataEdit
            // 
            this.dtpDataEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dtpDataEdit.BorderRadius = 0;
            this.dtpDataEdit.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.dtpDataEdit.ForeColor = System.Drawing.Color.White;
            this.dtpDataEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEdit.FormatCustom = "dd/MM/yyyy";
            this.dtpDataEdit.Location = new System.Drawing.Point(97, 27);
            this.dtpDataEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataEdit.Name = "dtpDataEdit";
            this.dtpDataEdit.Size = new System.Drawing.Size(277, 36);
            this.dtpDataEdit.TabIndex = 0;
            this.dtpDataEdit.Value = new System.DateTime(2020, 3, 26, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(44, 35);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(55, 23);
            this.bunifuCustomLabel9.TabIndex = 17;
            this.bunifuCustomLabel9.Text = "Data: ";
            // 
            // txtSenhaEdit
            // 
            this.txtSenhaEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenhaEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenhaEdit.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenhaEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenhaEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaEdit.ForeColor = System.Drawing.Color.White;
            this.txtSenhaEdit.HintForeColor = System.Drawing.Color.Empty;
            this.txtSenhaEdit.HintText = "";
            this.txtSenhaEdit.isPassword = false;
            this.txtSenhaEdit.LineFocusedColor = System.Drawing.Color.White;
            this.txtSenhaEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSenhaEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.txtSenhaEdit.LineThickness = 3;
            this.txtSenhaEdit.Location = new System.Drawing.Point(97, 174);
            this.txtSenhaEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenhaEdit.MaxLength = 32767;
            this.txtSenhaEdit.Name = "txtSenhaEdit";
            this.txtSenhaEdit.Size = new System.Drawing.Size(277, 37);
            this.txtSenhaEdit.TabIndex = 4;
            this.txtSenhaEdit.Text = "1317";
            this.txtSenhaEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAparelhoEdit
            // 
            this.txtAparelhoEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAparelhoEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAparelhoEdit.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAparelhoEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAparelhoEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAparelhoEdit.ForeColor = System.Drawing.Color.White;
            this.txtAparelhoEdit.HintForeColor = System.Drawing.Color.Empty;
            this.txtAparelhoEdit.HintText = "";
            this.txtAparelhoEdit.isPassword = false;
            this.txtAparelhoEdit.LineFocusedColor = System.Drawing.Color.White;
            this.txtAparelhoEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAparelhoEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.txtAparelhoEdit.LineThickness = 3;
            this.txtAparelhoEdit.Location = new System.Drawing.Point(97, 72);
            this.txtAparelhoEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAparelhoEdit.MaxLength = 32767;
            this.txtAparelhoEdit.Name = "txtAparelhoEdit";
            this.txtAparelhoEdit.Size = new System.Drawing.Size(277, 37);
            this.txtAparelhoEdit.TabIndex = 2;
            this.txtAparelhoEdit.Text = "Galaxy S10";
            this.txtAparelhoEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDefeitoEdit
            // 
            this.txtDefeitoEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDefeitoEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDefeitoEdit.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDefeitoEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDefeitoEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefeitoEdit.ForeColor = System.Drawing.Color.White;
            this.txtDefeitoEdit.HintForeColor = System.Drawing.Color.Empty;
            this.txtDefeitoEdit.HintText = "";
            this.txtDefeitoEdit.isPassword = false;
            this.txtDefeitoEdit.LineFocusedColor = System.Drawing.Color.White;
            this.txtDefeitoEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDefeitoEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.txtDefeitoEdit.LineThickness = 3;
            this.txtDefeitoEdit.Location = new System.Drawing.Point(97, 123);
            this.txtDefeitoEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefeitoEdit.MaxLength = 32767;
            this.txtDefeitoEdit.Name = "txtDefeitoEdit";
            this.txtDefeitoEdit.Size = new System.Drawing.Size(277, 37);
            this.txtDefeitoEdit.TabIndex = 3;
            this.txtDefeitoEdit.Text = "Tela rachada";
            this.txtDefeitoEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(33, 188);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(66, 23);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Senha: ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 137);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(74, 23);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Defeito: ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 86);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 23);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Aparelho: ";
            // 
            // panelNome
            // 
            this.panelNome.Controls.Add(this.lblClienteNome);
            this.panelNome.Location = new System.Drawing.Point(181, 3);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(455, 38);
            this.panelNome.TabIndex = 0;
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClienteNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNome.ForeColor = System.Drawing.Color.White;
            this.lblClienteNome.Location = new System.Drawing.Point(104, 4);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(257, 30);
            this.lblClienteNome.TabIndex = 0;
            this.lblClienteNome.Text = "Adriano Fraga de Andrade";
            this.lblClienteNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelNome;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnConcluirImprimir
            // 
            this.btnConcluirImprimir.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_print_480px;
            this.btnConcluirImprimir.ImageActive = global::PFC___StandBy_CSharp.Properties.Resources.icons8_print_512px;
            this.btnConcluirImprimir.Location = new System.Drawing.Point(799, 322);
            this.btnConcluirImprimir.Name = "btnConcluirImprimir";
            this.btnConcluirImprimir.Size = new System.Drawing.Size(53, 51);
            this.btnConcluirImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConcluirImprimir.TabIndex = 21;
            this.btnConcluirImprimir.TabStop = false;
            this.btnConcluirImprimir.Zoom = 15;
            this.btnConcluirImprimir.Click += new System.EventHandler(this.btnConcluirImprimir_Click);
            // 
            // btnConcluirServico
            // 
            this.btnConcluirServico.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_checked_checkbox_512px;
            this.btnConcluirServico.ImageActive = global::PFC___StandBy_CSharp.Properties.Resources.icons8_checked_checkbox_96px;
            this.btnConcluirServico.Location = new System.Drawing.Point(799, 265);
            this.btnConcluirServico.Name = "btnConcluirServico";
            this.btnConcluirServico.Size = new System.Drawing.Size(53, 51);
            this.btnConcluirServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConcluirServico.TabIndex = 5;
            this.btnConcluirServico.TabStop = false;
            this.btnConcluirServico.Zoom = 15;
            this.btnConcluirServico.Click += new System.EventHandler(this.btnConcluirServico_Click);
            // 
            // btnEditarServico
            // 
            this.btnEditarServico.Image = global::PFC___StandBy_CSharp.Properties.Resources.icons8_edit_file_512px;
            this.btnEditarServico.ImageActive = global::PFC___StandBy_CSharp.Properties.Resources.icons8_edit_file_512px_1;
            this.btnEditarServico.Location = new System.Drawing.Point(799, 208);
            this.btnEditarServico.Name = "btnEditarServico";
            this.btnEditarServico.Size = new System.Drawing.Size(53, 51);
            this.btnEditarServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditarServico.TabIndex = 4;
            this.btnEditarServico.TabStop = false;
            this.btnEditarServico.Zoom = 15;
            this.btnEditarServico.Click += new System.EventHandler(this.btnEditarServico_Click);
            // 
            // form_OrdensServ_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 566);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_OrdensServ_Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Servicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_OrdensServ_Edit_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_OrdensServ_Edit_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConcluirImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConcluirServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnEditarServico;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuImageButton btnConcluirServico;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtServicoEdit;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtLucroValorEdit;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPecaValorEdit;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtServicoValorEdit;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDefeitoEdit;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSenhaEdit;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAparelhoEdit;
        public System.Windows.Forms.RichTextBox txtSituacaoEdit;
        public Bunifu.Framework.UI.BunifuCustomLabel lblClienteNome;
        public System.Windows.Forms.Label lblIDcliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        public Bunifu.Framework.UI.BunifuDatepicker dtpDataEdit;
        public System.Windows.Forms.Label lblIDservico;
        private System.Windows.Forms.Panel panelNome;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnConcluirImprimir;
    }
}