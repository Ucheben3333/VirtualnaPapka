using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //namirane na "n" factoriel na chislo n! = n ...... 2.1
            // 7! = 7.6.5.4.3.2.1
            Console.Write("Vuvedi chislo za izchislyavane na factoriel: ");
            int number = int.Parse(Console.ReadLine());

            var P = 1;
            for (int i = 1 ; i <= number; i++)
            {
                P = P * i; //!!!!!
                Console.Write($"P{i} * ");
            }

            Console.WriteLine($"{number}! = {P}");
        }
    }
}
