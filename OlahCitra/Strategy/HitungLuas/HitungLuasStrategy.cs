using OlahCitra.Core;
using OlahCitra.Strategy.HSVColorSegmentation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.HitungLuas
{
    public class HitungLuasStrategy : TransformationStrategy
    {
        public HitungLuasStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;
            var opening = 6;
            var closing = 15;
            var minJumPiksel = 5452;
            var skala = 0.01834;

            var colorCorrected = ImageProcessing.ColorCorrection(rgbImage, 10, 10, 20);

            var hsvSegmentationStrategy = new HSVColorSegmentationStrategy(_context);
            var segmentedImage = hsvSegmentationStrategy.Transform(colorCorrected).Result;

            var otsuImage = ImageProcessing.OtsuCv(segmentedImage);
            var openingImage = ImageProcessing.Opening(otsuImage, opening);
            var closingImage = ImageProcessing.Opening(openingImage, closing);
            (var result, var blobs) = ImageProcessing.BlobDetection(closingImage, minJumPiksel);

            var hitungLuas = ImageProcessing.HitungLuas(rgbImage, blobs, skala);

            using (var formHasil = new FormHasil())
            {
                formHasil.AddHasil(new Bitmap[]
                {
                    colorCorrected,
                    segmentedImage,
                    otsuImage,
                    openingImage,
                    closingImage,
                    result,
                    hitungLuas,
                });
                formHasil.ShowDialog();
            }

            return Task.FromResult(hitungLuas);
        }
    }
}
