using System;

namespace Do_I_get_a_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string bonus_time(int salary, bool bonus)
        {
            return bonus ? String.Concat("$", (salary * 10).ToString()) : String.Concat("$", salary.ToString());
        }
    }
}
