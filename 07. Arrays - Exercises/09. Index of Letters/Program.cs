using System;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] text = Console.ReadLine()
                .ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{text[i]} -> {text[i] - 'a'}");
            }
        }
    }
}