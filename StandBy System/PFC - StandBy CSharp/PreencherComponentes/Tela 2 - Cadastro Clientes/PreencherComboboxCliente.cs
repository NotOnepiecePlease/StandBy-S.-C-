using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using PFC___StandBy_CSharp.Properties;
using Syncfusion.Windows.Forms.Tools;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_2___Cadastro_Clientes
{
    internal class PreencherComboboxCliente
    {
        private static List<string> listCidades = new List<string>();

        public void Preencher(BunifuMaterialTextbox _txtNomeCliente, ComboBoxBase _cmbCidades, Label _lblCidades_Carregando, ListBox _listBoxCidades)
        {
            CarregarListaDeCidadesAsync();
            _txtNomeCliente.Focus();
            _cmbCidades.ListControl = _listBoxCidades;

            _lblCidades_Carregando.Visible = true;
            _lblCidades_Carregando.Text = @"Carregando cidades...";

            //Coloquei isso na task porque classes estaticas nao aceitam componentes.
            Task.Run(() =>
            {
                Thread.Sleep(500);
                _listBoxCidades.DataSource = listCidades;
                _lblCidades_Carregando.Text = @"FIM";
                _lblCidades_Carregando.Visible = false;
                _cmbCidades.Text = @"Ex: Camaçari";
            });
        }

        private static async void CarregarListaDeCidadesAsync() => await PreencherAutoComplete();

        private static async Task PreencherAutoComplete()
        {
            try
            {
                await Task.Run(() =>
                {
                    string[] cidadesSeparadas = Resources.Cidades.Split('\n');
                    listCidades = cidadesSeparadas.ToList();
                });
            }
            catch (Exception)
            {
            }
        }
    }
}