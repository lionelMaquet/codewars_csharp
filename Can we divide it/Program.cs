using System;

namespace Can_we_divide_it
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool is_divide_by(int number, int a, int b)
        {
            return (number % a == 0 && number % b == 0);
        }
    }
}
