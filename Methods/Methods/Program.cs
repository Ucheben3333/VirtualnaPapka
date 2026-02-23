using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHeader(1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Hello, World!");
            Console.Write("Vavedete chislo: ");
            int number = int.Parse(Console.ReadLine());
            double result = GetSquare(number);
            Console.WriteLine(result);
            PrintHeader(2);
        }
        static double GetSquare(double number)
        {
            return number * number;
        }

        static void PrintHeader(int counter)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"===  Tova printira methoda za {counter} put  ===");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
