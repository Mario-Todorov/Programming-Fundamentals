using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(num);
            Console.WriteLine(factorial);
        }

        static BigInteger GetFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
