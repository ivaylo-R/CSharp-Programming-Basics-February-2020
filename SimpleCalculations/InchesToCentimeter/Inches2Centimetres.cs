using System;

namespace InchesToCentimeter
{
    class Inches2Centimetres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter inches:  ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimetres= " + (a * 2.54));
        }
    }
}
