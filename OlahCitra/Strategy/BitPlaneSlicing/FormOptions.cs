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
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        public int BitSplitBitPlane { get => (int)numericUpDownBItPlane.Value; }
        public bool BitSplitMaxGrayLevel { get => checkBoxBitSplitMaxGrayLevel.Checked; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
