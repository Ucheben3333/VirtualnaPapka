namespace nov3._6._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClassCar> cars = new List<ClassCar>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i< n ; i++ )
            {
                Console.WriteLine("-------------------");
                Console.Write("Marka: ");
                string brand = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Godina: ");
                int godina = int.Parse(Console.ReadLine());

                ClassCar car = new ClassCar(brand, model, godina);
                cars.Add(car);
            }
            foreach(ClassCar car in cars)
            {
                Console.WriteLine("-------------------");
                car.PrintInfo();
                car.sustoqnie();
            }
            Console.WriteLine($"Broi koli: {ClassCar.Count}");
            Console.WriteLine("-------------------");
        }
    }
}
