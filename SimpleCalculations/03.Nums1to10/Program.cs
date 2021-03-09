using System;

namespace _03.Nums1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("SquareSide =  ");
            var N = double.Parse(Console.ReadLine());
            // SquareSide
            Console.Write("TileWidght =  ");
            var W = double.Parse(Console.ReadLine());
            // TileWidght
            Console.Write("TileLenght= ");
            var L = double.Parse(Console.ReadLine());
            // TileLenght
            Console.Write("BenchWidght= ");
            var M = double.Parse(Console.ReadLine());
            // WidghtOfBench
            Console.Write("BenchLenght=");
            var O = double.Parse(Console.ReadLine());
            // Lenhgt of the bench
            var SquareFace = N * N;
            Console.Write("SquareFace is ");
            Console.WriteLine(SquareFace);
            var FaceoOfTile = W * L;
            Console.Write("FaceOfTile= ");
            Console.WriteLine(FaceoOfTile);
            var SquareOfBench = O * M;
            Console.Write("SquareOfBench= ");
            Console.WriteLine(SquareOfBench);
            var TotalTiles = (SquareFace - SquareOfBench) / FaceoOfTile;
            Console.Write("TotalTiles =");
            Console.WriteLine(TotalTiles);
            var resultTime = TotalTiles*0.2;
            Console.Write("TimeForTiles=");
            Console.WriteLine(resultTime);




        }
    }
}
