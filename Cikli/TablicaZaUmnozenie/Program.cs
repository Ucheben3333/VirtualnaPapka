using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaZaUmnozenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tablica za umnozenie s {number}.");
            
            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine($"{i} * {number} = {i*number}");
            }
        }
    }
}
