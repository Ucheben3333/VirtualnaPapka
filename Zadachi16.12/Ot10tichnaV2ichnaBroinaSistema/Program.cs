namespace Ot10tichnaV2ichnaBroinaSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo: ");
            byte numberDeset = byte.Parse(Console.ReadLine());

            while(numberDeset != 0)
            {
                Console.Write($"{numberDeset%16}");
                numberDeset /= 16;


            }
        }
    }
}
