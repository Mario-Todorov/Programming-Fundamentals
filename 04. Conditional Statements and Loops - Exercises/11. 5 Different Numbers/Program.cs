using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first + 5 > second)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = first; i <= second - 4; i++)
            {
                for (int k = first + 1; k <= second - 3; k++)
                {
                    for (int l = first + 2; l <= second - 2; l++)
                    {
                        for (int m = first + 3; m <= second - 1; m++)
                        {
                            for (int j = first + 4; j <= second; j++)
                            {
                                if (i < k && k < l && l < m && m < j)
                                {
                                    Console.WriteLine($"{i} {k} {l} {m} {j}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}