using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.EuclidDist
{
    public class EuclidDistStrategy : TransformationStrategy
    {
        public EuclidDistStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        FormOptions _formOptions = new FormOptions();

        public override Task<Bitmap> Transform()
        {
            if (_context.RGBImage == null)
                throw new Exception("Gambar tidak ada");

            Color targetColor = Color.White;
            double maxDistance = 1;

            _formOptions.FormClosing += (o, args) =>
            {
                targetColor = _formOptions.TargetColor;
                maxDistance = _formOptions.MaxDistance;
            };
            _formOptions.ShowDialog();

            var euclidDist = TransformationFactory.EuclidDist(targetColor, maxDistance);

            return Task.FromResult(ImageProcessing.RGBTransformation(_context.RGBImage, euclidDist));
        }
    }
}
