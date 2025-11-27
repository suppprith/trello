using System.Drawing;

namespace trellologin
{
    internal static class Resources
    {
   private static Bitmap? _google_icon;
        private static Bitmap? _facebook_icon;

        public static Bitmap google_icon
  {
      get
         {
     if (_google_icon == null)
      {
        _google_icon = CreateGoogleIcon();
    }
             return _google_icon;
            }
        }

        public static Bitmap facebook_icon
 {
        get
 {
          if (_facebook_icon == null)
                {
   _facebook_icon = CreateFacebookIcon();
                }
   return _facebook_icon;
            }
        }

  private static Bitmap CreateGoogleIcon()
    {
         // Create a simple Google-style icon (24x24)
Bitmap bmp = new Bitmap(24, 24);
     using (Graphics g = Graphics.FromImage(bmp))
     {
    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
     
        // Draw a circle with Google colors approximation
     g.FillEllipse(new SolidBrush(Color.FromArgb(66, 133, 244)), 2, 2, 20, 20);
                
                // Draw a white 'G' shape
      using (Font font = new Font("Arial", 14, FontStyle.Bold))
   {
    g.DrawString("G", font, Brushes.White, new PointF(5, 2));
 }
            }
  return bmp;
      }

    private static Bitmap CreateFacebookIcon()
      {
       // Create a simple Facebook-style icon (24x24)
        Bitmap bmp = new Bitmap(24, 24);
   using (Graphics g = Graphics.FromImage(bmp))
       {
  g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      // Draw a circle with Facebook blue
             g.FillEllipse(new SolidBrush(Color.FromArgb(24, 119, 242)), 2, 2, 20, 20);
       
        // Draw a white 'f'
         using (Font font = new Font("Arial", 16, FontStyle.Bold))
  {
          g.DrawString("f", font, Brushes.White, new PointF(7, 1));
}
        }
            return bmp;
        }
    }
}

namespace trellologin.Properties
{
    internal static class Resources
    {
        public static Bitmap google_icon => trellologin.Resources.google_icon;
        public static Bitmap facebook_icon => trellologin.Resources.facebook_icon;
    }
}
