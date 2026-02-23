namespace Sled15min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hours ");
            var hour = int.Parse(Console.ReadLine());
            Console.Write("Minutes ");
            var minutes = int.Parse(Console.ReadLine());

            var newMinutes = minutes + 15;
                if (newMinutes >= 60)
            {
                hour = hour + 1;
                newMinutes = newMinutes - 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            
            Console.WriteLine($"Novoto vreme e {hour} : {newMinutes}");
        }
    }
}
