using System;
using System.Collections.Generic;
using System.Linq;

namespace remove20_2_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chisla edno po edno. Vuvedete otricen broj za kraj.");

            var list = new List<int>();

            Console.WriteLine("Tekusht spisuk: " + (list.Count == 0 ? "(prazno)" : string.Join(", ", list)));

            Console.Write("Vuvedete chislo za premahvane: ");
            int numberToRemove;
            while (!int.TryParse(Console.ReadLine(), out numberToRemove))
            {

            }

            int element = list.Count(x => x == numberToRemove);
            if (element >= 2)
            {
                list.RemoveAll(x => x == numberToRemove);
                Console.WriteLine($"Chisloto {numberToRemove} e premahnto (namereno {element} puti).");
            }

        }
    }
}