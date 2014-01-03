using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteCapture
{
    public partial class EditSiteForm : Form
    {
        private WebBrowser webBrowser = new WebBrowser();
        private Bitmap bitmap = null;
        private int browserWidth = 0;
        private int browserHeight = 0;
        private int imageWidth = 0;
        private int imageHeight = 0;
        private string previousUrl;

        /// <summary>
        /// If true the calling form will refresh its data.
        /// </summary>
        public bool DoRefresh { get; set; }

        public EditSiteForm()
        {
            InitializeComponent();
        }

        private void EditSiteForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DoRefresh = false;
            Close();
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (urlTextBox.Text == "")
            {
                errorProvider.SetError(urlTextBox, "Please enter a valid URL");
                urlTextBox.Focus();
                return;
            }

            if (int.TryParse(browserWidthTextBox.Text, out browserWidth) == false)
            {
                errorProvider.SetError(browserWidthTextBox, "Please enter a number");
                browserWidthTextBox.Focus();
                return;
            }

            if (int.TryParse(browserHeightTextBox.Text, out browserHeight) == false)
            {
                errorProvider.SetError(browserHeightTextBox, "Please enter a number");
                browserHeightTextBox.Focus();
                return;
            }

            if (int.TryParse(imageWidthTextBox.Text, out imageWidth) == false)
            {
                errorProvider.SetError(imageWidthTextBox, "Please enter a number");
                imageWidthTextBox.Focus();
                return;
            }

            if (int.TryParse(imageHeightTextBox.Text, out imageHeight) == false)
            {
                errorProvider.SetError(imageHeightTextBox, "Please enter a number");
                imageHeightTextBox.Focus();
                return;
            }

            if (autoExpandCheckBox.Checked)
            {
                browserHeightTextBox.Text = "0";
                imageHeightTextBox.Text = "0";
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void autoExpandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            browserHeightTextBox.Enabled = !autoExpandCheckBox.Checked;
            imageHeightTextBox.Enabled = !autoExpandCheckBox.Checked;
        }
    }
}
