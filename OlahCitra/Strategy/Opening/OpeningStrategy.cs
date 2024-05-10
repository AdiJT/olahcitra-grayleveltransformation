using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.Strategy.Opening
{
    public class OpeningStrategy : TransformationStrategy
    {
        public OpeningStrategy(ITransformationStrategyContext context) : base(context)
        {
        }

        public override Task<Bitmap> Transform()
        {
            var greyScale = _context.GrayScaleImage;

            var kernelSize = 3;

            using (var formOptions = new FormOptions())
            {
                if(formOptions.ShowDialog() == DialogResult.OK)
                    kernelSize = formOptions.KernelSize;
            }

            return Task.FromResult(ImageProcessing.Opening(greyScale, kernelSize));
        }
    }
}
