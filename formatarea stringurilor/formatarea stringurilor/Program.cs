using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;


namespace formatarea_stringurilor
{
    class Program
    {
        static void Main(string[] args)
        {
            //float x = 123.456f;
            //double y = 23.456;
            //string s;



            //s = String.Format("x = {0}, y = {1}", x, y);
            //Console.WriteLine(s);



            //Console.WriteLine("\n\n");
            //s = String.Format("x = {0,12:E3}\ny = {1,12:F2}",x,y);
            //Console.WriteLine(s);



            //Console.WriteLine("\n\n");
            //y = 23.859;
            //Console.WriteLine("|y = {0,10:F2}|", y);
            //Console.WriteLine("|y = {0,-10:F2} |", y);



            //Console.WriteLine("\n\n");
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine(int.Parse("210"));
            //Console.WriteLine(double.Parse("-498.002"));




            /////////////////////////////////////////////////




            StreamWriter fout = new StreamWriter("test.txt");

            fout.WriteLine("Acesta este un test");
            fout.WriteLine("Acesta este a doua linie din fisier");

            fout.Close();

            StreamReader fin = new StreamReader("test.txt");

            Console.WriteLine(fin.ReadLine());
            Console.Write("\n\n");
            Console.WriteLine(fin.ReadLine());

            fin.Close();



            /////////////////////////////////////////////////
            try
            {

                List<int> nr = new List<int>();

                Console.WriteLine("Da-ti 10 numere aleatorii:");

                int i = 10;

                while (i > 0)
                {
                    nr.Add(int.Parse(Console.ReadLine()));
                    i--;
                }

                Console.WriteLine("Numerele date de dvs. sunt:");
                foreach (int n in nr)
                {
                    Console.WriteLine(n);
                }

                Console.WriteLine("Doriti sa salvati numerele in fisier sau nu ? ('da' | 'nu')");

                string raspuns = Console.ReadLine();

                if (raspuns.Equals("da"))
                {
                    StreamWriter fout2 = new StreamWriter("numere.txt");
                    foreach (int n in nr)
                    {
                        fout2.WriteLine(n);
                    }
                    fout2.Close();
                }
                else if (raspuns.Equals("nu"))
                {
                    Console.WriteLine("Bine raspunsurile nu vor fi salvate ))");
                }
                else
                {
                    Console.WriteLine("Raspunsul nu este valid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("A aparut o eroare: " + e.Message);
            }




            Console.WriteLine("Am 2 poezii frumoase pentru tine, alege una ('1','2')");
            string optiune = Console.ReadLine();

            if (optiune.Equals("1"))
            {
                StreamReader p1 = new StreamReader("poezie1.txt");
                Console.WriteLine(p1.ReadToEnd());
            }
            else if (optiune.Equals("2"))
            {
                StreamReader p1 = new StreamReader("poezie2.txt");
                Console.WriteLine(p1.ReadToEnd());
            }
            else
            {
                Console.WriteLine("Nu exista astfel de optiune");
            }
        }
    }
}
