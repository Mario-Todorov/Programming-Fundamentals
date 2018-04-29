using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateAreaOfTriangle(side, height):F2}");
            }

            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateAreaOfSquare(side):F2}");
            }

            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateAreaOfRectangle(width, height):F2}");
            }

            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalculateAreaOfCircle(radius):F2}");
            }

        }

        static double CalculateAreaOfTriangle(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }
        static double CalculateAreaOfSquare(double side)
        {
            double area = side * side;
            return area;
        }
        static double CalculateAreaOfRectangle(double width, double height)
        {
            double area = width * height;
            return area;
        }
        static double CalculateAreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}