using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.OtsuThresholding
{
    public class OtsuThresholdingStrategy : TransformationStrategy
    {
        public OtsuThresholdingStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            if (_context.GrayScaleImage == null)
                throw new Exception("Gambar tidak ada");

            var greyscale = _context.GrayScaleImage;

            var resultImage = ImageProcessing.GrayLevelTransformation(
                greyscale,
                TransformationFactory.OtsuThresholding(greyscale));

            var result = new Bitmap(resultImage.Width, resultImage.Height + 100);

            using(var graphic = Graphics.FromImage(result))
            {
                graphic.DrawImage(resultImage, new Point(0, 0));
                graphic.DrawString(
                    $"Threshold = {ImageProcessing.OtsuThresholding(greyscale)}",
                    new Font("Times New Roman", 12, FontStyle.Bold),
                    new SolidBrush(Color.Black),
                    new Point(0, resultImage.Height + 50));
            }

            return Task.FromResult(result);
        }
    }
}
