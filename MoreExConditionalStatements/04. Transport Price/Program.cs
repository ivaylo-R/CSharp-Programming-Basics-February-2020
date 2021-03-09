using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double sum = 0;
            if (n <= 20)
            {
                if (dayOrNight == "day")
                {
                    sum = n * 0.79 + 0.70;
                }
                else
                {
                    sum = n * 0.90 + 0.70;
                }

            }
            else if (n > 20 && n < 100)
            {
                sum = n * 0.09;
            }
            else if (n >= 100)
            {
                sum = n * 0.06;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
