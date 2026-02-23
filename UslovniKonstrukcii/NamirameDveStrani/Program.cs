namespace NamirameDveStrani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislata za da reshish tzai zadacha");
            Console.Write("Vuvdedi a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Vuvedi b: ");
            var b = int.Parse(Console.ReadLine());

            var S = (a+b) / 2;
            Console.WriteLine($"s={S} ");

            var c = (a * b * b * b) / 2;
            Console.WriteLine($"c = {c} cm");
            var P = (a * b * c);
            Console.WriteLine($"p = {P} cm");
        }
    }
}
