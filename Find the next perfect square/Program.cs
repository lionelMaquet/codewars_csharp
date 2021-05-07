using System;

namespace Find_the_next_perfect_square
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static long FindNextSquare(long num)
        {
            return Math.Sqrt((double)num) == (int)Math.Sqrt((double)num) ? (long)Math.Pow(Math.Sqrt(num) + 1, 2) : -1;
        }
    } 
}
