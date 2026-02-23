using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadacha5
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Vuvedete chsila (izpolzvaite space ili zapetai): ");
            var red = Console.ReadLine();
            var numbers = string.IsNullOrWhiteSpace(red)
                ? new List<int>()
                : red.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                      .SelectMany(s => int.TryParse(s, out var v) ? new[] { v } : Array.Empty<int>())
                      .ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("Nqma vuvedeni chisla.");
                return;
            }

            var prosti = numbers.Where(IsPrime).ToList();
            var NEprosti = numbers.Where(n => !IsPrime(n)).ToList();
            var chetni = numbers.Where(n => n % 2 == 0).ToList();
            var NEchetni = numbers.Where(n => n % 2 != 0).ToList();

            Console.WriteLine("Chislata " + (prosti.Count > 0 ? string.Join(", ", prosti) : "Nqma") + " sa prosti");
            Console.WriteLine("Chislata " + (NEprosti.Count > 0 ? string.Join(", ", NEprosti) : "Nqma") + " ne sa prosti");
            Console.WriteLine("Chislata " + (chetni.Count > 0 ? string.Join(", ", chetni) : "Nqma") + " sa chetni");
            Console.WriteLine("Chislata " + (NEchetni.Count > 0 ? string.Join(", ", NEchetni) : "Nqma") + " ne sa chetni");
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if ((number & 1) == 0) return false;
            for (int i = 3; i * i <= number; i += 2)
                if (number % i == 0) return false;
            return true;
        }
    }
}