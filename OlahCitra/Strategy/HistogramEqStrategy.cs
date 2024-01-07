using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class HistogramEqStrategy : TransformationStrategy
    {
        public HistogramEqStrategy(OlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Bitmap Transform()
        {
            if (_olahCitraForm.GreyScaleImage == null)
                throw new Exception("Gambar tidak ada");

            var greyscale = _olahCitraForm.GreyScaleImage;

            return ImageProcessing.GrayLevelTransformation(greyscale, TransformationFactory.HistogramEqualization(greyscale));
        }
    }
}
