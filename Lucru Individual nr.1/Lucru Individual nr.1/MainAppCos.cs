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
    public partial class MainAppCos: MaterialSkin.Controls.MaterialForm
    {


        Conectare connect = new Conectare();
        SqlDataAdapter dataAdapter;
        DataTable dataTable;



        public MainAppCos()
        {
            InitializeComponent();


            string querry = "\r\nSELECT cart_product.id, \r\n    product.product_name, \r\n    product.product_descriprion, \r\n    product.product_price, \r\n    cart_product.product_quantity\r\nFROM \r\n    cart_product\r\nINNER JOIN \r\n    product ON cart_product.id_product = product.id_product;";

            renderGridView(querry);
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

        private void MainAppCos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_ultraDataSet.cart_product' table. You can move, or remove it, as needed.
            this.cart_productTableAdapter.Fill(this.db_ultraDataSet.cart_product);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainApp main = new MainApp();
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MessageBox.Show("Produse cumparate cu success !");

            string querry = "DELETE FROM cart_product;";
            using (SqlCommand cmd = new SqlCommand(querry, connect.openConnection()))
            {
                int rowsAffected = cmd.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow;

            int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

            if (id != null)
            {
                string querry = "DELETE FROM cart_product WHERE id = " + id;
                using (SqlCommand cmd = new SqlCommand(querry, connect.openConnection()))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                }

                querry = "\r\nSELECT cart_product.id, \r\n    product.product_name, \r\n    product.product_descriprion, \r\n    product.product_price, \r\n    cart_product.product_quantity\r\nFROM \r\n    cart_product\r\nINNER JOIN \r\n    product ON cart_product.id_product = product.id_product;";

                renderGridView(querry);
            }
        }
    }
}
