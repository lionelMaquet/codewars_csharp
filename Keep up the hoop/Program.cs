using System;

namespace Keep_up_the_hoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string HoopCount(int n)
        {
            return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
        }
    }
}
