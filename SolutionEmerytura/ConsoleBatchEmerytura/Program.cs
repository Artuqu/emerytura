using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBatchEmerytura
{
    class Program
    {
        const int wiekEmerytalny = 65;
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja EMERYTURA");
            if (args.Length != 2)
            {
                Console.WriteLine("Brak danych. Koniec");
                return; // wychodzimy z Main()
            }

            string imie = args[0];
            Console.WriteLine($"Witaj {imie}");


            int wiek = int.Parse(args[1]);
            if (wiek < wiekEmerytalny)
            {
                Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury.");

            }
            else
            {
                Console.WriteLine("Jesteś emerytem.");
            }
        }
    }
}

