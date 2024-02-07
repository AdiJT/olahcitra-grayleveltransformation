using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra
{
    public partial class FormHistogram : Form
    {
        public FormHistogram()
        {
            InitializeComponent();
        }

        public void SetHistogram(Bitmap image) => histogram.Image = image;

        public void SetTitle(string title) => histogram.Title = title;
    }
}
