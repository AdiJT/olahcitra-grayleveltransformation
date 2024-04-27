using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.KMeans
{
    public class KMeansStrategy : TransformationStrategy
    {
        public KMeansStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var imageColor = _context.RGBImage;

            return Task.FromResult(ImageProcessing.KMeansSegmentation(imageColor, 3));
        }
    }
}
