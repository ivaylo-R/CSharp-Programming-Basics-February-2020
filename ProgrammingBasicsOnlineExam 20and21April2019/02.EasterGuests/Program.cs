using System;

namespace _02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());

            int budget = int.Parse(Console.ReadLine());

            double easterBread = Math.Round(guests/ 3.0+0.2);
            double easterEggs = guests * 2;
            

            double easterBreadSum = easterBread * 4;
            double easterEggsSum = easterEggs * 0.45;
            double sum = easterEggsSum + easterBreadSum;

            if (budget>=sum)
            {
                Console.WriteLine($"Lyubo bought {easterBread} Easter bread and {easterEggs} eggs.");
                Console.WriteLine($"He has {(budget-sum):f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {(sum-budget):f2} lv. more.");
            }


        }
    }
}
