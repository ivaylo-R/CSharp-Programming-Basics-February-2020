using System;
using System.Text.RegularExpressions;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        total = quantity * price;
                        break;
                    case "apple":
                        price = 1.20;
                        total = quantity * price;
                        break;
                    case "orange":
                        price = 0.85;
                        total = quantity * price;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        total = quantity * price;
                        break;
                    case "grapes":
                        price = 3.85;
                        total = quantity * price;
                        break;
                    case "pineapple":
                        price = 5.50;
                        total = quantity * price;
                        break;
                    case "kiwi":
                        price = 2.70;
                        total = quantity * price;
                        break;
                    default: 
                        Console.WriteLine("error");
                        return;
                        

                     
                }
              

            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {

                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        total = quantity * price;
                        break;
                    case "apple":
                        price = 1.25;
                        total = quantity * price;
                        break;
                    case "orange":
                        price = 0.90;
                        total = quantity * price;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        total = quantity * price;
                        break;
                    case "grapes":
                        price = 4.20;
                        total = quantity * price;
                        break;
                    case "pineapple":
                        price = 5.60;
                        total = quantity * price;
                        break;
                    case "kiwi":
                        price = 3.00;
                        total = quantity * price;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                      
                }

            }
            else
            {
                Console.WriteLine("error");
                return;
                
            }
            Console.WriteLine($"{total:f2}");

        }
    }
}
