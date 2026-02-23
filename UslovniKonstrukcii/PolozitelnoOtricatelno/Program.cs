namespace PolozitelnoOtricatelno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedete chislo: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Chisloto e 0");
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine($"Chisloto {num} e otricatelno");
                }

        }
    }
}
