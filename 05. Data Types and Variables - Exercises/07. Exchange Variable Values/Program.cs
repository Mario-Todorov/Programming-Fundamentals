﻿using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int oldA = a;
            a = b;
            b = oldA;

            Console.WriteLine($"Before:\r\na = {oldA}\r\nb = {a}");
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}