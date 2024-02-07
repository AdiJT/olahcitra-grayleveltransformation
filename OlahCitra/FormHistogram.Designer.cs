namespace OlahCitra
{
    partial class FormHistogram
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
            this.histogram = new CustomControl.Histogram();
            this.SuspendLayout();
            // 
            // histogram
            // 
            this.histogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histogram.Location = new System.Drawing.Point(0, 0);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(636, 450);
            this.histogram.TabIndex = 0;
            this.histogram.Title = "labelHistogram";
            // 
            // FormHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.histogram);
            this.Name = "FormHistogram";
            this.Text = "FormHistogram";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.Histogram histogram;
    }
}