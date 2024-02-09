using OlahCitra.Core;
using OlahCitra.Strategy.GrayLevelSplit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class GrayLevelSplitStrategy : TransformationStrategy
    {
        public GrayLevelSplitStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        private FormOptions _formOptions = new FormOptions();

        public override Task<Bitmap> Transform()
        {
            var grayScale = _context.GrayScaleImage;

            if (grayScale == null)
                throw new Exception("Gambar tidak ada");

            (int, int) range = (0, 0);
            int max = 0;
            int min = 0;
            bool maintain = false;

            _formOptions.FormClosing += (o, e) =>
            {
                range = _formOptions.GrayLevelSplitRange;
                max = _formOptions.GraySplitMaxGray;
                min = _formOptions.GraySplitMinGray;
                maintain = _formOptions.GraySplitMantainBackground;
            };
            _formOptions.ShowDialog();

            return Task.FromResult(
                ImageProcessing.GrayLevelTransformation(
                    grayScale,
                    TransformationFactory.GraySplitting(range, max, min, maintain)
                    )
                );
        }
    }
}
