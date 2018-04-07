using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Bitmap image1;
        public static Bitmap image2;
        public static int[,] pixel;        

        public void открытьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image1 = new Bitmap(open_dialog.FileName);
                    pictureBox1.Image = image1;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }       

        // Загрузка изображения.
        private void button1_Click(object sender, EventArgs e)
        {
            // Инициализирует новый экземпляр Bitmap класс из указанного существующего изображения, 
            // масштабированного до заданного размера.
            image2 = new Bitmap(image1, 256, 256);
            pictureBox1.Image = image2;

            //получение матрицы с пикселями
            pixel = new int[image2.Height, image2.Width];
            for (int y = 0; y < image2.Height; y++)
                for (int x = 0; x < image2.Width; x++)
                    pixel[y, x] = (image2.GetPixel(x, y).ToArgb());
        }       

        private void фрагментИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 cutOutAFragment = new Form4(this);
            cutOutAFragment.ShowDialog();            
        }

        private void уменьшениеРазрешенияИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ChangeOfSize = new Form3(this);
            ChangeOfSize.ShowDialog();
        }

        private void квантованиеИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ReduceTheFrequencyQuantization = new Form5(this);
            ReduceTheFrequencyQuantization.ShowDialog();
        }        

        private void заменаЗначенияЯркостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 replacementOfBrightnessValue = new Form6(this);
            replacementOfBrightnessValue.ShowDialog();
        }

        private void гистограммаРаспределенияЯркостейЗашумленногоИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 distributionHistogram = new Form7(this);
            distributionHistogram.ShowDialog();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form8 dynamicRangeOfTheImage = new Form8(this);
            dynamicRangeOfTheImage.ShowDialog();
        }


        private void поэлементноеПреобразованиеИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 cuttingTheRangeOfBrightness = new Form9(this);
            cuttingTheRangeOfBrightness.ShowDialog();
        }

        private void линейноеКонтрастированиеИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 BrightnessForm = new Form2(this);
            BrightnessForm.ShowDialog();
        }

        //вывод на экран
        public void FromBitmapToScreen()
        {
            pictureBox1.Image = image2;
        }
    }
}
