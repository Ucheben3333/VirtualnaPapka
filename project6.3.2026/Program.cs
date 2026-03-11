using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6._3._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int[] numbers = { 5, 2, 9, 1};
            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(numbers + " -- ");
            }
            Console.WriteLine(string.Join(", ", numbers));
            
            List<int> listnames = new List<int>() { 5, 2, 9, 1 };
            listnames.Sort();
            listnames.Reverse();

            Console.WriteLine(string.Join(", ", listnames));
        }
    }
}
