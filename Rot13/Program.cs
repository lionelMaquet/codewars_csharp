using System;
using System.Collections.Generic;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Rot13("Test1");
        }

        public static string Rot13(string message)
        {
            // creates the alphabet list of char (in lowercase)
            string alphabetString = "abcdefghijklmnopqrstuvwxyz";
            List<char> alphabet =  new List<char>();
            alphabet.AddRange(alphabetString);

            // the rot13'd list
            List<char> rot13 = new List<char>();

            foreach(char c in message)
            {
                int indexOfCharInAlphabet = alphabet.FindIndex(x => x == char.ToLower(c));
                int rot13Index = (indexOfCharInAlphabet + 13) % alphabet.Count;

                // if indexOfCharInAlphabet == -1, it means it wasn't found. Meaning it's not a simple letter.
                if (indexOfCharInAlphabet != -1)
                {
                    char chatToAdd = indexOfCharInAlphabet != -1 ? (char.IsUpper(c) ? char.ToUpper(alphabet[rot13Index]) : alphabet[rot13Index]) : c;
                    char charToAdd = char.IsUpper(c) ? char.ToUpper(alphabet[rot13Index]) : alphabet[rot13Index];
                    rot13.Add(charToAdd);
                }

                else
                {
                    rot13.Add(c);
                }
            }

            string rot13string = new string(rot13.ToArray());
            return rot13string;
        }
    }
}
