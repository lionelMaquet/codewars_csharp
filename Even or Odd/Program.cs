using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
