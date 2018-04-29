using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroesInFactorial(number));
        }

        static int TrailingZeroesInFactorial(int num)
        {
            string stringFactorial = GetFactorial(num).ToString();
            int zeroesCount = 0;
            for (int i = stringFactorial.Length - 1; i >= 0; i--)
            {
                if (stringFactorial[i] == '0')
                {
                    zeroesCount++;
                }
                else
                {
                    break;
                }
            }
            return zeroesCount;
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