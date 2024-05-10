using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.Opening
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        public int KernelSize { get => (int)numericUpDownKernelSize.Value; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void numericUpDownKernelSize_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = $"Besar Kernel ({numericUpDownKernelSize.Value} X {numericUpDownKernelSize.Value})";
        }
    }
}
