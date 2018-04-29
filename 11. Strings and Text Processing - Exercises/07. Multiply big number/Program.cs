using System;
using System.Linq;
using System.Text;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int multiplier = 0;
            int reminder = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                multiplier = (num1[i] - 48) * num2 + reminder;
                num = multiplier % 10;

                if (multiplier > 9)
                {
                    reminder = multiplier / 10;
                }
                else
                {
                    reminder = 0;
                }
                sb.Append(num);
            }

            if (reminder > 0)
            {
                sb.Append(reminder);
            }

            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}