﻿using PFC___StandBy_CSharp.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_CadastroClientes_Edit : Form
    {
        form_CadastroClientes cadCliente;
        AlterarDados ad = new AlterarDados();
        int[] corGeral = new int[3];
        public form_CadastroClientes_Edit(form_CadastroClientes cadCliente, int[] corRGB)
        {
            InitializeComponent();
            corGeral = corRGB;
            this.cadCliente = cadCliente;
            MudarCores();
        }
        public form_CadastroClientes_Edit()
        {
            InitializeComponent();
        }

        public void MudarCores()
        {
            cardFundo.color = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.BaseColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.BaseColor2 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            btnEditar.OnHoverBaseColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnEditar.OnHoverBaseColor2 = Color.White;

            sep1.GradientColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            sep2.GradientColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            sep3.GradientColor1 = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

            sep1.GradientColor2 = Color.FromArgb(200, 200, 200);
            sep2.GradientColor2 = Color.FromArgb(200, 200, 200);
            sep3.GradientColor2 = Color.FromArgb(200, 200, 200);
        }

        private void form_CadastroClientes_Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            long cpf = Convert.ToInt64(txtCpf.Text);
            string CPFformatado = String.Format(@"{0:\000\.000\.000\-00}", cpf);
            int id = int.Parse(lblID.Text);
            ad.AlterarClientes(id, txtNomeCliente.Text, txtTelefone.Text, CPFformatado);
            cadCliente.refreshTable();
            this.Close();
        }
    }
}
