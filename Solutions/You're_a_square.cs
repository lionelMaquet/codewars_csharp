using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class You_re_a_square
    {
        public static bool IsSquare(int n)
        {
            if (n >= 0)
            {
                double sqrt = Math.Sqrt((double)n);
                if (sqrt % 1 == 0)
                { // If it has no decimal values
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}



