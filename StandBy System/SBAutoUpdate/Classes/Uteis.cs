using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SBAutoUpdate.Classes
{
    internal static class Uteis
    {
        public static void DeleteTodosExceto(string meuDiretorio, List<string> arquivosParaManter, bool recursive = true)
        {
            var diretorioDoExecutavel = new DirectoryInfo(meuDiretorio);

            //Delete files excluding the list of file names
            foreach (FileInfo arquivo in diretorioDoExecutavel.GetFiles().Where(n => !arquivosParaManter.Contains(n.Name)))
            {
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

        public static void FecharSistemas()
        {
            foreach (Process process in Process.GetProcessesByName("StandBy System"))
            {
                process.Kill();
            }

            //Apenas uma forma secundaria de fazer a mesma coisa de cima.
            Process.GetProcessesByName("StandBy - CLIENT.SERVER").ToList().ForEach(process => process.Kill());
        }
    }
}