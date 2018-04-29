using System;

namespace _09._Longer_Line
{
    class Program
    {
        static double LineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        static double DistanceToCenter(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        static void PrintClosestPointFirst(double x1, double y1, double x2, double y2)
        {
            if (DistanceToCenter(x1, y1) <= DistanceToCenter(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2,
                                    double x3, double y3, double x4, double y4)
        {
            if (LineLength(x1, y1, x2, y2) >= LineLength(x3, y3, x4, y4))
            {
                PrintClosestPointFirst(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPointFirst(x3, y3, x4, y4);
            }
        }

        static void Main(string[] args)
        {
            double pointX1 = double.Parse(Console.ReadLine());
            double pointY1 = double.Parse(Console.ReadLine());
            double pointX2 = double.Parse(Console.ReadLine());
            double pointY2 = double.Parse(Console.ReadLine());
            double pointX3 = double.Parse(Console.ReadLine());
            double pointY3 = double.Parse(Console.ReadLine());
            double pointX4 = double.Parse(Console.ReadLine());
            double pointY4 = double.Parse(Console.ReadLine());

            PrintLongerLine(pointX1, pointY1, pointX2, pointY2, pointX3, pointY3, pointX4, pointY4);
        }
    }
}