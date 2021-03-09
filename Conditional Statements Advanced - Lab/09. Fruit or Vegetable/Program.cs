using System;

namespace _09._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfProduct = Console.ReadLine();
            if (nameOfProduct == "banana" || nameOfProduct == "lemon" || nameOfProduct == "cherry" || nameOfProduct == "grapes" || nameOfProduct == "kiwi" || nameOfProduct == "apple")
            {
                Console.WriteLine("fruit");
            }
            else if (nameOfProduct == "tomato" || nameOfProduct == "cucumber" || nameOfProduct == "carrot" || nameOfProduct == "pepper")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
                      
            
        }
    }
}
