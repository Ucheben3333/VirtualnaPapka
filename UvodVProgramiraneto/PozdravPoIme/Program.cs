namespace PozdravPoIme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Vavedete ime: ");
            var name = Console.ReadLine(); // chete imeto ni s bukvi
            Console.WriteLine("Hello, " + name + "!" + " :) ");
        }
    }
}
