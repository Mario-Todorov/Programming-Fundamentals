using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = array.Length / 4;
            int[] upperRow = new int[k * 2];
            int[] lowerRow = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                upperRow[i] = array[k - 1 - i];
                upperRow[upperRow.Length - 1 - i] = array[array.Length - k + i];
                lowerRow[2 * i] = array[2 * i + k];
                lowerRow[2 * i + 1] = array[2 * i + 1 + k];
            }

            int[] result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}