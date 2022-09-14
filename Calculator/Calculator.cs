using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            decimal result = (decimal)(a + b);
            return (double)result;
        }

        public double Substract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            decimal result = (decimal)(a * b);
            return (double)result;
        }

        public double Power(double a, double b)
        {
            decimal result = (decimal)MathF.Pow((float)a, (float)b);
            return (double)result;
        }
    }
}