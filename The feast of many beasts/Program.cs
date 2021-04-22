using System;

namespace The_feast_of_many_beasts
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool Feast(string beast, string dish)
        {
            return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
        }
    }
}
