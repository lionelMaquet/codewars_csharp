using System;

namespace Multiply_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Multiply(int number)
        {
            return (int)(number * (Math.Pow(5, Math.Abs(number).ToString().Length)));
        }
    }
}
