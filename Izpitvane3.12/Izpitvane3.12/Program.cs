using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Izpitvane3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Vuvedete chislo ot 1 do 4: ");
                n = int.Parse(Console.ReadLine());
            } while (n<1 || n>4);

            if (n == 1)
            {
                Console.WriteLine("Vuvedohte 1");
            }
            if (n == 2)
            {
                Console.WriteLine("Vuvedohte 2");
            }
            if (n == 3)
            {
                Console.WriteLine("Vuvedohte 3");
            }
            if (n == 4)
            {
                Console.WriteLine("Vuvedohte 4");
            }
            if(n >= 5)
            {
                Console.WriteLine("Nevalidno chislo");
            }

        }
    }
}
