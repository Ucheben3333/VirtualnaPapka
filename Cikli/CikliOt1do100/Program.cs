using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CikliOt1do100
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
                for (int i = 1; i <16; i++)
                {
                    Console.Write($"Vuvedi {i} chislo: ");
                    int number = int.Parse(Console.ReadLine());
            }
               // Console.WriteLine("1");
                Console.WriteLine(" End.");
                Console.ReadLine();
            }
    }
}
