using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using PFC___StandBy_CSharp.Dados;

namespace PFC___StandBy_CSharp.ConsoleLogServer
{
    public static class ConsoleLog
    {
        private static BackupDados bd = new BackupDados();
        private static NamedPipeServerStream pipeServer;
        private static Thread pipeThread;
        private static StreamWriter pipeWriter;
        public static bool isRunning = true;
        public static void IniciarServidor()
        {
            pipeServer = new NamedPipeServerStream("ConsoleLogServer", PipeDirection.Out, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);
            pipeThread = new Thread(WaitForClient);
            pipeThread.Start();
        }
        private static void WaitForClient()
        {
            while (isRunning)
            {
                try
                {
                    pipeServer.WaitForConnection();

                    // Abre um StreamWriter para o pipe
                    pipeWriter = new StreamWriter(pipeServer, Encoding.UTF8);

                    // Aguarda mensagens dos botões
                    while (isRunning)
                    {
                        Thread.Sleep(100);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao enviar mensagem para o console: " + ex.Message);
                }
                finally
                {
                    // Fecha o StreamWriter
                    pipeWriter?.Dispose();

                    if (pipeServer.IsConnected)
                    {
                        pipeServer.Disconnect();
                    }
                }
            }
        }
        public static void EnviarMensagemErro(string message)
        {
            if (IsModoDebugLog())
            {
                // Obtém a pilha de chamadas
                StackTrace stackTrace = new StackTrace();

                // Obtém o frame de chamada anterior (o método que chamou este)
                StackFrame callerFrame = stackTrace.GetFrame(1);

                // Obtém o método que chamou este
                MethodBase callerMethod = callerFrame.GetMethod();

                // Obtém o nome da classe e do método que chamou este
                string callingClassName = callerMethod.DeclaringType.Name;
                string callingMethodName = callerMethod.Name;

                try
                {
                    // Verifica se o StreamWriter está disponível
                    if (pipeWriter != null)
                    {
                        pipeWriter.WriteLine($"{DateTime.Today.ToShortDateString()} {DateTime.Now.ToShortTimeString()} - |ERRO| - {callingMethodName}({callingClassName}) | {message}");
                        pipeWriter.Flush(); // Força a gravação da mensagem
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar mensagem para o console: " + ex.Message);
                }
            }
        }
        public static void EnviarMensagemInfo(string message)
        {
            if (IsModoDebugLog())
            {
                // Obtém a pilha de chamadas
                StackTrace stackTrace = new StackTrace();

                // Obtém o frame de chamada anterior (o método que chamou este)
                StackFrame callerFrame = stackTrace.GetFrame(1);

                // Obtém o método que chamou este
                MethodBase callerMethod = callerFrame.GetMethod();

                // Obtém o nome da classe e do método que chamou este
                string callingClassName = callerMethod.DeclaringType.Name;
                string callingMethodName = callerMethod.Name;

                try
                {
                    // Verifica se o StreamWriter está disponível
                    if (pipeWriter != null)
                    {
                        pipeWriter.WriteLine($"{DateTime.Today.ToShortDateString()} {DateTime.Now.ToShortTimeString()} - |INFO| - {callingMethodName}({callingClassName}) | {message}");
                        pipeWriter.Flush(); // Força a gravação da mensagem
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar mensagem para o console: " + ex.Message);
                }
            }
        }
        public static void DesligarServidor()
        {
            if (pipeWriter != null)
            {
                pipeWriter.Dispose();
            }

            if (pipeServer != null)
            {
                pipeServer.Close();
                pipeServer.Dispose();
            }

            if (pipeThread != null && pipeThread.IsAlive)
            {
                pipeThread.Abort();
                //pipeThread.Join(); // Aguarda a conclusão da thread
            }
        }
        public static void FecharConsoleLog()
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName("ConsoleLogServer"))
                {
                    process.Kill();
                }

                //Apenas uma forma secundaria de fazer a mesma coisa de cima.
                Process.GetProcessesByName("ConsoleLogServer").ToList().ForEach(process => process.Kill());
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao fechar sistemas: \n\n" + e);
            }
        }
        public static bool IsModoDebugLog()
        {
            string pastaRaiz = bd.PASTA_RAIZ;
            string CAMINHO_TXT = bd.CAMINHO_TXT;

            if (Directory.Exists(pastaRaiz))
            {
                if (File.Exists(CAMINHO_TXT))
                {
                    string[] sr = File.ReadAllLines(CAMINHO_TXT);
                    foreach (var linha in sr)
                    {
                        if (linha.Contains("DEBUG_MODE"))
                        {
                            string debugMode = linha.Split('=')[1].Trim();
                            if (debugMode == "1")
                            {
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    bd.CriarDiretorioEscreverConfigs();
                }
            }
            else
            {
                bd.CriarDiretorioEscreverConfigs();
            }
            
            return false;
        }
    }

}
