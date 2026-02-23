using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNechetniDoN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo N: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sumata na nechetnite chisla do N e: " + sum);
        }
    }
}
