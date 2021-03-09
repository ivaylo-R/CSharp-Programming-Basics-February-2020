using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double sum = 0;
            if (guests>=10 && guests<=15)
            {
                sum= guests*(price*0.85);
            }
            else if (guests>=15 && guests <= 20)
            {
                sum = guests * (price * 0.80);
            }
            else if (guests>20)
            {
                sum = guests * (price * 0.75);

            }
            else
            {
                sum = guests * price;
            }
            budget = budget * 0.90;
            if(budget>=sum)
            {
                Console.WriteLine($"It is party time! {Math.Abs(sum-budget):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {Math.Abs(budget-sum):f2} leva needed.");
            }
        }
    }
}
