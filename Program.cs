using System;
using System.Collections.Generic;

namespace C_Ciklusokfeladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();

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
            Console.WriteLine($"{szamok.Count} prím szám van.");
        }
    }
}
