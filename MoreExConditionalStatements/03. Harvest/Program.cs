using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int numbersWorkers = int.Parse(Console.ReadLine());
            double totalGrape = x * y;
            double wine = totalGrape * 0.4 / 2.5;
            if (wine < Z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Z-wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor (wine)} liters.");
                double remainder = Math.Ceiling(wine - Z);
                Console.WriteLine($"{remainder} liters left -> {Math.Ceiling(remainder/numbersWorkers)} liters per person.");
            }

        }
    }
}
