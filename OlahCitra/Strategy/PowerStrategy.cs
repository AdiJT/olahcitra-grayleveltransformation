using OlahCitra.Core;
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
        public PowerStrategy(OlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Bitmap Transform()
        {
            if (_olahCitraForm.GreyScaleImage == null)
                throw new Exception("Gambar tidak ada");

            var greyscale = _olahCitraForm.GreyScaleImage;
            var gamma = _olahCitraForm.Gamma;

            return ImageProcessing.GrayLevelTransformation(greyscale, TransformationFactory.Power(gamma));
        }
    }
}
