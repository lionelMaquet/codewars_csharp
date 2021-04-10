using System;

namespace Take_the_derivative
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Derive(double coefficient, double exponent)
        {
            return $"{coefficient * exponent}x^{exponent - 1}";
        }
    }
}
