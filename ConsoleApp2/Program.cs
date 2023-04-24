using System;
using Colculation;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ColculationLib.Plus(15, 5));
            Console.WriteLine(ColculationLib.Minus(15, 5));
            Console.WriteLine(ColculationLib.MultiPly(15, 5));
            Console.WriteLine(ColculationLib.Divide(15, 5));
        }
    }
}
