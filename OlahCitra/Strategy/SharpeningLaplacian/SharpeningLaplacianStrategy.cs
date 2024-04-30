using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.SharpeningLaplacian
{
    public class SharpeningLaplacianStrategy : TransformationStrategy
    {
        public SharpeningLaplacianStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;

            return Task.FromResult(ImageProcessing.SharpeningLaplacian(rgbImage));
        }
    }
}
