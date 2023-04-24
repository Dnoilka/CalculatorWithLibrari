using System;

namespace CalculatinLib
{
    public static class CalculatoinLib
    {
       public static double Plus()
        {
            Console.WriteLine("Метод сложение:");
            Console.Write("Введите a - ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b - ");
            double b = Convert.ToDouble(Console.ReadLine());
            return a + b;
        }
        public static double Minus()
        {
            Console.WriteLine("Метод вычитание:");
            Console.Write("Введите a - ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b - ");
            double b = Convert.ToDouble(Console.ReadLine());
            return a - b;
        }
       public static double divide()
        {
            Console.WriteLine("Метод деление:");
            Console.Write("Введите a - ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b - ");
            double b = Convert.ToDouble(Console.ReadLine());
            return a / b;
        }
       public static double multiply()
        {
            Console.WriteLine("Метод умножение:");
            Console.Write("Введите a - ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b - ");
            double b = Convert.ToDouble(Console.ReadLine());
            return a * b;
        }
    }
}   
