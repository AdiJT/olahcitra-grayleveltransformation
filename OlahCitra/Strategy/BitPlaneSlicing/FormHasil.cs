using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.BitPlaneSlicing
{
    public partial class FormHasil : Form
    {
        public FormHasil()
        {
            InitializeComponent();
        }

        public Bitmap ImageBitPlane0 { get => customPictureBoxBit0.Image; set => customPictureBoxBit0.Image = value; }
        public Bitmap ImageBitPlane1 { get => customPictureBoxBit1.Image; set => customPictureBoxBit1.Image = value; }
        public Bitmap ImageBitPlane2 { get => customPictureBoxBit2.Image; set => customPictureBoxBit2.Image = value; }
        public Bitmap ImageBitPlane3 { get => customPictureBoxBit3.Image; set => customPictureBoxBit3.Image = value; }
        public Bitmap ImageBitPlane4 { get => customPictureBoxBit4.Image; set => customPictureBoxBit4.Image = value; }
        public Bitmap ImageBitPlane5 { get => customPictureBoxBit5.Image; set => customPictureBoxBit5.Image = value; }
        public Bitmap ImageBitPlane6 { get => customPictureBoxBit6.Image; set => customPictureBoxBit6.Image = value; }
        public Bitmap ImageBitPlane7 { get => customPictureBoxBit7.Image; set => customPictureBoxBit7.Image = value; }
    }
}
