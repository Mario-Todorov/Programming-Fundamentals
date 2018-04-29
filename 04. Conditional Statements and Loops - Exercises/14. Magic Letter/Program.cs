using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char toAvoid = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char m = first; m <= second; m++)
                    {
                        if (i != toAvoid && j != toAvoid && m != toAvoid)
                        {
                            Console.Write($"{i}{j}{m} ");
                        }
                    }
                }
            }
        }
    }
}