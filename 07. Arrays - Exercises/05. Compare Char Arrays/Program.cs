using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] textOne = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] textTwo = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            int minLength = Math.Min(textOne.Length, textTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (textOne[i] < textTwo[i])
                {
                    foreach (char ch in textOne)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();

                    foreach (char ch in textTwo)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();

                    return;
                }

                else if (textOne[i] > textTwo[i])
                {
                    foreach (char ch in textTwo)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();

                    foreach (char ch in textOne)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    return;
                }
            }

            if (textOne.Length < textTwo.Length)
            {
                Console.WriteLine(new string(textOne));
                Console.WriteLine(new string(textTwo));
            }
            else
            {
                Console.WriteLine(new string(textTwo));
                Console.WriteLine(new string(textOne));
            }
        }
    }
}