using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.RGBSplit
{
    public partial class FormHasil : Form
    {
        public FormHasil()
        {
            InitializeComponent();
        }

        public void SetRBGImage(Bitmap red, Bitmap green, Bitmap blue)
        {
            customPictureBoxRed.Image = red;
            customPictureBoxGreen.Image = green;
            customPictureBoxBlue.Image = blue;
        }

        public void SetRGBHistogram(int[] histogramR,int[] histogramG,int[] histogramB)
        {
            histogramRed.HistogramArray = histogramR;
            histogramGreen.HistogramArray = histogramG;
            histogramBlue.HistogramArray = histogramB;
        }
    }
}
