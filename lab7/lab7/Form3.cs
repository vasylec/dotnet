using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form3: Form
    {
        string 
            mate = "12.06.2025",
            rom = "11.06.2025",
            bio = "05.06.2025",
            chim = "14.06.2025",
            fiz = "07.06.2025",
            info = "03.06.2025",
            geo = "13.06.2025",
            ist = "10.06.2025";





        public Form3()
        {
            InitializeComponent();
            checkedListBox1.Items.AddRange(new string[]{
                "Matematică", "Română", "Biologie", "Chimie",
                "Fizică", "Informatică", "Geografie", "Istorie"
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int k = 0;
            List<string> selectedItems = new List<string>();



            foreach (var item in checkedListBox1.CheckedItems)
            {
                k++;
            }

            if(k == 4)
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    selectedItems.Add(item.ToString());
                }
            }


            if (k != 4)
            {
                MessageBox.Show("Selectati 4 materii");
            }
            else
            {

                string res = "";

                if (selectedItems.Contains("Matematică"))
                {
                    res += "Matematica: " + mate + "\n";
                }
                if (selectedItems.Contains("Română"))
                {
                    res += "Română: " + rom + "\n";
                }
                if (selectedItems.Contains("Biologie"))
                {
                    res += "Biologie: " + bio + "\n";
                }
                if (selectedItems.Contains("Chimie"))
                {
                    res += "Chimie: " + chim + "\n";
                }
                if (selectedItems.Contains("Fizică"))
                {
                    res += "Fizică: " + fiz + "\n";
                }
                if (selectedItems.Contains("Informatică"))
                {
                    res += "Informatică: " + info + "\n";
                }
                if (selectedItems.Contains("Geografie"))
                {
                    res += "Geografie: " + geo + "\n";
                }
                if (selectedItems.Contains("Istorie"))
                {
                    res += "Istorie: " + ist + "\n";
                }


                MessageBox.Show("Selectie cu succes");
                MessageBox.Show("Profilul selectat: "+comboBox1.SelectedItem.ToString()+
                    "\n\nMateriile selectate sunt: " + string.Join(", ", selectedItems) +
                    "\n\n\n\nData de prezentare pentru fiecare bac:\n\n" + res+
                    "\n\nElev:\n" + Program.users[Program.loggeduser].prenume + "\n" + Program.users[Program.loggeduser].bday +
                    "\n\n\n\nSite-ul pentru a exersa pentru BAC  -  ance.gov.md");
            }





        }
    }
}
