using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.HitungLuas
{
    public partial class FormHasil : Form
    {
        public FormHasil()
        {
            InitializeComponent();
        }

        public void AddHasil(Bitmap[] daftarHasil)
        {
            customPictureBox1.Image = daftarHasil[0];
            customPictureBox2.Image = daftarHasil[1];
            customPictureBox3.Image = daftarHasil[2];
            customPictureBox4.Image = daftarHasil[3];
            customPictureBox5.Image = daftarHasil[4];
            customPictureBox6.Image = daftarHasil[5];
            customPictureBox7.Image = daftarHasil[6];
        }
    }
}
