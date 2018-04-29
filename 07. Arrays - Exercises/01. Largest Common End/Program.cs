using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textOne = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] textTwo = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int minLength = Math.Min(textOne.Length, textTwo.Length);

            int counterLeft = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (textOne[i] == textTwo[i])
                {
                    counterLeft++;
                }
            }

            textOne = textOne.Reverse().ToArray();
            textTwo = textTwo.Reverse().ToArray();

            int counterRight = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (textOne[i] == textTwo[i])
                {
                    counterRight++;
                }
            }

            Console.WriteLine(Math.Max(counterLeft, counterRight));
        }
    }
}