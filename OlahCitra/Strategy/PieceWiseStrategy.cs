using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class PieceWiseStrategy : TransformationStrategy
    {
        public PieceWiseStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Bitmap Transform()
        {
            if (_olahCitraForm.GreyScaleImage == null)
                throw new Exception("No Image");

            var greyscale = _olahCitraForm.GreyScaleImage;

            (int r1, int s1) = _olahCitraForm.PieceWisePoint1;
            (int r2, int s2) = _olahCitraForm.PieceWisePoint2;

            return ImageProcessing.GrayLevelTransformation(greyscale, TransformationFactory.PieceWiseLinear(r1, s1, r2, s2));
        }
    }
}
