namespace Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine()); //5
            int number2 = = int.Parse(Console.ReadLine()); //7 
            var sum = number1 + number2;
            Console.WriteLine($" {number1} + {number2} = {sum}");
        }
    }
}
