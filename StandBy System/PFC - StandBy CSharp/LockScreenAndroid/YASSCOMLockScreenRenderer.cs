using System;
using System.Drawing;
using System.Drawing.Drawing2D;

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
    public class YASSCOMLockScreenRenderer : LockScreenRenderer, IDisposable
    {
        private readonly Pen padPen, gesturePen;
        private readonly SolidBrush activeBrush = new SolidBrush(Color.Empty);

        public YASSCOMLockScreenRenderer()
        {
            padPen = new Pen(Color.Empty, 5);
            gesturePen = new Pen(Color.Empty, 10);
            gesturePen.StartCap = gesturePen.EndCap = LineCap.Round;
            gesturePen.LineJoin = LineJoin.Round;
            ApplyThemeToUtencils();
        }

        private void ApplyThemeToUtencils()
        {
            Color c = Color.YellowGreen;
            gesturePen.Color = Color.FromArgb(100, c.R, c.G, c.B);
            padPen.Color = activeBrush.Color = c;
        }

        public override void RenderBackground(Graphics graphics, RectangleF bounds, Color backColor)
        {
            graphics.Clear(Color.FromArgb(50, 50, 50));
        }

        public override void RenderGesture(Graphics graphics, PointF[] polygon)
        {
            graphics.DrawLines(gesturePen, polygon);
        }

        public override void RenderPad(Graphics graphics, RectangleF bounds, GesturePadState state, int index)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawEllipse(padPen, bounds);
            if (state.HasFlag(GesturePadState.Inputted))
            {
                float inflationAmount = bounds.Width*0.3f;
                var innerRect = bounds;
                innerRect.Inflate(-inflationAmount, -inflationAmount);
                graphics.FillEllipse(activeBrush, innerRect);
            }
        }

        public void Dispose()
        {
            padPen.Dispose();
            gesturePen.Dispose();
            activeBrush.Dispose();
        }
    }
}