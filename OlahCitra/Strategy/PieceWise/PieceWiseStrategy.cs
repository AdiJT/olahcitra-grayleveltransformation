using OlahCitra.Core;
using OlahCitra.Strategy.PieceWise;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class PieceWiseStrategy : TransformationStrategy
    {
        public PieceWiseStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        private FormOptions _formOptions = new FormOptions();

        public override Task<Bitmap> Transform()
        {
            if (_context.GrayScaleImage == null)
                throw new Exception("No Image");

            var greyscale = _context.GrayScaleImage;

            (int r1, int s1) = (0, 0);
            (int r2, int s2) = (0, 0);

            _formOptions.FormClosing += (o, e) =>
            {
                (r1, s1) = _formOptions.PieceWisePoint1;
                (r2, s2) = _formOptions.PieceWisePoint2;
            };

            _formOptions.ShowDialog();

            return 
                Task.FromResult(ImageProcessing.GrayLevelTransformation(greyscale, 
                    TransformationFactory.PieceWiseLinear(r1, s1, r2, s2)));
        }
    }
}
