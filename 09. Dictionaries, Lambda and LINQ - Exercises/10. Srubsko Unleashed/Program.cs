using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> VanueSignerAndTotalMoney = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string text = Console.ReadLine();
                if (text == "End") break;
                string[] inputData = text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string[] checkData = text.Split(new char[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputData.Length == checkData.Length == false) continue;

                int indexSign = 0;
                indexSign = DefineIndexPossition(inputData, indexSign);
                if (indexSign <= 1 || indexSign >= 5) continue;
                if (inputData.Length - indexSign >= 5 || inputData.Length - indexSign < 2) continue;

                string singerName = DefineSignerName(inputData, indexSign);
                int ticketsPrice;
                int ticketsCount;

                try
                {
                    ticketsPrice = int.Parse(inputData[inputData.Length - 2]);
                    ticketsCount = int.Parse(inputData[inputData.Length - 1]);
                }
                catch (Exception)
                {

                    continue;
                }

                string vanue = DefineVanue(checkData, indexSign);

                long currentAmountOfMoney = (long)ticketsPrice * ticketsCount;

                DefineTheDectionary(VanueSignerAndTotalMoney, singerName, vanue, currentAmountOfMoney);
            }

            PrintTheDictionary(VanueSignerAndTotalMoney);
        }


        private static void PrintTheDictionary(Dictionary<string, Dictionary<string, long>> VanueSignerAndTotalMoney)
        {
            foreach (var pair in VanueSignerAndTotalMoney)
            {
                Console.WriteLine(pair.Key);
                var OrderedSignerAndTotalMoney = pair.Value.OrderByDescending(i => i.Value);
                foreach (var value in OrderedSignerAndTotalMoney)
                {
                    Console.WriteLine($"#  {value.Key} -> {value.Value}");
                }
            }
        }

        private static void DefineTheDectionary(Dictionary<string, Dictionary<string, long>> VanueSignerAndTotalMoney, string singerName, string vanue, long currentAmountOfMoney)
        {
            if (VanueSignerAndTotalMoney.ContainsKey(vanue))
            {
                Dictionary<string, long> CurrentVanue = VanueSignerAndTotalMoney[vanue];
                if (CurrentVanue.ContainsKey(singerName))
                {
                    CurrentVanue[singerName] += currentAmountOfMoney;
                }
                else CurrentVanue[singerName] = currentAmountOfMoney;
            }
            else
            {
                Dictionary<string, long> newVanue = new Dictionary<string, long>();
                newVanue[singerName] = currentAmountOfMoney;
                VanueSignerAndTotalMoney.Add(vanue, newVanue);
            }
        }

        private static string DefineVanue(string[] checkData, int indexSign)
        {
            string[] vanues = new string[checkData.Length - indexSign];
            for (int i = indexSign - 1; i < checkData.Length - 2; i++)
            {
                vanues[i - indexSign + 1] = checkData[i];
            }
            string vanue = string.Join(" ", vanues);
            return vanue;
        }

        private static string DefineSignerName(string[] inputData, int indexSign)
        {
            string[] singerNameData = new string[indexSign - 1];
            for (int i = 0; i < indexSign - 1; i++)
            {
                singerNameData[i] = inputData[i];
            }
            string singerName = string.Join(" ", singerNameData);
            return singerName;
        }

        private static int DefineIndexPossition(string[] inputData, int indexSign)
        {
            foreach (var a in inputData)
            {
                indexSign++;
                if (a.Contains('@')) break;
            }

            return indexSign;
        }
    }
}