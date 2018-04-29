using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine().to;

            double priceHall = 0;
            double pricePackage = 0;
            double discount = 0;
            string hall = null;

            if (groupSize <= 50)
            {
                priceHall = 2500;
                hall = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                priceHall = 5000;
                hall = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                priceHall = 7500;
                hall = "Great Hall";
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (servicePackage)
            {
                case "Normal":
                    pricePackage = 500;
                    discount = 0.95;
                    break;
                case "Gold":
                    pricePackage = 750;
                    discount = 0.90;
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discount = 0.85;           
                    break;
            }

            double totalPrice = (priceHall + pricePackage) * discount;
            double pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}