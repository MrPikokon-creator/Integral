using System;

namespace Integral.Methods
{
    public class RightRectangles : Method
    {
        public static void Decision(double a, double b, double step)
        {
            Console.WriteLine("\nМетод односторонних прямоугольников (точка справа):");
            ShowHeader(); // Отображение заголовка таблицы
            double result = 0;
            
            for (double i = a; i < b; i += step)
            {
                double stepResult = Program.Function((i + step) * step); // Площадь прямоугольника
                result += stepResult;

                ShowLine(i, stepResult);
            }

            result = Math.Round(result, 4);
            Console.WriteLine($"Результат: {result}");
        }
    }
}