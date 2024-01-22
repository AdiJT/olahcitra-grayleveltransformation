using OlahCitra.Core;
using OlahCitra.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra
{
    public partial class OlahCitra : Form
    {
        private TransformationStrategy _currentStrategy;

        public Bitmap GreyScaleImage { get => new Bitmap(pictureBoxGrayScale.Image); }

        public double Gamma { get => double.Parse(textBoxGamma.Text); }

        public (int, int) PieceWisePoint1 { get => ((int)numericUpDownR1.Value, (int)numericUpDownS1.Value); }
        public (int, int) PieceWisePoint2 { get => ((int)numericUpDownR2.Value, (int)numericUpDownS2.Value); }

        public (int, int) GrayLevelSplitRange { get => ((int)numericUpDownGraySplitR1.Value, (int)numericUpDownGraySplitR2.Value); }
        public int GraySplitMaxGray { get => (int)numericUpDownGraySplitMax.Value; }
        public int GraySplitMinGray { get => (int)numericUpDownGraySplitMin.Value; }
        public bool GraySplitMantainBackground { get => checkBoxMaintan.Checked; }

        public int BitPlane { get => (int)numericUpDownBItPlane.Value; }

        private FormHistogram formHistogramGreyScale = new FormHistogram(); 
        private FormHistogram formHistogramHasil = new FormHistogram(); 

        private FormStatistics formStatisticsGreyScale = new FormStatistics();
        private FormStatistics formStatisticsHasil = new FormStatistics();

        public OlahCitra()
        {
            InitializeComponent();

            var greyScale = new Bitmap(pictureBoxGrayScale.Image);

            formHistogramGreyScale.Title = "Histogram Gambar GreyScale";
            formHistogramHasil.Title = "Histogram Gambar Hasil Transformasi";

            formHistogramGreyScale.Image = greyScale;
            formHistogramHasil.Image = greyScale;

            formHistogramGreyScale.Show();
            formHistogramHasil.Show();

            formStatisticsGreyScale.Title = "Statistik Gambar GreyScale";
            formStatisticsHasil.Title = "Statistik Gambar Hasil Transformasi";

            formStatisticsGreyScale.Statistics = ImageProcessing.MakeStatistic(greyScale);
            formStatisticsHasil.Statistics = ImageProcessing.MakeStatistic(greyScale);

            formStatisticsGreyScale.Show();
            formStatisticsHasil.Show();
        }

        async void UpdateStatistics(bool onlyHasilChanged)
        {
            var greyScale = new Bitmap(pictureBoxGrayScale.Image);
            var hasil = new Bitmap(pictureBoxHasil.Image);

            ImageStatistics greyScaleStatistics = new ImageStatistics();
            ImageStatistics hasilStatistics = new ImageStatistics();

            if (onlyHasilChanged == false)
            {
                if (formStatisticsGreyScale.IsDisposed)
                {
                    formStatisticsGreyScale = new FormStatistics();
                    formStatisticsGreyScale.Title = "Statistik Gambar GreyScale";
                    formStatisticsGreyScale.Show();
                }

                formStatisticsGreyScale.Enabled = false;
                await Task.Run(() => greyScaleStatistics = ImageProcessing.MakeStatistic(greyScale));
                formStatisticsGreyScale.Statistics = greyScaleStatistics;
                formStatisticsGreyScale.Enabled = true;
            }

            if (formStatisticsHasil.IsDisposed)
            {
                formStatisticsHasil = new FormStatistics();
                formStatisticsHasil.Title = "Statistik Gambar Hasil Transformasi";
                formStatisticsHasil.Show();
            }

            formStatisticsHasil.Enabled = false;
            await Task.Run(() => hasilStatistics = ImageProcessing.MakeStatistic(hasil));
            formStatisticsHasil.Enabled = true;

            formStatisticsHasil.Statistics = hasilStatistics;
        }

        void UpdateHistogram(bool onlyHasilChanged)
        {
            if (onlyHasilChanged == false)
            {
                if (formHistogramGreyScale.IsDisposed)
                {
                    formHistogramGreyScale = new FormHistogram();
                    formHistogramGreyScale.Title = "Histogram Gambar GreyScale";
                    formHistogramGreyScale.Show();
                }

                formHistogramGreyScale.Image = new Bitmap(pictureBoxGrayScale.Image);
            }

            if (formHistogramHasil.IsDisposed)
            {
                formHistogramHasil = new FormHistogram();
                formHistogramHasil.Title = "Histogram Gambar Hasil Transformasi";
                formHistogramHasil.Show();
            }

            formHistogramHasil.Image = new Bitmap(pictureBoxHasil.Image);
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

                UpdateHistogram(false);
                UpdateStatistics(false);
            }
        }

        private void radioButtonNegatif_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNegatif.Checked == true)
                _currentStrategy = new NegativeStrategy(this);
        }

        private async void buttonTransform_Click(object sender, EventArgs e)
        {
            if(_currentStrategy != null)
            {
                var hasil = new Bitmap(1, 1);

                progressBar1.Enabled = true;
                progressBar1.Visible = true;
                tableLayoutPanel1.Enabled = false;

                await Task.Run(() => hasil = _currentStrategy.Transform());

                progressBar1.Enabled = false;
                progressBar1.Visible = false;
                tableLayoutPanel1.Enabled = true;

                pictureBoxHasil.Image = hasil;

                UpdateHistogram(true);
                UpdateStatistics(true);
            }
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

            labelGamma.Enabled = radioButtonPower.Checked;
            textBoxGamma.Enabled = radioButtonPower.Checked;
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

            tableLayoutPanelPieceWise.Enabled = radioButtonPieceWise.Checked;
        }

        private void radioButtonGraySplit_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonGraySplit.Checked == true)
                _currentStrategy = new GrayLevelSplitStrategy(this);

             tableLayoutPanelGraySplit.Enabled = radioButtonGraySplit.Checked;
        }

        private void checkBoxMaintan_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownGraySplitMin.Enabled = !checkBoxMaintan.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap hasil = new Bitmap(pictureBoxHasil.Image);
                hasil.Save(saveFileDialog1.FileName);
            }
        }

        private void radioButtonBitSplit_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonBitSplit.Checked == true)
                _currentStrategy = new BitPlaneSlicingStrategy(this);

            numericUpDownBItPlane.Enabled = radioButtonBitSplit.Checked;
        }
    }
}
