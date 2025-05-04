using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucru_Individual_nr._1
{
    public partial class Login: MaterialSkin.Controls.MaterialForm
    {

        Conectare connect = new Conectare();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string parola = textBox2.Text.Trim();

            // Validare simplă
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Te rog introdu un username și o parolă.");
                return;
            }

            string connectionString = "Server=COZMA\\SQLEXPRESS;Database=db_ultra;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND parola = @parola";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@parola", parola); 

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Autentificare reușită!");
                                MainApp main = new MainApp();
                                //main.FormClosed += (s, args) => this.Show();
                                main.Show();
                                this.Hide();
                        }
                        else
                        {
                            if (textBox1.Text == "1")
                            {
                                AdminApp admin = new AdminApp();
                                admin.FormClosed += (s, args) => this.Show();  
                                admin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username sau parolă incorectă!");

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conectare: " + ex.Message);
                }
            }




            //string query = "SELECT id FROM users WHERE username = " + textBox1.Text;

            //using (SqlCommand cmd = new SqlCommand(query, connect.openConnection()))
            //{

            //    object rezultat = cmd.ExecuteReader();

            //    if (rezultat != null)
            //    {
            //        string nume = rezultat.ToString();
            //        MessageBox.Show($"Nume găsit: {nume}");
            //        }
            //}





            //if (textBox1.Text == "1")
            //{
            //    AdminApp admin = new AdminApp();
            //    admin.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MainApp main = new MainApp();
            //    main.Show();
            //    this.Hide();
            //}



        }
        private void button2_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
            //
            reg.FormClosed += (s, args) => this.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
