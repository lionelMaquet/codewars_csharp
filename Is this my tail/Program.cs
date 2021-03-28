using System;

namespace Is_this_my_tail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool CorrectTail(string body, string tail)
        {
            return tail[0] == body[body.Length - 1];
        }
    }
}
