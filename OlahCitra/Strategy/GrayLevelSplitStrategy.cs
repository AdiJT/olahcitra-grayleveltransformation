using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class GrayLevelSplitStrategy : TransformationStrategy
    {
        public GrayLevelSplitStrategy(OlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Bitmap Transform()
        {
            var grayScale = _olahCitraForm.GreyScaleImage;

            if (grayScale == null)
                throw new Exception("Gambar tidak ada");

            var range = _olahCitraForm.GrayLevelSplitRange;
            var max = _olahCitraForm.GraySplitMaxGray;
            var min = _olahCitraForm.GraySplitMinGray;
            var maintain = _olahCitraForm.GraySplitMantainBackground;

            return ImageProcessing.GrayLevelTransformation(grayScale,
                TransformationFactory.GraySplitting(range, max, min, maintain));
        }
    }
}
