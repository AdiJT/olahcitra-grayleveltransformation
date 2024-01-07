namespace OlahCitra
{
    partial class OlahCitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlahCitra));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxAsli = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxHasil = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonConstrastS = new System.Windows.Forms.RadioButton();
            this.radioButtonHistogramEq = new System.Windows.Forms.RadioButton();
            this.labelGamma = new System.Windows.Forms.Label();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.radioButtonPower = new System.Windows.Forms.RadioButton();
            this.radioButtonLog = new System.Windows.Forms.RadioButton();
            this.radioButtonNegatif = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxGrayScale = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButtonPieceWise = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelPieceWise = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownR1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownR2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownS2 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsli)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHasil)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayScale)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelPieceWise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS2)).BeginInit();
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
            // pictureBoxAsli
            // 
            this.pictureBoxAsli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAsli.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAsli.Image")));
            this.pictureBoxAsli.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxAsli.Name = "pictureBoxAsli";
            this.pictureBoxAsli.Size = new System.Drawing.Size(327, 304);
            this.pictureBoxAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAsli.TabIndex = 2;
            this.pictureBoxAsli.TabStop = false;
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
            // pictureBoxHasil
            // 
            this.pictureBoxHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHasil.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxHasil.Name = "pictureBoxHasil";
            this.pictureBoxHasil.Size = new System.Drawing.Size(329, 304);
            this.pictureBoxHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHasil.TabIndex = 1;
            this.pictureBoxHasil.TabStop = false;
            // 
            // groupBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 3);
            this.groupBox4.Controls.Add(this.tableLayoutPanelPieceWise);
            this.groupBox4.Controls.Add(this.radioButtonPieceWise);
            this.groupBox4.Controls.Add(this.radioButtonConstrastS);
            this.groupBox4.Controls.Add(this.radioButtonHistogramEq);
            this.groupBox4.Controls.Add(this.labelGamma);
            this.groupBox4.Controls.Add(this.textBoxGamma);
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
            // radioButtonConstrastS
            // 
            this.radioButtonConstrastS.AutoSize = true;
            this.radioButtonConstrastS.Location = new System.Drawing.Point(195, 19);
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
            this.radioButtonHistogramEq.Location = new System.Drawing.Point(9, 111);
            this.radioButtonHistogramEq.Name = "radioButtonHistogramEq";
            this.radioButtonHistogramEq.Size = new System.Drawing.Size(132, 17);
            this.radioButtonHistogramEq.TabIndex = 8;
            this.radioButtonHistogramEq.TabStop = true;
            this.radioButtonHistogramEq.Text = "Histogram Equalization";
            this.radioButtonHistogramEq.UseVisualStyleBackColor = true;
            this.radioButtonHistogramEq.CheckedChanged += new System.EventHandler(this.radioButtonHistogramEq_CheckedChanged);
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Enabled = false;
            this.labelGamma.Location = new System.Drawing.Point(9, 91);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(43, 13);
            this.labelGamma.TabIndex = 7;
            this.labelGamma.Text = "Gamma";
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Enabled = false;
            this.textBoxGamma.Location = new System.Drawing.Point(58, 85);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(100, 20);
            this.textBoxGamma.TabIndex = 6;
            this.textBoxGamma.Text = "1";
            this.textBoxGamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButtonPower
            // 
            this.radioButtonPower.AutoSize = true;
            this.radioButtonPower.Location = new System.Drawing.Point(9, 67);
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
            this.radioButtonLog.Location = new System.Drawing.Point(9, 43);
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
            // pictureBoxGrayScale
            // 
            this.pictureBoxGrayScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGrayScale.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrayScale.Image")));
            this.pictureBoxGrayScale.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxGrayScale.Name = "pictureBoxGrayScale";
            this.pictureBoxGrayScale.Size = new System.Drawing.Size(328, 304);
            this.pictureBoxGrayScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGrayScale.TabIndex = 2;
            this.pictureBoxGrayScale.TabStop = false;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.buttonTransform);
            this.panel1.Controls.Add(this.buttonOpenImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 26);
            this.panel1.TabIndex = 6;
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
            this.openFileDialog1.Filter = "JPEG files|*.jpeg|PNG files|*.png|All files|*.*";
            // 
            // radioButtonPieceWise
            // 
            this.radioButtonPieceWise.AutoSize = true;
            this.radioButtonPieceWise.Location = new System.Drawing.Point(195, 43);
            this.radioButtonPieceWise.Name = "radioButtonPieceWise";
            this.radioButtonPieceWise.Size = new System.Drawing.Size(184, 17);
            this.radioButtonPieceWise.TabIndex = 10;
            this.radioButtonPieceWise.TabStop = true;
            this.radioButtonPieceWise.Text = "Piece Wise Linear Transformation";
            this.radioButtonPieceWise.UseVisualStyleBackColor = true;
            this.radioButtonPieceWise.CheckedChanged += new System.EventHandler(this.radioButtonPieceWise_CheckedChanged);
            // 
            // tableLayoutPanelPieceWise
            // 
            this.tableLayoutPanelPieceWise.ColumnCount = 4;
            this.tableLayoutPanelPieceWise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieceWise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieceWise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieceWise.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPieceWise.Controls.Add(this.numericUpDownS2, 3, 1);
            this.tableLayoutPanelPieceWise.Controls.Add(this.numericUpDownR2, 2, 1);
            this.tableLayoutPanelPieceWise.Controls.Add(this.numericUpDownS1, 1, 1);
            this.tableLayoutPanelPieceWise.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanelPieceWise.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanelPieceWise.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelPieceWise.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelPieceWise.Controls.Add(this.numericUpDownR1, 0, 1);
            this.tableLayoutPanelPieceWise.Enabled = false;
            this.tableLayoutPanelPieceWise.Location = new System.Drawing.Point(195, 67);
            this.tableLayoutPanelPieceWise.Name = "tableLayoutPanelPieceWise";
            this.tableLayoutPanelPieceWise.RowCount = 2;
            this.tableLayoutPanelPieceWise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPieceWise.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPieceWise.Size = new System.Drawing.Size(405, 50);
            this.tableLayoutPanelPieceWise.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "R1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(104, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "S1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(205, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "R2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(306, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "S2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownR1
            // 
            this.numericUpDownR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownR1.Location = new System.Drawing.Point(3, 28);
            this.numericUpDownR1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownR1.Name = "numericUpDownR1";
            this.numericUpDownR1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownR1.TabIndex = 4;
            // 
            // numericUpDownS1
            // 
            this.numericUpDownS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownS1.Location = new System.Drawing.Point(104, 28);
            this.numericUpDownS1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownS1.Name = "numericUpDownS1";
            this.numericUpDownS1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownS1.TabIndex = 5;
            // 
            // numericUpDownR2
            // 
            this.numericUpDownR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownR2.Location = new System.Drawing.Point(205, 28);
            this.numericUpDownR2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownR2.Name = "numericUpDownR2";
            this.numericUpDownR2.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownR2.TabIndex = 6;
            // 
            // numericUpDownS2
            // 
            this.numericUpDownS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownS2.Location = new System.Drawing.Point(306, 28);
            this.numericUpDownS2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownS2.Name = "numericUpDownS2";
            this.numericUpDownS2.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownS2.TabIndex = 7;
            // 
            // OlahCitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 544);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OlahCitra";
            this.Text = "Pengolahan Citra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsli)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHasil)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrayScale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanelPieceWise.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox pictureBoxHasil;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButtonNegatif;
        private System.Windows.Forms.RadioButton radioButtonLog;
        private System.Windows.Forms.PictureBox pictureBoxAsli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.PictureBox pictureBoxGrayScale;
        private System.Windows.Forms.RadioButton radioButtonPower;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.RadioButton radioButtonHistogramEq;
        private System.Windows.Forms.RadioButton radioButtonConstrastS;
        private System.Windows.Forms.RadioButton radioButtonPieceWise;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPieceWise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownR1;
        private System.Windows.Forms.NumericUpDown numericUpDownS2;
        private System.Windows.Forms.NumericUpDown numericUpDownR2;
        private System.Windows.Forms.NumericUpDown numericUpDownS1;
    }
}

