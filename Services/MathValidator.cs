namespace lab_SaTPM_cs_calc.Services;

public static class MathValidator
{
    public static bool HasMoreFiveDecimals(string input)
    {
        if (input.Contains('.'))
        {
            string[] parts = input.Split('.');
            return parts.Length == 2 && parts[1].Length > 5;
        }
        return false;
    }

    public static bool IsValidOperation(string? op)
    {
        return op == "+" || op == "-" || op == "*" || op == "/" || op == "^" || op == "sqrt";
    }
}