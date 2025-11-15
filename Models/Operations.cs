namespace lab_SaTPM_cs_calc.Models;

public delegate double MathOperation(double a, double b);

public static class Operations
{
    public static readonly MathOperation Add = (a, b) => a + b;
    public static readonly MathOperation Subtract = (a, b) => a - b;
    public static readonly MathOperation Multiply = (a, b) => a * b;
    public static readonly MathOperation Divide = (a, b) => a / b;
    public static readonly MathOperation Power = (a, b) => Math.Pow(a, b);
}