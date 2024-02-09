namespace OlahCitra.Strategy.BitPlaneSlicing
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
            this.tableLayoutPanelBitSplit = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownBItPlane = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBitSplitMaxGrayLevel = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanelBitSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBItPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBitSplit
            // 
            this.tableLayoutPanelBitSplit.ColumnCount = 1;
            this.tableLayoutPanelBitSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBitSplit.Controls.Add(this.numericUpDownBItPlane, 0, 1);
            this.tableLayoutPanelBitSplit.Controls.Add(this.checkBoxBitSplitMaxGrayLevel, 0, 0);
            this.tableLayoutPanelBitSplit.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelBitSplit.Name = "tableLayoutPanelBitSplit";
            this.tableLayoutPanelBitSplit.RowCount = 2;
            this.tableLayoutPanelBitSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBitSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBitSplit.Size = new System.Drawing.Size(112, 46);
            this.tableLayoutPanelBitSplit.TabIndex = 17;
            // 
            // numericUpDownBItPlane
            // 
            this.numericUpDownBItPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownBItPlane.Location = new System.Drawing.Point(3, 26);
            this.numericUpDownBItPlane.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownBItPlane.Name = "numericUpDownBItPlane";
            this.numericUpDownBItPlane.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownBItPlane.TabIndex = 19;
            // 
            // checkBoxBitSplitMaxGrayLevel
            // 
            this.checkBoxBitSplitMaxGrayLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBitSplitMaxGrayLevel.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBitSplitMaxGrayLevel.Name = "checkBoxBitSplitMaxGrayLevel";
            this.checkBoxBitSplitMaxGrayLevel.Size = new System.Drawing.Size(106, 17);
            this.checkBoxBitSplitMaxGrayLevel.TabIndex = 0;
            this.checkBoxBitSplitMaxGrayLevel.Text = "Max Grey Level";
            this.checkBoxBitSplitMaxGrayLevel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(31, 65);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 18;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 94);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tableLayoutPanelBitSplit);
            this.Name = "FormOptions";
            this.Text = "Bit Plane Slicing Options";
            this.tableLayoutPanelBitSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBItPlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBitSplit;
        private System.Windows.Forms.NumericUpDown numericUpDownBItPlane;
        private System.Windows.Forms.CheckBox checkBoxBitSplitMaxGrayLevel;
        private System.Windows.Forms.Button buttonOk;
    }
}