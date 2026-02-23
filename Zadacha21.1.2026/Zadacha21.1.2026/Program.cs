using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha21._1._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = new DateTime(2025, 1, 1);
            int dsync = 5740;
            DateTime birthDate = currentDate.AddDays(-dsync);
            Console.WriteLine("Andrey e roden na:" + birthDate.ToString("dd.MM.yy"));

            int days = 5740;
            int years = days / 365;
            int months = years / 365;
            int day = days % 365;

            DateTime b = new DateTime(years, months, day);
            //DateTime newB = new DateTime(currentDate - b);
            Console.WriteLine(b.ToString("dd. MM. yyyy."));
            int birthyear = 2026 - years;
            int birthmonth = 13 - months;
            int birthday = day - 40;
            Console.WriteLine($"{birthday} {birthmonth} {birthyear}");

            // zadacha 2
            Console.WriteLine("Ime:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Familiq: ");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Vuzrast: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Zdravei,{Firstname} {Lastname}.Ti si {age} godini.");

            //zadacha 3
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            object obj = str1 + " " + str2;
            string result = (string)obj;
            Console.WriteLine(result);

            //zadacha 4
        }
    }
 }