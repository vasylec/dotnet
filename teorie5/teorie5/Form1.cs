using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teorie5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;

                this.BackColor = selectedColor; // Schimbă culoarea de fundal a formularului
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Doresti sa inchizi aplicatia cu adevarat ?", "Shut Down", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.Font = fontDialog1.Font;
                button2.Font = fontDialog1.Font;
                button1.Font = fontDialog1.Font;

            }
        }
    }
}
