using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

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

        public static Bitmap RGBTransformation(Bitmap original, Func<Color, Color> transform)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    var pixel = original.GetPixel(i, j);
                    var newPixel = transform(pixel);
                    newBitmap.SetPixel(i, j, newPixel);
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

            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
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

            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    var pixel = img.GetPixel(i, j);
                    histogram[(pixel.R + pixel.G + pixel.B) / 3]++;
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

        public static int OtsuThresholding(Bitmap bitmap)
        {
            var histogram = MakeGrayScaleHistogram(bitmap);

            var total = histogram.Sum();

            var sum = 0f;
            for (int i = 0; i < histogram.Length; i++) sum += i * histogram[i];

            var sumB = 0f;
            var wB = 0;
            var wF = 0;

            var varMax = 0f;
            var threshold = 0;

            for (int i = 0; i < histogram.Length; i++)
            {
                wB += histogram[i];

                if (wB == 0) continue;

                wF = total - wB;

                if (wF == 0) break;

                sumB += i * histogram[i];

                var mB = sumB / wB;
                var mF = (sum - sumB) / wF;

                float varBetween = (float)wB * (float)wF * (mB - mF) * (mB - mF);

                if (varBetween > varMax)
                {
                    varMax = varBetween;
                    threshold = i;
                }
            }

            return threshold;
        }

        private static double ColorDist(Color color1, Color color2)
        {
            var diffR = Math.Pow(color1.R - color2.R, 2);
            var diffG = Math.Pow(color1.G - color2.G, 2);
            var diffB = Math.Pow(color1.B - color2.B, 2);

            return Math.Sqrt(diffR + diffG + diffB);
        }

        public static Bitmap KMeansSegmentation(
            Bitmap image,
            int k = 3)
        {
            var clusters = new List<List<(int x, int y,Color c)>>();
            var centroids = new List<Color>();
            var centroidDist = double.MaxValue;
            var minCentroidDist = 0.0001;
            var random = new Random();

            //Centroid awal
            for(int i = 0; i < k; i++)
            {
                var randX = random.Next(0, image.Width);
                var randY = random.Next(0, image.Height);
                var centroid = image.GetPixel(randX, randY);
                centroids.Add(centroid);
                clusters.Add(new List<(int x, int y, Color c)>());
            }

            if (centroids.Count != k || clusters.Count != k)
                throw new Exception("Inilisasi gagal");

            //Kluster awal
            for(int x = 0; x < image.Width; x++)
                for(int y = 0; y < image.Height; y++)
                {
                    var pixel = image.GetPixel(x, y);
                    var minDist = double.MaxValue;
                    var clusterIndex = 0;

                    for(int i = 0; i < k;i++)
                    {
                        var dist = ColorDist(centroids[i], pixel);
                        if(dist < minDist)
                        {
                            minDist = dist;
                            clusterIndex = i;
                        }
                    }

                    clusters[clusterIndex].Add((x, y, pixel));
                }

            while (centroidDist >= minCentroidDist)
            {
                var sumCentroidDist = 0d;
                //Pembaruan centroid
                for (int i = 0; i < centroids.Count; i++)
                {
                    var cluster = clusters[i];
                    var jumlahData = cluster.Count;

                    if (jumlahData <= 0) continue;

                    var sumR = 0d;
                    var sumG = 0d;
                    var sumB = 0d;

                    foreach (var data in cluster)
                    {
                        sumR += data.c.R;
                        sumG += data.c.G;
                        sumB += data.c.B;
                    }

                    var newCentroid = Color.FromArgb(
                        (int)Math.Round(sumR / jumlahData),
                        (int)Math.Round(sumG / jumlahData),
                        (int)Math.Round(sumB / jumlahData)
                    );

                    sumCentroidDist += ColorDist(centroids[i], newCentroid);
                    centroids[i] = newCentroid;
                }

                //Klustering ulang
                for (int i = 0; i < clusters.Count; i++)
                    clusters[i] = new List<(int x, int y, Color c)>();

                for (int x = 0; x < image.Width; x++)
                    for (int y = 0; y < image.Height; y++)
                    {
                        var pixel = image.GetPixel(x, y);
                        var minDist = double.MaxValue;
                        var clusterIndex = 0;

                        for (int i = 0; i < k; i++)
                        {
                            var dist = ColorDist(centroids[i], pixel);
                            if (dist < minDist)
                            {
                                minDist = dist;
                                clusterIndex = i;
                            }
                        }

                        clusters[clusterIndex].Add((x, y, pixel));
                    }

                //Hitung rata2 perubahan centroid
                centroidDist = sumCentroidDist / centroids.Count;
            }

            //Pelabelan
            var colorLabel = new List<Color>();
            for(int i = 0; i < k; i++)
            {
                var randR = random.Next(0, 256);
                var randG = random.Next(0, 256);
                var randB = random.Next(0, 256);
                colorLabel.Add(Color.FromArgb(randR, randG, randB));
            }

            var outImage = new Bitmap(image.Width, image.Height);
            for(int i = 0; i < clusters.Count; i++)
            {
                var cluster = clusters[i];
                foreach(var pixel in cluster)
                {
                    outImage.SetPixel(pixel.x, pixel.y, colorLabel[i]);
                }
            }

            return outImage;
        }

        private static double ColorDist(Lab color1, Lab color2)
        {
            var diffA = Math.Pow(color1.Y - color2.Y, 2);
            var diffB = Math.Pow(color1.Z - color2.Z, 2);

            return Math.Sqrt(diffB + diffA);
        }

        public static Bitmap KMeansSegmentationCielab(
            Bitmap image,
            int k = 3)
        {
            Image<Bgr, Byte> imageBgr = image.ToImage<Bgr, Byte>();
            Image<Lab, Byte> imageLab = new Image<Lab, byte>(image.Width, image.Height);
            CvInvoke.CvtColor(imageBgr, imageLab, ColorConversion.Bgr2Lab);

            var clusters = new List<List<(int x, int y, Lab c)>>();
            var centroids = new List<Lab>();
            var centroidDist = double.MaxValue;
            var minCentroidDist = 0.001;
            var random = new Random();

            //Centroid awal
            for (int i = 0; i < k; i++)
            {
                var randX = random.Next(0, imageLab.Width);
                var randY = random.Next(0, imageLab.Height);
                var centroid = imageLab[randY, randX];
                centroids.Add(centroid);
                clusters.Add(new List<(int x, int y, Lab c)>());
            }

            if (centroids.Count != k || clusters.Count != k)
                throw new Exception("Inilisasi gagal");

            //Kluster awal
            for (int x = 0; x < imageLab.Width; x++)
                for (int y = 0; y < imageLab.Height; y++)
                {
                    var pixel = imageLab[y, x];
                    var minDist = double.MaxValue;
                    var clusterIndex = 0;

                    for (int i = 0; i < k; i++)
                    {
                        var dist = ColorDist(centroids[i], pixel);
                        if (dist < minDist)
                        {
                            minDist = dist;
                            clusterIndex = i;
                        }
                    }

                    clusters[clusterIndex].Add((x, y, pixel));
                }

            while (centroidDist >= minCentroidDist)
            {
                var sumCentroidDist = 0d;
                //Pembaruan centroid
                for (int i = 0; i < centroids.Count; i++)
                {
                    var cluster = clusters[i];
                    var jumlahData = cluster.Count;

                    if (jumlahData <= 0) continue;

                    var sumA = 0d;
                    var sumB = 0d;

                    foreach (var data in cluster)
                    {
                        sumA += data.c.Y;
                        sumB += data.c.Z;
                    }

                    var newCentroid = new Lab() { Y = sumA / jumlahData, Z = sumB / jumlahData };

                    sumCentroidDist += ColorDist(centroids[i], newCentroid);
                    centroids[i] = newCentroid;
                }

                //Klustering ulang
                for (int i = 0; i < clusters.Count; i++)
                    clusters[i] = new List<(int x, int y, Lab c)>();

                for (int x = 0; x < imageLab.Width; x++)
                    for (int y = 0; y < imageLab.Height; y++)
                    {
                        var pixel = imageLab[y, x];
                        var minDist = double.MaxValue;
                        var clusterIndex = 0;

                        for (int i = 0; i < k; i++)
                        {
                            var dist = ColorDist(centroids[i], pixel);
                            if (dist < minDist)
                            {
                                minDist = dist;
                                clusterIndex = i;
                            }
                        }

                        clusters[clusterIndex].Add((x, y, pixel));
                    }

                //Hitung rata2 perubahan centroid
                centroidDist = sumCentroidDist / centroids.Count;
            }

            //Pelabelan
            var colorLabel = new List<Color>();
            for (int i = 0; i < k; i++)
            {
                var randR = random.Next(0, 256);
                var randG = random.Next(0, 256);
                var randB = random.Next(0, 256);
                colorLabel.Add(Color.FromArgb(randR, randG, randB));
            }

            var outImage = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < clusters.Count; i++)
            {
                var cluster = clusters[i];
                foreach (var pixel in cluster)
                {
                    outImage.SetPixel(pixel.x, pixel.y, colorLabel[i]);
                }
            }

            return outImage;
        }
    }
}