using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int time = seconds + minutes * 60 + hours * 3600;

            float mPerS = (float)distanceInMeters / time;
            float kmPerH = ((float)distanceInMeters / 1000) / ((float)time / 3600);
            float mPerH = ((float)distanceInMeters / 1609) / ((float)time / 3600);

            Console.WriteLine($"{mPerS:0.#######}");
            Console.WriteLine($"{kmPerH:0.#######}");
            Console.WriteLine($"{mPerH:0.#######}");
        }
    }
}