using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleneNa5do100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete chislo ot 1 do 100 za delene na 5");
            var num = int.Parse(Console.ReadLine());
            for (int i=1; i<=100; i++)
            {if (i%5 == 0)
                Console.WriteLine(i);
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {0}", num);


        }
    }
}
