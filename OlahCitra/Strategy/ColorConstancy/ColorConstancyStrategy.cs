using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.ColorConstancy
{
    public class ColorConstancyStrategy : TransformationStrategy
    {
        public ColorConstancyStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;

            var colorContancy = TransformationFactory.ColorConstancy(rgbImage);

            return Task.FromResult(ImageProcessing.RGBTransformation(rgbImage, colorContancy));
        }
    }
}
