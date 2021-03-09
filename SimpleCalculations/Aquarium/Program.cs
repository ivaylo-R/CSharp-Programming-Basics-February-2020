using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Дължина в см – цяло число в интервала[10 … 500]
            int lenght = int.Parse(Console.ReadLine());
            //2.Широчина в см – цяло число в интервала[10 … 300]
            int widght = int.Parse(Console.ReadLine());
            //3.Височина в см – цяло число в интервала[10… 200]
            int height = int.Parse(Console.ReadLine());
            //4.Процент  – реално число в интервала[0.000 … 100.000]
            int percent = int.Parse(Console.ReadLine());
            // capacity paralelep. V= l*w*h in CM;
            int capacity = ((lenght * widght * height)*10)-percent*100;
            Console.WriteLine(capacity);




        }
    }
}
