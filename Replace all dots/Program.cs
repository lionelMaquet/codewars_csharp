using System;

namespace Replace_all_dots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string ReplaceDots(string str)
        {
            return str.Replace('.', '-');
        }
    }
}
