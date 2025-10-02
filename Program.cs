using System;

namespace C_Ciklusokfeladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int db = 0;
            string szo = "";
            do
            {
                Console.Write("Kérem a szót:");
                szo = Console.ReadLine();

                if (szo.Length > 5)
                    db++;
            } while (szo != "vége");
            Console.WriteLine($"{db} 5 karakternél hosszab szó volt");

            /*Feladat3
            int paros = 0, paratlan = 0, szam;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Kérem a számot:");
                szam = int.Parse(Console.ReadLine());

                if (szam % 2 == 0)
                    paros++;
                else
                    paratlan++;
            }
            Console.WriteLine($"A páros számokból {paros} a pártlanokból {paratlan} volt.");*/

            /*Feladat1
            int szam = 0;
            List<int> szamok = new List<int>();
            do
            {
                Console.Write("Kérem a számot:");
                szam = int.Parse(Console.ReadLine());
                szamok.Add(szam);

            } while (szam != 0);

            List<int> dbLista = new List<int>();

            for (int i = 0; i < szamok.Count; i++)
            {
                int db = 0;
                for (int j = 0; j < szamok.Max(); j++)
                {
                    if (szamok[i] == j)
                    {
                        db++;
                    }
                }
                dbLista.Add(db);
                db = 0;
            }

            int max = 0;
            int id = 0;
            for (int i = 0; i < dbLista.Count; i++)
            {
                if (dbLista[i] > max)
                {
                    max = dbLista[i];
                    id = i;
                }
            }
            Console.WriteLine($"A legtöbbször beütött szám {szamok[id]} szám volt.");*/

            /*Feladat1
            List<int> szamok = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Kérem az {i + 1}. számot:");
                szamok.Add(int.Parse(Console.ReadLine()));
            }

            if (szamok[0] > szamok[1])
                Console.WriteLine("Az első szám a nagyobb.");
            else
                Console.WriteLine("A második szám a nagyobb");

            Console.WriteLine(Math.Abs(szamok[0] - szamok[1]));*/

            /*Dictionary<int, string> dobasEredmeny = new Dictionary<int, string>();
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
                Console.WriteLine("A játékot a gép nyerte.");*/



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
