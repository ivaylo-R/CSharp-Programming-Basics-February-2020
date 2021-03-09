using System;

namespace ProgrammingBasicsOnlineRetakeExam_2and3May2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = int.Parse(Console.ReadLine());
            double hours = int.Parse(Console.ReadLine());
            double total = 0;
            double sum = 0;
            for (int i = 1; i <= days; i++)
            {
                double parkingPrice = 0;
                total = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        parkingPrice += 1.25;
                    }
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        parkingPrice += 2.50;
                    }
                    
                    if (i%2==0 && j%2==0)
                    {
                        parkingPrice += 1.0;
                    }
                    if (i%2!=0 && j%2!=0)
                    {
                        parkingPrice += 1.0;
                    }
                }
                
                total += parkingPrice;
                sum += total;
                Console.WriteLine($"Day: {i} - {total:F2} leva");
            }
            
            Console.WriteLine($"Total: {sum:F2} leva");
        }   
    }
}
