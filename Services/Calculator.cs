using lab_SaTPM_cs_calc.Models;

namespace lab_SaTPM_cs_calc.Services;

public class Calculator
{
    public double Calculate(double a, double b, string operation)
    {
        double result;

        switch (operation)
        {
            case "+":
                result = Operations.Add(a, b);
                break;

            case "-":
                result = Operations.Subtract(a, b);
                break;

            case "*":
                result = Operations.Multiply(a, b);
                break;

            case "/":
                if (b == 0)
                    throw new DivideByZeroException("Деление на 0 невозможно. Введите корректное значение.");
                result = Operations.Divide(a, b);
                break;

            case "^":
                result = Operations.Power(a, b);
                break;

            case "sqrt":
                if (a < 0)
                    throw new ArgumentException("Невозможно вычислить квадратный корень из отрицательного числа.");
                result = Math.Sqrt(a);
                break;

            default:
                throw new InvalidOperationException("Введённая операция не поддерживается.");
        }

        return result;
    }
}