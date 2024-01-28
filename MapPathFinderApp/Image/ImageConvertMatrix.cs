using System.Drawing;

namespace MapPathFinderApp.Image
{
    public class ImageConvertMatrix : ImageGreyScale
    {
        public Color[][] GetBitMapColorMatrix(Bitmap GreyScaleMap)
        {
            Bitmap b1 = new Bitmap(GreyScaleMap);

            int hight = b1.Height;
            int width = b1.Width;

            Color[][] colorMatrix = new Color[width][];
            for (int i = 0; i < width; i++)
            {
                colorMatrix[i] = new Color[hight];
                for (int j = 0; j < hight; j++)
                {
                    colorMatrix[i][j] = b1.GetPixel(i, j);
                }
            }
            return colorMatrix;
        }
    }
}
