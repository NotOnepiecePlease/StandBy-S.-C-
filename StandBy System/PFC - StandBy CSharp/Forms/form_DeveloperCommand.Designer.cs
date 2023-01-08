namespace PFC___StandBy_CSharp.Forms
{
    partial class form_DeveloperCommand
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
            this.cmbComando = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExecutarComando = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComando.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbComando
            // 
            this.cmbComando.EditValue = "dev";
            this.cmbComando.Location = new System.Drawing.Point(12, 12);
            this.cmbComando.Name = "cmbComando";
            this.cmbComando.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbComando.Properties.Items.AddRange(new object[] {
            "dev",
            "cmb"});
            this.cmbComando.Size = new System.Drawing.Size(224, 30);
            this.cmbComando.TabIndex = 0;
            this.cmbComando.ToolTip = "dev = Painel de Desenvolvedor | cmb = Edicao das combobox";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExecutarComando);
            this.panelControl1.Controls.Add(this.cmbComando);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(281, 56);
            this.panelControl1.TabIndex = 1;
            // 
            // btnExecutarComando
            // 
            this.btnExecutarComando.Location = new System.Drawing.Point(242, 12);
            this.btnExecutarComando.Name = "btnExecutarComando";
            this.btnExecutarComando.Size = new System.Drawing.Size(30, 30);
            this.btnExecutarComando.TabIndex = 1;
            this.btnExecutarComando.Text = ">";
            this.btnExecutarComando.Click += new System.EventHandler(this.btnExecutarComando_Click);
            // 
            // form_DeveloperCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(281, 56);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "form_DeveloperCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_DeveloperCommand";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_DeveloperCommand_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbComando.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbComando;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExecutarComando;
    }
}