using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cikli
{
    internal class Program
    {
        static void Main(string[] args)
        
            {
            for (int i = 5; i <= 25; i=i+2)
            {
                Console.WriteLine("i = " + i);
            }
            Console.WriteLine("End.");
            Console.ReadLine();
        }
    }
}
