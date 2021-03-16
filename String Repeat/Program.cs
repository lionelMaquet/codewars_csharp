using System;
using System.Collections.Generic;

namespace String_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string RepeatStr(int n, string s)
        {
            return new String('X', n).Replace("X", s);
        }
    }
}
