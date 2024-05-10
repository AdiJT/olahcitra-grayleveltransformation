namespace OlahCitra.Strategy.HSVColorSegmentation
{
    partial class FormOptions
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.panelHueOnly = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHueRange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownHue = new System.Windows.Forms.NumericUpDown();
            this.radioButtonHueOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonLowHigh = new System.Windows.Forms.RadioButton();
            this.panelLowHigh = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownLowHue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHighHue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHighSaturation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowSaturation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHighValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowValue = new System.Windows.Forms.NumericUpDown();
            this.panelHueOnly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).BeginInit();
            this.panelLowHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(129, 257);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panelHueOnly
            // 
            this.panelHueOnly.Controls.Add(this.label2);
            this.panelHueOnly.Controls.Add(this.numericUpDownHueRange);
            this.panelHueOnly.Controls.Add(this.label1);
            this.panelHueOnly.Controls.Add(this.numericUpDownHue);
            this.panelHueOnly.Location = new System.Drawing.Point(23, 30);
            this.panelHueOnly.Name = "panelHueOnly";
            this.panelHueOnly.Size = new System.Drawing.Size(307, 71);
            this.panelHueOnly.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hue Range";
            // 
            // numericUpDownHueRange
            // 
            this.numericUpDownHueRange.Location = new System.Drawing.Point(79, 37);
            this.numericUpDownHueRange.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHueRange.Name = "numericUpDownHueRange";
            this.numericUpDownHueRange.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHueRange.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hue";
            // 
            // numericUpDownHue
            // 
            this.numericUpDownHue.Location = new System.Drawing.Point(79, 11);
            this.numericUpDownHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHue.Name = "numericUpDownHue";
            this.numericUpDownHue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHue.TabIndex = 4;
            // 
            // radioButtonHueOnly
            // 
            this.radioButtonHueOnly.AutoSize = true;
            this.radioButtonHueOnly.Checked = true;
            this.radioButtonHueOnly.Location = new System.Drawing.Point(7, 7);
            this.radioButtonHueOnly.Name = "radioButtonHueOnly";
            this.radioButtonHueOnly.Size = new System.Drawing.Size(75, 17);
            this.radioButtonHueOnly.TabIndex = 6;
            this.radioButtonHueOnly.TabStop = true;
            this.radioButtonHueOnly.Text = "Pakai Hue";
            this.radioButtonHueOnly.UseVisualStyleBackColor = true;
            this.radioButtonHueOnly.CheckedChanged += new System.EventHandler(this.radioButtonHueOnly_CheckedChanged);
            // 
            // radioButtonLowHigh
            // 
            this.radioButtonLowHigh.AutoSize = true;
            this.radioButtonLowHigh.Location = new System.Drawing.Point(7, 117);
            this.radioButtonLowHigh.Name = "radioButtonLowHigh";
            this.radioButtonLowHigh.Size = new System.Drawing.Size(121, 17);
            this.radioButtonLowHigh.TabIndex = 7;
            this.radioButtonLowHigh.Text = "Pakai Low dan High";
            this.radioButtonLowHigh.UseVisualStyleBackColor = true;
            this.radioButtonLowHigh.CheckedChanged += new System.EventHandler(this.radioButtonLowHigh_CheckedChanged);
            // 
            // panelLowHigh
            // 
            this.panelLowHigh.Controls.Add(this.numericUpDownHighValue);
            this.panelLowHigh.Controls.Add(this.numericUpDownLowValue);
            this.panelLowHigh.Controls.Add(this.numericUpDownHighSaturation);
            this.panelLowHigh.Controls.Add(this.numericUpDownLowSaturation);
            this.panelLowHigh.Controls.Add(this.numericUpDownHighHue);
            this.panelLowHigh.Controls.Add(this.numericUpDownLowHue);
            this.panelLowHigh.Controls.Add(this.label7);
            this.panelLowHigh.Controls.Add(this.label6);
            this.panelLowHigh.Controls.Add(this.label5);
            this.panelLowHigh.Controls.Add(this.label4);
            this.panelLowHigh.Controls.Add(this.label3);
            this.panelLowHigh.Enabled = false;
            this.panelLowHigh.Location = new System.Drawing.Point(23, 140);
            this.panelLowHigh.Name = "panelLowHigh";
            this.panelLowHigh.Size = new System.Drawing.Size(307, 111);
            this.panelLowHigh.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saturation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "High";
            // 
            // numericUpDownLowHue
            // 
            this.numericUpDownLowHue.Location = new System.Drawing.Point(64, 48);
            this.numericUpDownLowHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownLowHue.Name = "numericUpDownLowHue";
            this.numericUpDownLowHue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownLowHue.TabIndex = 5;
            // 
            // numericUpDownHighHue
            // 
            this.numericUpDownHighHue.Location = new System.Drawing.Point(64, 74);
            this.numericUpDownHighHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHighHue.Name = "numericUpDownHighHue";
            this.numericUpDownHighHue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHighHue.TabIndex = 6;
            // 
            // numericUpDownHighSaturation
            // 
            this.numericUpDownHighSaturation.Location = new System.Drawing.Point(126, 74);
            this.numericUpDownHighSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownHighSaturation.Name = "numericUpDownHighSaturation";
            this.numericUpDownHighSaturation.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHighSaturation.TabIndex = 8;
            // 
            // numericUpDownLowSaturation
            // 
            this.numericUpDownLowSaturation.Location = new System.Drawing.Point(126, 48);
            this.numericUpDownLowSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLowSaturation.Name = "numericUpDownLowSaturation";
            this.numericUpDownLowSaturation.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownLowSaturation.TabIndex = 7;
            // 
            // numericUpDownHighValue
            // 
            this.numericUpDownHighValue.Location = new System.Drawing.Point(194, 74);
            this.numericUpDownHighValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownHighValue.Name = "numericUpDownHighValue";
            this.numericUpDownHighValue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHighValue.TabIndex = 10;
            // 
            // numericUpDownLowValue
            // 
            this.numericUpDownLowValue.Location = new System.Drawing.Point(194, 48);
            this.numericUpDownLowValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLowValue.Name = "numericUpDownLowValue";
            this.numericUpDownLowValue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownLowValue.TabIndex = 9;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 287);
            this.ControlBox = false;
            this.Controls.Add(this.panelLowHigh);
            this.Controls.Add(this.radioButtonLowHigh);
            this.Controls.Add(this.radioButtonHueOnly);
            this.Controls.Add(this.panelHueOnly);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.panelHueOnly.ResumeLayout(false);
            this.panelHueOnly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).EndInit();
            this.panelLowHigh.ResumeLayout(false);
            this.panelLowHigh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelHueOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHueRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHue;
        private System.Windows.Forms.RadioButton radioButtonHueOnly;
        private System.Windows.Forms.RadioButton radioButtonLowHigh;
        private System.Windows.Forms.Panel panelLowHigh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHighValue;
        private System.Windows.Forms.NumericUpDown numericUpDownLowValue;
        private System.Windows.Forms.NumericUpDown numericUpDownHighSaturation;
        private System.Windows.Forms.NumericUpDown numericUpDownLowSaturation;
        private System.Windows.Forms.NumericUpDown numericUpDownHighHue;
        private System.Windows.Forms.NumericUpDown numericUpDownLowHue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}