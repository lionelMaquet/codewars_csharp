using System;

namespace Area_or_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int AreaOrPerimeter(int l, int w)
        {
            return l == w ? l * w : (l * 2) + (w * 2);
        }
    }
}
