using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream_cuccok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Kell a using System.IO;*/
            StreamReader sr = new StreamReader("eloadas.txt");
            string sor = sr.ReadLine();
            int sordb = 0;
            while (sor != null)
            {
                Console.WriteLine(sor);
                sor = sr.ReadLine();
                sordb++;
            }
            Console.WriteLine(sordb);
            Console.ReadKey();
        }
    }
}
