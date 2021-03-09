using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double bugetForMove = double.Parse(Console.ReadLine());
            int states = int.Parse(Console.ReadLine());
            double PriceForClothes = double.Parse(Console.ReadLine());
            double decor = 0.1 * bugetForMove;
            double bugetFoorClothes = states * PriceForClothes;
            if (states > 150)
            {
                bugetFoorClothes -= 0.1* bugetFoorClothes;
            }
            double total = Math.Abs(bugetForMove - (decor + bugetFoorClothes));
            if (bugetFoorClothes + decor > bugetForMove)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(bugetForMove - (decor + bugetFoorClothes)):F2} leva left.");
            }

        }
    }
}
