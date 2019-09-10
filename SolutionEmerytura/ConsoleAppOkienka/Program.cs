using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleAppOkienka
{
    class Program
    {
        const int wiekEmerytalny = 67;

        static void Main(string[] args)
        {
            Interaction.MsgBox("Aplikacja EMERYTURA");




            Interaction.MsgBox("Podaj imię:");

            string imie = Interaction.InputBox("Podaj imię:");
            Console.WriteLine($"Witaj {imie}");

            Console.Write("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek < wiekEmerytalny)
            {
                Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury.");

            }
            else
            {
                Console.WriteLine("Jesteś emerytem.");
            }
            // Console.ReadKey();//oczekuje na naciśnięcie dowolnego klawisza lub crt + f5
        }
    }
}
