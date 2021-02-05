using System;
using System.Collections.Generic;

namespace Scramblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool Scramble(string str1, string str2)
        {

            List<char> chars = new List<char>();
            chars.AddRange(str1);
            
            foreach(char c in str2)
            {
                if (chars.Contains(c))
                {
                    chars.Remove(c);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
