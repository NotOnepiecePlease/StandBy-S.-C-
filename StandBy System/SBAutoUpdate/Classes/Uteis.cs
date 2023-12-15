using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SBAutoUpdate.Classes
{
    internal static class Uteis
    {
        public static void DeleteTodosExceto(string meuDiretorio, List<string> arquivosParaManter
                                             , bool recursive = false)
        {
            try
            {

                var diretorioDoExecutavel = new DirectoryInfo(meuDiretorio);
                var teste = diretorioDoExecutavel.GetFiles().Where(n => !arquivosParaManter.Contains(n.Name));
                //Delete files excluding the list of file names
                foreach (FileInfo arquivo in teste)
                {
                    //if (arquivo.Name.Contains("NLog.xml"))
                    //{
                    //    var a = 1;
                    //}

                    //if (arquivo.Name.Contains("StandBy System"))
                    //{
                    //    var b = 2;
                    //}

                    if (arquivo.Name == "StandBy System.exe")
                    {
                        // Renomear o arquivo ao adicionar um sufixo, por exemplo, "_backup"
                        string novoNome = arquivo.Name.Replace("StandBy System.exe", "StandBy System.old");
                        string novoCaminho = Path.Combine(arquivo.DirectoryName, novoNome);
                        if (File.Exists(novoCaminho))
                        {
                            File.Delete(novoCaminho);
                        }
                        File.Move(arquivo.FullName, novoCaminho);
                    }
                    else
                    {
                        if (!arquivo.Name.Contains("SNI") && !arquivo.Name.Contains(".config") && !arquivo.Name.Contains(".old"))
                        {
                            File.SetAttributes(arquivo.FullName, FileAttributes.Normal);
                            arquivo.Delete();

                        }
                    }
                }

                //Loop sub directories if recursive == true
                if (recursive)
                {
                    foreach (DirectoryInfo deretorio in diretorioDoExecutavel.GetDirectories())
                    {
                        DeleteTodosExceto(deretorio.FullName, arquivosParaManter, recursive);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao deletar arquivos: \n\n" + e);
            }
        }

        public static void FecharSistemas()
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName("StandBy System"))
                {
                    process.Kill();
                }

                //Apenas uma forma secundaria de fazer a mesma coisa de cima.
                Process.GetProcessesByName("StandBy - CLIENT.SERVER").ToList().ForEach(process => process.Kill());
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao fechar sistemas: \n\n" + e);
            }
        }
    }
}