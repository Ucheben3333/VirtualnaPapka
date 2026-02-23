using System;
using System.Globalization;
using System.Linq;

namespace pregovor16_2_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Nqma vkarani imena.");
                return;
            }
            string[] imena = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string longest = imena.OrderByDescending(s => s.Length).First();
            Console.WriteLine(longest);
            Console.WriteLine(string.Join(" ", imena));
        }
    }
}