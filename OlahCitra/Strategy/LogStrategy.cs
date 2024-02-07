using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class LogStrategy : TransformationStrategy
    {
        public LogStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Bitmap Transform()
        {
            if (_olahCitraForm.GreyScaleImage == null)
                throw new Exception("Greyscale belum ada!");

            var bitmap = _olahCitraForm.GreyScaleImage;
            return ImageProcessing.GrayLevelTransformation(bitmap, TransformationFactory.Log(bitmap));
        }
    }
}
