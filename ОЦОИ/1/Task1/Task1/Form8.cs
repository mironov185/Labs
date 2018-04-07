using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form8 : Form
    {
        Form1 OwnerForm;

        public Form8(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = Form1.image2;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            int left = 85;
            int right = 170;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorR = bitmap.GetPixel(i, j).R;
                    if (bitmap.GetPixel(i, j).R > right)
                        ColorR = right;
                    if (bitmap.GetPixel(i, j).R < left)
                        ColorR = left;
                    ColorG = bitmap.GetPixel(i, j).G;
                    if (bitmap.GetPixel(i, j).G > right)
                        ColorG = right;
                    if (bitmap.GetPixel(i, j).G < left)
                        ColorG = left;
                    ColorB = bitmap.GetPixel(i, j).B;
                    if (bitmap.GetPixel(i, j).B > right)
                        ColorB = right;
                    if (bitmap.GetPixel(i, j).B < left)
                        ColorB = left;

                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = Form1.image2;
            int hight = 63;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorB = bitmap.GetPixel(i, j).B;
                    if (ColorB > hight)
                        ColorB = hight;
                    ColorR = bitmap.GetPixel(i, j).R;
                    if (ColorR > hight)
                        ColorR = hight;
                    ColorG = bitmap.GetPixel(i, j).G;
                    if (ColorG > hight)
                        ColorG = hight;
                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));
                }
            pictureBox2.Image = bitmap;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = Form1.image2;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            int hight = 192;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorR = bitmap.GetPixel(i, j).R;
                    if (ColorR < hight)
                        ColorR = hight;
                    ColorG = bitmap.GetPixel(i, j).G;
                    if (ColorG < hight)
                        ColorG = hight;
                    ColorB = bitmap.GetPixel(i, j).B;
                    if (ColorB < hight)
                        ColorB = hight;

                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));
                }
            }
            pictureBox3.Image = bitmap;
        }

    }
}
