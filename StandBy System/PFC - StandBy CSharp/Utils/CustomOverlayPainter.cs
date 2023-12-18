using DevExpress.Utils.Drawing;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;

namespace PFC___StandBy_CSharp.Utils
{
    internal class CustomOverlayPainter : OverlayWindowPainterBase
    {
        // Defines the string’s font.
        private static readonly Font drawFont;

        static CustomOverlayPainter()
        {
            drawFont = new Font("Tahoma", 18);
        }

        protected override void Draw(OverlayWindowCustomDrawContext context)
        {
            //The Handled event parameter should be set to true.
            //to disable the default drawing algorithm.
            context.Handled = true;
            //Provides access to the drawing surface.
            GraphicsCache cache = context.DrawArgs.Cache;
            //Adjust the TextRenderingHint option
            //to improve the image quality.
            cache.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //Overlapped control bounds.
            Rectangle bounds = context.DrawArgs.Bounds;
            //Draws the default background.
            context.DrawBackground();
            //Specify the string that will be drawn on the Overlay Form instead of the wait indicator.
            String drawString = "Carregando tela...";
            //Get the system's black brush.
            Brush drawBrush = Brushes.White;
            //Calculate the size of the message string.
            SizeF textSize = cache.CalcTextSize(drawString, drawFont);
            //A point that specifies the upper-left corner of the rectangle where the string will be drawn.
            PointF drawPoint = new PointF(
                bounds.Left + bounds.Width / 2 - textSize.Width / 2,
                bounds.Top + bounds.Height / 2 - textSize.Height / 2
            );
            //Draw the string on the screen.
            cache.DrawString(drawString, drawFont, drawBrush, drawPoint);
            //cache.DrawString("teste", drawFont, drawBrush, drawPoint);
        }
    }
}