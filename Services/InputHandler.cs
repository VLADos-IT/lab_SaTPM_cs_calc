using System.Globalization;

namespace lab_SaTPM_cs_calc.Services;

public static class InputHandler
{
    public static double ReadNumber(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine()?.Trim()?.Replace(',', '.');

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double num))
            {
                if (MathValidator.HasMoreFiveDecimals(input))
                {
                    Console.WriteLine("Превышено количество знаков после запятой (максимум 5).");
                    continue;
                }

                return num;
            }

            Console.WriteLine("Данное значение не является корректным для ввода. Введите верное число.");
        }
    }

    public static string ReadOperation(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? op = Console.ReadLine()?.Trim();

            if (MathValidator.IsValidOperation(op))
                return op;

            Console.WriteLine("Введённая операция не поддерживается. Повторите ввод.");
        }
    }
}