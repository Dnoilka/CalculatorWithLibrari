using System;
using CalculatinLib;

namespace Calculatorwithlib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculatinLib.CalculatoinLib.Plus());
            Console.WriteLine(CalculatinLib.CalculatoinLib.Minus());
            Console.WriteLine(CalculatinLib.CalculatoinLib.multiply());
            Console.WriteLine(CalculatinLib.CalculatoinLib.divide());
        }
    }
}
