using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFC___StandBy_CSharp.Utils;

namespace PFC___StandBy_CSharp.Forms._1___Ordems_Servico
{
    public partial class form_OrdemServicoEditar : Form
    {
        public form_OrdemServicoEditar()
        {
            InitializeComponent();
            FormatarCampos.AplicarApenasNumeroVirgulaEMoeda(txtServicoValor);
            FormatarCampos.AplicarApenasNumeroVirgulaEMoeda(txtPecaValor);
            FormatarCampos.AplicarApenasNumeroVirgulaEMoeda(txtLucroValor);
        }

        private void AbrirRichtextExterna(RichTextBox _richText)
        {
            form_RichTextboxExterno formRTB = new form_RichTextboxExterno(ref _richText);
            formRTB.txtRichtextExterna.Text = _richText.Text;
            formRTB.ShowDialog();
        }

        private void txtRelatoCliente_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtRelatoCliente);
        }

        private void txtObservacoes_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtObservacoes);
        }

        private void txtCondicoesBalcao_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtCondicoesBalcao);
        }

        private void txtSolucao_DoubleClick(object sender, EventArgs e)
        {
            AbrirRichtextExterna(txtSolucao);
        }

        private void txtServicoValor_TextChange(object sender, EventArgs e)
        {
            if (txtServicoValor.Text.Trim() != "R$" && txtServicoValor.Text.Trim() != "R" && !string.IsNullOrWhiteSpace(txtServicoValor.Text))
            {
                float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
                txtValorAvista.Text = $"{servicoValor:C}";

                txtValorCartao.Text = $"{servicoValor * 1.05f:C}";
                CalcularLucro();
            }
        }

        private void txtServicoValor_Leave(object sender, EventArgs e)
        {
            //float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
            //txtValorAvista.Text = $"{servicoValor:C}";
        }

        private void txtValorAvista_TextChange(object sender, EventArgs e)
        {
            float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
            int parcelas = int.Parse(txtParcelas.Text);
            txtValorParcelaIndividual.Text = $"{servicoValor / parcelas:C}";
        }

        private void txtParcelas_TextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtParcelas.Text))
            {
                float servicoValor = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
                int parcelas = int.Parse(txtParcelas.Text);
                txtValorParcelaIndividual.Text = $"{servicoValor / parcelas:C}";
            }
            else
            {
                txtValorParcelaIndividual.Text = "";
            }
        }

        public void CalcularLucro()
        {
            float valorServico = 0.0f;
            float valorPeca = 0.0f;
            float lucro = valorServico - valorPeca;
            try
            {
                valorServico = float.Parse(txtServicoValor.Text.TrimStart('R', '$').Trim());
                valorPeca = float.Parse(txtPecaValor.Text.TrimStart('R', '$').Trim());
                lucro = valorServico - valorPeca;
            }
            catch (Exception)
            {
                // MessageBox.Show(ex.ToString());
            }
            if (lucro > 0)
            {
                txtLucroValor.ForeColor = Color.LimeGreen;
                sepLucro.ForeColor = Color.LimeGreen;
                sepLucro.LineColor = Color.LimeGreen;
                //sepLucro.LineFocusedColor = Color.LimeGreen;
                //txtLucroValor.Font = new Font(this.Font.Name, 11, FontStyle.Bold);
                txtLucroValor.Text = $"{lucro:C}";
            }
            else if (lucro == 0)
            {
                txtLucroValor.ForeColor = Color.White;
                sepLucro.ForeColor = Color.White;
                sepLucro.LineColor = Color.White;
                //txtLucroValor.LineFocusedColor = Color.White;
                txtLucroValor.Text = $"{lucro:C}";
            }
            else if (lucro < 0)
            {
                txtLucroValor.ForeColor = Color.Red;
                sepLucro.ForeColor = Color.Red;
                sepLucro.LineColor = Color.Red;
                //txtLucroValor.LineFocusedColor = Color.Red;
                txtLucroValor.Text = $"{lucro:C}";
            }
        }

        private void txtServicoValor_KeyUp(object sender, KeyEventArgs e)
        {
            //CalcularLucro();
        }

        private void txtPecaValor_TextChange(object sender, EventArgs e)
        {
            CalcularLucro();
        }
    }
}