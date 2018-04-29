using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] numbersCopy = new int [numbers.Length];
            int[] saveNum = new int[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            int counter = 1;
            int maxCounter = 0;
            int position = -1;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] != position)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[j] == numbers[k])
                        {
                            counter++;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        position = numbers[j];
                    }

                    counter = 1;
                }
            }

            Console.WriteLine(position);
        }
    }
}