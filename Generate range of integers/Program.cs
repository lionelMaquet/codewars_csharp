using System;
using System.Linq;

namespace Generate_range_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateRange(2, 10, 2);
        }
        
        public static int[] GenerateRange(int min, int max, int step)
        {
            return Enumerable.Range(min, max - min + 1).Select(e => e == min || (e - min) % step == 0 ? e : -1).Where(i => i != -1).ToArray();
        }
    }
}
