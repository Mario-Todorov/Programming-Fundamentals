using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[j] == numbers[i] - difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}