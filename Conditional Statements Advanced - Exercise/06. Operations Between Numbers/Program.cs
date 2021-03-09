using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            if (symbol == "+")
            {
                double result = n1 + n2;
                string evenOdd;
                if (result %2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine($"{n1} {symbol} {n2} = {result} - {evenOdd}");
                
            }
           else if (symbol == "-")
            {
                double result = n1 - n2;
                string evenOdd;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine($"{n1} {symbol} {n2} = {result} - {evenOdd}");

            }
            else if (symbol == "*")
            {
                double result = n1 * n2;
                string evenOdd;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine($"{n1} {symbol} {n2} = {result} - {evenOdd}");

            }
            else if (symbol == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    
                }
                else
                {
                    double result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
                
            }
           else if (symbol == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    return;
                }
                Console.WriteLine($"{n1} % {n2} = {n1%n2}");
            }
        }
    }
}
