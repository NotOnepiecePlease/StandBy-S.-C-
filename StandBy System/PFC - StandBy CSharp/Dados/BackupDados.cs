using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Dados
{
    internal class BackupDados
    {
        private static string pastaRaiz = @"./data";
        public string caminhoTXT = @"./data/dts.txt";

        //Adriano
        //private static string dataSource = "localhost\\SQLEXPRESS";

        private static string dataSource = "localhost\\SQEXPRESS";
        private static string login = "sa";
        private static string pass = "123adr";

        public void criarPasta()
        {
            if (Directory.Exists(pastaRaiz))
            {
                if (File.Exists(caminhoTXT))
                {
                    // This path is a file
                    // Console.WriteLine("Existe");
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(caminhoTXT))
                    {
                        sw.WriteLine(dataSource);
                        //sw.WriteLine(login);
                        //sw.WriteLine(pass);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(pastaRaiz);
                using (StreamWriter sw = File.CreateText(caminhoTXT))
                {
                    sw.WriteLine(dataSource);
                }
            }
        }
    }
}