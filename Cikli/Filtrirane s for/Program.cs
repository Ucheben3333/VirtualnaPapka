using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltriraneSfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            string print = "";
            int broi = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Vuvedi {i} chislo ");
                int number = int.Parse(Console.ReadLine());

                //a
                //Console.Write($"{number}, ");
                print = print + number + ", ";
                //b
                sum = sum + number;
                //c kogato namerq  number  is even => br++
                if (number %2 == 0)
                {
                    broi++;
                }
                
                {
                    Console.Write(print);
                    Console.WriteLine($" = {sum}");
                    Console.WriteLine($"broia na chetnite chisla");
                }

            }
        }
    }
}
