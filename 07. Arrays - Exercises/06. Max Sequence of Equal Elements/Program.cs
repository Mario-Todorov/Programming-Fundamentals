using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();
            List<int> finalList = new List<int>();

            int counter = 1;
            int maxCounter = 1;

            resultList.Add(numbers[0]);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    resultList.Add(numbers[i + 1]);
                }
                else
                {
                    counter = 1;
                    resultList.Clear();
                    resultList.Add(numbers[i + 1]);
                }

                if (counter > maxCounter)
                {
                    finalList.Clear();
                    maxCounter = counter;
                    finalList.AddRange(resultList);
                }

            }

            if (maxCounter == 1)
            {
                Console.WriteLine(numbers[0]);
            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}