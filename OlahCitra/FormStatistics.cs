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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        public void SetTitle(string title) => imageStatistics.Title = title;
        public void SetStatistics(ImageStatistics statistics) => imageStatistics.Statistics = statistics;
    }
}
