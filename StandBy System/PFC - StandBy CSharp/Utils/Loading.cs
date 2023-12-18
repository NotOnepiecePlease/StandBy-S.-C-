using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;


namespace PFC___StandBy_CSharp.Utils
{
    public static class Loading
    {
        public static IOverlaySplashScreenHandle Init(Control _control)
        {
            OverlayWindowOptions options = new OverlayWindowOptions(
                startupDelay: 0,
                backColor: Color.FromArgb(255, 23, 23, 36),
                opacity: 1,
                fadeIn: true,
                fadeOut: true,
                imageSize: new Size(64, 64)
            );

            return SplashScreenManager.ShowOverlayForm(_control, options);
        }
    }
}
