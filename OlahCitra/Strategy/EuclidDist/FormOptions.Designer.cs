namespace OlahCitra.Strategy.EuclidDist
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPick = new System.Windows.Forms.Button();
            this.numericUpDownTargetB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTargetG = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownTargetR = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericUpDownMaxDist = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.buttonPick);
            this.groupBox1.Controls.Add(this.numericUpDownTargetB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownTargetG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownTargetR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target RGB";
            // 
            // buttonPick
            // 
            this.buttonPick.Location = new System.Drawing.Point(117, 178);
            this.buttonPick.Name = "buttonPick";
            this.buttonPick.Size = new System.Drawing.Size(75, 23);
            this.buttonPick.TabIndex = 6;
            this.buttonPick.Text = "Pick Color";
            this.buttonPick.UseVisualStyleBackColor = true;
            this.buttonPick.Click += new System.EventHandler(this.buttonPick_Click);
            // 
            // numericUpDownTargetB
            // 
            this.numericUpDownTargetB.Location = new System.Drawing.Point(37, 130);
            this.numericUpDownTargetB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTargetB.Name = "numericUpDownTargetB";
            this.numericUpDownTargetB.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownTargetB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // numericUpDownTargetG
            // 
            this.numericUpDownTargetG.Location = new System.Drawing.Point(37, 75);
            this.numericUpDownTargetG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTargetG.Name = "numericUpDownTargetG";
            this.numericUpDownTargetG.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownTargetG.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "G";
            // 
            // numericUpDownTargetR
            // 
            this.numericUpDownTargetR.Location = new System.Drawing.Point(37, 26);
            this.numericUpDownTargetR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTargetR.Name = "numericUpDownTargetR";
            this.numericUpDownTargetR.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownTargetR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maximum Distance";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(129, 268);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericUpDownMaxDist
            // 
            this.numericUpDownMaxDist.DecimalPlaces = 2;
            this.numericUpDownMaxDist.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownMaxDist.Location = new System.Drawing.Point(129, 240);
            this.numericUpDownMaxDist.Maximum = new decimal(new int[] {
            -647710721,
            69,
            0,
            0});
            this.numericUpDownMaxDist.Name = "numericUpDownMaxDist";
            this.numericUpDownMaxDist.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxDist.TabIndex = 5;
            this.numericUpDownMaxDist.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(117, 26);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(199, 45);
            this.trackBar1.TabIndex = 7;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(117, 75);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(199, 45);
            this.trackBar2.TabIndex = 8;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(117, 130);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(199, 45);
            this.trackBar3.TabIndex = 9;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 302);
            this.ControlBox = false;
            this.Controls.Add(this.numericUpDownMaxDist);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownTargetB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTargetG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownTargetR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxDist;
        private System.Windows.Forms.Button buttonPick;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}