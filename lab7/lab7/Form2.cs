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

namespace lab7
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(User user in Program.users)
            {
                if (user != null)
                {
                    if (user.login.Equals(textBox1.Text))
                    {
                        MessageBox.Show("Userul exista deja");
                        return;
                    }
                }
            }



            User u = new User(textBox1.Text,dateTimePicker1.Value.ToShortDateString(), textBox2.Text, textBox3.Text, textBox4.Text);
            StreamWriter sw = new StreamWriter("users.txt", true);
            sw.WriteLine(textBox1.Text + " " + dateTimePicker1.Value.ToShortDateString() + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text);
            sw.Close();
            Form1.UploadUsers();
            MessageBox.Show("Inregistrare cu succes");
        }

    }
}
