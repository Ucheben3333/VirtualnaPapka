namespace KvartalnoMagazinche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete v koi grad ste - ");
            string city = Console.ReadLine();
            var coffeePrice = 0.0;
            var waterPrice = 0.0;
            var sweetsPrice = 0.0;
            var beerPrice = 0.0;
            var peanutsPrice = 0.0;

            if (city == "Sofia")
            {
                coffeePrice = 0.50;
                waterPrice = 0.80;
                sweetsPrice = 1.45;
                beerPrice = 1.20;
                peanutsPrice = 1.60; //1,50lv
            }
            if (city == "Plovdiv")
            {
                coffeePrice = 0.40;
                waterPrice = 0.70;
                sweetsPrice = 1.30;
                beerPrice = 1.15;
                peanutsPrice = 1.50; //2lv
            }
            if (city == "Varna")
            {
                coffeePrice = 0.45;
                waterPrice = 0.70;
                sweetsPrice = 1.10;
                beerPrice = 1.10;
                peanutsPrice = 1.55;
            }
            ///......................
            ///
            Console.Write("Vuvedete product - ");
            string product = Console.ReadLine();

            Console.Write("Vuvedete broi producti");
            int kolichestvo = int.Parse(Console.ReadLine());


        }
    }
}
