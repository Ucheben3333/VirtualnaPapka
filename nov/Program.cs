namespace nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(string.Join(" ", numbers));
            {
                Console.WriteLine(numbers);
            }
            List<string> imena = Console.ReadLine()
                .Split(' ')
                .ToList();
            int input = int.Parse(Console.ReadLine());
            while (input != 0)
            {
                numbers.Add(input);
                input = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
