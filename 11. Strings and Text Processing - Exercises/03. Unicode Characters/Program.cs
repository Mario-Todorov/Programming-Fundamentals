using System;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                Console.Write("\\u{0:x4}", (int)ch);
            }
        }
    }
}