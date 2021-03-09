using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeForRoom = Console.ReadLine();
            string feedBack = Console.ReadLine();
            double pricePerNight = 0;

           
            double discount = 0;
            switch (typeForRoom)
            {
                case "room for one person":
                    pricePerNight = 18;
                    break;
                case "apartment":
                    pricePerNight = 25;
                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else
                    {
                        discount = 0.50;
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35;
                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.20;
                    }
                    break;
            }
            double totalPrice = pricePerNight * (days - 1);
            totalPrice = totalPrice - totalPrice * discount;
            if (feedBack == "positive")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }
            else
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
