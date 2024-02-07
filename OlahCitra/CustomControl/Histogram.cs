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

namespace OlahCitra.CustomControl
{
    public partial class Histogram : UserControl
    {
        public Bitmap Image
        {
            set
            {
                chartHistogram.Series["Histogram"].Points.Clear();
                chartNormalizedHistogram.Series["Normalized Histogram"].Points.Clear();

                var histogram = ImageProcessing.MakeHistogram(value);
                double jumlahPixel = histogram.Sum();
                var normalizedHistogram = histogram.Select(i => i / jumlahPixel).ToArray();

                chartHistogram.ChartAreas[0].Axes[1].Maximum = histogram.Max();
                chartHistogram.ChartAreas[0].Axes[1].Minimum = 0;

                for (int i = 0; i < histogram.Length; i++)
                {
                    chartHistogram.Series["Histogram"].Points.AddXY(i, histogram[i]);
                    chartNormalizedHistogram.Series["Normalized Histogram"].Points.AddXY(i, normalizedHistogram[i]);
                }
            }
        }

        public string Title { set => labelHistogram.Text = value; }

        public Histogram()
        {
            InitializeComponent();
        }
    }
}
