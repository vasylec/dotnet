using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            UploadUsers();
        }

        public static void UploadUsers()
        {
            try
            {
                StreamReader sr = new StreamReader("users.txt");
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    Program.users[i] = new User(parts[0], parts[1], parts[2], parts[3], parts[4]);
                    i++;
                }
                sr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Eroare la citirea fisierului");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool k = false;     
            
            foreach(User u in Program.users)
            {
                if(u != null)
                {
                
                    if (textBox1.Text.Equals(u.login) && textBox2.Text.Equals(u.parola))
                    {
                        k = true;
                        if(MessageBox.Show("Logare cu succes") == DialogResult.OK)
                        {
                            Program.loggeduser = Array.IndexOf(Program.users, u);
                            
                            Form3 form3 = new Form3();
                            form3.Show();

                            this.Hide();


                            //this.Close();
                        }
                    }
                }
            }

            if(k == false)
            {
                MessageBox.Show("Logare esuata");
            }


        }
    }
}
