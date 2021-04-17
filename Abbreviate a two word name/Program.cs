using System;

namespace Abbreviate_a_two_word_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string AbbrevName(string name)
        {
            List<char> chars = new List<char>();
            name.foreach(char c){
                if (char.ToUpper(c) == c) {
                    chars.add(c);
                }
            }
        }
    }
}
