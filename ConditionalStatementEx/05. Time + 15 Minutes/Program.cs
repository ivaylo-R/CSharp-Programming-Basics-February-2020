using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMinutes = hours*60 + minutes + 15;
            int minutesToHours = totalMinutes / 60;
            int remainder = totalMinutes % 60;
            if (hours==24)
            {
                hours = 0;
            }
            Console.WriteLine($"{minutesToHours}:{remainder:d2}");

        }
        
    }
}
