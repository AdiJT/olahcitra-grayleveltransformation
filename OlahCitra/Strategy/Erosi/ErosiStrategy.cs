using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.Erosi
{
    public class ErosiStrategy : TransformationStrategy
    {
        public ErosiStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var greyImage = _context.GrayScaleImage;

            return Task.FromResult(ImageProcessing.Erosion(greyImage, 10));
        }
    }
}
