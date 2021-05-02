using System;
using System.Linq;

namespace Calculate_average
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static double FindAverage(double[] array)
        {
            return array.Length > 0 ? array.ToList().Average() : 0;
        }
    }
}
