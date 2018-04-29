using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50 * nightsCount;
                    if (nightsCount > 7)
                    {
                        priceStudio = 50 * nightsCount * 0.95;
                    }
                    if (nightsCount > 7 && month == "October")
                    {
                        priceStudio = 50 * (nightsCount - 1) * 0.95;
                    }
                    priceDouble = 65 * nightsCount;
                    priceSuite = 75 * nightsCount;
                    break;
                case "June":
                case "September":
                    priceStudio = 60 * nightsCount;
                    if (nightsCount > 7 && month == "September")
                    {
                        priceStudio = 60 * (nightsCount - 1);
                    }
                    priceDouble = 72 * nightsCount;
                    if (nightsCount > 14)
                    {
                        priceDouble = 72 * nightsCount * 0.90;
                    }
                    priceSuite = 82 * nightsCount;
                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68 * nightsCount;
                    priceDouble = 77 * nightsCount;
                    priceSuite = 89 * nightsCount;
                    if (nightsCount > 14)
                    {
                        priceSuite = 89 * nightsCount * 0.85;
                    }
                    break;
            }

            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
            Console.WriteLine($"Double: {priceDouble:F2} lv.");
            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
        }
    }
}