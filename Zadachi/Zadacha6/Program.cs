using System;

namespace Zadacha6
{
    internal static class Program
    {
        private static void Main()
        {
            int obshto = 0;
            int oricatelni = 0;

            while (true)
            {
                Console.Write("Napishete chislo (0 za da spre programata): ");
                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("Nevalidna stoinost");
                    continue;
                }

                if (n == 0) break;

                obshto++;
                if (n < 0) oricatelni++;
            }

            Console.WriteLine($"Obshto vuvedeni chisla: {obshto}");
            Console.WriteLine($"Oricatelni chisla: {oricatelni}");
        }
    }
}