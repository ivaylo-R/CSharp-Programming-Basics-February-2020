using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mayAndOctoberStudioPrice = 50;
            const double mayAndOctoberApartmentPrice = 65;
            const double juneAndSeptemberStudioPrice = 75.20;
            const double juneAndSeptemberApartmentPrice = 68.70;
            const double julyAndAugustStudioPrice = 76;
            const double julyAndAugustApartmentPrice = 77;

            string months = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double totalMoneyStudio = 0;
            double totalMoneyApartment = 0;

            switch (months)
            {
                case "May":
                case "October":
                    totalMoneyStudio = nights * mayAndOctoberStudioPrice;
                    totalMoneyApartment = nights * mayAndOctoberApartmentPrice;
                    
                    if (nights > 7 && nights < 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    else if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.30;
                    }
                    break;

                case "June":
                case "September":
                    totalMoneyStudio = nights * juneAndSeptemberStudioPrice;
                    totalMoneyApartment = nights * juneAndSeptemberApartmentPrice;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.20;
                    }
                    break;
                case "August":
                case "July":
                    totalMoneyStudio = nights * julyAndAugustStudioPrice;
                    totalMoneyApartment = nights * julyAndAugustApartmentPrice;
                    break;
                
            }
            if (nights > 14)
            {
                totalMoneyApartment -= totalMoneyApartment * 0.10;
            }
            Console.WriteLine($"Apartment: {totalMoneyApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyStudio:f2} lv.");
        }
    }
}
