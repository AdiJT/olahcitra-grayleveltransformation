using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlahCitra.CustomControl
{
    public partial class CustomPictureBox : UserControl
    {
        public CustomPictureBox()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(300, 300);
            Title = "CustomPictureBox";

            pictureBox1.Click += new EventHandler(CustomPictureBox_Click);
        }

        private void CustomPictureBox_Click(object sender, EventArgs e)
        {
            var form = new Form();
            var pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image;
            pictureBox.Dock = DockStyle.Fill;

            form.Text = Title;
            form.WindowState = FormWindowState.Maximized;

            form.Controls.Add(pictureBox);
            form.ShowDialog();
        }

        [Browsable(true)]
        public string Title { get; set; }

        [Browsable(true)]
        public Bitmap Image
        {
            get => new Bitmap(pictureBox1.Image);
            set => pictureBox1.Image = value;
        }
    }
}
