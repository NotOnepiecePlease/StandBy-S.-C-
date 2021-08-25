using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Dados
{
    class BackupDados
    {
        private static string pastaRaiz = @"./data";
        public string caminhoTXT = @"./data/dts.txt";
        //Adriano
        //private static string dataSource = "localhost\\SQLEXPRESS";
        private static string dataSource = "localhost\\SQEXPRESS";
        public void criarPasta()
        {
            if (Directory.Exists(pastaRaiz))
            {
                if (File.Exists(caminhoTXT))
                {
                    // This path is a file
                    Console.WriteLine("Existe");
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(caminhoTXT))
                    {
                        sw.WriteLine(dataSource);
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
