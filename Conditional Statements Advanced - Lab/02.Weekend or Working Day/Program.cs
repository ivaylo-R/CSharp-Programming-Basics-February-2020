using System;

namespace _02.Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int leva = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                    if (leva > 5)
                    {
                        Console.WriteLine("bravo");
                    }
                    else
                    {
                        Console.WriteLine("Test Testov");
                    }
                    break;
                case "Tuesday":
                    leva = 8;
                    break;
                case "Wednesday":
                    Console.WriteLine("wednesday");
                    break;
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
            Console.WriteLine(leva);
        }
    }
}
