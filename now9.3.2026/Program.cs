using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace now9._3._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 5, 6 };
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                int temp = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > temp)
                {
                    numbers[j + 1] = numbers[j]; //premestvane na dqsno
                    j--;
                }
                numbers[j + 1] = temp; //vryshtane na temp na pravilnoto mu mqsto
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
