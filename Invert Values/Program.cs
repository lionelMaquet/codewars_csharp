using System;
using System.Linq;

namespace Invert_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            InvertValues(new int[] { 1, 2, 3 });
        }

        public static int[] InvertValues(int[] input)
        {
            return input.Select(s => s * -1).ToArray();
        }
    }
}
