using Contracts;

namespace ClassLibrary
{
    public class MathService: IMathService
    {
        public double Sum(double a, double b)
        {
            return a + b;
        } 
        public double Substracion(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is prohibited");
            }
            
            return a / b;
        }
        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}