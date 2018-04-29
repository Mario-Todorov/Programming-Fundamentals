using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int num = 0;

            if (int.TryParse(userInput,out num))
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (userInput)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                    case "y":

                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}