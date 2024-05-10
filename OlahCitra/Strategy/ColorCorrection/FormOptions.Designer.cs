namespace OlahCitra.Strategy.ColorCorrection
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
            this.numericUpDownDeltaR = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDeltaB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDeltaG = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaG)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDeltaR
            // 
            this.numericUpDownDeltaR.Location = new System.Drawing.Point(124, 8);
            this.numericUpDownDeltaR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDeltaR.Name = "numericUpDownDeltaR";
            this.numericUpDownDeltaR.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDeltaR.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pergeseran Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pergeseran Blue";
            // 
            // numericUpDownDeltaB
            // 
            this.numericUpDownDeltaB.Location = new System.Drawing.Point(124, 71);
            this.numericUpDownDeltaB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDeltaB.Name = "numericUpDownDeltaB";
            this.numericUpDownDeltaB.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDeltaB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pergeseran Green";
            // 
            // numericUpDownDeltaG
            // 
            this.numericUpDownDeltaG.Location = new System.Drawing.Point(124, 41);
            this.numericUpDownDeltaG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDeltaG.Name = "numericUpDownDeltaG";
            this.numericUpDownDeltaG.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDeltaG.TabIndex = 4;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(81, 112);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 142);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownDeltaG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDeltaB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDeltaR);
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownDeltaR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDeltaB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDeltaG;
        private System.Windows.Forms.Button buttonOk;
    }
}