namespace Tipove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long longNumber = 9223372036854775807L; //8 bytes
            double a = 3.141592653589793238D; //8 bytes
            float b = 1.60217657f; //4 bytes
            decimal c = 7.8184261974584555216535342341m; //16 bytes
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(longNumber);
        }
    }
}
