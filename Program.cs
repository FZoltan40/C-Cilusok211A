using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Ciklusokfeladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dobasEredmeny = new Dictionary<int, string>();
            dobasEredmeny.Add(1, "Kő");
            dobasEredmeny.Add(2, "Papír");
            dobasEredmeny.Add(3, "Olló");

            int gepTalalat = 0;
            int talalat = 0;

            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Kérem a tipped:");
                string tipp = Console.ReadLine().ToLower();

                string gepTipp = dobasEredmeny.Values.ElementAt(rnd.Next(3)).ToLower();
                Console.WriteLine(gepTipp);

                if (tipp == gepTipp)
                {
                    Console.WriteLine("ugyanaz");
                }
                else if (tipp == "olló" && gepTipp == "papír" || tipp == "kő" && gepTipp == "papír" ||
                    tipp == "papír" && gepTipp == "kő")
                {
                    Console.WriteLine("Te nyertél");
                    talalat++;
                }
                else
                {
                    Console.WriteLine("Gép nyert");
                    gepTalalat++;
                }
            }

            if (talalat > gepTalalat)
                Console.WriteLine("A játkot te nyerted.");
            else
                Console.WriteLine("A játékot a gép nyerte.");



            /*List<int> szamok = new List<int>();

            int db = 0;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i % j == 0)
                    {
                        db++;
                    }
                }

                if (db <= 2)
                {
                    szamok.Add(i);
                }

                db = 0;
            }

            foreach (var item in szamok)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine($"{szamok.Count} prím szám van.");*/
        }
    }
}
