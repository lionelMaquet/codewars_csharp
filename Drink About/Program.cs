using System;

namespace Drink_About
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string PeopleWithAgeDrink(int old)
        {
            return old < 14 ? "drink toddy" : (old < 18 ? "drink coke" : (old < 21 ? "drink beer" : "drink whisky"));
        }
    }
}
