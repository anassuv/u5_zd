using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static int minP(int[] a, int x)
        {
            int p = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x) p = i;
            }
            return p;
        }

        static void Main(string[] args)
        {
            const int n = 10;
            int[] a = new int[n];
            Random rd = new Random();

            Console.Write("\n[");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rd.Next(-10, 50);
                if (i < a.Length - 1)
                  Console.Write("{0} ", a[i]);
                else
                  Console.Write("{0}", a[i]);                
            }
            Console.Write("]\nКакое число ищем? -> ");
            int x = int.Parse(Console.ReadLine());

            int p = minP(a, x);            
            Console.WriteLine("его индекс: {0}", p);

            Console.ReadKey();
        }
    }
}
