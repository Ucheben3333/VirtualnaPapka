using System;

namespace Zadacha4
{
    internal static class Program
    {
        private static void Main()
        {
            double[] number = new double[3];
            for (int i = 0; i < number.Length; i++)
                number[i] = ReadDouble($"Napishete chislo {i + 1}: ");

            Array.Sort(number);
            Console.WriteLine(string.Join("<", number));

            double naimalko = number[0];
            double naigolqmo = number[number.Length - 1];
            double srednoaritmetichno = (number[0] + number[1] + number[2]) / 3.0;

            Console.WriteLine($"Nai-malkoto chislo = {naimalko}");
            Console.WriteLine($"Nai-golyamoto chislo = {naigolqmo}");
            Console.WriteLine($"Srednoaritmetichno = {srednoaritmetichno}");
        }

        private static double ReadDouble(string prompt)
        {
            double stoinost;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out stoinost))
            {
                Console.WriteLine("Nevalidna stoinost.");
                Console.Write(prompt);
            }

            return stoinost;
        }
    }
}