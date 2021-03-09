using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine())*100;
            var widght = double.Parse(Console.ReadLine())*100;
            var cols = (widght - 100) / 70;
            var rows = lenght / 120;
            double seats = cols * rows-3;
            Console.Write("Seats are ");
            Console.WriteLine(Math.Truncate(seats));


        }
    }
}