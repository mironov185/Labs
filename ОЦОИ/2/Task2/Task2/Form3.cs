using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            pictureBox1.Image = Equalizing(Form1.image1);
        }

        public static Bitmap Equalizing(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            double[] histogramm = convertionToGray.CalcHistogram(image);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int temp = (int)(histogramm[bitmap.GetPixel(i, j).R] * 256);
                    if (temp > 255)
                    {
                        temp = 255;
                    }
                    if (temp < 0)
                    {
                        temp = 0;
                    }
                    // Результатом эквализации гистограммы является перекрашивание всех пикселей одного цвета в другой один цвет. 
                    // Метод не позволяет передать два разных цвета пикселям, изначально раскрашенным одинаково.
                    bitmap.SetPixel(i, j, Color.FromArgb(temp, temp, temp));
                }
            }
            return bitmap;
        }

        
    }
}
