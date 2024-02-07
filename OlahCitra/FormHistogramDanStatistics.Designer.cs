namespace OlahCitra
{
    partial class FormHistogramDanStatistics
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.histogramGreyScale = new OlahCitra.CustomControl.Histogram();
            this.histogramHasil = new OlahCitra.CustomControl.Histogram();
            this.imageStatisticsGreyScale = new OlahCitra.CustomControl.ImageStatistics();
            this.imageStatisticsHasil = new OlahCitra.CustomControl.ImageStatistics();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.histogramGreyScale, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.histogramHasil, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageStatisticsGreyScale, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imageStatisticsHasil, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // histogramGreyScale
            // 
            this.histogramGreyScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogramGreyScale.Location = new System.Drawing.Point(3, 3);
            this.histogramGreyScale.Name = "histogramGreyScale";
            this.histogramGreyScale.Size = new System.Drawing.Size(459, 367);
            this.histogramGreyScale.TabIndex = 0;
            this.histogramGreyScale.Title = "Histogram Grey Scale";
            // 
            // histogramHasil
            // 
            this.histogramHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogramHasil.Location = new System.Drawing.Point(468, 3);
            this.histogramHasil.Name = "histogramHasil";
            this.histogramHasil.Size = new System.Drawing.Size(459, 367);
            this.histogramHasil.TabIndex = 1;
            this.histogramHasil.Title = "Histogram Hasil Transformasi";
            // 
            // imageStatisticsGreyScale
            // 
            this.imageStatisticsGreyScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageStatisticsGreyScale.Location = new System.Drawing.Point(3, 376);
            this.imageStatisticsGreyScale.Name = "imageStatisticsGreyScale";
            this.imageStatisticsGreyScale.Size = new System.Drawing.Size(459, 155);
            this.imageStatisticsGreyScale.Statistics = null;
            this.imageStatisticsGreyScale.TabIndex = 2;
            this.imageStatisticsGreyScale.Title = "Statistik Gambar Grey Scale";
            // 
            // imageStatisticsHasil
            // 
            this.imageStatisticsHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageStatisticsHasil.Location = new System.Drawing.Point(468, 376);
            this.imageStatisticsHasil.Name = "imageStatisticsHasil";
            this.imageStatisticsHasil.Size = new System.Drawing.Size(459, 155);
            this.imageStatisticsHasil.Statistics = null;
            this.imageStatisticsHasil.TabIndex = 3;
            this.imageStatisticsHasil.Title = "Statistik Gambar Hasil Transformasi";
            // 
            // FormHistogramDanStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormHistogramDanStatistics";
            this.Text = "FormHistogramDanStatistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControl.Histogram histogramGreyScale;
        private CustomControl.Histogram histogramHasil;
        private CustomControl.ImageStatistics imageStatisticsGreyScale;
        private CustomControl.ImageStatistics imageStatisticsHasil;
    }
}