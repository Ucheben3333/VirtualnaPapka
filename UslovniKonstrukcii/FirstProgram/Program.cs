namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 5;
            //var b = 10;
            //Console.WriteLine(a>b);
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.5) // 
            {
                Console.WriteLine($"Ocenkata {grade} e za stipendiq!");
            }
            else
            {
                Console.WriteLine($"Ocenkata {grade} ne e za stipendiq!");
            }
        }
    }
}
