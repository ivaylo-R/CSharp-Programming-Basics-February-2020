using System;

namespace ExamRoomWorkPlaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitcoins = ");
            decimal bitcoins = int.Parse (Console.ReadLine());
            Console.Write("ChineeseYuans =   ");
            decimal yuans = decimal.Parse(Console.ReadLine());
            Console.Write("Comission=");
            decimal commision = decimal.Parse(Console.ReadLine())/ 100.00m;

            decimal bitcoinsToleva = bitcoins * 1168;
            decimal yuanTodollar = yuans * 0.15m;
            decimal dollarToleva = yuanTodollar * 1.76m;
            decimal TotalLeva = bitcoinsToleva + dollarToleva;
            decimal ComissionInLeva= TotalLeva*commision;
            decimal Euro = TotalLeva / 1.95m - ComissionInLeva;
            Console.Write("Euro =   ");
            Console.WriteLine(Euro);
           
                


                
            
        }
    }
}
