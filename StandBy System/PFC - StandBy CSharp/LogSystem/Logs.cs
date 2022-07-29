//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PFC___StandBy_CSharp.LogSystem
//{
//    public static class Logs
//    {
//        public const string PastaLogs = @"./Logs";
//        public const string ARQUIVO_LOGS_ERRO = "./Logs/ErrorLogsStandBySystem.txt";

//        public static void VerificarCriarPastaLogs()
//        {
//            Directory.CreateDirectory(PastaLogs);
//        }

//        public static void VerificarCriarArquivoLogs()
//        {
//            var a = File.CreateText(ARQUIVO_LOGS_ERRO);
//        }

//        public static void GerarLogErro()
//        {
//            VerificarCriarPastaLogs();
//            VerificarCriarArquivoLogs();

//            if (File.Exists(CAMINHO_TXT))
//            {
//                //Se ja existe, nao faz nada, poderia apenas negar a condicao mas acho mais legivel assim.
//            }

//            using (StreamWriter sw = File.CreateText(ARQUIVO_LOGS_ERRO))
//            {
//                DadosParaEscrever.ForEach(x => sw.WriteLine(x));
//            }
//        }
//    }
//}