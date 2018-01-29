using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
// Add comment
            return a + b + 3;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
