using System;

namespace Opposites_Attract
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool lovefunc(int flower1, int flower2)
        {
            return (flower1 + flower2) % 2 == 1;
        }
    }
}
