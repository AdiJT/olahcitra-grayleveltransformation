﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

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

        public static Bitmap OtsuCv(Bitmap original)
        {
            var outImage = new Bitmap(original.Width, original.Height);

            using (var image = original.ToImage<Bgr, byte>())
            using (var imageGray = image.Convert<Gray, byte>())
            using (var result = new UMat())
            {
                CvInvoke.Threshold(imageGray, result, 0, 255, ThresholdType.Otsu | ThresholdType.Binary);

                outImage = result.ToBitmap();
            }
            
            return outImage;
        }

        public static Bitmap KMeansSegmentation(
            Bitmap image,
            int k = 3)
        {
            Matrix<float> data = new Matrix<float>(image.Width * image.Height, 3);
            var labels = new VectorOfInt();

            int matrixIndex = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    var pixel = image.GetPixel(x, y);
                    data[matrixIndex, 0] = (float)pixel.R;
                    data[matrixIndex, 1] = (float)pixel.G;
                    data[matrixIndex, 2] = (float)pixel.B;
                    matrixIndex++;
                }
            }

            CvInvoke.Kmeans(data, k, labels, new MCvTermCriteria(Math.Pow(10, -10)), 8, KMeansInitType.PPCenters);

            //Pelabelan
            var random = new Random();
            var colorLabel = new List<Color>();
            for (int i = 0; i < k; i++)
            {
                var randR = random.Next(0, 256);
                var randG = random.Next(0, 256);
                var randB = random.Next(0, 256);
                colorLabel.Add(Color.FromArgb(randR, randG, randB));
            }

            var outImage = new Bitmap(image.Width, image.Height);
            var labelsIndex = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    outImage.SetPixel(x, y, colorLabel[labels[labelsIndex]]);
                    labelsIndex++;
                }
            }

            return outImage;
        }

        public static Bitmap KMeansSegmentationCielab(
            Bitmap image,
            int k = 3)
        {
            Image<Bgr, Byte> imageBgr = image.ToImage<Bgr, Byte>();
            Image<Lab, Byte> imageLab = imageBgr.Convert<Lab, Byte>();

            Matrix<float> data = new Matrix<float>(image.Width * image.Height, 3);
            var labels = new VectorOfInt();

            int matrixIndex = 0;
            for (int x = 0; x < imageLab.Width; x++)
            {
                for (int y = 0; y < imageLab.Height; y++)
                {
                    var pixel = imageLab[y, x];
                    data[matrixIndex, 0] = (float)pixel.X;
                    data[matrixIndex, 1] = (float)pixel.Y;
                    data[matrixIndex, 2] = (float)pixel.Z;
                    matrixIndex++;
                }
            }

            CvInvoke.Kmeans(data, k, labels, new MCvTermCriteria(Math.Pow(10, -10)), 8, KMeansInitType.PPCenters);

            //Pelabelan
            var random = new Random();
            var colorLabel = new List<Color>();
            for (int i = 0; i < k; i++)
            {
                var randR = random.Next(0, 256);
                var randG = random.Next(0, 256);
                var randB = random.Next(0, 256);
                colorLabel.Add(Color.FromArgb(randR, randG, randB));
            }

            var outImage = new Bitmap(image.Width, image.Height);
            var labelsIndex = 0;
            for (int x = 0; x < imageLab.Width; x++)
            {
                for (int y = 0; y < imageLab.Height; y++)
                {
                    outImage.SetPixel(x, y, colorLabel[labels[labelsIndex]]);
                    labelsIndex++;
                }
            }

            return outImage;
        }

        public static Bitmap Dilation(Bitmap input, int kernelSize)
        {
            Bitmap outImage = new Bitmap(input.Width, input.Height);

            using (UMat image = input.ToImage<Gray, Byte>().ToUMat())
            {
                var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(1, 1));

                CvInvoke.MorphologyEx(image,
                                      image,
                                      MorphOp.Dilate,
                                      kernel,
                                      new Point(-1, -1),
                                      1,
                                      BorderType.Default,
                                      new MCvScalar());

                outImage = image.ToBitmap();
            }

            return outImage;
        }

        public static Bitmap Erosion(Bitmap input, int kernelSize)
        {
            Bitmap outImage = new Bitmap(input.Width, input.Height);

            using (UMat image = input.ToImage<Gray, Byte>().ToUMat())
            {
                var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(1, 1));

                CvInvoke.MorphologyEx(image,
                                      image,
                                      MorphOp.Erode,
                                      kernel,
                                      new Point(-1, -1),
                                      1,
                                      BorderType.Default,
                                      new MCvScalar());

                outImage = image.ToBitmap();
            }

            return outImage;
        }

        public static Bitmap Opening(Bitmap input, int kernelSize)
        {
            Bitmap outImage = new Bitmap(input.Width, input.Height);

            using (UMat image = input.ToImage<Gray, Byte>().ToUMat())
            {
                var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(1, 1));

                CvInvoke.MorphologyEx(image,
                                      image,
                                      MorphOp.Open,
                                      kernel,
                                      new Point(-1, -1),
                                      1,
                                      BorderType.Default,
                                      new MCvScalar());

                outImage = image.ToBitmap();
            }

            return outImage;
        }

        public static Bitmap Closing(Bitmap input, int kernelSize)
        {
            Bitmap outImage = new Bitmap(input.Width, input.Height);

            using (UMat image = input.ToImage<Gray, Byte>().ToUMat())
            {
                var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(1, 1));

                CvInvoke.MorphologyEx(image,
                                      image,
                                      MorphOp.Close,
                                      kernel,
                                      new Point(-1, -1),
                                      1,
                                      BorderType.Default,
                                      new MCvScalar());

                outImage = image.ToBitmap();
            }

            return outImage;
        }

        public static Bitmap WatershedSegmentation(Bitmap input)
        {
            Image<Bgr, Byte> image = input.ToImage<Bgr, byte>();
            using (UMat imageGray = new UMat())
            using (UMat imageClear = new UMat())
            using (UMat sureBg = new UMat())
            using (UMat sureFg = new UMat())
            using (UMat unknown = new UMat())
            using (UMat markers = new UMat())
            {
                float[,] kernelMat = new float[3, 3]
                {
                    {1, 1, 1 },
                    {1, -8, 1 },
                    {1, 1, 1 }
                };
                ConvolutionKernelF kernelLap = new ConvolutionKernelF(kernelMat);

                Mat imgLaplacian = new Mat(image.Size, DepthType.Cv32F, 3);
                CvInvoke.Filter2D(image, imgLaplacian, kernelLap, new Point(-1, -1));

                Mat sharp = new Mat();
                image.Mat.ConvertTo(sharp, DepthType.Cv32F);
                Mat imgResult = sharp - imgLaplacian;

                imgLaplacian.ConvertTo(imgLaplacian, DepthType.Cv8U);
                Image<Bgr, byte> imageSharp = imgResult.ToImage<Bgr, byte>();

                //Konversi ke grayscale
                CvInvoke.CvtColor(imageSharp, imageGray, ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(imageGray, imageClear, 0, 255, ThresholdType.Otsu);

                //Kernel
                var kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

                //Removing noise
                CvInvoke.MorphologyEx(imageClear, imageClear, MorphOp.Open, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());
                CvInvoke.MorphologyEx(imageClear, imageClear, MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());

                //Get sure background
                CvInvoke.MorphologyEx(imageClear, sureBg, MorphOp.Dilate, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());

                //Get sure foreground
                CvInvoke.MorphologyEx(imageClear, sureFg, MorphOp.Erode, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());

                //Get unknown
                CvInvoke.Subtract(sureBg, sureFg, unknown);

                //Get Markers
                CvInvoke.ConnectedComponents(sureFg, markers, LineType.EightConnected, DepthType.Cv32S);

                Matrix<int> markersMat = new Matrix<int>(markers.Rows, markers.Cols);
                markers.CopyTo(markersMat);
                markersMat += 1;
                Mat m = new Mat();

                Matrix<byte> unknownMat = new Matrix<byte>(unknown.Rows, unknown.Cols);
                unknown.CopyTo(unknownMat);

                for (int x = 0; x < unknownMat.Rows; x++)
                    for (int y = 0; y < unknownMat.Cols; y++)
                        if (unknownMat[x, y] == 255) markersMat[x, y] = 0;

                CvInvoke.Watershed(image, markersMat);

                for (int x = 0; x < markersMat.Rows; x++)
                    for (int y = 0; y < markersMat.Cols; y++)
                        if (markersMat[x, y] == -1) image[x, y] = new Bgr(0, 0, 255);

                input = image.ToBitmap<Bgr, Byte>();
            }

            return input;
        }

        public static Bitmap AdaptMeanThreshold(Bitmap input, double c)
        {
            var image = input.ToImage<Bgr, byte>();
            UMat imageGray = new UMat();
            CvInvoke.CvtColor(image, imageGray, ColorConversion.Bgr2Gray);
            CvInvoke.AdaptiveThreshold(imageGray, imageGray, 255, AdaptiveThresholdType.MeanC, ThresholdType.Binary, 3, c);

            var outImage = imageGray.ToBitmap();
            image.Dispose();

            return outImage;
        }

        public static Bitmap KMeansSegmentationHsv(
            Bitmap image,
            int k = 3)
        {
            Image<Bgr, Byte> imageBgr = image.ToImage<Bgr, Byte>();
            Image<Hsv, Byte> imageHsv = new Image<Hsv, byte>(imageBgr.Width, imageBgr.Height);
            CvInvoke.CvtColor(imageBgr, imageHsv, ColorConversion.Bgr2Hsv);

            Matrix<float> data = new Matrix<float>(image.Width * image.Height, 3);
            var labels = new VectorOfInt();

            int matrixIndex = 0;
            for (int x = 0; x < imageHsv.Width; x++)
            {
                for (int y = 0; y < imageHsv.Height; y++)
                {
                    var pixel = imageHsv[y, x];
                    data[matrixIndex, 0] = (float)pixel.Hue;
                    data[matrixIndex, 1] = (float)pixel.Satuation;
                    data[matrixIndex, 2] = (float)pixel.Value;
                    matrixIndex++;
                }
            }

            CvInvoke.Kmeans(data, k, labels, new MCvTermCriteria(Math.Pow(10, -10)), 8, KMeansInitType.PPCenters);

            //Pelabelan
            var random = new Random();
            var colorLabel = new List<Color>();
            for (int i = 0; i < k; i++)
            {
                var randR = random.Next(0, 256);
                var randG = random.Next(0, 256);
                var randB = random.Next(0, 256);
                colorLabel.Add(Color.FromArgb(randR, randG, randB));
            }

            var outImage = new Bitmap(image.Width, image.Height);
            var labelsIndex = 0;
            for (int x = 0; x < imageHsv.Width; x++)
            {
                for (int y = 0; y < imageHsv.Height; y++)
                {
                    outImage.SetPixel(x, y, colorLabel[labels[labelsIndex]]);
                    labelsIndex++;
                }
            }

            return outImage;
        }

        public static Bitmap SharpeningLaplacian(Bitmap original)
        {
            Bitmap outImage = new Bitmap(original.Width, original.Height);
            using (Image<Bgr, byte> image = original.ToImage<Bgr, byte>())
            using (UMat laplacian = new UMat(image.Size, DepthType.Cv32F, 3))
            using (UMat img32F = new UMat())
            using (UMat sharp = new UMat())
            {
                var kernel = new ConvolutionKernelF(new float[,]
                {
                    { -1, -1, -1 },
                    { -1, 8, -1 },
                    { -1, 1, -1 }
                });

                CvInvoke.Filter2D(image, laplacian, kernel, new Point(-1, -1));

                image.Mat.ConvertTo(img32F, DepthType.Cv32F);

                CvInvoke.AbsDiff(img32F, laplacian, sharp);

                sharp.ConvertTo(sharp, DepthType.Cv8U);

                outImage = sharp.ToBitmap();
            }

            return outImage;
        }

        public static Bitmap GaussianBlur(Bitmap original)
        {
            Bitmap outImage = new Bitmap(original.Width, original.Height);
            using (Image<Bgr, byte> image = original.ToImage<Bgr, byte>())
            using (UMat blurred = new UMat())
            {
                CvInvoke.GaussianBlur(image, blurred, new Size(5, 5), 0);
                outImage = blurred.ToBitmap();
            }

            return outImage;
        }
    }
}