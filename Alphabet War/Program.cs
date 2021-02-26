using System;

namespace Alphabet_War
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string AlphabetWar(string fight)
        {
            int leftSide = 0;
            int rightSide = 0;

            foreach(char c in fight)
            {
                switch (c)
                {
                    case 'w':
                        leftSide += 4;
                        break;
                    case 'p':
                        leftSide += 3;
                        break;
                    case 'b':
                        leftSide += 2;
                        break;
                    case 's':
                        leftSide += 1;
                        break;

                    case 'm':
                        rightSide += 4;
                        break;
                    case 'q':
                        rightSide += 3;
                        break;
                    case 'd':
                        rightSide += 2;
                        break;
                    case 'z':
                        rightSide += 1;
                        break;

                    default:
                        break;
                }
            }

            return rightSide != leftSide ? (leftSide > rightSide ? "Left side wins!" : "Right side wins!" ) : "Let's fight again!";
        }
    }
}
