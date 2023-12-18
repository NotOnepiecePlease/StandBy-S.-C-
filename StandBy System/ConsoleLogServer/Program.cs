using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorFull = Colorful.Console;
using System.Drawing;
using Colorful;
using Console = System.Console;
using System.Diagnostics;

namespace ConsoleLogServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var pipeClient = new NamedPipeClientStream(".", "ConsoleLogServer", PipeDirection.In))
            {
                pipeClient.Connect();
                using (var sr = new StreamReader(pipeClient, Encoding.UTF8))
                {
                    try
                    {
                        //Inicializando
                        FigletFont font = FigletFont.Load("big.flf");
                        Figlet figlet = new Figlet(font);

                        ColorFull.WriteLine(figlet.ToAscii("Log Server"), ColorTranslator.FromHtml("#00e1ff"));
                        //ColorFull.WriteLine(figlet.ToAscii("--------"), ColorTranslator.FromHtml("#00e1ff"));

                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.BackgroundColor = ConsoleColor.DarkRed;
                        //Console.WriteLine("Texto com cor de fundo e texto modificados");
                        //Console.ResetColor(); // Retorna às configurações padrão


                        while (true)
                        {
                            //Lendo a mensagem
                            string message = sr.ReadLine();

                            var mensagemQuebrada = message.Split('|');
                            string dataHora = mensagemQuebrada[0];
                            string tipoMensagem = mensagemQuebrada[1];
                            string classeEMetodo = mensagemQuebrada[2];
                            string mensagem = mensagemQuebrada[3];

                            if (tipoMensagem == "INFO")
                            {
                                //Busco a palavra INFO e pinto apenas ela com a cor escolhida
                                StyleSheet styleSheet = new StyleSheet(Color.White);
                                styleSheet.AddStyle("INFO[a-z]*", Color.Aqua);

                                //Escreve mensagem
                                ColorFull.WriteLineStyled(message, styleSheet);

                            }else if (tipoMensagem == "ERRO")
                            {
                                StyleSheet styleSheet = new StyleSheet(Color.White);
                                styleSheet.AddStyle("ERRO[a-z]*", Color.Red);

                                ColorFull.Write(dataHora, Color.White);
                                ColorFull.WriteStyled($"|{tipoMensagem}|", styleSheet);
                                ColorFull.Write(classeEMetodo, Color.Red);
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                ColorFull.WriteLine($"|{mensagem}", Color.White);
                                Console.ResetColor();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ColorFull.WriteLine($"{e.Message}", Color.DeepPink);
                    }
                }
            }
            Console.ReadLine();
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
    }
}
