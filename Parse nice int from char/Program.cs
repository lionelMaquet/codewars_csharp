using System;

namespace Parse_nice_int_from_char
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GetAge(string inputString)
        {
            return int.Parse(inputString.Substring(0, 1));
        }
    }
}
