using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Core
{
    public class TransformationFactory
    {
        public static Func<int, int> Power(double gamma)
        {
            return g => (int)(Math.Pow((double)g / 255, gamma) * 255d);
        }

        public static Func<int, int> Log(Bitmap img)
        {
            double c = 255 / Math.Log(ImageProcessing.MaxGrayLevel(img) + 1);

            return g => (int)(Math.Log(g + 1) * c);
        }

        public static Func<int, int> PieceWiseLinear(int r1, int s1, int r2, int s2)
        {
            if (r1 > r2 || s1 > s2)
                throw new ArgumentException();

            double m1 = ((double)s1 - 0) / Math.Max(1, ((double)r1 - 0));     //(0, 0) - (r1, s1)
            double m2 = ((double)s2 - s1) / Math.Max(1, ((double)r2 - r1));    //(r1, s1) - (r2, s2)
            double m3 = (255d - s2) / Math.Max(1, (255d - r2));  //(r2, s2) - (255, 255)

            Func<int, int> func1 = (g) => (int)(m1 * g);           //(0, 0) - (r1, s1)
            Func<int, int> func2 = g => (int)(m2 * (g - r1) + s1); //(r1, s1) - (r2, s2)
            Func<int, int> func3 = g => (int)(m3 * (g - r2) + s2); //(r2, s2) - (255, 255)

            return g =>
            {
                if (g <= r1)
                    return func1(g);
                else if (g <= r2)
                    return func2(g);
                else
                    return func3(g);
            };
        }

        public static Func<int, int> ContrastStreching(Bitmap bitmap)
        {
            return PieceWiseLinear(ImageProcessing.MinGrayLevel(bitmap), 0, ImageProcessing.MaxGrayLevel(bitmap), 255);
        }

        public static Func<int, int> HistogramEqualization(Bitmap bitmap)
        {
            var histogram = ImageProcessing.MakeHistogram(bitmap);

            double jumlahPixel = histogram.Sum();

            double[] normalizedHistogram = histogram.Select(i => i/jumlahPixel).ToArray();

            var sum = normalizedHistogram.Sum();

            var outputLookUp = new int?[256];

            return (g) =>
            {
                if (outputLookUp[g].HasValue == true)
                    return outputLookUp[g].Value;

                double output = 0;

                for (int i = 0; i < g; i++)
                    output += normalizedHistogram[i];

                output = output * 255;

                outputLookUp[g] = (int)output;

                return (int)output;
            };
        }

        public static Func<int, int> GraySplitting((int, int) range, int maxGrayLevel, int minGrayLevel, bool maintainBackgroundTonality)
        {
            if (range.Item1 > range.Item2)
                throw new ArgumentException();

            return (g) =>
            {
                if(range.Item1 <= g && g <= range.Item2)
                {
                    return maxGrayLevel;
                }
                else
                {
                    if (maintainBackgroundTonality)
                        return g;
                    else
                        return minGrayLevel;
                }
            };
        }

        public static Func<int, int> BitSplitting(int bit)
        {
            if (bit < 0 || bit > 7)
                throw new ArgumentException("Bit antara 0 sampai 7", nameof(bit));

            int mask = (int)Math.Pow(2, bit);


            var memo = new int?[256];

            return g =>
            {
                if (memo[g].HasValue)
                    return memo[g].Value;

                var masked = g & mask;
                var shifted = masked >> (bit);
                var result = shifted * 255;

                memo[g] = result;

                return result;
            };
        }
    }
}
