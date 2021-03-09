using System;

namespace _05.divisionWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
                
            }
            sum1 = p1/n* 100;
            sum2 = p2/n*100;
            sum3 = p3/n*100;
            Console.WriteLine($"{sum1:F2}%");
            
            Console.WriteLine($"{sum2:F2}%");
            
            Console.WriteLine($"{sum3:F2}%");

        }
    }
}
