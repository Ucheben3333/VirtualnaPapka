namespace Veriga1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1vi etap
            double number = 1.95;
            double b = number * 4;
            Console.WriteLine(Math.Round(b, 1));
            //2ri etap
            int c = (int)7.8;
            Console.WriteLine(c/2);
            //3ti etap
            int e = 3;
            int result1 = 104 * e;
            Console.WriteLine(result1);
            //4ti etap
            double result2 = (double)result1;
            double result3 = result2 / 6;
            double result4 = (double)result2;
            Console.WriteLine(Math.Round(result3, 2));
            Console.WriteLine(result3);
            Console.WriteLine($"resut3 (do dva znaka) = {result3:f2}");
            Console.WriteLine($"resut3 (do dva znaka) = {result4:f2}");
            
        }
    }
}
