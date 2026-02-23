using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolNchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////zad1
            //Console.WriteLine("Vuvedi symbol");
            //char letter = '\u0020';
            //if (letter > 64 && letter < 91)
            //{
            //    Console.WriteLine(true + "Glavna bukva");
            //}
            //else
            //{
            //    Console.WriteLine(false + "ne e glavna");
            //}
            ////zad2
            //char digit = '0';
            //if (digit >= 48 && digit <= 57)
            //{
            //    Console.WriteLine($"'{digit}' --> {(int)digit}");
            //}
            ////zad3
            //char ch = '5';
            //if (ch >= 98 && ch < 123)
            //{
            //    Console.WriteLine(true + "malka bukva");
            //}
            //else if (ch >= 65 && ch <= 90)
            //{
            //    Console.WriteLine(true + "glavna bukva");
            //}
            //zad4
            char ch = char.Parse(Console.ReadLine());
            if (ch > 64 && ch < 91)
            {
                Console.WriteLine(true + "Glavna bukva");
            }
            else if (ch >= 97 && ch <= 122)
            {
                Console.WriteLine(true + "malka bukva");
            }
            else
            {
                Console.WriteLine(false + "ne e bukva");
            }
            //zad5
            char symbol = char.Parse(Console.ReadLine());
            for(char c = 'A'; c <= 'Z'; c++)
            {
                
            }
            //zad6
                Console.WriteLine("malki bukvi");
                for (char c = 'a'; c <= 'z'; c++)
                {
                    Console.WriteLine($"{c} -> {(int)c}");
                }
            }
        }
    }