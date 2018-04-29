using System;

namespace _06._Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            object concatenatedStrings = firstWord + " " + secondWord;
            string greeting = concatenatedStrings.ToString();

            Console.WriteLine(greeting);
        }
    }
}