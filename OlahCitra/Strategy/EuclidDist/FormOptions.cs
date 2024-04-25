using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.EuclidDist
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        public Color TargetColor { get => Color.FromArgb(1,
            (int)numericUpDownTargetR.Value,
            (int)numericUpDownTargetG.Value,
            (int)numericUpDownTargetB.Value);
        }

        public double MaxDistance { get => (double)numericUpDownMaxDist.Value; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPick_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                numericUpDownTargetR.Value = color.R;
                numericUpDownTargetG.Value = color.G;
                numericUpDownTargetB.Value = color.B;
            }
        }
    }
}
