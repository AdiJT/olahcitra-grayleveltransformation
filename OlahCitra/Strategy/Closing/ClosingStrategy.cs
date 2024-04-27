using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.Closing
{
    public class ClosingStrategy : TransformationStrategy
    {
        public ClosingStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var greyScale = _context.GrayScaleImage;

            return Task.FromResult(ImageProcessing.Closing(greyScale, 10));
        }
    }
}
