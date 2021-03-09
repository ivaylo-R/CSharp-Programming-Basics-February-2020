using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int priceTicket = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    priceTicket = 12;
                    break;
                case "Thursday":
                case "Wednesday":
                    priceTicket = 14;
                    break;
                case "Saturday":
                    priceTicket = 16;
                    break;
                case "Sunday":
                    priceTicket = 16;
                    
                    break;
                    

            }
            Console.WriteLine(priceTicket);
        }
    }
}
