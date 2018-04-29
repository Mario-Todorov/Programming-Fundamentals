using System;
using System.Linq;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine().Trim();
            string input2 = Console.ReadLine().Trim();

            input1 = input1.TrimStart('0');
            input2 = input2.TrimStart('0');

            string num1 = "";
            string num2 = "";
            string num3 = "";
            string num4 = "";

            if (input1.Contains('.'))
            {
                string[] input3 = input1.Split('.').ToArray();
                num1 = input3[0];
                num2 = input2;
                num3 = input3[1];
                if (input2.Contains('.'))
                {
                    string[] input4 = input2.Split('.').ToArray();
                    num2 = input4[0];
                    num4 = input4[1];
                }
            }
            else if (input2.Contains('.') && input1.Contains('.') == false)
            {
                string[] input4 = input2.Split('.').ToArray();

                num2 = input4[0];
                num4 = input4[1];
            }
            else
            {
                num1 = input1;
                num2 = input2;
            }
            

            string currentNum1 = "";
            string currentNum2 = "";
            string currentNum3 = "";
            string currentNum4 = "";

            string sum = "";
            string sumDouble = "";
            int helper = 0;
            int currentSumCheck = 0;
            string remainder = "";

            if (num3 == "" == false && num4 == "" == false)
            {
                if (num3.Length > num4.Length)
                {
                    currentNum3 = num3.Remove(num4.Length, num3.Length - num4.Length);
                    currentNum4 = num4;
                    for (int i = num4.Length; i < num3.Length; i++)
                    {
                        remainder += num3[i];
                    }
                }
                else if (num3.Length < num4.Length)
                {
                    currentNum3 = num3;
                    currentNum4 = num4.Remove(num3.Length, num4.Length - num3.Length);
                    for (int i = num3.Length; i < num4.Length; i++)
                    {
                        remainder += num4[i];
                    }
                }
                else
                {
                    currentNum3 = num3;
                    currentNum4 = num4;
                }


                for (int i = currentNum3.Length - 1; i >= 0; i--)
                {
                    int digit1 = (int)char.GetNumericValue(currentNum3[i]);
                    int digit2 = (int)char.GetNumericValue(currentNum4[i]);

                    int currentSum = digit1 + digit2;

                    if (helper == 1)
                    {
                        currentSum++;
                    }

                    currentSumCheck = currentSum;
                    helper = 0;

                    if (currentSum > 9)
                    {
                        currentSum = currentSum % 10;
                    }

                    sumDouble = currentSum.ToString() + sumDouble;

                    if (currentSumCheck > 9)
                    {
                        helper = 1;
                    }
                }
            }


            if (num1.Length > num2.Length)
            {
                currentNum1 = num1.Remove(0, num1.Length - num2.Length);
                currentNum2 = num2;
            }
            else if (num1.Length < num2.Length)
            {
                currentNum1 = num1;
                currentNum2 = num2.Remove(0, num2.Length - num1.Length);
            }
            else
            {
                currentNum1 = num1;
                currentNum2 = num2;
            }

            for (int i = currentNum1.Length - 1; i >= 0; i--)
            {
                int digit1 = (int)char.GetNumericValue(currentNum1[i]);
                int digit2 = (int)char.GetNumericValue(currentNum2[i]);

                int currentSum = digit1 + digit2;

                if (helper == 1)
                {
                    currentSum++;
                }

                currentSumCheck = currentSum;
                helper = 0;

                if (currentSum > 9)
                {
                    currentSum = currentSum % 10;
                }

                sum = currentSum.ToString() + sum;

                if (currentSumCheck > 9)
                {
                    helper = 1;
                }
            }

            string startOfTheNumber = "";
            int digit3 = 0;

            if (helper == 0)
            {
                if (num1.Length > num2.Length)
                {
                    startOfTheNumber = num1.Remove(num1.Length - num2.Length, num2.Length);
                }
                else if (num1.Length < num2.Length)
                {
                    startOfTheNumber = num2.Remove(num2.Length - num1.Length, num1.Length);
                }
                sum = startOfTheNumber + sum;
            }

            else
            {
                for (int i = Math.Abs(num1.Length - num2.Length) - 1; i >= 0; i--)
                {
                    if (num1.Length > num2.Length)
                    {
                        digit3 = (int)char.GetNumericValue(num1[i]);
                    }
                    else if (num1.Length < num2.Length)
                    {
                        digit3 = (int)char.GetNumericValue(num2[i]);
                    }


                    if (helper == 1)
                    {
                        digit3++;
                    }

                    int currentSum2 = digit3;

                    currentSumCheck = currentSum2;
                    helper = 0;

                    if (currentSum2 > 9)
                    {
                        currentSum2 = currentSum2 % 10;
                    }

                    sum = currentSum2.ToString() + sum;

                    if (currentSumCheck > 9)
                    {
                        helper = 1;
                    }
                }
            }

            if (helper == 1)
            {
                sum = helper + sum;
            }


            if (sumDouble == "" == false)
            {
                sum = sum + "." + sumDouble;
            }

            if (num3 == "" == false && num4 == "")
            {
                sum = sum + "." + num3;
            }

            if (num4 == "" == false && num3 == "")
            {
                sum = sum + "." + num4;
            }

            sum = sum + remainder;

            Console.WriteLine(sum);
        }
    }
}