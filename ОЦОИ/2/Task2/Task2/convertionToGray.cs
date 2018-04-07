using System.Drawing;

namespace Task2
{
    class convertionToGray
    {
        public static double[] CalcHistogram(Image image)
        {
            double[] histogram = new double[256];
            int[,] gray = new int[image.Width, image.Height];
            Bitmap bitmap = new Bitmap(image);
            Color color = new Color();
            double grayColor = 0;

            for (int i = 0; i < bitmap.Width; i++)
            {

                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    grayColor = 0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B;

                    if ((int)grayColor > 255)
                    {
                        gray[i, j] = 255;
                    }
                    else
                    {
                        gray[i, j] = (int)grayColor;
                    }
                    histogram[gray[i, j]]++;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                histogram[i] = histogram[i] / (image.Width * image.Height);
            }
            return histogram;
        }
    }
}
