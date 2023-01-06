using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

// ReSharper disable All

namespace PFC___StandBy_CSharp.Dados
{
    public class BackupDados
    {
        private static string pastaRaiz = @"./data";
        public string CAMINHO_TXT = @"./data/dts.ini";

        private List<string> DadosParaEscrever { get; } = new List<string>()
        {
            "#SQL Data Config",
            $"IP= {PegarIp()}",
            "PORT= 1433",
            "USER= sa",
            "PASS= 123adr",
            "TYPE= 0"
        };

        public void criarPasta()
        {
            if (Directory.Exists(pastaRaiz))
            {
                if (File.Exists(CAMINHO_TXT))
                {
                    string[] sr = File.ReadAllLines(CAMINHO_TXT);
                    string ipDoArquivoTexto = sr[1].Substring(4);
                    string ipAtualDoPC = PegarIp();

                    if (ipDoArquivoTexto != ipAtualDoPC)
                    {
                        CriarDiretorioEscreverConfigs();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(CAMINHO_TXT))
                    {
                        DadosParaEscrever.ForEach(x => sw.WriteLine(x));
                    }
                }
            }
            else
            {
                CriarDiretorioEscreverConfigs();
            }
        }

        public void CriarDiretorioEscreverConfigs()
        {
            Directory.CreateDirectory(pastaRaiz);
            using (StreamWriter sw = File.CreateText(CAMINHO_TXT))
            {
                DadosParaEscrever.ForEach(x => sw.WriteLine(x));
            }
        }

        private static string PegarIp()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = (IPEndPoint)socket.LocalEndPoint;
                if (endPoint != null)
                {
                    string localIP = endPoint.Address.ToString();
                    return localIP;
                }

                return "NULL";
            }
        }
    }
}