using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace SiteCapture
{
    public partial class PreviewForm : Form
    {
        public PreviewForm(Bitmap screenshotBitmap, string webpageTitle)
        {
            InitializeComponent();

            this.Text = "Preview of '" + webpageTitle + "'";

            int width = 640;
            int height = 480;

            pictureBox.Image = screenshotBitmap;

            if (pictureBox.Width < Screen.PrimaryScreen.WorkingArea.Width)
                width = pictureBox.Width;

            if (pictureBox.Height < Screen.PrimaryScreen.WorkingArea.Height)
                height = pictureBox.Height;

            this.ClientSize = new Size(width, height);
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

                if (pictureBox.Width < this.ClientSize.Width)
                    pictureBox.Left = (this.ClientSize.Width - pictureBox.Width) / 2;
                else
                    pictureBox.Left = 0;

                if (pictureBox.Height < this.ClientSize.Height)
                    pictureBox.Top = (this.ClientSize.Height - pictureBox.Height) / 2;
                else
                    pictureBox.Top = 0;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                ImageFormat imageFormat = ImageFormat.Jpeg;

                switch (System.IO.Path.GetExtension(saveFileDialog.FileName))
                {
                    case ".gif":
                        imageFormat = ImageFormat.Gif;
                        break;

                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;

                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;

                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;

                    default:
                        saveFileDialog.FileName += ".jpg";
                        break;
                }

                pictureBox.Image.Save(saveFileDialog.FileName, imageFormat);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox.Image);
        }
    }
}
