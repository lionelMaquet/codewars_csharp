using System;

namespace Do_you_speak_English
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool SpeakEnglish(string sentence)
        {
            return sentence.ToLower().Contains("english");
        }
    }
}
