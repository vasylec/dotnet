using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucru_Individual_nr._1
{
    public partial class Register: MaterialSkin.Controls.MaterialForm
    {
        Conectare connect = new Conectare();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                string email = textBox2.Text;
                string nume = textBox3.Text;
                string prenume = textBox4.Text;
                string bday = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string parola = textBox5.Text;






                string querry = "INSERT INTO users VALUES (@username,@email,@nume,@prenume,@bday,@parola)";


                using (SqlCommand cmd = new SqlCommand(querry, connect.openConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@nume", nume);
                    cmd.Parameters.AddWithValue("@prenume", prenume);
                    cmd.Parameters.AddWithValue("@bday", bday);
                    cmd.Parameters.AddWithValue("@parola", parola);





                    int rowsAffected = cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Inregistrare cu success !");
            }
            catch
            (Exception ex)
            {
                MessageBox.Show("Eroare la inregistrare: " + ex.Message);
            }

            
        }
    }
}
