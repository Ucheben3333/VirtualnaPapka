using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi elementite na masiv: ");
            int[] nums = new int [10];

            //vavejdane na chisla ot klaviaturata
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"nums [{i}] = ");
                nums[i] = int.Parse(Console.ReadLine());
            }




                nums[0] = 5; //purviq element
            nums[nums.Length - 1] = 100; //posledniq element
            nums[nums.Length / 2] = -10; //sredniq element

            for (int i = 0; i < nums.Length; i++) //otpechatvane na vsicki elementi
            {
                Console.WriteLine($"nums [{i}] = {nums[i]}");
            }
            for (int i = nums.Length-1; i >= 0; i--) //otpechatvane na vsicki elementi obratno
            {
                Console.WriteLine($"{nums[i]}");
            }
        }
    }
}
