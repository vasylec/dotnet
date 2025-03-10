using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label5.Text = "";

            // Permite evenimentului KeyPress să fie activ
            this.KeyPress += new KeyPressEventHandler(Form2_KeyPress);
            this.KeyPreview = true; // Permite să captezi evenimentul tastaturii chiar dacă un control are focus
        }

        // Evenimentul de tastatură pentru a detecta apăsarea Enter
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Când se apasă Enter, deschide forma cu triunghiul
                OpenTriangleForm();
            }
        }

        // Functie pentru deschiderea unei noi forme ce va desena triunghiul
        private void OpenTriangleForm()
        {
            try
            {
                // Citirea valorilor laturilor din câmpurile de text
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);

                // Verifică dacă triunghiul poate exista
                if (a + b > c && a + c > b && b + c > a)
                {
                    // Deschide o nouă formă pentru a desena triunghiul
                    FormTriangle formTriangle = new FormTriangle(a, b, c);
                    formTriangle.Show();
                }
                else
                {
                    MessageBox.Show("Nu poate exista un asemenea triunghi!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calcularea ariei și perimetrului și desenarea triunghiului
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Citirea valorilor laturilor din câmpurile de text
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);

                // Verifică dacă triunghiul poate exista
                if (a + b > c && a + c > b && b + c > a)
                {
                    // Calcularea perimetrului
                    float perimetru = a + b + c;
                    float sp = perimetru / 2; // semiperimetrul

                    // Calcularea ariei folosind formula semiperimetrului
                    double aria = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));

                    // Afișează rezultatele în eticheta
                    label5.Text = $"Aria = {aria:F2}\nPerimetru = {perimetru:F2}";

                    // Re-desenarea triunghiului pe baza laturilor introduse
                    this.Invalidate(); // Triggers the Paint event
                }
                else
                {
                    label5.Text = "Nu poate exista un asemenea triunghi!";
                }
            }
            catch (Exception ex)
            {
                // În caz de eroare la conversia valorilor
                label5.Text = "Eroare: " + ex.Message;
            }
        }

        // Funcție pentru a închide formularul și a deschide altul
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();  // Folosește Show() în loc de showmMainMenu()
            this.Close();
        }

        // Evenimentul Paint pentru a desena triunghiul pe formular
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Citirea valorilor din textboxuri pentru laturile triunghiului
            if (float.TryParse(textBox1.Text, out float l1) &&
                float.TryParse(textBox2.Text, out float l2) &&
                float.TryParse(textBox3.Text, out float l3))
            {
                // Desenăm triunghiul doar dacă laturile sunt valide
                DrawTriangle(this, e, l1, l2, l3);
            }
        }

        // Functie pentru desenarea triunghiului pe baza laturilor
        private void DrawTriangle(object sender, PaintEventArgs e, float l1, float l2, float l3)
        {
            // Laturile triunghiului
            double a = l1; // Lungimea laturii AB
            double b = l2; // Lungimea laturii BC
            double c = l3; // Lungimea laturii CA

            // Verifică validitatea triunghiului
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                e.Graphics.DrawString("Triunghi invalid!", new Font("Arial", 12), Brushes.Red, 50, 50);
                return;
            }

            // Calculul unghiului dintre laturile b și c folosind formula cosinusului
            double angleB = Math.Acos((b * b + c * c - a * a) / (2 * b * c));

            // Calculăm coordonatele punctului C
            double cx = b * Math.Cos(angleB);
            double cy = b * Math.Sin(angleB);

            // Punctele triunghiului
            PointF A = new PointF(50, 300); // Punctul A
            PointF B = new PointF(50 + (float)a, 300); // Punctul B
            PointF C = new PointF((float)cx, (float)(300 - cy)); // Punctul C

            // Desenăm triunghiul
            e.Graphics.DrawLine(Pens.Black, A, B); // Latura AB
            e.Graphics.DrawLine(Pens.Black, B, C); // Latura BC
            e.Graphics.DrawLine(Pens.Black, C, A); // Latura CA

            // Desenăm punctele
            e.Graphics.FillEllipse(Brushes.Red, A.X - 5, A.Y - 5, 10, 10); // Punctul A
            e.Graphics.FillEllipse(Brushes.Red, B.X - 5, B.Y - 5, 10, 10); // Punctul B
            e.Graphics.FillEllipse(Brushes.Red, C.X - 5, C.Y - 5, 10, 10); // Punctul C
        }
    }

    // Clasa pentru a desena triunghiul pe o nouă formă
    public class FormTriangle : Form
    {
        private float a, b, c;

        public FormTriangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.Text = "Triunghi Desenat";
            this.Size = new Size(400, 400);
        }

        // Evenimentul Paint pentru a desena triunghiul pe formular
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawTriangle(this, e, a, b, c);
        }

        // Funcție pentru desenarea triunghiului
        private void DrawTriangle(object sender, PaintEventArgs e, float l1, float l2, float l3)
        {
            // Laturile triunghiului
            double a = l1;
            double b = l2;
            double c = l3;

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                e.Graphics.DrawString("Triunghi invalid!", new Font("Arial", 12), Brushes.Red, 50, 50);
                return;
            }

            double angleB = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            double cx = b * Math.Cos(angleB);
            double cy = b * Math.Sin(angleB);

            PointF A = new PointF(50, 300);
            PointF B = new PointF(50 + (float)a, 300);
            PointF C = new PointF((float)cx, (float)(300 - cy));

            e.Graphics.DrawLine(Pens.Black, A, B);
            e.Graphics.DrawLine(Pens.Black, B, C);
            e.Graphics.DrawLine(Pens.Black, C, A);

            e.Graphics.FillEllipse(Brushes.Red, A.X - 5, A.Y - 5, 10, 10);
            e.Graphics.FillEllipse(Brushes.Red, B.X - 5, B.Y - 5, 10, 10);
            e.Graphics.FillEllipse(Brushes.Red, C.X - 5, C.Y - 5, 10, 10);
        }
    }
}
