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

                //Delete files excluding the list of file names
                foreach (FileInfo arquivo in diretorioDoExecutavel.GetFiles()
                             .Where(n => !arquivosParaManter.Contains(n.Name)))
                {
                    if (!arquivo.Name.Contains("SNI") && !arquivo.Name.Contains(".config"))
                        arquivo.Delete();
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
                // MessageBox.Show("Erro ao deletar arquivos: \n\n" + e);
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