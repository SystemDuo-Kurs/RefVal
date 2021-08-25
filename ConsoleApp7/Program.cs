using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 5;
            Console.WriteLine($"Na pocetku, broj je {broj}");
            Uvecaj(broj);
            Console.WriteLine($"Na kraju, broj je {broj}");

            List<int> brojevi = new();
            brojevi.Add(5);
            Console.WriteLine($"Na pocetku, broj je {brojevi[0]}");
            UvecajLista(brojevi);
            Console.WriteLine($"Na kraju, broj je {brojevi[0]}");
        }

        static void UvecajLista(List<int> nesto)
        {
            nesto[0]++;
            Console.WriteLine($"Broj je, u metodi, {nesto[0]}");
        }
        static void Uvecaj(int x)
        {
            x++;
            Console.WriteLine($"Broj je, u metodi, {x}");
        }
    }
}
