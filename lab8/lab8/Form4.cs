using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            this.KeyPress += new KeyPressEventHandler(Form4_KeyPress);
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DrawCircle(); 
            }
        }

        private void DrawCircle()
        {
            try
            {
                float r = float.Parse(textBox1.Text); 

                double aria = r * r * Math.PI;
                double lungimea = 2 * r * Math.PI;

                label5.Text = $"Aria = {aria:F2}\nLungimea discului = {lungimea:F2}";

                this.Invalidate();
            }
            catch (Exception ex)
            {
                label5.Text = "Eroare: " + ex.Message;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            try
            {
                if (float.TryParse(textBox1.Text, out float r))
                {
                    DrawCircleOnForm(e.Graphics, r);
                }
            }
            catch (Exception ex)
            {
                label5.Text = "Eroare: " + ex.Message;
            }
        }

        private void DrawCircleOnForm(Graphics g, float r)
        {
            PointF center = new PointF(200, 200); 
            float diameter = r * 2;

            g.DrawEllipse(Pens.Black, center.X - r, center.Y - r, diameter, diameter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawCircle(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show(); 
            this.Close(); 
        }
    }
}
