using System.Security.Cryptography.X509Certificates;

namespace list18_2_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvejdane na elemnti i tursene na stoinost v SPISAK!!");

            List<string> imena = new List<string>();

            imena.Add("Alex");
            imena.Add("15");

            Console.WriteLine("Vkaraite 3 neshta ot klaviaturata");
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());
            Console.WriteLine("Vuvedete imena >>>> END za krai");

            string stringInput = Console.ReadLine();
            while (stringInput != "END")
            {
              imena.Add(stringInput);
              stringInput = Console.ReadLine();
            }
            if (imena.Contains("Dimo"))
            {
                Console.WriteLine("Dimo e v spisuka!");
            }
            else
            {
                Console.WriteLine("Dimo NE E v spisuka!!");
            }
                Console.Write(string.Join(",", imena));
        }
    }
}
