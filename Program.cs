using System;
using Integral.Methods;

namespace Integral
{
    public static class Program
    {
        // Функция
        public static double Function(double number)
        {
            double y = Math.Sqrt(number);
            return number;
        }
        
        public static void Main()
        {
            Console.Write("Начало отрезка (a): ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Конец отрезка (b): ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Длина шага (h): ");
            double step = double.Parse(Console.ReadLine());

            MiddleRectangles.Decision(a, b, step); // Метод средних прямоугольников
            LeftRectangles.Decision(a, b, step); // Метод односторонних прямоугольников (точка слева)
            RightRectangles.Decision(a, b, step); // Метод односторонних прямоугольников (точка справа)
            Trapezoids.Decision(a, b, step); // Метод трапеций
            Simpson.Decision(a, b, step); // Метод Симпсона
            _3_8.Decision(a, b, step); // Метод 3/8
        }
    }
}