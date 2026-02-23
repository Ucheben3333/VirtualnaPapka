using System;

namespace Zadacha3
{
    internal static class Program
    {
        private static void Main()
        {
            int number = ReadThreeDigitPositiveNumber();

            int stotici = number / 100;
            int desetici = (number / 10) % 10;
            int edinici = number % 10;

            Console.WriteLine($"Cifrata na stoticite e: {stotici}");
            Console.WriteLine($"Cifrata na deseticite e: {desetici}");
            Console.WriteLine($"Cifrata na edinicite e: {edinici}");
        }

        private static int ReadThreeDigitPositiveNumber()
        {
            int stoinost;
            Console.Write("Napishete chislo: ");
            while (!int.TryParse(Console.ReadLine(), out stoinost) || stoinost < 100 || stoinost > 999)
            {
                Console.WriteLine("Napishete polozitelno chislo (100-999).");
                Console.Write("Napishete chislo: ");
            }

            return stoinost;
        }
    }
}
