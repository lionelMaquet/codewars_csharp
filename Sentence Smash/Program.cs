using System;

namespace Sentence_Smash
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Smash(string[] words)
        {
            string smashed = "";

            foreach(string s in words)
            {
                smashed = string.Concat(smashed, " ");
                smashed = string.Concat(smashed, s);
            }

            return smashed.Remove(0,1);
        }
    }
}
