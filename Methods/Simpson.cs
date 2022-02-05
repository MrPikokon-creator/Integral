using System;

namespace Integral.Methods
{
    public class Simpson : Method
    {
        public static void Decision(double a, double b, double step)
        {
            double result = 0;
            Console.WriteLine("\nМетод Симпсона:");
            ShowHeader(); // Отображение заголовка таблицы
            
            for (double i = a; i < b; i += step)
            {
                double begin = Program.Function(i); // Начало фигуры
                double middle = Program.Function((a + b) / 2); // Середина фигуры
                double end = Program.Function(i + step); // Конец фигуры

                double stepResult = (begin + 4 * middle + end) / 6 * step; // Площадь фигуры
                result += stepResult;

                ShowLine(i, stepResult);
            }

            result = Math.Round(result, 4);
            Console.WriteLine($"Результат: {result}");
        }
    }
}