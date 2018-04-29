using System;
using System.Linq;
using System.Collections.Generic;


namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> longestSeq = GetLongestSequence(numbers);
            Console.WriteLine(string.Join(" ", longestSeq));

        }

        private static List<int> GetLongestSequence(List<int> numbers)
        {
            int startIndex = 0;
            int maxLength = 1;
            int currentStartIndex = 0;
            int currentLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentStartIndex = i;
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = currentStartIndex;
                }

            }

            List<int> longestSeq = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(numbers[startIndex + i]);
            }

            return longestSeq;
        }
    }
}