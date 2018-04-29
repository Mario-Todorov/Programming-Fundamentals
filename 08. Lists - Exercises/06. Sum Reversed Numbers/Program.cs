using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
               int reverseNumber = 0;

                while (sequence[i] > 0)
                {
                    int getDigit = sequence[i] % 10;
                    reverseNumber = reverseNumber * 10 + getDigit;
                    sequence[i] = sequence[i] / 10;
                }

                sum += reverseNumber;
            }

            Console.WriteLine(sum);
        }
    }
}