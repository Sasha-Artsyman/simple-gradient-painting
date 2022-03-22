/* automatic drawing of gradient images
 * by colors in cycles
 * and saving in PNG
 */

using System;
using System.Drawing;

namespace Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range0 = 256;
            int step0 = 1;

            int x = 0;
            int y = 0;

            var myImage = new Bitmap(4096, 4096);

            // cycles for colors
            for (int rColor = 0; rColor < range0; rColor += step0)
            {
                for (int gColor = 0; gColor < range0; gColor += step0)
                {
                    for (int bColor = 0; bColor < range0; bColor += step0)
                    {
                        myImage.SetPixel(x, y, Color.FromArgb(rColor, gColor, bColor));

                        // pixel movement
                        if (x < 4095)
                        {
                            x += 1;
                        }
                        else
                        {
                            x = 0;
                            y += 1;
                        }
                    }
                }
            }
            // saving png
            string saveTo = @"C:\PixelGradient.png";
            myImage.Save(saveTo);
        }
    }
}
