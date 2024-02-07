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
    public partial class FormHistogramDanStatistics : Form
    {
        public FormHistogramDanStatistics()
        {
            InitializeComponent();
        }

        public void UpdateHistogram(Bitmap greyScale, Bitmap hasil, bool onlyHasilChanged = false)
        {
            if (onlyHasilChanged == false)
                histogramGreyScale.Image = greyScale;

            histogramHasil.Image = hasil;
        }

        public void UpdateStatistics(Bitmap greyScale, Bitmap hasil, bool onlyHasilChanged = false)
        {
            if (onlyHasilChanged == false)
                imageStatisticsGreyScale.Statistics = ImageProcessing.MakeStatistic(greyScale);

            imageStatisticsHasil.Statistics = ImageProcessing.MakeStatistic(hasil);
        }
    }
}
