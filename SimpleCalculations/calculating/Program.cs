using System;

namespace calculating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vegetables Price: ");
            var vegetablesPrice = double.Parse(Console.ReadLine());
            // Price of Vegetables
            Console.Write("Fruits Price: ");
            var fruitsPrice = double.Parse(Console.ReadLine());
            //Price of Fruits
            Console.Write("Quantity of Vegetables(in kg): ");
            var quantityVegetables = int.Parse(Console.ReadLine());
            //Quantity of Vegetables in kg
            Console.Write("Quantity of Fruits: ");
            var quantityFruits = int.Parse(Console.ReadLine());
            //Quantity of Fruits in kg
            var total1 = (vegetablesPrice * quantityVegetables)/1.94;
            Console.Write("Vegetables total:"); 
            Console.WriteLine(total1);
            var total2 = (Math.Truncate(fruitsPrice*quantityFruits))/1.94;
            Console.Write("Fruits total:");
            Console.WriteLine(total2);
            Console.Write("Total:");
            Console.WriteLine(total1+total2);

        }
    }
}
