using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucru_Individual_nr._1
{
    public partial class quantity: Form
    {
        public static int q;
        
        public quantity()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                q = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Cantitate: " + q + " adaugata cu success !");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcarea produselor: " + ex.Message);
            }
        }
    }
}
