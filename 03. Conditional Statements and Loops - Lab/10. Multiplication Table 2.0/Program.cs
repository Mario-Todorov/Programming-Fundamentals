﻿using System;

namespace _10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int result = 0;
            if (m <= 10)
            {
                for (int i = m; i <= 10; i++)
                {
                    result = n * i;
                    Console.WriteLine($"{n} X {i} = {result}");
                }
            }
            else
            {
                result = n * m;
                Console.WriteLine($"{n} X {m} = {result}");
            }

        }
    }
}