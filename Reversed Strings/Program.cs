using System;

namespace Reversed_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Solution(string str)
        {
            char[] strToArray = str.ToCharArray();
            Array.Reverse(strToArray);
            return new string(strToArray);
        }
    }
}
