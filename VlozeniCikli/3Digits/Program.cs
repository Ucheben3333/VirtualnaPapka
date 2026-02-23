using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi 3 cifreno chislo: ");
            int number = int.Parse(Console.ReadLine());
            int digit;
            number = Math.Abs(number);

            while (number != 0)
            {
                digit = number % 10; //poslednata cifra
                number = number / 10; //chisloto bez poslednata cifra
                Console.Write(digit);
            }
            //int digit = number % 10; //poslednata cifra
            //number = number / 10; //chisloto bez poslednata cifra
            //Console.Write(digit);
            //digit = number % 10;
            //number = number / 10;
            //Console.Write(digit);
            //digit = number % 10;
            //number = number / 10;
            //Console.Write(digit);
        }
    }
}
