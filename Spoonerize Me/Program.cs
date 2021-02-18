using System;

namespace Spoonerize_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Spoonerize(string str)
        {
            string[] splittedStr = str.Split(' ');

            string spoonerizedWordOne = string.Concat(splittedStr[1].Substring(0, 2), splittedStr[0].Substring(2));
            string spoonerizedWordTwo = string.Concat(splittedStr[0].Substring(0, 2), splittedStr[1].Substring(2));

            return string.Concat(spoonerizedWordOne, " ", spoonerizedWordTwo);
        }
    }
}
