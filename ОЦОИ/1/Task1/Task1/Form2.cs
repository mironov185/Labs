using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form2 : Form
    {
        Form1 OwnerForm;
        private Image image;

        public Form2(Form1 ownerForm)
        {
            OwnerForm = ownerForm;
            InitializeComponent();
        }

        public Form2(Image image)
        {
            this.image = image;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = 78;
            trackBar2.Maximum = 112;

            label1.Text = trackBar2.Value.ToString();
            
            UInt32 p;
            for (int i = 0; i < Form1.image2.Height; i++)
                for (int j = 0; j < Form1.image2.Width; j++)
                {
                    p = Contrasting.Contrast(image,(UInt32)Form1.pixel[i, j], trackBar2.Value, trackBar2.Maximum);
                    FromOnePixelToBitmap(i, j, p);
                }

            FromBitmapToScreen();
        }

        //вывод изображения на экран
        void FromBitmapToScreen()
        {
            OwnerForm.FromBitmapToScreen();
        }

        //преобразование из UINT32 к Bitmap по одному пикселю
        public static void FromOnePixelToBitmap(int x, int y, UInt32 pixel)
        {
            Form1.image2.SetPixel(y, x, Color.FromArgb((int)pixel));
        }

    }
}
