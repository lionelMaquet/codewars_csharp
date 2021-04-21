using System;

namespace Convert_a_string_to_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string[] StringToArray(string str)
        {
            return str.Split(' ');
        }
    }
}
