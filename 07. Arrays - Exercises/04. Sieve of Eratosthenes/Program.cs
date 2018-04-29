using System;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                array[i] = true;
            }

            if (n == 0 || n == 1)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = 2; i <= n; i++)
            {
                if (array[i] == true)
                {
                    Console.Write(i + " ");

                    int p = i;
                    int multiplier = 1;
                    while (p <= n)
                    {
                        array[p] = false;
                        multiplier++;
                        p = i * multiplier;
                    }
                }
            }
        }
    }
}