using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.RGBSplit
{
    public class RBGSplitStrategy : TransformationStrategy
    {
        public RBGSplitStrategy(ITransformationStrategyContext olahCitraForm) : base(olahCitraForm)
        {
        }

        private FormHasil _formHasil = new FormHasil();

        public override Task<Bitmap> Transform()
        {
            var original = _context.RGBImage;

            var redImage = new Bitmap(original.Width, original.Height);
            var greenImage = new Bitmap(original.Width, original.Height);
            var blueImage = new Bitmap(original.Width, original.Height);

            for(int i = 0; i < original.Width; i++) 
            {
                for(int j = 0; j < original.Height; j++)
                {
                    var originalPixel = original.GetPixel(i, j);
                    redImage.SetPixel(i, j, Color.FromArgb(originalPixel.A, originalPixel.R, 0, 0));
                    greenImage.SetPixel(i, j, Color.FromArgb(originalPixel.A, 0, originalPixel.G, 0));
                    blueImage.SetPixel(i, j, Color.FromArgb(originalPixel.A, 0, 0, originalPixel.B));
                }
            }

            (var histogramR, var histogramG, var histogramB) = ImageProcessing.MakeRGBHistogram(original);

            var result = new Bitmap(original.Width * 3, original.Height);

            using(var graphics = Graphics.FromImage(result))
            {
                graphics.DrawImage(redImage, new Point(0, 0));
                graphics.DrawImage(blueImage, new Point(original.Width, 0));
                graphics.DrawImage(greenImage, new Point(original.Width * 2, 0));
            }

            if(_formHasil == null || _formHasil.IsDisposed)
                _formHasil = new FormHasil();

            _formHasil.SetRBGImage(redImage, greenImage, blueImage);
            _formHasil.SetRGBHistogram(histogramR, histogramG, histogramB);
            _formHasil.Show();

            return Task.FromResult(result);
        }
    }
}
