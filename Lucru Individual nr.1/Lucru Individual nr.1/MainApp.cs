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
    public partial class MainApp: MaterialSkin.Controls.MaterialForm
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainAppProduse pr = new MainAppProduse();
            pr.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainAppContacte cont = new MainAppContacte();
            cont.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainAppLivrare liv = new MainAppLivrare();
            liv.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainAppCos cos = new MainAppCos();
            cos.Show();
            this.Close();
        }
    }
}
