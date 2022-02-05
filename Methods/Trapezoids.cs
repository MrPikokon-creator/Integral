using System;

namespace Integral.Methods
{
    public class Trapezoids : Method
    {
        public static void Decision(double a, double b, double step)
        {
            double result = 0;
            Console.WriteLine("\nМетод трапеций:");
            ShowHeader(); // Отображение заголовка таблицы
            
            for (double i = a; i < b; i += step)
            {
                double begin = Program.Function(i); // Начало трапеции
                double end = Program.Function(i + step); // Конец трапеции

                double stepResult = (begin + end) / 2 * step; // Площадь трапеции
                result += stepResult;

                ShowLine(i, stepResult);
            }

            result = Math.Round(result, 4);
            Console.WriteLine($"Результат: {result}");
        }
    }
}