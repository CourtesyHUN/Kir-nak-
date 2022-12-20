using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        static int szam;
        static void Main(string[] args)
        {
            string mp = "0";
            while (mp != "5")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Adat bekérése");
                Console.WriteLine("2. Karácsonyfa");
                Console.WriteLine("3. Műveletek");
                Console.WriteLine("4. Prímszám-e?");
                Console.WriteLine("5. Nem");
                Console.WriteLine("------------------");
                Console.Write("Menüpont választás: ");
                mp = Console.ReadLine();
                Console.WriteLine("------------------");
                switch (mp)
                {
                    case "1":
                        beolvas();
                        break;
                    case "2":
                        karacsonyfa(szam);
                        break;
                    case "3":
                        muveletek();
                        break;
                    case "4":
                        Console.Clear();
                        if (prim(szam))
                        {
                            Console.WriteLine("A(z) {0} prímszám", szam);
                        }
                        else
                        {
                            Console.WriteLine("A(z) {0} nem prímszám", szam);
                        }
                        Console.ReadKey();
                        break;
                        
                }
            }
        }
        static void beolvas()
        {
            Console.Clear();
            Console.Write("Kérek egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());
        }
        static void Color()
        {
            Random rnd = new Random();
            int r = rnd.Next(4);
            if (r == 0) Console.ForegroundColor = ConsoleColor.Red;
            if (r == 1) Console.ForegroundColor = ConsoleColor.Blue;
            if (r == 2) Console.ForegroundColor = ConsoleColor.Yellow;
            if (r == 3) Console.ForegroundColor = ConsoleColor.Cyan;

        }
        static void karacsonyfa(int sor)
        {
            Console.Clear();

            int osszcs = 2 * sor - 1;
            int szokoz;
            int csillag = 1;
            for (int i = 0; i < sor; i++)
            {
                szokoz = (osszcs - csillag)/2;
                for (int j = 0; j < szokoz; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < csillag; j++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                        System.Threading.Thread.Sleep(10);
                    }
                    else if (j%4==0)
                    {
                        Color();
                        Console.Write("*");
                        System.Threading.Thread.Sleep(10);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                        System.Threading.Thread.Sleep(10);
                    }
                }
                for (int j = 0; j < szokoz; j++)
                {
                    Console.Write(" ");
                }
                csillag += 2;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void muveletek()
        {
            Console.Clear();
            Console.WriteLine("A szám kétserese: {0}", 2*szam);
            Console.WriteLine("A szám négyzete: {0}", szam*szam);
            Console.WriteLine("A szám köbe: {0}", Math.Pow(szam,3));
            Console.WriteLine("A szám gyöke: {0}", Math.Sqrt(Convert.ToDouble(szam)));
            Console.ReadKey();
        }
        static bool prim(int x)
        {
            int oszto = 0;
            for (int i = 2; i < x; i++)
            {
                if (x%i == 0)
                {
                    oszto++;
                }
            }
            return oszto == 0;
        }
    }
    
}
