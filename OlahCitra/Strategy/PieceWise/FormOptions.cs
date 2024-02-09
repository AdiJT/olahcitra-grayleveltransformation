using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.PieceWise
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        public (int, int) PieceWisePoint1 { get => ((int)numericUpDownR1.Value, (int)numericUpDownS1.Value); }
        public (int, int) PieceWisePoint2 { get => ((int)numericUpDownR2.Value, (int)numericUpDownS2.Value); }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
