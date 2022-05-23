using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SBAutoUpdate.Classes
{
    internal class VerificarTipoSistema
    {
        public bool SeForSistemaPrincipal()
        {
            Uteis.FecharSistemas();
            //BackupDados bckData = new BackupDados();
            //@"./data/dts.ini"
            // string path = bckData.CAMINHO_TXT;
            string path = @"./data/dts.ini";
            List<string> linhasTexto = File.ReadAllLines(path).ToList();
            string type = linhasTexto[5].TrimStart('T', 'Y', 'P', 'E', '=').Trim();

            //0 = StandBy System
            //1 = StandBy Client - Server
            if (type.Equals("0"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}