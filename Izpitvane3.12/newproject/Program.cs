using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counterPositive = 0;
            int counterNegative = 0;
            int counterZero = 0;
            int j = 0;
            for (int i = 1; j <= 5; i++)
            {
                Console.Write("Vuvedete chislo: ");
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    counterPositive++;
                }
                else if (number < 0)
                {
                    counterNegative++;
                }
                else
                {
                    counterZero++;
                }
                Console.WriteLine($"Polozitelni: {counterPositive}");
                Console.WriteLine($"Negativni: {counterNegative}");
                Console.WriteLine($"Nuli: {counterZero}");
            }
        }
    }
}
