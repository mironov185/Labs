using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form2 : Form
    {
        public Form2(Form1 ownerForm)
        {
            InitializeComponent();
            pictureBox1.Image = CalculateBarChart(Form1.image1);
        }

        private Image CalculateBarChart(Image image)
        {
            Bitmap barChart = null;
            if (image != null)
            {
                // определяем размеры гистограммы.
                int width = 256, height = 256;
                // получаем битмап из изображения
                Bitmap bmp = new Bitmap(image);
                // создаем саму гистограмму
                barChart = new Bitmap(width, height);
                // создаем массивы, в котором будут содержаться количества повторений для каждого из значений каналов.
                // индекс соответствует значению канала
                double[] B = new double[256];
                B = convertionToGray.CalcHistogram(Form1.image1);
                int i, j;
                Color color;
                // собираем статистику для изображения
                for (i = 0; i < bmp.Width; ++i)
                    for (j = 0; j < bmp.Height; ++j)
                    {
                        color = bmp.GetPixel(i, j);
                        ++B[color.B];
                    }
                // находим самый высокий столбец, чтобы корректно масштабировать гистограмму по высоте
                int max = 0;
                for (i = 0; i < 256; ++i)
                {
                    if (B[i] > max)
                        max = (int)B[i];
                }
                // определяем коэффициент масштабирования по высоте
                double point = (double)max / height;
                // отрисовываем столбец за столбцом нашу гистограмму с учетом масштаба
                for (i = 0; i < width - 3; ++i)
                {
                    for (j = height - 1; j > height - B[i / 3] / point; --j)
                    {
                        barChart.SetPixel(i, j, Color.Blue);
                    }
                }
            }
            return barChart;
        }

    }
}
