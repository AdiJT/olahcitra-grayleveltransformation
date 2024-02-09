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
            this.pictureBoxAsli = new OlahCitra.CustomControl.CustomPictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxHasil = new OlahCitra.CustomControl.CustomPictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.pictureBoxGrayScale = new OlahCitra.CustomControl.CustomPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonRBGSplit = new System.Windows.Forms.RadioButton();
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
            this.pictureBoxHasil.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBoxHasil.Image")));
            this.pictureBoxHasil.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxHasil.Name = "pictureBoxHasil";
            this.pictureBoxHasil.Size = new System.Drawing.Size(329, 304);
            this.pictureBoxHasil.TabIndex = 0;
            this.pictureBoxHasil.Title = "Hasil Transformasi";
            // 
            // groupBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 3);
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
    }
}

