using System;
using System.Collections.Generic;


namespace Convert_PascalCase_string_into_snake_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToUnderscore(56));
            Console.WriteLine(ToUnderscore("AlphaBet"));
        }

        public static string ToUnderscore(int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore(string str)
        {
            List<char> underscored = new List<char>();

            foreach(char c in str)
            {
                if (Char.IsUpper(c) && !Char.IsDigit(c))
                {
                    underscored.Add('_');
                }
                
                underscored.Add(Char.ToLower(c));
            }

            return new string(underscored.ToArray()).Remove(0, 1);
        }
    }
}
