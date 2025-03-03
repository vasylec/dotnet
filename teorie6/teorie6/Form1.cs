using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace teorie6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 5);

            g.DrawRectangle(pen, 10, 10, 100, 100);
            //g.DrawLine(pen, 10, 10, 10, 100);
            //g.DrawLine(pen, 10, 100, 100, 100);
            //g.DrawLine(pen, 100, 100, 100, 10);
            //g.DrawLine(pen, 100, 10, 10, 10);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 5);
            g.DrawEllipse(pen, 100, 100, 150, 150);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 5);

            g.DrawLine(pen, 300, 300, 300, 400);
            g.DrawLine(pen, 300, 400, 400, 400);
            g.DrawLine(pen, 400, 400, 300, 300);
            //g.DrawLine(pen, 100, 10, 10, 10);


        }
    }
}
