using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReversedNumber(number));
        }

        static double GetReversedNumber(double number)
        {
            string numberAsAString = number.ToString();
            string reversedNumberAsAString = string.Empty;

            if (number < 0)
            {
                reversedNumberAsAString += '-';
            }

            for (int i = numberAsAString.Length - 1; i >= 0; i--)
            {
                if (number < 0 && i == 0)
                {
                    continue;
                }
                char digitOrPoint = numberAsAString[i];
                reversedNumberAsAString += digitOrPoint;
            }
            double reversedNumber = double.Parse(reversedNumberAsAString);
            return reversedNumber;
        }
    }
}