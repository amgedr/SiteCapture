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
    public partial class CaptureForm : Form
    {
        private string Url;
        private int BrowserWidth;
        private int BrowserHeight;
        private int ImageWidth;
        private int ImageHeight;
        private WebBrowser webBrowser = new WebBrowser();

        public Bitmap Screenshot = null;
        public string DocumentTitle = "";

        public CaptureForm(string url, int browserWidth, int browserHeight, int imageWidth, int imageHeight)
        {
            InitializeComponent();

            Url = url;
            BrowserWidth = browserWidth;
            BrowserHeight = browserHeight;
            ImageWidth = imageWidth;
            ImageHeight = imageHeight;
        }

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            webBrowser.BringToFront();
            webBrowser.ScrollBarsEnabled = false;
            webBrowser.Width = BrowserWidth;
            webBrowser.Height = BrowserHeight;
            webBrowser.ScriptErrorsSuppressed = true;

            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted);
            webBrowser.Navigated += new WebBrowserNavigatedEventHandler(wb_Navigated);
            webBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(wb_ProgressChanged);

            Application.DoEvents();
            //System.Threading.Thread.Sleep(50);
            this.Cursor = Cursors.WaitCursor;
            webBrowser.Navigate(Url);
            Application.DoEvents();
            //System.Threading.Thread.Sleep(1000);
        }

        void wb_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //if (e.CurrentProgress > 0)
            //    //calculate percentage
            //    progressBar.Value = Convert.ToInt32((e.CurrentProgress / e.MaximumProgress) * 100);
            //else
            //    progressBar.Value = 0;

            ////Application.DoEvents();
        }

        void wb_Navigated(object sender, EventArgs e)
        {

        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Application.DoEvents();

            //if the browser height is 0 get the height of the complete webpage
            if (BrowserHeight <= 0)
                webBrowser.Height = webBrowser.Document.Window.Size.Height;

            Screenshot = new Bitmap(ImageWidth, ImageHeight);
            NativeMethods.GetImage(webBrowser.ActiveXInstance, Screenshot, Color.White);
            DocumentTitle = webBrowser.DocumentTitle;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Cursor = Cursors.Default;
            this.Close();
        }
    }
}
