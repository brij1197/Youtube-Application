using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace Youtubelight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            Gecko.IO.MimeInputStream stream = Gecko.IO.MimeInputStream.Create();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sUserAgent = "Mozilla/5.0 (X11; U; Linux i686; en-US) AppleWebKit/533.4 (KHTML, like Gecko) Chrome/5.0.375.127 Large Screen Safari/533.4 GoogleTV/ 162671";
            Gecko.GeckoPreferences.User["general.useragent.override"] = sUserAgent;
            geckoWebBrowser1.Navigate("https://youtube.com/");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void geckoWebBrowser1_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
