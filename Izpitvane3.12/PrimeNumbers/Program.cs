using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo: ");
            int number = int.Parse(Console.ReadLine());
            int i;

            for (i = 2; i <= number-1; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"Chisloto {number} ne e prosto.");
                    break;
                }

            }
            
            if ( i == number-1)
            {
                Console.WriteLine($"Chisloto {number} e prosto.");
            }

        }
    }
}
