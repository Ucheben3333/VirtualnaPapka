using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete N = ");
            int n = int.Parse(Console.ReadLine());

            int MAX = int.MinValue; //0
            int MIN = int.MaxValue; // mnogo golqmo chislo
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Vuvedi {i} chislo ");
                int number = int.Parse(Console.ReadLine());

                if (number > MAX)
                {
                    MAX = number;
                }
                if(number < MIN)
                {
                    MIN = number;
                }
                Console.WriteLine($"MAX = {MAX}");
                Console.WriteLine($"MIN = {MIN}");
            }
        }
    }
}
