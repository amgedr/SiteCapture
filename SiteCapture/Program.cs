using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteCapture
{
    static class Program
    {
        #region Disable IE's clicking sound when rendering a page
        /* For more info:
         * http://social.msdn.microsoft.com/Forums/vstudio/en-US/1940f513-8b72-4a29-9a57-85427d8fa88a/how-to-disable-click-sound-in-webbrowser-control?forum=csharpgeneral
         * http://stackoverflow.com/questions/10456/howto-disable-webbrowser-click-sound-in-your-app-only
         * http://stackoverflow.com/questions/393166/how-to-disable-click-sound-in-webbrowser-control
         * http://www.hackcommunity.com/Thread-VB-Net-C-Disable-Sound-of-the-WebBrowser-Control
         * http://stackoverflow.com/questions/1720902/how-to-disable-click-sound-using-a-webbrowser-element-in-c-sharp
         * http://stackoverflow.com/questions/10629499/muting-refresh-sound-in-webbrowser-control-c-sharp-winform
         */

        const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        const int SET_FEATURE_ON_THREAD = 0x00000001;
        const int SET_FEATURE_ON_PROCESS = 0x00000002;
        const int SET_FEATURE_IN_REGISTRY = 0x00000004;
        const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;
        const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;
        const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;
        const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;
        const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;

        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        static extern int CoInternetSetFeatureEnabled(
            int FeatureEntry,
            [MarshalAs(UnmanagedType.U4)] int dwFlags,
            bool fEnable);

        static void DisableClickSounds()
        {
            CoInternetSetFeatureEnabled(
                FEATURE_DISABLE_NAVIGATION_SOUNDS,
                SET_FEATURE_ON_PROCESS,
                true);
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //make sure there is only 1 instance running of SiteCapture
            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            //if there is another instance running exit
            if (!result)
                return;

            DisableClickSounds();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            GC.KeepAlive(mutex);
        }
    }
}
