namespace OlahCitra
{
    partial class FormStatistics
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
            this.imageStatistics = new OlahCitra.CustomControl.ImageStatistics();
            this.SuspendLayout();
            // 
            // imageStatistics
            // 
            this.imageStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageStatistics.Location = new System.Drawing.Point(0, 0);
            this.imageStatistics.Name = "imageStatistics";
            this.imageStatistics.Size = new System.Drawing.Size(646, 234);
            this.imageStatistics.Statistics = null;
            this.imageStatistics.TabIndex = 0;
            this.imageStatistics.Title = "labelStatistics";
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 234);
            this.Controls.Add(this.imageStatistics);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.ImageStatistics imageStatistics;
    }
}