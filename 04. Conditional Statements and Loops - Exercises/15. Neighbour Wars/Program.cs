using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 0;
            string pesho = "Pesho";
            string gosho = "Gosho";
            string peshoHit = "Roundhouse kick";
            string goshoHit = "Thunderous fist";
            string stop = null;

            while (stop != "Stop!")
            {
                round++;
                if (goshoHealth - peshoDamage > 0 && round % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    Console.WriteLine($"{pesho} used {peshoHit} and reduced" +
                        $" {gosho} to {goshoHealth} health.");
                }
                else if (peshoHealth - goshoDamage > 0 && round % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    Console.WriteLine($"{gosho} used {goshoHit} and reduced" +
                        $" {pesho} to {peshoHealth} health.");
                }
                else
                {
                    stop = "Stop!";
                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }

            if (round % 2 != 0)
            {
                Console.WriteLine($"{pesho} won in {round}th round.");
            }
            else
            {
                Console.WriteLine($"{gosho} won in {round}th round.");
            }
        }
    }
}