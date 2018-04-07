using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form9 : Form
    {
        Form1 OwnerForm;

        public Form9(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();

            Bitmap bitmap = Form1.image2;
            // Максимальное значение индекса цвета
            int max = 255;
            int ColorR = 0;
            int ColorG = 0;
            int ColorB = 0;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    ColorR = max - bitmap.GetPixel(i, j).R;
                    ColorG = max - bitmap.GetPixel(i, j).G;
                    ColorB = max - bitmap.GetPixel(i, j).B;
                    bitmap.SetPixel(i, j, Color.FromArgb(ColorR, ColorG, ColorB));
                }
            }
            pictureBox1.Image = bitmap;
        }
    }
}
