using System;
using System.Linq;

namespace My_head_is_at_the_wrong_end
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string[] FixTheMeerkat(string[] arr)
        {
            return arr.Reverse().ToArray();
        }
    }
}
