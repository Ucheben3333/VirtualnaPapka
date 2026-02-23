using System;

namespace Zadachi
{
    internal static class Program
    {
        private static void Main()
        {
            double a = ReadSide("a");
            double b = ReadSide("b");
            double c = ReadSide("c");

            double perimeter = a + b + c;
            double s = perimeter / 2.0;
            double area = Math.Sqrt(Math.Max(0.0, s * (s - a) * (s - b) * (s - c)));

            Console.WriteLine($"Perimetur P = {perimeter}");
            Console.WriteLine($"S = {area}");
        }

        private static double ReadSide(string name)
        {
            double value;
            Console.Write($"Napishete stoinost {name}: ");
            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0.0)
            {
                Console.WriteLine("Nevaliden format.");
                Console.Write($"Napishete stoinost {name}: ");
            }

            return value;
        }

    }
}