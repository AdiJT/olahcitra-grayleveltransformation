using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.PreProcessing
{
    public class PreProcessingStrategy : TransformationStrategy
    {
        public PreProcessingStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;

            var result = ImageProcessing.PreProcessing(rgbImage);

            int cols = result.Count / 4 + 1;

            int shift = 50;
            var outImage = new Bitmap(4 * (rgbImage.Width + shift), cols * (rgbImage.Height + shift));

            using (var g = Graphics.FromImage(outImage))
            {
                var row = 0;
                var col = 0;
                foreach (var item in result)
                {
                    g.DrawImage(item.Value, new Point(row * (rgbImage.Width + shift), col * (rgbImage.Height + shift)));
                    if (row == 3)
                    {
                        row = 0;
                        col++;
                    }
                    else
                        row++;
                }
            }

            return Task.FromResult(outImage);
        }
    }
}
