using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab10
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
            this.webBrowser1.ScriptErrorsSuppressed = true;
        }

    }
}
