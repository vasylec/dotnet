using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formular_Creare_Cont
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        
        static List<user> users = new List<user>();


        public Form1()
        {
            InitializeComponent();
            upload();
            user.setIndex(0);
        }

        private void upload()
        {
            string[] lines = File.ReadAllLines("users.txt");
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                users.Add(new user(words[0], words[1], words[2], words[3], words[4]));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
