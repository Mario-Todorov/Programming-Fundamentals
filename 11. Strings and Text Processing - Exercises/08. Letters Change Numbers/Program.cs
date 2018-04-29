using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0;

            foreach (var word in input)
            {
                double tempSum = 0;
                char firstLetter = word.First();
                char secondLetter = word.Last();
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsLower(firstLetter))
                {
                    tempSum = number * (firstLetter - 96); 
                }
                else
                {
                    tempSum = number / (firstLetter - 64);
                }

                if (char.IsLower(secondLetter))
                {
                    tempSum += secondLetter - 96;
                }
                else
                {
                    tempSum -= secondLetter - 64;
                }

                sum += tempSum;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}