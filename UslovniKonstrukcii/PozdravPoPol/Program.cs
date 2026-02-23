using System.ComponentModel.Design;

namespace PozdravPoPol
{
    internal class Program
    {
        static void Main(string[] args)
        {//input
            Console.Write("Vuvedete pola f/m - ");
            var gender = Console.ReadLine();

            Console.Write("Vuvedete vuzrast - ");
            var age = int.Parse(Console.ReadLine());

            //logic
            if (age > 16)
            {
                //Mr ili Mrs
                if(gender == "f")
                    Console.WriteLine("Miss");
            }
            else //obratnoto na >16 e >=16
            {
                Console.WriteLine("Master");
            }//Master ili Miss


            else
            {
                if (gender == "m")
                    Console.WriteLine("Mr");
            }
        }
    }
}
