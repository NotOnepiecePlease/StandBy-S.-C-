using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Utils
{
    public static class ConvertImage
    {
        public static Image ConvertByteArrayToImage(byte[] data)
        {
            if (data[0] != 0)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        public static byte[] ConvertImageToByte(Image img)
        {
            if (img != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    img.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }

            return new byte[] { 0 };
        }
    }
}