using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
            openFileDialog.Title = "Selectează un fișier text";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Form2 f2 = new Form2();
                    f2.MdiParent = this;
                    f2.Show();

                    string fileContent = File.ReadAllText(openFileDialog.FileName);

                    f2.setRichTextBoxText(fileContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare la citire: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa inchizi toate ferestrele ? Orice lucru nesalvat va fi pierdut", "Window Close", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                foreach (Form2 childForm in this.MdiChildren)
                {
                    if (!childForm.IsDisposed)
                    {
                        childForm.Close();
                    }
                }
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true; 
            colorDialog.Color = this.BackColor; 

            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = colorDialog.Color;
                this.BackColor = colorDialog.Color; 
                Form2.color = colorDialog.Color;
            }
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Form2 childForm in this.MdiChildren)
                {
                    if (!childForm.IsDisposed)
                    {
                        childForm.setRichTextFont(fontDialog.Font);
                    }
                }
            }


        }
    }
}
