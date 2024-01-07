using System.Windows.Forms;

namespace OlahCitra
{
    public partial class NumericsSlider : UserControl
    {
        public NumericsSlider()
        {
            InitializeComponent();

            Minimum = 0;
            Maximum = 10;
        }

        public double Minimum
        {
            get
            {
                if (double.TryParse(labelMinValue.Text, out double result))
                    return result;
                else
                    return 0;
            }
            set
            {
                labelMinValue.Text = value.ToString("F2");
            }
        }

        public double Maximum
        {
            get
            {
                if (double.TryParse(labelMaxValue.Text, out double result))
                    return result;
                else
                    return 0;
            }
            set
            {
                labelMaxValue.Text = value.ToString("F2");
            }
        }
    }
}
