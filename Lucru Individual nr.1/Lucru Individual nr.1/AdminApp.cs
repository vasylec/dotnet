using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucru_Individual_nr._1
{
    public partial class AdminApp: MaterialSkin.Controls.MaterialForm
    {
        Conectare connect = new Conectare();

        public AdminApp()
        {
            InitializeComponent();
        }

        private void AdminApp_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox1.Text);
                int q = Convert.ToInt32(textBox2.Text);


                string querry = "UPDATE product SET product_stock ="+ q +"WHERE id_product = " + id;
                using (SqlCommand cmd = new SqlCommand(querry, connect.openConnection()))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Stoc actualizat cu success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizarea produselor: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox4.Text);
                double p = Convert.ToDouble(textBox3.Text);


                string querry = "UPDATE product SET product_price =" + p + "WHERE id_product = " + id;
                using (SqlCommand cmd = new SqlCommand(querry, connect.openConnection()))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pret actualizat cu success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizarea produselor: " + ex.Message);
            }
        }
    }
}
