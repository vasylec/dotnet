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
    public partial class MainAppProduse: MaterialSkin.Controls.MaterialForm
    {
        public MainAppProduse()
        {
            InitializeComponent();
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
    }
}
