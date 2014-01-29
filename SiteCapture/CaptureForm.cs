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

        /// <summary>
        /// if set to true the capturing process will be cancelled
        /// </summary>
        public bool CancelProcess { get; private set; }

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
            this.Cursor = Cursors.WaitCursor;
            webBrowser.Navigate(new Uri(Url)); //using the Uri overload seams to work better
            Application.DoEvents();
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
            if (CancelProcess)
                this.Close();

            //this event executes more than once. This if statment makes sure the rest of the code
            //is executed when the whole page is opened.
            if (e.Url.AbsolutePath != webBrowser.Url.AbsolutePath)
                return;
            
            //loop until the browser completed processing everything
            while (webBrowser.IsBusy == true && webBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();

                if (CancelProcess)
                    this.Close();
            }

            //if the browser height is 0 get the height of the complete webpage
            if (BrowserHeight <= 0)
                webBrowser.Height = ImageHeight = webBrowser.Document.Window.Size.Height;

            Screenshot = new Bitmap(ImageWidth, ImageHeight);
            NativeMethods.GetImage(webBrowser.ActiveXInstance, Screenshot, Color.White);
            DocumentTitle = webBrowser.DocumentTitle;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Cursor = Cursors.Default;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelProcess = true;
        }
    }
}
