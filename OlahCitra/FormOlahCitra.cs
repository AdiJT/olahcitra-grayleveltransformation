using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using OlahCitra.Core;
using OlahCitra.Strategy;
using OlahCitra.Strategy.AdaptMeanThreshold;
using OlahCitra.Strategy.Closing;
using OlahCitra.Strategy.ColorConstancy;
using OlahCitra.Strategy.Dilasi;
using OlahCitra.Strategy.Erosi;
using OlahCitra.Strategy.EuclidDist;
using OlahCitra.Strategy.SharpeningLaplacian;
using OlahCitra.Strategy.KMeans;
using OlahCitra.Strategy.KMeansHsv;
using OlahCitra.Strategy.KMeansLab;
using OlahCitra.Strategy.Opening;
using OlahCitra.Strategy.OtsuThresholding;
using OlahCitra.Strategy.RGBSplit;
using OlahCitra.Strategy.Watershed;
using OlahCitra.Strategy.OtsuCv;
using OlahCitra.Strategy.GaussianBlur;
using OlahCitra.Strategy.GreenSegmentation;
using OlahCitra.Strategy.Sobel;
using OlahCitra.Strategy.PreProcessing;
using OlahCitra.Strategy.Canny;
using OlahCitra.Strategy.ColorCorrection;
using OlahCitra.Strategy.HSVColorSegmentation;
using OlahCitra.Strategy.BlobDetection;
using OlahCitra.Strategy.HitungLuas;

namespace OlahCitra
{
    public partial class FormOlahCitra : Form, ITransformationStrategyContext
    {
        private TransformationStrategy _currentStrategy;

        public Bitmap RGBImage { get => pictureBoxAsli.Image; }
        public Bitmap GrayScaleImage { get => pictureBoxGrayScale.Image; }

        private FormHistogramDanStatistics _formHistogramDanStatistics;

        public FormOlahCitra()
        {
            InitializeComponent();

            var greyScale = new Bitmap(pictureBoxGrayScale.Image);

            _formHistogramDanStatistics = new FormHistogramDanStatistics();
            _formHistogramDanStatistics.UpdateHistogram(greyScale, greyScale);
            _formHistogramDanStatistics.UpdateStatistics(greyScale, greyScale);

            _formHistogramDanStatistics.Show();
        }

        void UpdateHistogramDanStatistics(bool onlyHasilChanged)
        {
            var greyScale = new Bitmap(pictureBoxGrayScale.Image);
            var hasil = new Bitmap(pictureBoxHasil.Image);

            if (_formHistogramDanStatistics.IsDisposed)
            {
                onlyHasilChanged = false;
                _formHistogramDanStatistics = new FormHistogramDanStatistics();
                _formHistogramDanStatistics.Show();
            }

            _formHistogramDanStatistics.UpdateHistogram(greyScale, hasil, onlyHasilChanged);
            _formHistogramDanStatistics.UpdateStatistics(greyScale, hasil, onlyHasilChanged);
        }
        
        private async void buttonOpenImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap greyScale = new Bitmap(bmp.Width, bmp.Height);

                progressBar1.Enabled = true;
                progressBar1.Visible = true;

                await Task.Run(() => greyScale = ImageProcessing.MakeGreyScale(bmp));

                progressBar1.Enabled = false;
                progressBar1.Visible = false;

                pictureBoxAsli.Image = bmp;
                pictureBoxGrayScale.Image = greyScale;
                pictureBoxHasil.Image = greyScale;

