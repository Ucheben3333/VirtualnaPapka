namespace nov23_2_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            byte count = 0;
            byte maxCount = 0;
            int maxElement = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                //maxcount = (count > maxCount) ? count : maxCount;

                if (count > maxCount)
                {
                    maxCount = count;
                    maxElement = numbers[i];
                }
                count = 1;
                Console.WriteLine($"Max repeaterElement is {maxElement} --> {maxCount} times.");

            }
        }
    }
}