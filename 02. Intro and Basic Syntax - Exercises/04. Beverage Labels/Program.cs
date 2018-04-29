using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string beverage = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100 = int.Parse(Console.ReadLine());
            int sugarContentPer100 = int.Parse(Console.ReadLine());

            double energyTotal = (double)(energyContentPer100) * volume / 100;
            double sugarTotal = (double)(sugarContentPer100) * volume / 100;

            Console.WriteLine($"{volume}ml {beverage}:\r\n{energyTotal}kcal, {sugarTotal}g sugars");
        }
    }
}