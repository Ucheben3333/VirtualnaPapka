using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo N :");

            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}