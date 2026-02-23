using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Vuvedete chislo ot klaviaturata: ");
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write(".");
            }

            Console.Write("Vuvedete vtoroto chislo ot klaviaturata: ");
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write(".");
            }

            int naimalko = Math.Min(number1, number2);
            int naigolqmo = Math.Max(number1, number2);

            
            if (naimalko % 2 != 0) naimalko++;

            if (naimalko > naigolqmo)
            {
                Console.Write(".");
            }
            else
            {
                for (int i = naimalko; i <= naigolqmo; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}