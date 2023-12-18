using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

// ReSharper disable All

namespace PFC___StandBy_CSharp.Dados
{
    public class BackupDados
    {
        public  string PASTA_RAIZ = @"./data";
        public  string CAMINHO_TXT = @"./data/dts.ini";

        private List<string> DadosParaEscrever { get; } = new List<string>()
        {
            "#SQL Data Config",
            $"IP= {PegarIp()}",
            "PORT= 1433",
            "USER= sa",
            "PASS= 123adr",
            "TYPE= 0",
            "DEBUG_MODE= 0",
            "FILE_1= UpdateNEW.zip",
            "FILE_2= UpdateClientServer.zip",
            "LINK_1= https://www.dropbox.com/s/nxtk7sztle13th2/UpdateNEW.zip?dl=1",
            "LINK_2= "
        };

        public void criarPasta()
        {
            if (Directory.Exists(PASTA_RAIZ))
            {
                if (File.Exists(CAMINHO_TXT))
                {
                    string[] sr = File.ReadAllLines(CAMINHO_TXT);
                    string ipDoArquivoTexto = "";
                    string ipAtualDoPC = PegarIp();

                    foreach (var linha in sr)
                    {
                        if (linha.Contains("IP="))
                        {
                            ipDoArquivoTexto = linha.Split('=')[1].Trim();
                            if (ipDoArquivoTexto != ipAtualDoPC)
                            {
                                CriarDiretorioEscreverConfigs();
                                break;
                            }
                        }
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
            Directory.CreateDirectory(PASTA_RAIZ);
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