using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratOtZvezdi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Shte pechatim {} reda = ");
            int N = int.Parse(Console.ReadLine());
            
            for (int j = 1; j <= N; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();


            }
        
        }
    }
}
