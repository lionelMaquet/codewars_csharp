using System;

namespace Whats_the_real_floor
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GetRealFloor(int n)
        {
            return n <= 0 ? n : (n >= 13 ? n - 2 : n - 1);
        }
    }
}
