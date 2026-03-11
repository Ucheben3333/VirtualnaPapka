using System.Security.Cryptography.X509Certificates;

namespace izpit11._3._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
             .Split(' ')
             .Select(int.Parse)
             .ToArray();
            Console.WriteLine(string.Join(" ", numbers));
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Nqma vkarani chisla");
            }
            string[] number = input.Split(' ');


        }
    }
}
