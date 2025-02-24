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
    public partial class Form2: Form
    {
        public static Color color = Color.White;

        public Form2()
        {
            InitializeComponent();
            this.BackColor = color;
        }

        public void setRichTextBoxText(string text)
        {
            richTextBox1.Text = text;
        }

        public void setRichTextFont(Font font)
        {
            richTextBox1.Font = font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere text (*.txt)|*.txt|Fișiere RTF (*.rtf)|*.rtf|Toate fișierele (*.*)|*.*";
            saveFileDialog.Title = "Salvează conținutul";
            saveFileDialog.DefaultExt = "txt";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK) {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);

                    MessageBox.Show("Fișierul a fost salvat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare la salvare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esti sigur ca vrei sa inchizi fereastra ? Orice lucru nesalvat va fi pierdut", "Window Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
