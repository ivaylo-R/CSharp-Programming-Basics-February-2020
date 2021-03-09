using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int relaxDays = int.Parse(Console.ReadLine());
            double relaxMin = relaxDays * 127;
            double workDays = 365 - relaxDays;
            double workDaysInMin = workDays * 63;
            double totalMin = workDaysInMin + relaxMin;
            if (totalMin > 30000)
            {
                Console.WriteLine("Tom will run away");
                totalMin -= 30000;
                Console.WriteLine($"{Math.Floor(totalMin / 60)} hours and {totalMin%60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                double Min = 30000 - totalMin;
                Console.WriteLine($"{Math.Floor(Min / 60)} hours and {Min % 60} minutes less for play");
            }
        }
    }
}
