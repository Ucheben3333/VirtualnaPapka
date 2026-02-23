namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vuvedete proizvolen broi chisla, dokato ne vuvedete 0
            Console.WriteLine("Vuvedete proizvolen broi chisla (za krai vuvedete 0)");
            int sum = 0;
            byte number1, number2;
            do
            {
                Console.Write("Vuvedete edno chislo: ");
                number1 = byte.Parse(Console.ReadLine());
                Console.WriteLine($"Chastnoto e {number1/2} -----------> {number1%2} e ostatuk.");

                Console.WriteLine("Vuvedete prosto chislo: ");
                number2 = byte.Parse(Console.ReadLine());
                Console.WriteLine($"Chisloto e {number1/number2}" + $" -----------> {number1%number2} e ostatuk.");

            }  while (number1 != 0 && number2 != 0);

        }
    }
}
