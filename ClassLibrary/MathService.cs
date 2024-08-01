using Contracts;

namespace ClassLibrary
{
    public class MathService: IMathService
    {
        public int Sum(int a, int b)
        {
            return a + b;
        } 

    }
}