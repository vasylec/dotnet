using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            upload();
        }

        void upload()
        {
            listBox1.Items.Add(Program.info + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            int[] n = new int[4];
            a = comboBox1.SelectedIndex + 1;
            b = comboBox2.SelectedIndex + 1;
            c = comboBox3.SelectedIndex + 1;
            d = comboBox4.SelectedIndex + 1;
            n[0] = a; n[1] = b; n[2] = c; n[3] = d;

            Program.elevi.Add(new elev(textBox1.Text, dateTimePicker1.Value.ToShortDateString(), comboBox5.SelectedIndex + 1, n));
            save();

            Program.info = textBox1.Text + " " + dateTimePicker1.Value.ToShortDateString() + " " + (comboBox5.SelectedIndex + 1) + " " + a + " " + b +  " " + c + " " + d;
            upload();
        }

        private void save()
        {
            StreamWriter sw = new StreamWriter("elevi.txt");
            foreach (elev e in Program.elevi)
            {
                sw.WriteLine(e.nume + " " + e.bday + " " + e.an + " " + e.note[0] + " " + e.note[1] + " " + e.note[2] + " " + e.note[3]);
            }
            sw.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