                UpdateHistogramDanStatistics(false);
            }
        }

        private async void buttonTransform_Click(object sender, EventArgs e)
        {
            if(_currentStrategy != null)
            {
                var hasil = new Bitmap(1, 1);

                progressBar1.Enabled = true;
                progressBar1.Visible = true;
                tableLayoutPanel1.Enabled = false;

                hasil = await _currentStrategy.Transform();

                progressBar1.Enabled = false;
                progressBar1.Visible = false;
                tableLayoutPanel1.Enabled = true;

                pictureBoxHasil.Image = hasil;

                UpdateHistogramDanStatistics(true);
            }
        }

        private void radioButtonNegatif_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNegatif.Checked == true)
                _currentStrategy = new NegativeStrategy(this);
        }

        private void radioButtonLog_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLog.Checked == true)
                _currentStrategy = new LogStrategy(this);
        }

        private void radioButtonPower_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPower.Checked == true)
                _currentStrategy = new PowerStrategy(this);
        }

        private void radioButtonHistogramEq_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonHistogramEq.Checked == true)
                _currentStrategy = new HistogramEqStrategy(this);
        }

        private void radioButtonConstrastS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConstrastS.Checked == true)
                _currentStrategy = new ContrastStrechingStrategy(this);
        }

        private void radioButtonPieceWise_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPieceWise.Checked == true)
                _currentStrategy = new PieceWiseStrategy(this);
        }

        private void radioButtonGraySplit_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonGraySplit.Checked == true)
                _currentStrategy = new GrayLevelSplitStrategy(this);
        }

        private void radioButtonBitSplit_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonBitSplit.Checked == true)
                _currentStrategy = new BitPlaneSlicingStrategy(this);
        }

        private void radioButtonRBGSplit_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonRBGSplit.Checked == true)
                _currentStrategy = new RBGSplitStrategy(this);
        }

        private void radioButtonOtsu_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonOtsu.Checked == true)
                _currentStrategy = new OtsuThresholdingStrategy(this);
        }

        private void radioButtonEuclidDist_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEuclidDist.Checked == true)
                _currentStrategy = new EuclidDistStrategy(this);
        }

        private void radioButtonKMeans_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonKMeans.Checked == true)
                _currentStrategy = new KMeansStrategy(this);
        }

        private void radioButtonKMeansLab_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKMeansLab.Checked == true)
                _currentStrategy = new KMeansLabStrategy(this);
        }

        private void radioButtonDilasi_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDilasi.Checked == true)
                _currentStrategy = new DilasiStrategy(this);
        }

        private void radioButtonErosi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonErosi.Checked == true)
                _currentStrategy = new ErosiStrategy(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap hasil = new Bitmap(pictureBoxHasil.Image);
                hasil.Save(saveFileDialog1.FileName);
            }
        }

        private void radioButtonOpening_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpening.Checked == true)
                _currentStrategy = new OpeningStrategy(this);
        }

        private void radioButtonClosing_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClosing.Checked == true)
                _currentStrategy = new ClosingStrategy(this);
        }

        private void radioButtonWatershed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWatershed.Checked == true)
                _currentStrategy = new WatershedStrategy(this);
        }

        private void radioButtonAdaptMeanThreshold_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdaptMeanThreshold.Checked == true)
                _currentStrategy = new AdaptMeanThresholdStrategy(this);
        }

        private void radioButtonKMeansHsv_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKMeansHsv.Checked == true)
                _currentStrategy = new KMeansHsvStrategy(this);
        }

        private void radioButtonColorConstancy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonColorConstancy.Checked == true)
                _currentStrategy = new ColorConstancyStrategy(this);
        }

        private void radioButtonSharpeningLaplacian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSharpeningLaplacian.Checked == true)
                _currentStrategy = new SharpeningLaplacianStrategy(this);
        }

        private void radioButtonOtsuCv_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOtsuCv.Checked == true)
                _currentStrategy = new OtsuCvStrategy(this);
        }

        private void radioButtonGaussianBlur_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGaussianBlur.Checked == true)
                _currentStrategy = new GaussianBlurStrategy(this);
        }

        private void radioButtonGreenSegmentation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreenSegmentation.Checked == true)
                _currentStrategy = new GreenSegmentationStrategy(this);
        }

        private void radioButtonSobel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSobel.Checked == true)
                _currentStrategy = new SobelStrategy(this);
        }

        private void radioButtonPreProcessing_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPreProcessing.Checked == true)
                _currentStrategy = new PreProcessingStrategy(this);
        }

        private void radioButtonCanny_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCanny.Checked == true)
                _currentStrategy = new CannyStrategy(this);
        }

        private void radioButtonColorCorrection_CheckedChanged(object sender, EventArgs e)
        {
            if ( radioButtonColorCorrection.Checked == true)
                _currentStrategy = new ColorCorrectionStrategy(this);
        }

        private void radioButtonHSVColorSegmentation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHSVColorSegmentation.Checked == true)
                _currentStrategy = new HSVColorSegmentationStrategy(this);
        }

        private void radioButtonBlobDetection_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlobDetection.Checked == true)
                _currentStrategy = new BlobDetectionStrategy(this);
        }

        private void radioButtonHitungLuas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHitungLuas.Checked == true)
                _currentStrategy = new HitungLuasStrategy(this);
        }
    }
}