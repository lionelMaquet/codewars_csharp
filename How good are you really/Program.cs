using System;
using System.Linq;

namespace How_good_are_you_really
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.ToList().Average() < YourPoints ? true : false;
        }
    }
}
