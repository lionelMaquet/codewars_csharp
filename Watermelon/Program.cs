using System;

namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool Divide(int weight)
        {
            return weight <= 2 ? false : weight % 2 == 0;  
        }
    }
}