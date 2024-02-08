using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.Power
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        public double Gamma { get => double.Parse(textBoxGamma.Text); }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
