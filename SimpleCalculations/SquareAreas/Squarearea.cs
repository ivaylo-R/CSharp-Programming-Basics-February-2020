using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareAreas
{
    class Squarearea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :  ");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Лицето е= " + (a*a));


        }
    }
}
