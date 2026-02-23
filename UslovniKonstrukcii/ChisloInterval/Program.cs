namespace ChisloInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo ot 1 do 100 - ");
            var number = int.Parse(Console.ReadLine());

            if(number >= 1 && number <= 100)
            {
                Console.WriteLine($"Chisloto {number} e v intervala [1 , 100] ");
            }//else
            if(!(number >= 1 && number <= 100))
            if (number <1 || number >100 )
            {
                Console.WriteLine($"Chisloto e IZVUN ");
            }
        }
    }
}
