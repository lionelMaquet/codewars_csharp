using System;

namespace Switch_it_up
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string SwitchItUp(int number)
        {
            return "Zero,One,Two,Three,Four,Five,Six,Seven,Eight,Nine".Split(',')[number]; 
        }
    }
}
