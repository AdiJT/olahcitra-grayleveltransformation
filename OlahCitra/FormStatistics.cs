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

        public string Title
        {
            set => labelStatistics.Text = value;
        }

        public ImageStatistics Statistics { 
            set 
            {
                progressBarMin.Value = value.MininimumGrayLevel;
                labelCurrentMin.Text = value.MininimumGrayLevel.ToString();

                progressBarMax.Value = value.MaximumGrayLevel;
                labelCurrentMax.Text = value.MaximumGrayLevel.ToString();

                progressBarAvg.Value = (int)value.AverageGrayLevel;
                labelCurrentAvg.Text = value.AverageGrayLevel.ToString("F3");
            }
        }
    }
}
