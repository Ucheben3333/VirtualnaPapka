using System;

namespace Project10._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napishete visochina na durvoto (5-20): ");
            int visochina;
            while (!int.TryParse(Console.ReadLine(), out visochina) || visochina < 1)
            {
                Console.Write(" * ");
            }

            
            for (int red = 0; red < visochina; red++)
            {
                int spaces = visochina - 1 - red;
                int zvezdi = 2 * red + 1;
                Console.Write(new string(' ', spaces));
                Console.WriteLine(new string('*', zvezdi));
            }

            
            int visochinaStublo = Math.Max(1, visochina / 3);
            int shirochina = Math.Max(1, visochina / 3);
            if (shirochina % 2 == 0) shirochina++;
            int dolnaChast = visochina - 1 - shirochina / 2;

            for (int t = 0; t < visochinaStublo; t++)
            {
                Console.Write(new string(' ', dolnaChast));
                Console.WriteLine(new string('*', shirochina));
            }
        }
    }
}