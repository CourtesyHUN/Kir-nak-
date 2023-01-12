using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_0110
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Random rnd = new Random();
            int rnd1 = rnd.Next(1, 10001);
            int rnd2 = rnd.Next(1, 10001);
            Console.WriteLine(rnd1.ToString());
            Console.WriteLine(rnd2.ToString());
            Console.ReadKey();

            //2. feladat
            Console.Write("Kérem az angol mondatot: ");
            string mondat = Console.ReadLine();

            Console.WriteLine(Szamol(mondat));
            Console.ReadKey();

            //3. feladat

            Console.Write("Szam1 : ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Szam2 : ");
            int end = Convert.ToInt32(Console.ReadLine());
            int ossz = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0) 
                {
                    ossz += i;
                }
            }
            Console.WriteLine(ossz);
            Console.ReadKey();

            //4. feladat

            Console.WriteLine("Magasság: ");
            int magas = int.Parse(Console.ReadLine());

            for (int sor = 1; sor <= magas; sor++)
            {
                for (int space = magas - sor; space > 0; space--)
                {
                    Console.Write(" ");
                }

                for (int oszlop = 1; oszlop <= 2 * sor - 1; oszlop++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();

            //5. feladat
            Console.WriteLine("Mondat: ");
            string text = Console.ReadLine();
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();

            //6. feladat

            Random rnd = new Random();
            int rnd1 = rnd.Next(1, 101);

            int virag1 = rnd1 / 3;
            int virag2 = rnd1 / 4;

            while (rnd1 % 100 == 0)
            {
                virag1 -= 1;
                virag2 -= 1;
            }

            Console.WriteLine("Az erdei sétád során " + virag1 + " pajzsikát és " + virag2 + " citromgüvet láttál.");
            
            Console.ReadLine();
        }
        static int Szamol(string mondat)
        {
            int db = 0;
            char[] betuk = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i= 0; i < mondat.Length; i++)
            {
                if (betuk.Contains(mondat[i]))
                {
                    db++;
                }
            }
            return db;
        }

    }
}
