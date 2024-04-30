namespace OlahCitra
{
    partial class FormOlahCitra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOlahCitra));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonSharpeningLaplacian = new System.Windows.Forms.RadioButton();
            this.radioButtonColorConstancy = new System.Windows.Forms.RadioButton();
            this.radioButtonKMeansHsv = new System.Windows.Forms.RadioButton();
            this.radioButtonAdaptMeanThreshold = new System.Windows.Forms.RadioButton();
            this.radioButtonWatershed = new System.Windows.Forms.RadioButton();
            this.radioButtonClosing = new System.Windows.Forms.RadioButton();
            this.radioButtonOpening = new System.Windows.Forms.RadioButton();
            this.radioButtonErosi = new System.Windows.Forms.RadioButton();
            this.radioButtonDilasi = new System.Windows.Forms.RadioButton();
            this.radioButtonKMeansLab = new System.Windows.Forms.RadioButton();
            this.radioButtonKMeans = new System.Windows.Forms.RadioButton();
            this.radioButtonEuclidDist = new System.Windows.Forms.RadioButton();
            this.radioButtonOtsu = new System.Windows.Forms.RadioButton();
            this.radioButtonRBGSplit = new System.Windows.Forms.RadioButton();
            this.radioButtonBitSplit = new System.Windows.Forms.RadioButton();
            this.radioButtonGraySplit = new System.Windows.Forms.RadioButton();
            this.radioButtonPieceWise = new System.Windows.Forms.RadioButton();
            this.radioButtonConstrastS = new System.Windows.Forms.RadioButton();
            this.radioButtonHistogramEq = new System.Windows.Forms.RadioButton();
            this.radioButtonPower = new System.Windows.Forms.RadioButton();
            this.radioButtonLog = new System.Windows.Forms.RadioButton();
            this.radioButtonNegatif = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonOtsuCv = new System.Windows.Forms.RadioButton();
            this.pictureBoxAsli = new OlahCitra.CustomControl.CustomPictureBox();
            this.pictureBoxHasil = new OlahCitra.CustomControl.CustomPictureBox();
            this.pictureBoxGrayScale = new OlahCitra.CustomControl.CustomPictureBox();
            this.radioButtonGaussianBlur = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.060606F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 544);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxAsli);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto Asli";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxHasil);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(682, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 323);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasil Transformasi";
            // 
            // groupBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 3);
            this.groupBox4.Controls.Add(this.radioButtonGaussianBlur);
            this.groupBox4.Controls.Add(this.radioButtonOtsuCv);
            this.groupBox4.Controls.Add(this.radioButtonSharpeningLaplacian);
            this.groupBox4.Controls.Add(this.radioButtonColorConstancy);
            this.groupBox4.Controls.Add(this.radioButtonKMeansHsv);
            this.groupBox4.Controls.Add(this.radioButtonAdaptMeanThreshold);
            this.groupBox4.Controls.Add(this.radioButtonWatershed);
            this.groupBox4.Controls.Add(this.radioButtonClosing);
            this.groupBox4.Controls.Add(this.radioButtonOpening);
            this.groupBox4.Controls.Add(this.radioButtonErosi);
            this.groupBox4.Controls.Add(this.radioButtonDilasi);
            this.groupBox4.Controls.Add(this.radioButtonKMeansLab);
            this.groupBox4.Controls.Add(this.radioButtonKMeans);
            this.groupBox4.Controls.Add(this.radioButtonEuclidDist);
            this.groupBox4.Controls.Add(this.radioButtonOtsu);
            this.groupBox4.Controls.Add(this.radioButtonRBGSplit);
            this.groupBox4.Controls.Add(this.radioButtonBitSplit);
            this.groupBox4.Controls.Add(this.radioButtonGraySplit);
            this.groupBox4.Controls.Add(this.radioButtonPieceWise);
            this.groupBox4.Controls.Add(this.radioButtonConstrastS);
            this.groupBox4.Controls.Add(this.radioButtonHistogramEq);
            this.groupBox4.Controls.Add(this.radioButtonPower);
            this.groupBox4.Controls.Add(this.radioButtonLog);
            this.groupBox4.Controls.Add(this.radioButtonNegatif);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1014, 177);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transformasi";
            // 
            // radioButtonSharpeningLaplacian
            // 
            this.radioButtonSharpeningLaplacian.AutoSize = true;
            this.radioButtonSharpeningLaplacian.Location = new System.Drawing.Point(748, 43);
            this.radioButtonSharpeningLaplacian.Name = "radioButtonSharpeningLaplacian";
            this.radioButtonSharpeningLaplacian.Size = new System.Drawing.Size(134, 17);
            this.radioButtonSharpeningLaplacian.TabIndex = 28;
            this.radioButtonSharpeningLaplacian.TabStop = true;
            this.radioButtonSharpeningLaplacian.Text = "Sharpening (Laplacian)";
            this.radioButtonSharpeningLaplacian.UseVisualStyleBackColor = true;
            this.radioButtonSharpeningLaplacian.CheckedChanged += new System.EventHandler(this.radioButtonSharpeningLaplacian_CheckedChanged);
            // 
            // radioButtonColorConstancy
            // 
            this.radioButtonColorConstancy.AutoSize = true;
            this.radioButtonColorConstancy.Location = new System.Drawing.Point(748, 19);
            this.radioButtonColorConstancy.Name = "radioButtonColorConstancy";
            this.radioButtonColorConstancy.Size = new System.Drawing.Size(102, 17);
            this.radioButtonColorConstancy.TabIndex = 27;
            this.radioButtonColorConstancy.TabStop = true;
            this.radioButtonColorConstancy.Text = "Color Constancy";
            this.radioButtonColorConstancy.UseVisualStyleBackColor = true;
            this.radioButtonColorConstancy.CheckedChanged += new System.EventHandler(this.radioButtonColorConstancy_CheckedChanged);
            // 
            // radioButtonKMeansHsv
            // 
            this.radioButtonKMeansHsv.AutoSize = true;
            this.radioButtonKMeansHsv.Location = new System.Drawing.Point(593, 111);
            this.radioButtonKMeansHsv.Name = "radioButtonKMeansHsv";
            this.radioButtonKMeansHsv.Size = new System.Drawing.Size(92, 17);
            this.radioButtonKMeansHsv.TabIndex = 26;
            this.radioButtonKMeansHsv.TabStop = true;
            this.radioButtonKMeansHsv.Text = "K-Means HSV";
            this.radioButtonKMeansHsv.UseVisualStyleBackColor = true;
            this.radioButtonKMeansHsv.CheckedChanged += new System.EventHandler(this.radioButtonKMeansHsv_CheckedChanged);
            // 
            // radioButtonAdaptMeanThreshold
            // 
            this.radioButtonAdaptMeanThreshold.AutoSize = true;
            this.radioButtonAdaptMeanThreshold.Location = new System.Drawing.Point(593, 88);
            this.radioButtonAdaptMeanThreshold.Name = "radioButtonAdaptMeanThreshold";
            this.radioButtonAdaptMeanThreshold.Size = new System.Drawing.Size(147, 17);
            this.radioButtonAdaptMeanThreshold.TabIndex = 25;
            this.radioButtonAdaptMeanThreshold.TabStop = true;
            this.radioButtonAdaptMeanThreshold.Text = "Adaptive Mean Threshold";
            this.radioButtonAdaptMeanThreshold.UseVisualStyleBackColor = true;
            this.radioButtonAdaptMeanThreshold.CheckedChanged += new System.EventHandler(this.radioButtonAdaptMeanThreshold_CheckedChanged);
            // 
            // radioButtonWatershed
            // 
            this.radioButtonWatershed.AutoSize = true;
            this.radioButtonWatershed.Location = new System.Drawing.Point(593, 65);
            this.radioButtonWatershed.Name = "radioButtonWatershed";
            this.radioButtonWatershed.Size = new System.Drawing.Size(77, 17);
            this.radioButtonWatershed.TabIndex = 24;
            this.radioButtonWatershed.TabStop = true;
            this.radioButtonWatershed.Text = "Watershed";
            this.radioButtonWatershed.UseVisualStyleBackColor = true;
            this.radioButtonWatershed.CheckedChanged += new System.EventHandler(this.radioButtonWatershed_CheckedChanged);
            // 
            // radioButtonClosing
            // 
            this.radioButtonClosing.AutoSize = true;
            this.radioButtonClosing.Location = new System.Drawing.Point(593, 42);
            this.radioButtonClosing.Name = "radioButtonClosing";
            this.radioButtonClosing.Size = new System.Drawing.Size(59, 17);
            this.radioButtonClosing.TabIndex = 23;
            this.radioButtonClosing.TabStop = true;
            this.radioButtonClosing.Text = "Closing";
            this.radioButtonClosing.UseVisualStyleBackColor = true;
            this.radioButtonClosing.CheckedChanged += new System.EventHandler(this.radioButtonClosing_CheckedChanged);
            // 
            // radioButtonOpening
            // 
            this.radioButtonOpening.AutoSize = true;
            this.radioButtonOpening.Location = new System.Drawing.Point(593, 20);
            this.radioButtonOpening.Name = "radioButtonOpening";
            this.radioButtonOpening.Size = new System.Drawing.Size(65, 17);
            this.radioButtonOpening.TabIndex = 22;
            this.radioButtonOpening.TabStop = true;
            this.radioButtonOpening.Text = "Opening";
            this.radioButtonOpening.UseVisualStyleBackColor = true;
            this.radioButtonOpening.CheckedChanged += new System.EventHandler(this.radioButtonOpening_CheckedChanged);
            // 
            // radioButtonErosi
            // 
            this.radioButtonErosi.AutoSize = true;
            this.radioButtonErosi.Location = new System.Drawing.Point(388, 111);
            this.radioButtonErosi.Name = "radioButtonErosi";
            this.radioButtonErosi.Size = new System.Drawing.Size(48, 17);
            this.radioButtonErosi.TabIndex = 21;
            this.radioButtonErosi.TabStop = true;
            this.radioButtonErosi.Text = "Erosi";
            this.radioButtonErosi.UseVisualStyleBackColor = true;
            this.radioButtonErosi.CheckedChanged += new System.EventHandler(this.radioButtonErosi_CheckedChanged);
            // 
            // radioButtonDilasi
            // 
            this.radioButtonDilasi.AutoSize = true;
            this.radioButtonDilasi.Location = new System.Drawing.Point(388, 88);
            this.radioButtonDilasi.Name = "radioButtonDilasi";
            this.radioButtonDilasi.Size = new System.Drawing.Size(50, 17);
            this.radioButtonDilasi.TabIndex = 20;
            this.radioButtonDilasi.TabStop = true;
            this.radioButtonDilasi.Text = "Dilasi";
            this.radioButtonDilasi.UseVisualStyleBackColor = true;
            this.radioButtonDilasi.CheckedChanged += new System.EventHandler(this.radioButtonDilasi_CheckedChanged);
            // 
            // radioButtonKMeansLab
            // 
            this.radioButtonKMeansLab.AutoSize = true;
            this.radioButtonKMeansLab.Location = new System.Drawing.Point(388, 65);
            this.radioButtonKMeansLab.Name = "radioButtonKMeansLab";
            this.radioButtonKMeansLab.Size = new System.Drawing.Size(103, 17);
            this.radioButtonKMeansLab.TabIndex = 19;
            this.radioButtonKMeansLab.TabStop = true;
            this.radioButtonKMeansLab.Text = "K-Means CieLab";
            this.radioButtonKMeansLab.UseVisualStyleBackColor = true;
            this.radioButtonKMeansLab.CheckedChanged += new System.EventHandler(this.radioButtonKMeansLab_CheckedChanged);
            // 
            // radioButtonKMeans
            // 
            this.radioButtonKMeans.AutoSize = true;
            this.radioButtonKMeans.Location = new System.Drawing.Point(388, 43);
            this.radioButtonKMeans.Name = "radioButtonKMeans";
            this.radioButtonKMeans.Size = new System.Drawing.Size(67, 17);
            this.radioButtonKMeans.TabIndex = 18;
            this.radioButtonKMeans.TabStop = true;
            this.radioButtonKMeans.Text = "K-Means";
            this.radioButtonKMeans.UseVisualStyleBackColor = true;
            this.radioButtonKMeans.CheckedChanged += new System.EventHandler(this.radioButtonKMeans_CheckedChanged);
            // 
            // radioButtonEuclidDist
            // 
            this.radioButtonEuclidDist.AutoSize = true;
            this.radioButtonEuclidDist.Location = new System.Drawing.Point(388, 20);
            this.radioButtonEuclidDist.Name = "radioButtonEuclidDist";
            this.radioButtonEuclidDist.Size = new System.Drawing.Size(199, 17);
            this.radioButtonEuclidDist.TabIndex = 17;
            this.radioButtonEuclidDist.TabStop = true;
            this.radioButtonEuclidDist.Text = "Ecluid Distance Segmentation (RGB)";
            this.radioButtonEuclidDist.UseVisualStyleBackColor = true;
            this.radioButtonEuclidDist.CheckedChanged += new System.EventHandler(this.radioButtonEuclidDist_CheckedChanged);
            // 
            // radioButtonOtsu
            // 
            this.radioButtonOtsu.AutoSize = true;
            this.radioButtonOtsu.Location = new System.Drawing.Point(173, 111);
            this.radioButtonOtsu.Name = "radioButtonOtsu";
            this.radioButtonOtsu.Size = new System.Drawing.Size(111, 17);
            this.radioButtonOtsu.TabIndex = 16;
            this.radioButtonOtsu.TabStop = true;
            this.radioButtonOtsu.Text = "Otsu Thresholding";
            this.radioButtonOtsu.UseVisualStyleBackColor = true;
            this.radioButtonOtsu.CheckedChanged += new System.EventHandler(this.radioButtonOtsu_CheckedChanged);
            // 
            // radioButtonRBGSplit
            // 
            this.radioButtonRBGSplit.AutoSize = true;
            this.radioButtonRBGSplit.Location = new System.Drawing.Point(173, 88);
            this.radioButtonRBGSplit.Name = "radioButtonRBGSplit";
            this.radioButtonRBGSplit.Size = new System.Drawing.Size(202, 17);
            this.radioButtonRBGSplit.TabIndex = 15;
            this.radioButtonRBGSplit.TabStop = true;
            this.radioButtonRBGSplit.Text = "Pisah menjadi komponen R, G, dan B";
            this.radioButtonRBGSplit.UseVisualStyleBackColor = true;
            this.radioButtonRBGSplit.CheckedChanged += new System.EventHandler(this.radioButtonRBGSplit_CheckedChanged);
            // 
            // radioButtonBitSplit
            // 
            this.radioButtonBitSplit.AutoSize = true;
            this.radioButtonBitSplit.Location = new System.Drawing.Point(173, 65);
            this.radioButtonBitSplit.Name = "radioButtonBitSplit";
            this.radioButtonBitSplit.Size = new System.Drawing.Size(101, 17);
            this.radioButtonBitSplit.TabIndex = 14;
            this.radioButtonBitSplit.TabStop = true;
            this.radioButtonBitSplit.Text = "Bit Plane Slicing";
            this.radioButtonBitSplit.UseVisualStyleBackColor = true;
            this.radioButtonBitSplit.CheckedChanged += new System.EventHandler(this.radioButtonBitSplit_CheckedChanged);
            // 
            // radioButtonGraySplit
            // 
            this.radioButtonGraySplit.AutoSize = true;
            this.radioButtonGraySplit.Location = new System.Drawing.Point(173, 42);
            this.radioButtonGraySplit.Name = "radioButtonGraySplit";
            this.radioButtonGraySplit.Size = new System.Drawing.Size(116, 17);
            this.radioButtonGraySplit.TabIndex = 12;
            this.radioButtonGraySplit.TabStop = true;
            this.radioButtonGraySplit.Text = "Gray Level Splitting";
            this.radioButtonGraySplit.UseVisualStyleBackColor = true;
            this.radioButtonGraySplit.CheckedChanged += new System.EventHandler(this.radioButtonGraySplit_CheckedChanged);
            // 
            // radioButtonPieceWise
            // 
            this.radioButtonPieceWise.AutoSize = true;
            this.radioButtonPieceWise.Location = new System.Drawing.Point(173, 19);
            this.radioButtonPieceWise.Name = "radioButtonPieceWise";
            this.radioButtonPieceWise.Size = new System.Drawing.Size(184, 17);
            this.radioButtonPieceWise.TabIndex = 10;
            this.radioButtonPieceWise.TabStop = true;
            this.radioButtonPieceWise.Text = "Piece Wise Linear Transformation";
            this.radioButtonPieceWise.UseVisualStyleBackColor = true;
            this.radioButtonPieceWise.CheckedChanged += new System.EventHandler(this.radioButtonPieceWise_CheckedChanged);
            // 
            // radioButtonConstrastS
            // 
            this.radioButtonConstrastS.AutoSize = true;
            this.radioButtonConstrastS.Location = new System.Drawing.Point(9, 111);
            this.radioButtonConstrastS.Name = "radioButtonConstrastS";
            this.radioButtonConstrastS.Size = new System.Drawing.Size(112, 17);
            this.radioButtonConstrastS.TabIndex = 9;
            this.radioButtonConstrastS.TabStop = true;
            this.radioButtonConstrastS.Text = "Contrast Streching";
            this.radioButtonConstrastS.UseVisualStyleBackColor = true;
            this.radioButtonConstrastS.CheckedChanged += new System.EventHandler(this.radioButtonConstrastS_CheckedChanged);
            // 
            // radioButtonHistogramEq
            // 
            this.radioButtonHistogramEq.AutoSize = true;
            this.radioButtonHistogramEq.Location = new System.Drawing.Point(9, 88);
            this.radioButtonHistogramEq.Name = "radioButtonHistogramEq";
            this.radioButtonHistogramEq.Size = new System.Drawing.Size(132, 17);
            this.radioButtonHistogramEq.TabIndex = 8;
            this.radioButtonHistogramEq.TabStop = true;
            this.radioButtonHistogramEq.Text = "Histogram Equalization";
            this.radioButtonHistogramEq.UseVisualStyleBackColor = true;
            this.radioButtonHistogramEq.CheckedChanged += new System.EventHandler(this.radioButtonHistogramEq_CheckedChanged);
            // 
            // radioButtonPower
            // 
            this.radioButtonPower.AutoSize = true;
            this.radioButtonPower.Location = new System.Drawing.Point(9, 65);
            this.radioButtonPower.Name = "radioButtonPower";
            this.radioButtonPower.Size = new System.Drawing.Size(78, 17);
            this.radioButtonPower.TabIndex = 5;
            this.radioButtonPower.TabStop = true;
            this.radioButtonPower.Text = "Power Law";
            this.radioButtonPower.UseVisualStyleBackColor = true;
            this.radioButtonPower.CheckedChanged += new System.EventHandler(this.radioButtonPower_CheckedChanged);
            // 
            // radioButtonLog
            // 
            this.radioButtonLog.AutoSize = true;
            this.radioButtonLog.Location = new System.Drawing.Point(9, 42);
            this.radioButtonLog.Name = "radioButtonLog";
            this.radioButtonLog.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLog.TabIndex = 4;
            this.radioButtonLog.TabStop = true;
            this.radioButtonLog.Text = "Log";
            this.radioButtonLog.UseVisualStyleBackColor = true;
            this.radioButtonLog.CheckedChanged += new System.EventHandler(this.radioButtonLog_CheckedChanged);
            // 
            // radioButtonNegatif
            // 
            this.radioButtonNegatif.AutoSize = true;
            this.radioButtonNegatif.Location = new System.Drawing.Point(9, 19);
            this.radioButtonNegatif.Name = "radioButtonNegatif";
            this.radioButtonNegatif.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNegatif.TabIndex = 3;
            this.radioButtonNegatif.TabStop = true;
            this.radioButtonNegatif.Text = "Negatif";
            this.radioButtonNegatif.UseVisualStyleBackColor = true;
            this.radioButtonNegatif.CheckedChanged += new System.EventHandler(this.radioButtonNegatif_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(3, 148);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1008, 26);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 100;
            this.progressBar1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxGrayScale);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(342, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 323);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gray Scale";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonTransform);
            this.panel1.Controls.Add(this.buttonOpenImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 26);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransform.Location = new System.Drawing.Point(913, 3);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(92, 23);
            this.buttonTransform.TabIndex = 3;
            this.buttonTransform.Text = "Transform";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(9, 3);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(92, 23);
            this.buttonOpenImage.TabIndex = 0;
            this.buttonOpenImage.Text = "Open";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.png;*.gif|JPEG files|*.jpeg|PNG files|*.png|All " +
    "files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image Files|*.jpg|JPEG files|*.jpeg|All files|*.*";
            // 
            // radioButtonOtsuCv
            // 
            this.radioButtonOtsuCv.AutoSize = true;
            this.radioButtonOtsuCv.Location = new System.Drawing.Point(748, 65);
            this.radioButtonOtsuCv.Name = "radioButtonOtsuCv";
            this.radioButtonOtsuCv.Size = new System.Drawing.Size(163, 17);
            this.radioButtonOtsuCv.TabIndex = 29;
            this.radioButtonOtsuCv.TabStop = true;
            this.radioButtonOtsuCv.Text = "Ostu Thresholding (Open CV)";
            this.radioButtonOtsuCv.UseVisualStyleBackColor = true;
            this.radioButtonOtsuCv.CheckedChanged += new System.EventHandler(this.radioButtonOtsuCv_CheckedChanged);
            // 
            // pictureBoxAsli
            // 
            this.pictureBoxAsli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAsli.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBoxAsli.Image")));
            this.pictureBoxAsli.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxAsli.Name = "pictureBoxAsli";
            this.pictureBoxAsli.Size = new System.Drawing.Size(327, 304);
            this.pictureBoxAsli.TabIndex = 0;
            this.pictureBoxAsli.Title = "Foto Asli";
            // 
            // pictureBoxHasil
            // 
            this.pictureBoxHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHasil.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBoxHasil.Image")));
            this.pictureBoxHasil.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxHasil.Name = "pictureBoxHasil";
            this.pictureBoxHasil.Size = new System.Drawing.Size(329, 304);
            this.pictureBoxHasil.TabIndex = 0;
            this.pictureBoxHasil.Title = "Hasil Transformasi";
            // 
            // pictureBoxGrayScale
            // 
            this.pictureBoxGrayScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGrayScale.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBoxGrayScale.Image")));
            this.pictureBoxGrayScale.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxGrayScale.Name = "pictureBoxGrayScale";
            this.pictureBoxGrayScale.Size = new System.Drawing.Size(328, 304);
            this.pictureBoxGrayScale.TabIndex = 0;
            this.pictureBoxGrayScale.Title = "Grey Scale";
            // 
            // radioButtonGaussianBlur
            // 
            this.radioButtonGaussianBlur.AutoSize = true;
            this.radioButtonGaussianBlur.Location = new System.Drawing.Point(746, 88);
            this.radioButtonGaussianBlur.Name = "radioButtonGaussianBlur";
            this.radioButtonGaussianBlur.Size = new System.Drawing.Size(90, 17);
            this.radioButtonGaussianBlur.TabIndex = 30;
            this.radioButtonGaussianBlur.TabStop = true;
            this.radioButtonGaussianBlur.Text = "Gaussian Blur";
            this.radioButtonGaussianBlur.UseVisualStyleBackColor = true;
            this.radioButtonGaussianBlur.CheckedChanged += new System.EventHandler(this.radioButtonGaussianBlur_CheckedChanged);
            // 
            // FormOlahCitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormOlahCitra";
            this.Text = "Pengolahan Citra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButtonNegatif;
        private System.Windows.Forms.RadioButton radioButtonLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.RadioButton radioButtonPower;
        private System.Windows.Forms.RadioButton radioButtonHistogramEq;
        private System.Windows.Forms.RadioButton radioButtonConstrastS;
        private System.Windows.Forms.RadioButton radioButtonPieceWise;
        private System.Windows.Forms.RadioButton radioButtonGraySplit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton radioButtonBitSplit;
        private CustomControl.CustomPictureBox pictureBoxAsli;
        private CustomControl.CustomPictureBox pictureBoxGrayScale;
        private CustomControl.CustomPictureBox pictureBoxHasil;
        private System.Windows.Forms.RadioButton radioButtonRBGSplit;
        private System.Windows.Forms.RadioButton radioButtonOtsu;
        private System.Windows.Forms.RadioButton radioButtonEuclidDist;
        private System.Windows.Forms.RadioButton radioButtonKMeans;
        private System.Windows.Forms.RadioButton radioButtonKMeansLab;
        private System.Windows.Forms.RadioButton radioButtonDilasi;
        private System.Windows.Forms.RadioButton radioButtonErosi;
        private System.Windows.Forms.RadioButton radioButtonOpening;
        private System.Windows.Forms.RadioButton radioButtonClosing;
        private System.Windows.Forms.RadioButton radioButtonWatershed;
        private System.Windows.Forms.RadioButton radioButtonAdaptMeanThreshold;
        private System.Windows.Forms.RadioButton radioButtonKMeansHsv;
        private System.Windows.Forms.RadioButton radioButtonColorConstancy;
        private System.Windows.Forms.RadioButton radioButtonSharpeningLaplacian;
        private System.Windows.Forms.RadioButton radioButtonOtsuCv;
        private System.Windows.Forms.RadioButton radioButtonGaussianBlur;
    }
}

