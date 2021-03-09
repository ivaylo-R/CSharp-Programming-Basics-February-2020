using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double recordInMeteres = double.Parse(Console.ReadLine());
            double timeforSwimm = double.Parse(Console.ReadLine());
            double totalSeconds = recordInMeteres * timeforSwimm;
            double every15Meters = Math.Floor(recordInMeteres / 15);
            double delay = every15Meters * 12.5;
            double totalTime = totalSeconds + delay;
                if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - recordInSeconds):f2} seconds slower.");
            }
        }
    }
}
