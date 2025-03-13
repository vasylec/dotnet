using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teorie__xml_
{
    public partial class Form1 : Form
    {
        DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            dataSet.Reset();

            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Select XML File";
            o.Filter = "xml files (*.xml)|*.xml";
            o.FilterIndex = 1;
            
            if (o.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    dataSet.ReadXml(o.FileName);

                    if (dataSet.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Fișierul XML nu conține tabele.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare la citirea fișierului XML: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           

        }


        private void export_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Save File";
            s.Filter = "xml files (*.xml)|*.xml";


            if (s.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    dataSet.WriteXml(s.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare : " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
