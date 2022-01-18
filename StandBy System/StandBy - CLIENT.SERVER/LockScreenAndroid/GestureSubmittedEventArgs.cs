using System;
using System.Linq;

/******************** CREATED BY YASSCOM **********************
*                                                             *
#         __   __ _    ____ ____   ____ ___  __  __           *
#         \ \ / // \  / ___/ ___| / ___/ _ \|  \/  |          *
#          \ V // _ \ \___ \___ \| |  | | | | |\/| |          *
#           | |/ ___ \ ___) |__) | |__| |_| | |  | |          *
#           |_/_/   \_\____/____/ \____\___/|_|  |_|          *
#                                                             *
#                       DEVOUJDA.COM                          *
#  https://www.youtube.com/channel/UChiPl4zBq6pNbZHT0rwTT9g   *
*                                                             *
***************************************************************    
*/

namespace GestureLockApp.GestureLockControl
{
    public class PassCodeSubmittedEventArgs : EventArgs
    {
        public bool Valid { get; private set; }

        public int[] Code { get; private set; }

        public PassCodeSubmittedEventArgs(bool valid, int[] code)
        {
            Valid = valid;
            Code = code;
        }

        public override string ToString()
        {
            string strCode = Code.Aggregate("{", (current, num) => current + (num + ", "));
            strCode = strCode.TrimEnd(',', ' ') + "}";
            return string.Format("Valid: {0}, Code: {1}", Valid, strCode);
        }
    }
}