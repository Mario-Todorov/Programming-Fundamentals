using System;

namespace _08._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int odd = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{odd}");
                sum += odd;
                odd += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}