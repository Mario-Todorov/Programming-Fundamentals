using System;

namespace _06._Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
            
        }

        static bool IsPrime(long n)
        {
            bool isPrime = n > 1;
             double sqrtN = Math.Sqrt(n);

                for (long i = 2; i <= sqrtN; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        return isPrime;
                    }

                }

            return isPrime;
        }

    }
}