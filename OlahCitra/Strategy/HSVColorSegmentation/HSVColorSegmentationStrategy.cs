using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.HSVColorSegmentation
{
    public class HSVColorSegmentationStrategy : TransformationStrategy
    {
        public HSVColorSegmentationStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;
            var hue = 0;
            var hueRange = 0;
            var mode = FormOptions.Mode.HueOnly;
            var low = new int[0];
            var high = new int[0];

            using (var formOptions = new FormOptions())
            {
                if (formOptions.ShowDialog() == DialogResult.OK)
                {
                    mode = formOptions.FormMode;

                    if (mode == FormOptions.Mode.HueOnly)
                    {
                        hue = formOptions.Hue / 2;
                        hueRange = formOptions.HueRange / 2;
                    }
                    else
                    {
                        low = formOptions.Low;
                        low[0] = low[0] / 2;
                        high = formOptions.High;
                        high[0] = high[0] / 2;
                    }
                }
            }

            if(mode == FormOptions.Mode.HueOnly)
                return Task.FromResult(ImageProcessing.HSVColorSegmentation(rgbImage, hue, hueRange));
            else
                return Task.FromResult(ImageProcessing.HSVColorSegmentation(rgbImage, low, high));
        }
    }
}
