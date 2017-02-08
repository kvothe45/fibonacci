using System;
using System.Numerics;

namespace fibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many iterations do you want?  ");
            var length = int.Parse(Console.ReadLine());

            fib(length);
            Console.WriteLine();
            //Console.Write($"{Fibbonacci}");
            Console.ReadLine();
        }

        //public static long fib(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 0;
        //    }
        //    else if (n == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        var result = fib(n - 1) + fib(n - 2);
        //        return result;
        //    }
        //}

        public static void fib(int n)
        {
            BigInteger prior = 0, doubleprior = 0, temp = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    doubleprior = 0;
                    Console.Write("0 ");
                }
                else if (i == 1)
                {
                    prior = 1;
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("{0} ", (prior) + (doubleprior));
                    temp = prior;
                    prior = (prior) + (doubleprior);
                    doubleprior = temp;

                }

            }
        }
    }
}
