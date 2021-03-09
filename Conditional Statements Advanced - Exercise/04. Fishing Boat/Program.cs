using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int springPrice = 3000;
            const int summerAndAutumnPrice = 4200;
            const int winterPrice = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishermans = int.Parse(Console.ReadLine());
            double totalMoney = 0;

            switch (season)
            {
                case "Spring":
                    totalMoney = springPrice;
                    break;
                case "Summer":
                    totalMoney = summerAndAutumnPrice;
                    break;
                case "Autumn":
                    totalMoney = summerAndAutumnPrice;
                    break;
                case "Winter":
                    totalMoney = winterPrice;
                    break;

            }
            if (numOfFishermans <= 6)
            {
                totalMoney -= totalMoney * 0.10;
            }
            else if (numOfFishermans >= 7 && numOfFishermans <=11)
            {
                totalMoney -= totalMoney * 0.15;
            }
            else
            {
                totalMoney -= totalMoney * 0.25;
            }

            if (numOfFishermans % 2 == 0 && season != "Autumn")
            {
                totalMoney -= totalMoney * 0.05;
            }

            if (budget >= totalMoney)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }

            else
            {
                double neededMoney = totalMoney - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
        }
    }
}
