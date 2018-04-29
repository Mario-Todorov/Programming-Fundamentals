using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static double FindFaceDiagonal(double side)
        {
            double result = Math.Sqrt(2 * Math.Pow(side, 2));
            return result;
        }

        static double FindSpaceDiagonal(double side)
        {
            double result = Math.Sqrt(3 * Math.Pow(side, 2));
            return result;
        }

        static double FindVolume(double side)
        {
            double result = Math.Pow(side, 3);
            return result;
        }

        static double FindSurfaceArea(double side)
        {
            double result = 6 * Math.Pow(side, 2);
            return result;
        }

        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face": Console.WriteLine($"{FindFaceDiagonal(side):F2}"); break;
                case "space": Console.WriteLine($"{FindSpaceDiagonal(side):F2}"); break;
                case "volume": Console.WriteLine($"{FindVolume(side):F2}"); break;
                case "area": Console.WriteLine($"{FindSurfaceArea(side):F2}"); break;
            }
        }
    }
}