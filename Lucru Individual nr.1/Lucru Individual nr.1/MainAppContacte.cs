using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucru_Individual_nr._1
{
    public partial class MainAppContacte: MaterialSkin.Controls.MaterialForm
    {
        public MainAppContacte()
        {
            InitializeComponent();
            LoadGoogleMaps();
        }

        private async void LoadGoogleMaps()
        {
            await webView21.EnsureCoreWebView2Async();
            string url = "https://www.google.com/maps/place/Ultra/@47.0418939,28.8117901,17z/data=!4m6!3m5!1s0x40c97dbf8140239f:0x27835acaf247626d!8m2!3d47.0418939!4d28.814365!16s%2Fg%2F1tfl_zpj";
            
            webView21.Source = new Uri(url);    

            //webBrowser1.ScriptErrorsSuppressed = true;
            //webBrowser1.Navigate(url);
        }

        private void MainAppContacte_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainApp main = new MainApp();   
            main.Show();
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
