using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form6 : Form
    {
        Form1 OwnerForm;
        public Form6(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Form1.image2;
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Random rand = new Random();
            double percent = rand.Next(0,255);
            double result = (percent / 100) * (bitmap.Width * bitmap.Height / 2);
            int step = 0;
            while (step < result)
            {
                bitmap.SetPixel(rand.Next(bitmap.Width), rand.Next(bitmap.Height), Color.White);
                bitmap.SetPixel(rand.Next(bitmap.Width), rand.Next(bitmap.Height), Color.Black);
                step++;
            }
        }
    }
}
