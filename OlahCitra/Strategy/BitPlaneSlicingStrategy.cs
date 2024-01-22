using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class BitPlaneSlicingStrategy : TransformationStrategy
    {
        public BitPlaneSlicingStrategy(OlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Bitmap Transform()
        {
            var grayScale = _olahCitraForm.GreyScaleImage;
            if (grayScale == null)
                throw new Exception("Gambar GreyScale belum dipilih");

            var bitPlane = _olahCitraForm.BitPlane;

            return ImageProcessing.GrayLevelTransformation(grayScale, TransformationFactory.BitSplitting(bitPlane));
        }
    }
}
