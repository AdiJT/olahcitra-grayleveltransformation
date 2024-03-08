using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Core
{
    public static class ImageProcessing
    {
        public static Bitmap MakeGreyScale(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    var pixel = original.GetPixel(i, j);
                    var avg = (pixel.R + pixel.B + pixel.G) / 3;
                    newBitmap.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }

            return newBitmap;
        }

        public static Bitmap GrayLevelTransformation(Bitmap original, Func<int, int> transform)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    var pixel = original.GetPixel(i, j);
                    var newGrayScale = Math.Min(transform(pixel.R), 255);
                    newGrayScale = Math.Max(newGrayScale, 0);

                    newBitmap.SetPixel(i, j, Color.FromArgb(pixel.A, newGrayScale, newGrayScale, newGrayScale));
                }
            }

            return newBitmap;
        }

        public static int MaxGrayLevel(Bitmap img)
        {
            int max = 0;

            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                    max = Math.Max(max, img.GetPixel(i, j).R);

            return max;
        }

        public static int MinGrayLevel(Bitmap img)
        {
            int min = int.MaxValue;

            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                    min = Math.Min(min, img.GetPixel(i, j).R);

            return min;
        }

        public static double AvgGreyLevel(Bitmap img)
        {
            double total = 0;
            double jumlahPixel = img.Width * img.Height;

            for(int i = 0; i < img.Width; i++)
                for(int j = 0; j < img.Height; j++)
                {
                    var pixel = img.GetPixel(i, j);
                    total += pixel.R;
                }

            return total / jumlahPixel;
        }

        public static ImageStatistics MakeStatistic(Bitmap img)
        {
            return new ImageStatistics
            {
                MininimumGrayLevel = MinGrayLevel(img),
                MaximumGrayLevel = MaxGrayLevel(img),
                AverageGrayLevel = AvgGreyLevel(img)
            };
        }

        public static int[] MakeGrayScaleHistogram(Bitmap img)
        {
            int[] histogram = new int[256];

            for(int i = 0; i < img.Width; i++)
                for(int j = 0; j < img.Height; j++)
                {
                    var pixel = img.GetPixel(i, j);
                    histogram[(pixel.R + pixel.G + pixel.B)/3]++;
                }

            return histogram;
        }

        public static (Bitmap red, Bitmap green, Bitmap blue) SplitToRGB(Bitmap img)
        {
            var redImage = new Bitmap(img.Width, img.Height);
            var greenImage = new Bitmap(img.Width, img.Height);
            var blueImage = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    var originalPixel = img.GetPixel(i, j);
                    redImage.SetPixel(i, j, Color.FromArgb(originalPixel.A, originalPixel.R, 0, 0));
                    greenImage.SetPixel(i, j, Color.FromArgb(originalPixel.A, 0, originalPixel.G, 0));
                    blueImage.SetPixel(i, j, Color.FromArgb(originalPixel.A, 0, 0, originalPixel.B));
                }
            }

            return (redImage, greenImage, blueImage);
        }

        public static (int[] histogramR, int[] histogramG, int[] histogramB) MakeRGBHistogram(Bitmap img)
        {
            var histogramR = new int[256];
            var histogramG = new int[256];
            var histogramB = new int[256];

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    var pixel = img.GetPixel(i, j);
                    histogramR[pixel.R]++;
                    histogramG[pixel.G]++;
                    histogramB[pixel.B]++;
                }
            }

            return (histogramR, histogramG, histogramB);
        }
    }
}
