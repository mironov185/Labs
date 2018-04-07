using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form5 : Form
    {
        Form1 OwnerForm;
        public Form5(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            pictureBox1.Image = reduceTheFrequencyQuantization(Form1.image2, 2);
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = reduceTheFrequencyQuantization(Form1.image2, 4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = reduceTheFrequencyQuantization(Form1.image2, 8);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = reduceTheFrequencyQuantization(Form1.image2, 16);
        }

        private Bitmap reduceTheFrequencyQuantization(Image original, int num)
        {
            Bitmap newImage = new Bitmap(Form1.image2, 256, 256);
            for (int i = 0; i < newImage.Width; i++)
                for (int j = 0; j < newImage.Height; j++)
                    // Задает цвет указанного пикселя в этом объекте Bitmap.
                    newImage.SetPixel(i, j, Color.FromArgb(newImage.GetPixel(i, j).A,
                                            // Возвращает цвет указанного пиксела в этом Bitmap.
                                            newImage.GetPixel(i, j).R / num,
                                            newImage.GetPixel(i, j).G / num,
                                            newImage.GetPixel(i, j).B / num));
            return newImage;
        }

    }
}
