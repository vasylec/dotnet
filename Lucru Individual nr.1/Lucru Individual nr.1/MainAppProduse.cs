using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucru_Individual_nr._1
{
    public partial class MainAppProduse: MaterialSkin.Controls.MaterialForm
    {
        Conectare connect = new Conectare();
        SqlDataAdapter dataAdapter;
        DataTable dataTable;

        public MainAppProduse()
        {
            InitializeComponent();
            string querry = "SELECT * FROM product";

            renderGridView(querry);
        }

        private void MainAppProduse_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainApp main = new MainApp();
            main.Show();
            this.Close();
        }

        private void renderGridView(string querry)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(querry, connect.openConnection());
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcarea produselor: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM product WHERE id_prod_category = 1";

            renderGridView(querry);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM product WHERE id_prod_category = 2";

            renderGridView(querry);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM product WHERE id_prod_category = 3";

            renderGridView(querry);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM product WHERE id_prod_category = 4";

            renderGridView(querry);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM product WHERE id_prod_category = 5";

            renderGridView(querry);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM product WHERE id_prod_category = 10";

            renderGridView(querry);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM product WHERE id_prod_category = 7";

            renderGridView(querry);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow;

            int id = Convert.ToInt32(selectedRow.Cells["id_product"].Value);

            if(id != null)
            {

                try
                {
                    quantity quantity = new quantity();
                    quantity.ShowDialog();
                    quantity.FormClosed += (s, args) => this.Show();


                }catch (Exception ex)
                {
                    MessageBox.Show("Eroare la incarcarea produselor: " + ex.Message);
                }

                int q = quantity.q;




                string querry = "INSERT INTO cart_product VALUES (1," + id + "," + q +")";
                using (SqlCommand cmd = new SqlCommand(querry, connect.openConnection()))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                
                
            }



            //try
            //{
            //    dataAdapter = new SqlDataAdapter(querry, connect.openConnection());
            //    dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);
            //    dataGridView1.DataSource = dataTable;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Eroare la incarcarea produselor: " + ex.Message);
            //}


        }
    }
}
