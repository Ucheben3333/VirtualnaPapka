using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CConsole9._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string input;
            int number = int.Parse(Console.ReadLine());
            Console.Write("Vuvedete chislo ot klaviaturata sus text: ");
            input = Console.ReadLine();

            Console.Write("Vuvedete vtoroto chislo ot klaviaturata sus text: ");
            input = Console.ReadLine();
            number = number + 1;
            Console.WriteLine($"Chisloto e: {number = number + 1} ");
            
            for (int i = 1; i >= 10; i++)
            {
                Console.WriteLine($"Chisloto e:  {i} ");
            }


        }
    }
}
