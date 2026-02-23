using System;
using System.Collections.Generic;

namespace ZadachaSMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentNumber;
            Console.Write("Vuvedete chislo: ");
            while (!int.TryParse(Console.ReadLine(), out currentNumber))
            {
                Console.Write("Nevaliden vhod. Vuvedete cqlo chislo: ");
            }

            Console.WriteLine();
            Console.WriteLine("=========== Zadachi ===========");
            Console.WriteLine("1. Chetno li e chisloto");
            Console.WriteLine("2. Otricatelno ili polozitelno");
            Console.WriteLine("3. Chisloto prosto li e?");
            Console.WriteLine("4. Obrushtane na chisloto");
            Console.WriteLine("5. Vsicki deliteli na chisloto");
            Console.WriteLine("===============================");

            int izbor;
            do
            {
                Console.Write("Napravete izbor (1-5): ");
                if (!int.TryParse(Console.ReadLine(), out izbor))
                {
                    izbor = -1;
                }
            } while (izbor < 1 || izbor > 5);

            switch (izbor)
            {
                case 1: Zad1(currentNumber); break;
                case 2: Zad2(currentNumber); break;
                case 3: Zad3(currentNumber); break;
                case 4: Zad4(currentNumber); break;
                case 5: Zad5(currentNumber); break;
            }
        }

        static void Zad1(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("Chisloto {0} e chetno.", number);
            else
                Console.WriteLine("Chisloto {0} e nechetno.", number);
        }

        static void Zad2(int number)
        {
            if (number < 0)
                Console.WriteLine("Chisloto {0} e otricatelno.", number);
            else if (number == 0)
                Console.WriteLine("Chisloto e nula.");
            else
                Console.WriteLine("Chisloto {0} e polozitelno.", number);
        }

        static void Zad3(int number)
        {
            int n = Math.Abs(number);
            if (n < 2)
            {
                Console.WriteLine("Chisloto {0} ne e prosto.", number);
                return;
            }

            bool isPrime = true;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("Chisloto {0} e prosto.", number);
            else
                Console.WriteLine("Chisloto {0} NE e prosto.", number);
        }

        static void Zad4(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Obraten vid na 0 e 0");
                return;
            }

            int sign = number < 0 ? -1 : 1;
            int n = Math.Abs(number);
            int reversed = 0;

            while (n > 0)
            {
                reversed = reversed * 10 + (n % 10);
                n /= 10;
            }

            reversed *= sign;
            Console.WriteLine("Obraten vid na {0} e {1}", number, reversed);
        }

        static void Zad5(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Deliteli na 0: vsichki chisla.");
                return;
            }

            int n = Math.Abs(number);
            var divisors = new List<int>();
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    int other = n / i;
                    if (other != i) divisors.Add(other);
                }
            }

            divisors.Sort();
            Console.WriteLine("Deliteli na chisloto {0}: {1}", number, string.Join(", ", divisors));
        }
    }
}