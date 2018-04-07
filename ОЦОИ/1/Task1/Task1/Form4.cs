using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form4 : Form
    {
        Form1 OwnerForm;
        Bitmap pic;
        public Form4(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(0, 0, 15, 15);
            pic = (Bitmap)OwnerForm.pictureBox1.Image;
            pictureBox1.Image = pic;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Size size = new Size(pic.Width * 4, pic.Height * 4);
            Bitmap newImage = new Bitmap(Form1.image2, size);
            pictureBox2.Image = newImage;
        }

    }
}
