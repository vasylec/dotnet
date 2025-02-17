using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab5
{
    static class Program
    {
        public static List<elev> elevi = new List<elev>();
        public static string info = "";
        private static void upload()
        {
            StreamReader sr = new StreamReader("elevi.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                info = info + "\n" + line ;
                string[] s = line.Split(' ');
                int[] n = new int[4];
                n[0] = int.Parse(s[3]);
                n[1] = int.Parse(s[4]);
                n[2] = int.Parse(s[5]);
                n[3] = int.Parse(s[6]);
                elevi.Add(new elev(s[0], s[1], int.Parse(s[2]), n));
            }
            sr.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            upload();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
