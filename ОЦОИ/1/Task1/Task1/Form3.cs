using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form3 : Form
    {
        Form1 OwnerForm;
        public Form3(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Size size = new Size(Form1.image2.Width / 2, Form1.image2.Height / 2);
            Bitmap newBitmap = new Bitmap(Form1.image2, size);
            pictureBox1.Image = newBitmap;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Size size = new Size(Form1.image2.Width / 4, Form1.image2.Height / 4);
            Bitmap newBitmap = new Bitmap(Form1.image2, size);
            pictureBox2.Image = newBitmap;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Size size = new Size(Form1.image2.Width / 8, Form1.image2.Height / 8);
            Bitmap newBitmap = new Bitmap(Form1.image2, size);
            pictureBox3.Image = newBitmap;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Size size = new Size(Form1.image2.Width / 16, Form1.image2.Height / 16);
            Bitmap newBitmap = new Bitmap(Form1.image2, size);
            pictureBox4.Image = newBitmap;
        }
    }
}
