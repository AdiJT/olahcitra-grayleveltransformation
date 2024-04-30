using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.KMeansHsv
{
    public class KMeansHsvStrategy : TransformationStrategy
    {
        public KMeansHsvStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;

            return Task.FromResult(ImageProcessing.KMeansSegmentationHsv(rgbImage, 3));
        }
    }
}
