using OlahCitra.Core;
using System.Drawing;
using System.Threading.Tasks;

namespace OlahCitra.Strategy.OtsuCv
{
    public class OtsuCvStrategy : TransformationStrategy
    {
        public OtsuCvStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;

            return Task.FromResult(ImageProcessing.OtsuCv(rgbImage));
        }
    }
}
