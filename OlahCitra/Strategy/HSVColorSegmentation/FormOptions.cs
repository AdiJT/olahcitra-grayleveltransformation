using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.HSVColorSegmentation
{
    public partial class FormOptions : Form
    {
        public enum Mode
        {
            HueOnly, LowHigh
        }

        public FormOptions()
        {
            InitializeComponent();
        }


        private Mode _formMode = Mode.HueOnly;

        public Mode FormMode
        {
            get => _formMode;
            set
            {
                _formMode = value;
                if(_formMode == Mode.HueOnly)
                {
                    panelHueOnly.Enabled = true;
                    panelLowHigh.Enabled = false;
                }
                else
                {
                    panelHueOnly.Enabled = false;
                    panelLowHigh.Enabled = true;
                }
            }
        }

        public int Hue { get => (int)numericUpDownHue.Value; }
        public int HueRange { get => (int)numericUpDownHueRange.Value; }

        public int[] Low { 
            get
            {
                return new int[]
                {
                    (int)numericUpDownLowHue.Value,
                    (int)numericUpDownLowSaturation.Value,
                    (int)numericUpDownLowValue.Value,
                };
            } 
        }

        public int[] High
        {
            get
            {
                return new int[]
                {
                    (int)numericUpDownHighHue.Value,
                    (int)numericUpDownHighSaturation.Value,
                    (int)numericUpDownHighValue.Value,
                };
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void radioButtonHueOnly_CheckedChanged(object sender, EventArgs e)
        {
            FormMode = Mode.HueOnly;
        }

        private void radioButtonLowHigh_CheckedChanged(object sender, EventArgs e)
        {
            FormMode = Mode.LowHigh;
        }
    }
}
