using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace PFC___StandBy_CSharp.Dados
{
    internal class BackupDados
    {
        private static string pastaRaiz = @"./data";

        //public string caminhoTXT = @"./data/dts.txt";
        public string CaminhoTxt = @"./data/dts.ini";

        private List<string> DadosParaEscrever { get; } = new List<string>()
        {
            "#SQL Data Config",
            $"IP= {PegarIp()}",
            "PORT= 1433",
            "USER= sa",
            "PASS= 123adr",
            "TYPE= 0"
        };

        //private const string Title = "#SQL Data Config";
        //private const string DataSource = "IP= localhost\\SQLEXPRESS";
        //private const string Port = "PORT= 1433";
        //private const string Login = "USER= sa";
        //private const string Pass = "PASS= 123adr";
        //private const string Type = "TYPE= 0";

        public void criarPasta()
        {
            if (Directory.Exists(pastaRaiz))
            {
                if (File.Exists(CaminhoTxt))
                {
                    // This path is a file
                    // Console.WriteLine("Existe");
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(CaminhoTxt))
                    {
                        //sw.WriteLine(Title);
                        //sw.WriteLine(DataSource);
                        //sw.WriteLine(Port);
                        //sw.WriteLine(Login);
                        //sw.WriteLine(Pass);
                        //sw.WriteLine(Type);

                        //
                        DadosParaEscrever.ForEach(x => sw.WriteLine(x));
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(pastaRaiz);
                using (StreamWriter sw = File.CreateText(CaminhoTxt))
                {
                    // sw.WriteLine(DataSource);
                    DadosParaEscrever.ForEach(x => sw.WriteLine(x));
                }
            }
        }

        private static string PegarIp()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                string localIP = endPoint.Address.ToString();
                return localIP;
            }
        }
    }
}