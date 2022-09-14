using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return MathF.Round((float)a * (float)b);
        }

        public double Power(double a, double b)
        {
            return MathF.Round(MathF.Pow((float)a, (float)b));
        }
    }
}