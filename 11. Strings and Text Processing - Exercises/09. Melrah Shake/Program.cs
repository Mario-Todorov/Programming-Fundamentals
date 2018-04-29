using System;

namespace _09._Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            int firstIndex = input.IndexOf(pattern);
            int lastIndex = input.LastIndexOf(pattern);

            while (pattern.Length > 0)
            {
                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                input = input.Remove(lastIndex, pattern.Length);
                input = input.Remove(firstIndex, pattern.Length);
                Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }
                pattern = pattern.Remove(pattern.Length / 2, 1);

                firstIndex = input.IndexOf(pattern);
                lastIndex = input.LastIndexOf(pattern);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);

        }
    }
}
