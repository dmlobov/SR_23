using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Sum(n);
            Fact(n);
            Console.ReadKey();

        }

        static void Sum(int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += i;
                Thread.Sleep(100);
            }
            Console.WriteLine(s);
        }
        static void Fact(int n)
        {
            int s = 1;
            for (int i = 1; i < n; i++)
            {
                s *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine(s);
        }
    }
}
