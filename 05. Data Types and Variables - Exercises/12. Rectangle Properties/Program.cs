using System;

namespace _12._Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double perimeter = 2 * sideA + 2 * sideB;
            double area = sideA * sideB;
            double diagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            Console.WriteLine($"{perimeter}\r\n{area}\r\n{diagonal}");
        }
    }
}