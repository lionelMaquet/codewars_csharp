using System;

namespace Remove_first_and_last_character
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}
