using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFC___StandBy_CSharp.Properties;

namespace PFC___StandBy_CSharp.PreencherComponentes.Tela_2___Cadastro_Clientes
{
    internal static class Cidades
    {
        public static List<string> listCidades = new List<string>();

        public static void BuscarListaCidades()
        {
            try
            {
                Task.Run(() =>
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