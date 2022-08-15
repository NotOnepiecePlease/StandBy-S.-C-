using System;
using System.Collections.Generic;
using Correios;

namespace PFC___StandBy_CSharp.APIs.CEP
{
    internal class CepModel
    {
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
    }

    internal static class CepApi
    {
        public static List<CepModel> Buscar(string _CEP)
        {
            List<CepModel> listEndereco = new List<CepModel>();
            //CepModel listEndereco = new CepModel();
            try
            {
                CorreiosApi correiosApi = new CorreiosApi();
                var endereco = correiosApi.consultaCEP(_CEP);

                listEndereco.Add(new CepModel()
                {
                    Endereco = endereco.end ?? "------",
                    Bairro = endereco.bairro ?? "------",
                    Cidade = endereco.cidade ?? "------",
                    Complemento = endereco.complemento ?? "------",
                    UF = endereco.uf ?? "------"
                });
                return listEndereco;
            }
            catch (Exception)
            {
                return listEndereco;
                //Console.WriteLine(exception);
                //throw;
            }
        }
    }
}