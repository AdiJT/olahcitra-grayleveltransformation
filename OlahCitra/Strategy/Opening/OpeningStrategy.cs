using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.Opening
{
    public class OpeningStrategy : TransformationStrategy
    {
        public OpeningStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var greyScale = _context.GrayScaleImage;

            return Task.FromResult(ImageProcessing.Opening(greyScale, 10));
        }
    }
}
