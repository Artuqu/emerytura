using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprawki
{
    class Program
    {
        static void Main1(string[] args)
        {
            int x = int.MaxValue;
            int y = 2;
            int z = x + y;

            Console.WriteLine(z);
            checked { z = x + y; }

            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            double x = 0.1;
            double y = 0.2;
            double z = 0.3;
            Console.WriteLine(x + y == z);//false
        }

        static void Main3(string[] args)
        {
            decimal x = 0.1m;   // różne wartości double i float, rzutowanie, konwersja
            float y = 0.1f;         // literał typu float
            decimal suma = 0;         // domyślna konwersja 0 --> 0.0

            suma = suma + x;
            for (int i = 1; i <= 1000000; i++)          //milion razy wykonaj
            {
                suma = suma + x;                        //sumuj akumulacyjnie
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }

        static void Main4(string[] args)
        {
            char znak = 'a';
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((char)(znak + i));
                Console.ReadKey();
            }
            {
                string napis = "a";
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(napis + i);
                    Console.ReadKey();
                }
            }
        }

        static void Main5(string[] args)
        {
            string napis = "Ala ma kota";
            for (int i = napis.Length - 1; i >= 0; i--)

            {
                Console.Write(napis[i]);



            }


        }

        static void Main(string[] args)
        {
            int x=3, y=5;
            int z = 0;
            int u = x;
            do
            {
                z += y;//z = z + y;
                u--;//u = u - 1;
            } while (u != 0);
            Console.WriteLine(z);


        }
    }
}
