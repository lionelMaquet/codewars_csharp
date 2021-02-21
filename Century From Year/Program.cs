using System;

namespace Century_From_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int СenturyFromYear(int year)
        {
            return year % 100 == 0 ? year / 100 : (year / 100) + 1;
        }
    }
}
