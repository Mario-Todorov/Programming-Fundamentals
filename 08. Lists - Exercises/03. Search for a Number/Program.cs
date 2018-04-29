using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] numbersToTake = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] collectionNumbers = new int[numbersToTake[0]];

            for (int i = 0; i < numbersToTake[0]; i++)
            {
                collectionNumbers[i] = numbers[i];
            }

            List<int> takenNumbers = new List<int>();

            takenNumbers.InsertRange(0, collectionNumbers);
            takenNumbers.RemoveRange(0, numbersToTake[1]);
            bool yes = takenNumbers.Remove(numbersToTake[2]);

            if (yes)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}