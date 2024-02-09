using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class ContrastStrechingStrategy : TransformationStrategy
    {
        public ContrastStrechingStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        public override Task<Bitmap> Transform()
        {
			if (_context.GrayScaleImage == null)
				throw new Exception("Gambar tidak ada");

			var greyscale = _context.GrayScaleImage;

			return Task.FromResult(
                ImageProcessing.GrayLevelTransformation(
                    greyscale, 
                    TransformationFactory.ContrastStreching(greyscale)
                    )
                );
		}
    }
}
