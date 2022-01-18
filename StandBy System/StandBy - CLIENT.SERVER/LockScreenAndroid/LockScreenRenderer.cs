using System;
using System.Drawing;

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
    [Flags]
    public enum GesturePadState
    {
        None = 0,
        Hovered = 1,
        Inputted = 2,
        LastInputted = 4,
        FirstInputted = 8
    }

    public abstract class LockScreenRenderer
    {
        public abstract void RenderBackground(Graphics graphics, RectangleF bounds, Color backColor);

        public abstract void RenderGesture(Graphics graphics, PointF[] polygon);

        public abstract void RenderPad(Graphics graphics, RectangleF bounds, GesturePadState state, int index);
    }
}