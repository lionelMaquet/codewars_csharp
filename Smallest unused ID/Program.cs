using System;
using System.Linq;

namespace Smallest_unused_ID
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int NextId(int[] ids)
        {
            for (int check = 0;; check++)
            {
                if (!ids.ToList().Contains(check))
                {
                    return check;
                }
            }
        }
    }
}
