using System;

namespace Are_you_playing_banjo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string AreYouPlayingBanjo(string name)
        {
            return char.ToLower(name[0]) == 'r' ? $"{name} plays banjo" : $"{name} does not play banjo";
        }
    }
}
