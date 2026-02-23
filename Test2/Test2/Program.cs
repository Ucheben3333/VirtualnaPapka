namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Vavedi osnova / cqlo chislo:");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Vavedi cylo chislo:");
            int secondnumber = int.Parse(Console.ReadLine());
            Novo(firstnumber, secondnumber);
        }
        public static void Novo(int firstnumber, int secondnumber)
        {
            
            if (secondnumber > 0)
            { 
                    int result = firstnumber * secondnumber;
                    Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ne raboti s otricatelni chisla");
            }
        }

    }
}
    
    

