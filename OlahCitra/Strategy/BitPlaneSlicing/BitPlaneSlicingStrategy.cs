using OlahCitra.Core;
using OlahCitra.Strategy.BitPlaneSlicing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public class BitPlaneSlicingStrategy : TransformationStrategy
    {
        public BitPlaneSlicingStrategy(FormOlahCitra olahCitraForm) : base(olahCitraForm)
        {
        }

        private FormOptions _formOptions = new FormOptions();
        private FormHasil _formHasil = new FormHasil();

        public override async Task<Bitmap> Transform()
        {
            var grayScale = _context.GrayScaleImage;
            if (grayScale == null)
                throw new Exception("Gambar GreyScale belum dipilih");

            int bitPlane = 0;
            bool makeMaxGrayLevel = false;

            _formOptions.FormClosing += (s, e) =>
            {
                bitPlane = _formOptions.BitSplitBitPlane;
                makeMaxGrayLevel = _formOptions.BitSplitMaxGrayLevel;
            };
            _formOptions.ShowDialog();

            List<Bitmap> result = new List<Bitmap>();

            for (int i = 0; i < 8; i++)
                result.Add(new Bitmap(1, 1));

            for(int i = 0; i < 8; i++)
            {
                Bitmap bitPlaneResult = await Task.Run(() =>
                    ImageProcessing.GrayLevelTransformation(
                        grayScale,
                        TransformationFactory.BitSplitting(i, makeMaxGrayLevel)
                    )
                );

                result[i] = bitPlaneResult;
            }

            _formHasil.ImageBitPlane0 = result[0];
            _formHasil.ImageBitPlane1 = result[1];
            _formHasil.ImageBitPlane2 = result[2];
            _formHasil.ImageBitPlane3 = result[3];
            _formHasil.ImageBitPlane4 = result[4];
            _formHasil.ImageBitPlane5 = result[5];
            _formHasil.ImageBitPlane6 = result[6];
            _formHasil.ImageBitPlane7 = result[7];

            _formHasil.ShowDialog();

            return result[bitPlane];
        }
    }
}
