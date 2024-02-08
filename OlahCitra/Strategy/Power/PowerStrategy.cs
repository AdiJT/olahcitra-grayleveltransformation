using OlahCitra.Core;
using OlahCitra.Strategy.Power;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class PowerStrategy : TransformationStrategy
    {
        public PowerStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        private FormOptions _formOptions = new FormOptions();

        public override Bitmap Transform()
        {
            if (_olahCitraForm.GrayScaleImage == null)
                throw new Exception("Gambar tidak ada");

            var greyscale = _olahCitraForm.GrayScaleImage;
            double gamma = 0;

            _formOptions.FormClosing += (o, e) => gamma = _formOptions.Gamma;
            _formOptions.ShowDialog();

            return ImageProcessing.GrayLevelTransformation(greyscale, TransformationFactory.Power(gamma));
        }
    }
}
