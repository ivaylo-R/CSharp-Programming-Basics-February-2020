using System;

namespace _03._New_House
{
    class Program
    {
        static double rosesPrice = 5;
        static double dhaliasPrice = 3.80;
        static double tulipPrice = 2.80;
        static double narcissusPrice = 3;
        static double gladiusPrice = 2.50;
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            if (flowers == "Roses")
            {
                if (numOfFlowers > 80)
                {
                    totalPrice -= numOfFlowers * rosesPrice * 0.10;
                }
                totalPrice += numOfFlowers * rosesPrice;
            }
            else if (flowers == "Dahlias")
            {
                if (numOfFlowers > 90)
                {
                    totalPrice -= numOfFlowers * dhaliasPrice * 0.15;
                }
                totalPrice += numOfFlowers * dhaliasPrice;
            }
            else if (flowers == "Tulips")
            {
                if (numOfFlowers > 80)
                {
                    totalPrice -= numOfFlowers * tulipPrice * 0.15;
                }
                totalPrice += numOfFlowers * tulipPrice;
            }
            else if (flowers == "Narcissus")
            {
                if (numOfFlowers < 120)
                {
                    totalPrice += numOfFlowers * narcissusPrice * 0.15;
                }
                totalPrice += numOfFlowers * narcissusPrice;
            }
            else
            {
                if (numOfFlowers < 80)
                {
                    totalPrice += numOfFlowers * gladiusPrice * 0.20;
                }
                totalPrice += numOfFlowers * gladiusPrice;
            }
            if (budget>= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }

        }
    }
}
