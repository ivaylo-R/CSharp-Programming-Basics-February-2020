using System;

namespace MoreExConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double forThreeHForPipe1 = P1 * H;
            double forThreeHForPipe2 = P2 * H;
            double totalV = forThreeHForPipe1 + forThreeHForPipe2;
            if (totalV > V)
            {
                Console.WriteLine($"For {H} hours the pool overflows with {totalV - V} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {(totalV / V * 100):f2}% full. Pipe 1: {(forThreeHForPipe1 / totalV * 100):f2}%. Pipe 2: {(forThreeHForPipe2 / totalV * 100):f2}%.");
            }


        }
    }
}
