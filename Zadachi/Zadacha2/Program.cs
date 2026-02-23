using System;

namespace Zadacha2
{
    internal static class Program
    {
        private static void Main()
        {
            double radius = ReadPositiveDouble("radius");
            double height = ReadPositiveDouble("visochina");

            double s = 2.0 * Math.PI * radius * (radius + height);
            double V = Math.PI * radius * radius * height;   

            Console.WriteLine($"s = {s}");
            Console.WriteLine($"V = {V}");
        }

        private static double ReadPositiveDouble(string name)
        {
            double value;
            Console.Write($"Zapishete {name}: ");
            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0.0)
            {
                Console.WriteLine("Nevaliden format.");
                Console.Write($"Zapishete {name}: ");
            }

            return value;
        }
    }
}