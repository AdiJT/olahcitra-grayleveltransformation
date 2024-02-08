using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class NegativeStrategy : TransformationStrategy
    {
        public NegativeStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Bitmap Transform()
        {
            if (_olahCitraForm.GrayScaleImage == null)
                throw new Exception("Greyscale belum ada!");

            var bitmap = _olahCitraForm.GrayScaleImage;
            return ImageProcessing.GrayLevelTransformation(bitmap, GreyLevelTransform.Negative);
        }
    }
}
