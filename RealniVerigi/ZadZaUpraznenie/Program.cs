namespace ZadZaUpraznenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1
            Console.WriteLine("zad1");
            double a = 7.8;
            Console.WriteLine(a / 2);
            //zad2
            Console.WriteLine("zad2");
            int a2 = 5;
            double result = (double)a2 / 2;
            Console.WriteLine(result);
            //zad3
            Console.WriteLine("zad3");
            double a3 = 9.6;
            int result3 = (int)a3 / 3;
            Console.WriteLine(result3);
            //zad4
            Console.WriteLine("zad4");
            double x = 4.5;
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Round(x));
            //zad5
            Console.WriteLine("zad5");
            double value = 6.4;
            int A = (int)value;
            int A3 = A * 3;
            Console.WriteLine(A3);
            //zad6
            {
                Console.WriteLine("zad6");
                int zad6 = 7;
                Console.WriteLine(zad6 / 2);
                Console.WriteLine((double)zad6 / 2);
            }
            //zad7
            {
                Console.WriteLine("zad7");
                double valuezad7 = 8.9;
                int zad7 = (int)Math.Round(valuezad7);
                int resultzad7 = zad7 / 2;
                Console.WriteLine(resultzad7);
            }
            //zad8
            {
                Console.WriteLine("zad8");
                double zad8 = 5;
                Console.WriteLine(zad8 / 2);
            }
            //zad9
            {
                Console.WriteLine("zad9");
                double zad9 = 3.14159;
                double drugo = Math.Round(zad9, 3);
                int resultzad9 = (int)drugo;
                Console.WriteLine(resultzad9);
            }
            //zad10
            {
                Console.WriteLine("zad10");
                int chislo = 5;
                int reshenie = chislo / 2;
                double realnoreshenie = ((double)chislo )/ 2;
                //double zakrugleno = Math.Round(2.6);//realnoreshenie);
                double zakrugleno = Math.Round(2.6);//realnoreshenie);

                Console.WriteLine(reshenie);
                Console.WriteLine(realnoreshenie);
                Console.WriteLine(Math.Ceiling(zakrugleno));
            }
        }
    }
}