using System;

namespace ProgrammingBasicsOnlineExam_20and21April2019
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalEggs = int.Parse(Console.ReadLine());
            string color = "";
            int redCounter = 0;
            int orangeCounter = 0;
            int blueCounter = 0;
            int greenCounter = 0;
            int max = int.MinValue;

            for (int i = 0; i <= totalEggs; i++)
            {

                color = Console.ReadLine();
                if (color=="red")
                {
                    redCounter++;
                }
                if (color=="orange")
                {
                    orangeCounter++;
                }
                if (color=="blue")
                {
                    blueCounter++;
                }
                if(color=="green")
                {
                    greenCounter++;
                }
                
            }
            string colorMax = "";
            if (max<=redCounter)
            {
                max = redCounter;
                colorMax = "red";
            }
            if (max<=orangeCounter)
            {
                max = orangeCounter;
                colorMax = "orange";
            }
            if (max<=blueCounter)
            {
                max = blueCounter;
                colorMax = "blue";
            }
            if(max<=greenCounter)
            {
                max = greenCounter;
                colorMax = "green";
            }
            Console.WriteLine($"Red eggs: {redCounter}");
            Console.WriteLine($"Orange eggs: {orangeCounter}");
            Console.WriteLine($"Blue eggs: {blueCounter}");
            Console.WriteLine($"Green eggs: {greenCounter}");
            Console.WriteLine($"Max eggs: {max} -> {colorMax}");
        }
    }
}
