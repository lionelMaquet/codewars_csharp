using System;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool ValidParentheses(string input)
        {
            int validation = 0; 

            foreach(char c in input.ToCharArray())
            {
                if (validation < 0)
                {
                    return false;
                }

                switch (c)
                {
                    case '(':
                        validation++;
                        break;
                    case ')':
                        validation--;
                        break;
                    default:
                        break;
                }
            }

            return validation == 0;

        }
    }
}
