using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //char ch = '#';
            //Console.WriteLine((int)ch + " ----> " + ch); //desetichen kod

            //int code10 = 65;
            //Console.WriteLine((char)code10);

            //int code16 = 0x68;
            //Console.WriteLine((char)code16);

            //for (int i = 0; i < 128; i++) ;
            //{
            //    Console.WriteLine($"{i} ----> {(char)}");
            //}
            for (int code = 0x0410; code <= 0x042F; code++)
            {
                Console.Write((char)code + " ");
            }
            Console.WriteLine();


            ////bg lower case
            for (int code = 0x0430; code <= 0x044F; code++)
            {
                Console.Write((char)code + " ");
            }
        }
    }
}
