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
    public partial class Login: MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1")
            {
                AdminApp admin = new AdminApp();
                admin.Show();
                this.Hide();
            }
            else
            {
                MainApp main = new MainApp();
                main.Show();
                this.Hide();
            }



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
