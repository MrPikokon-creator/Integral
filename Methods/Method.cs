using System;

namespace Integral.Methods
{
    public class Method
    {
        // Вывод заголовка таблицы
        protected static void ShowHeader()
        {
            Console.WriteLine($"{"i",-6}Результат");
        }
        
        // Вывод строки таблицы
        protected static void ShowLine(double i, double stepResult)
        {
            stepResult = Math.Round(stepResult, 4);
            Console.WriteLine("{0,-6}{1}", i, stepResult);
        }
    }
}