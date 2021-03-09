using System;

namespace _01.HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 =");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            var y2 = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            var y = double.Parse(Console.ReadLine());
                if (x >= x1 && x <= x2 && y >= y1 && y2 >= y)
            
                 {
                    Console.WriteLine("Inside");
                 }
           
                else
                 {
                    Console.WriteLine("Outside");
                 }
        }
    }
}
