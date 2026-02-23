using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetnoIliNechetno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete chislo:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {//chisloto e chetno
                Console.WriteLine("even");
            }
            else
            {// chisloto e nechetno
                Console.WriteLine("odd");
            }
        }
    }
}
