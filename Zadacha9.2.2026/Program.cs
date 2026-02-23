using System;

namespace Zadacha9._2._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[3];
            int[] arr3 = new int[6];
            int arr4 = 10;

            for (int i = 0; i < arr1.Length; i++) arr1[i] = i;
            for (int i = 0; i < arr2.Length; i++) arr2[i] = -10 + i;
            for (int i = 0; i < arr3.Length; i++) arr3[i] = 100 + i;

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arr4);
        }
    }
}