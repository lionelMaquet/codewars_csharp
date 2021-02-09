using System;

namespace First_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (!s.Remove(i, 1).ToLower().Contains(char.ToLower(s[i])))
                {
                    return s[i].ToString();
                }
            }
            return "";
        }
    }
}
