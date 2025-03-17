using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool semn = true;
        int selected = 3;
        string c;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text); textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text); textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text); textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text); textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = (float)Math.Sqrt(a); textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = (float)Math.Pow(a, 2); textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = (float)Math.Abs(a); textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label2.Text = a.ToString() + "-";
            semn = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label2.Text = a.ToString() + "*";
            semn = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label2.Text = a.ToString() + "/";
            semn = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculate();
            label2.Text = "";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";

        }

        private void button21_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1; string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (semn == true)
            {
                textBox1.Text = "-" + textBox1.Text; semn = false;

            }
            else if (semn == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", ""); semn = true;

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label2.Text = "V"+a.ToString();
            semn = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label2.Text = "pow(" + a.ToString()+")";
            semn = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label2.Text = "|" + a.ToString() + "|";
            semn = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label2.Text = a.ToString() + "+";
            semn = true;

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToggleButtonsForSelectedSystem(string system)
        {
            // Arată toate butoanele numerice
            button37.Show(); // 0
            button38.Show(); // 1
            button39.Show(); // 2
            button40.Show(); // 3
            button41.Show(); // 4
            button42.Show(); // 5
            button43.Show(); // 6
            button44.Show(); // 7
            button45.Show(); // 8
            button46.Show(); // 9
            button30.Show(); // A
            button31.Show(); // B
            button32.Show(); // C
            button33.Show(); // D
            button29.Show(); // E
            button24.Show(); // F

            // Sistemul numeric selectat
            switch (system)
            {
                case "Bin":
                    // Ascundem toate butoanele, în afară de 0 și 1
                    button38.Hide(); // 2
                    button39.Hide(); // 3
                    button40.Hide(); // 4
                    button41.Hide(); // 5
                    button42.Hide(); // 6
                    button43.Hide(); // 7
                    button44.Hide(); // 8
                    button45.Hide(); // 9
                    button30.Hide(); // A
                    button31.Hide(); // B
                    button32.Hide(); // C
                    button33.Hide(); // D
                    button29.Hide(); // E
                    button24.Hide(); // F
                    break;

                case "Dec":
                    // Ascundem butoanele A, B, C, D, E, F
                    button30.Hide(); // A
                    button31.Hide(); // B
                    button32.Hide(); // C
                    button33.Hide(); // D
                    button29.Hide(); // E
                    button24.Hide(); // F
                    break;

                case "Oct":
                    // Ascundem butoanele 8, 9, A, B, C, D, E, F
                    button39.Hide(); // 8
                    button38.Hide(); // 9
                    button30.Hide(); // A
                    button31.Hide(); // B
                    button32.Hide(); // C
                    button33.Hide(); // D
                    button29.Hide(); // E
                    button24.Hide(); // F
                    break;

                case "Hex":
                    // Arătăm toate butoanele (pentru Hex nu ascundem niciunul)
                    break;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //Hex
            textBox2.BackColor = Color.Gray;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            ToggleButtonsForSelectedSystem("Hex");

            selected = 1;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //Dec
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.Gray;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;

            ToggleButtonsForSelectedSystem("Dec");

            selected = 2;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //Oct
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.Gray;
            textBox5.BackColor = Color.White;

            ToggleButtonsForSelectedSystem("Oct");

            selected = 3;
        }


        private void button28_Click(object sender, EventArgs e)
        {
            //Bin
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.Gray;

            ToggleButtonsForSelectedSystem("Bin");

            selected = 4;
        }


        public string inverseString(string input)
        {
            char[] array = input.ToCharArray(); 
            Array.Reverse(array); 
            return new string(array); 
        }

        private void calculateToHex()
        {
            if(selected == 3)
            {
                string toDisplay;
                
                int nr = Convert.ToInt32(c);
                string output = "";
                

                while(nr > 0)
                {
                    int res = nr % 16;
                    nr = nr / 16;

                    switch (res)
                    {
                        case 0:
                            output += "0";
                            break;
                        case 1:
                            output += "1";
                            break;
                        case 2:
                            output += "2";
                            break;
                        case 3:
                            output += "3";
                            break;
                        case 4:
                            output += "4";
                            break;
                        case 5:
                            output += "5";
                            break;
                        case 6:
                            output += "6";
                            break;
                        case 7:
                            output += "7";
                            break;
                        case 8:
                            output += "8";
                            break;
                        case 9:
                            output += "9";
                            break;
                        case 10:
                            output += "A";
                            break;
                        case 11:
                            output += "B";
                            break;
                        case 12:
                            output += "C";
                            break;
                        case 13:
                            output += "D";
                            break;
                        case 14:
                            output += "E";
                            break;
                        case 15:
                            output += "F";
                            break;
                    }
                }

                toDisplay = inverseString(output);

                textBox2.Text = toDisplay;
            }
        }

        private void calculateToOct()
        {
            if(selected == 3)
            {
                string toDisplay;

                int nr = Convert.ToInt32(c);
                string output = "";


                while (nr > 0)
                {
                    int res = nr % 8;
                    nr = nr / 8;

                    switch (res)
                    {
                        case 0:
                            output += "0";
                            break;
                        case 1:
                            output += "1";
                            break;
                        case 2:
                            output += "2";
                            break;
                        case 3:
                            output += "3";
                            break;
                        case 4:
                            output += "4";
                            break;
                        case 5:
                            output += "5";
                            break;
                        case 6:
                            output += "6";
                            break;
                        case 7:
                            output += "7";
                            break;
                    }
                }

                toDisplay = inverseString(output);

                textBox4.Text = toDisplay;

            }
        }

        private void calculateToBin()
        {
            if (selected == 3)
            {
                string toDisplay;

                int nr = Convert.ToInt32(c);
                string output = "";


                while (nr > 0)
                {
                    int res = nr % 2;
                    nr = nr / 2;

                    switch (res)
                    {
                        case 0:
                            output += "0";
                            break;
                        case 1:
                            output += "1";
                            break;
                    }
                }

                toDisplay = inverseString(output);

                textBox5.Text = toDisplay;

            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            //1
            c = c + "1";
            calculateToHex();
            calculateToOct();
            calculateToBin();
            textBox3.Text = c;

            //textBox2.Text;


        }

        private void button45_Click(object sender, EventArgs e)
        {
            //2
            c = c + "2";
            calculateToOct();
            calculateToHex();
            calculateToBin();
            textBox3.Text = c;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            c = c + "3";
            calculateToOct();
            calculateToHex();
            calculateToBin();
            textBox3.Text = c;

            //3
        }

        private void button43_Click(object sender, EventArgs e)
        {
            c = c + "4";
            calculateToHex();
            calculateToOct();
            calculateToBin();
            textBox3.Text = c;
            //4
        }

        private void button42_Click(object sender, EventArgs e)
        {
            c = c + "5";
            calculateToHex();
            calculateToOct();
            calculateToBin();
            textBox3.Text = c;
            //5
        }

        private void button41_Click(object sender, EventArgs e)
        {
            c = c + "6";
            calculateToHex();
            calculateToOct();
            calculateToBin();
            textBox3.Text = c;
            //6
        }

        private void button40_Click(object sender, EventArgs e)
        {
            c = c + "7";
            calculateToHex();
            calculateToOct();
            calculateToBin();
            textBox3.Text = c;
            //7
        }

        private void button39_Click(object sender, EventArgs e)
        {
            c = c + "8";
            calculateToHex();
            calculateToOct();
            calculateToBin();

            textBox3.Text = c;
            //8
        }

        private void button38_Click(object sender, EventArgs e)
        {
            c = c + "9";
            calculateToOct();
            calculateToBin();
            calculateToHex();
            textBox3.Text = c;
            //9
        }

        private void button37_Click(object sender, EventArgs e)
        {
            c = c + "0";
            calculateToHex();
            calculateToOct();
            calculateToBin();
            textBox3.Text = c;
            //0
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //A
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //B
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //C
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //D
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //E
        }


        private void button24_Click(object sender, EventArgs e)
        {
            //F
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //EQUALS
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //CLEAR
        }

        





    }
}
