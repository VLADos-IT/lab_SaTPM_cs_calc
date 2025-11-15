using lab_SaTPM_cs_calc.Services;

namespace lab_SaTPM_cs_calc;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        while (true)
        {
            try
            {
                double num1 = InputHandler.ReadNumber("Введите первое число: ");
                string op = InputHandler.ReadOperation("Введите операцию(+,-,*,/,^,sqrt): ");

                double result;

                if (op == "sqrt")
                {
                    result = calculator.Calculate(num1, 0, op);
                }
                else
                {
                    double num2 = InputHandler.ReadNumber("Введите второе число: ");
                    result = calculator.Calculate(num1, num2, op);
                }

                Console.WriteLine($"Результат: {result:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}