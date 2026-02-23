namespace LiceNaKrug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
            decimal s = (decimal)Math.PI * (decimal)r * (decimal)r;
            Console.WriteLine($"S = {s}");
        }
    }
}
