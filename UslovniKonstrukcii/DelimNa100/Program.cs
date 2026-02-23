namespace DelimNa100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo: ");
            var number = int.Parse(Console.ReadLine());

            if (number %100 == 0)
            {
                Console.WriteLine("Chisloto se deli na 100");
            }
            else
            {
                Console.WriteLine("Chisloto ne se deli na 100");
            }
        }
    }
}
