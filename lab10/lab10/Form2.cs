using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            CreateMDITab();
        }

        

        public void CreateMDITab()
        {
            // Creăm un nou TabPage
            TabPage newTab = new TabPage();
            newTab.Text = "MDI Tab " + (tabControl1.TabPages.Count + 1);

            // Creăm un Panel pentru MDI Child
            Panel mdiPanel = new Panel();
            mdiPanel.Dock = DockStyle.Fill;
            mdiPanel.BorderStyle = BorderStyle.FixedSingle;

            // Adăugăm Panel-ul în TabPage
            newTab.Controls.Add(mdiPanel);
            tabControl1.TabPages.Add(newTab);

            // Deschidem un nou Form1 în acest tab
            OpenMDIChild(mdiPanel);

            // Comutăm pe noul tab
            tabControl1.SelectedTab = newTab;
        }

        private void OpenMDIChild(Panel mdiPanel)
        {
            // Creăm o instanță nouă a lui Form1
            Form1 childForm = new Form1();
            childForm.TopLevel = false; // Important: Nu trebuie să fie Top-Level
            childForm.FormBorderStyle = FormBorderStyle.Sizable;
            childForm.Dock = DockStyle.Fill; // Se extinde în interiorul panel-ului

            // Adăugăm Form1 în Panel și îl afișăm
            mdiPanel.Controls.Add(childForm);
            childForm.Show();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMDITab();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Dispose();
        }
    }
}
