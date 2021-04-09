using System;

namespace Find_the_position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Position(char alphabet)
        {
            return $"Position of alphabet: {"abcdefghijklmnopqrstuvwxyz".IndexOf(alphabet) + 1}"; 
        }
    }
}
