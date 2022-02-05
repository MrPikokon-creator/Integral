using System;

namespace Integral.Methods
{
    public class _3_8 : Method
    {
        public static void Decision(double a, double b, double step)
        {
            double result = 0;
            Console.WriteLine("\nМетод 3/8");
            ShowHeader(); // Отображение заголовка таблицы
            
            for (double i = a; i < b; i += step)
            {
                double begin = Program.Function(i); // Начало фигуры
                double middle1 = Program.Function((2 * a + b) / 3); // Первая треть фигуры
                double middle2 = Program.Function((a + 2 * b) / 3); // Вторая треть фигуры
                double end = Program.Function(i + step); // Конец фигуры

                double stepResult = (begin + 3 * middle1 + 3 * middle2 + end) / 8 * step; // Площадь фигуры
                result += stepResult;

                ShowLine(i, stepResult);
            }

            result = Math.Round(result, 4);
            Console.WriteLine($"Результат: {result}");
        }
    }
}