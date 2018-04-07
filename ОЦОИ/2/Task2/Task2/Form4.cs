using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Image = ImageReduction(Form1.image1);
        }

        public static double[] Calc(Bitmap bmp)
        {
            double[] count = new double[256];
            for (int i = 0; i < bmp.Size.Width; i++)
            {
                for (int j = 0; j < bmp.Size.Height; j++)
                {
                    count[bmp.GetPixel(i, j).R]++;
                }
            }
            return count;
        }

        // Метод, позволяющий получить обработанное изображение с задаваемой формой гистограммы.
        public static Image ImageReduction(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            double[] count = Calc(bitmap);
            double[] view = new double[256];
            double[] Pc = new double[256];
            double[] Pv = new double[256];
            double[] countnew = new double[256];
            double nView = 0;
            view[0] = 0;

            for (int i = 1; i < 256; i++)
            {
                view[i] = view[i - 1] + 1;
                nView += view[i];
            }

            for (int i = 1; i < 256; i++)
            {
                Pc[i] = count[i] / (bitmap.Height * bitmap.Width);
                Pv[i] = view[i] / nView;

                Pc[i] += Pc[i - 1];
                Pv[i] += Pv[i - 1];
            }

            for (int i = 0, j = 0; i < Pc.Length; i++)
            {
                while (j < Pv.Length - 1 && Pv[j] <= Pc[i])
                {
                    j++;
                }
                countnew[i] = j;
            }
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb((int)countnew[bitmap.GetPixel(x, y).R], (int)countnew[bitmap.GetPixel(x, y).R], (int)countnew[bitmap.GetPixel(x, y).R]));
                }
            }
            return bitmap;
        }
    }
}
