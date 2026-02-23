using System;
using System.Linq;
using System.Collections.Generic;

namespace zadacha13_2_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var Chetni = numbers.Where(n => n % 2 == 0).ToList();
            var Nechetni = numbers.Where(n => n % 2 != 0).ToList();
            var polozitelni = numbers.Where(n => n > 0).ToList();
            var otricatelni = numbers.Where(n => n < 0).ToList();

            Console.WriteLine("Chetni: " + (Chetni.Any() ? string.Join(", ", Chetni) : "Nqma"));
            Console.WriteLine("Nechetni: " + (Nechetni.Any() ? string.Join(", ", Nechetni) : "Nqma"));
            Console.WriteLine("Polozitelni: " + (polozitelni.Any() ? string.Join(", ", polozitelni) : "Nqma"));
            Console.WriteLine("Otricatelni: " + (otricatelni.Any() ? string.Join(", ", otricatelni) : "Nqma"));
        }
    }
}