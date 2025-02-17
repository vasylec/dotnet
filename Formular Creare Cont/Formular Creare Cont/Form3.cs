using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formular_Creare_Cont
{
    public partial class Form3: MaterialSkin.Controls.MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool logged = false;
            for (int i=0;i<user.getIndex(); i++)
            {
                if (textBox1.Text == Program.users[i].Username && textBox2.Text == Program.users[i].Password)
                {
                    logged = true;
                    MessageBox.Show("Login successful");
                    return;
                }
            }
            if(!logged)
            {
                MessageBox.Show("Login failed");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
