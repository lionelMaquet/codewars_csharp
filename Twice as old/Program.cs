using System;

namespace Twice_as_old
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return Math.Abs(dadYears - sonYears * 2);
        }
    }
}
