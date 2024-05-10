using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.ColorCorrection
{
    public class ColorCorrectionStrategy : TransformationStrategy
    {
        public ColorCorrectionStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var rgbImage = _context.RGBImage;
            var pergeseran = new Color();

            using (var formOptions = new FormOptions())
            {
                if(formOptions.ShowDialog() == DialogResult.OK)
                {
                    pergeseran = formOptions.Pergeseran;
                }
            }

            return Task.FromResult(ImageProcessing.ColorCorrection(rgbImage, pergeseran.R, pergeseran.G, pergeseran.B));
        }
    }
}
