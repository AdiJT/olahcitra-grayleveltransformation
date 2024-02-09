using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.GrayLevelSplit
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        public (int, int) GrayLevelSplitRange { get => ((int)numericUpDownGraySplitR1.Value, (int)numericUpDownGraySplitR2.Value); }
        public int GraySplitMaxGray { get => (int)numericUpDownGraySplitMax.Value; }
        public int GraySplitMinGray { get => (int)numericUpDownGraySplitMin.Value; }
        public bool GraySplitMantainBackground { get => checkBoxMaintan.Checked; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxMaintan_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownGraySplitMin.Enabled = !checkBoxMaintan.Checked;
        }
    }
}
