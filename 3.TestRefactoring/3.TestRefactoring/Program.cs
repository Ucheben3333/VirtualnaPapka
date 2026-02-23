using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TestRefactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine(&quot; Vavedi osnova / cqlo chislo /: &quot;);
            //    int N = int.Parse(Console.ReadLine());
            //    Console.Write(&quot; Vavedi cylo chislo & quot;);
            //    int st = int.Parse(Console.ReadLine());
            //    long St = Nesto(N, st);
            //    Console.WriteLine(St);
            //}
            //private static int Nesto(int n, sbyte v)
            //{
            //    int R = 1, S, pow = 1;
            //    if (v & lt; 0) {
            //        Console.WriteLine("Nesto NE raboti za otric.step.pok.");
            //    }
            //        else
            //    {
            //        for (int iP = 1; iP & lt;= v; iP++) { R = R * n; }
            //    }
            //    return R;
            //}
            Console.WriteLine("Vavedi cqlo chislo: ");
            int cqlo = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedi osnova: ");
            int osnova =  int.Parse(Console.ReadLine());

            long result = Power(cqlo, osnova );

            Console.WriteLine($"Resultat: {result}");
        }

        private static long Power(int cqlo, int osnova)
        {
            if (osnova < 0)
            {
                Console.WriteLine("metodut ne raboti s otricatelni osnovi.");
                return 0;
            }

            long result = 1;

            for (int i = 1; i <= osnova; i++)
            {
                result *= cqlo;
            }

            return result;


        }
    }
}
        