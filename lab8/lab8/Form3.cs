using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            this.KeyPress += new KeyPressEventHandler(Form3_KeyPress);
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DrawRectangle(); 
            }
        }

        private void DrawRectangle()
        {
            try
            {
                float a = float.Parse(textBox1.Text); 
                float b = float.Parse(textBox2.Text); 

                double aria = a * b;
                double perimetru = 2 * (a + b);

                label5.Text = $"Aria = {aria:F2}\nPerimetru = {perimetru:F2}";

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
                if (float.TryParse(textBox1.Text, out float a) && float.TryParse(textBox2.Text, out float b))
                {
                    DrawRectangleOnForm(e.Graphics, a, b);
                }
            }
            catch (Exception ex)
            {
                label5.Text = "Eroare: " + ex.Message;
            }
        }

        private void DrawRectangleOnForm(Graphics g, float a, float b)
        {
            PointF topLeft = new PointF(100, 100); 

            g.DrawRectangle(Pens.Black, topLeft.X, topLeft.Y, a, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawRectangle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show(); 
            this.Close(); 
        }
    }
}
