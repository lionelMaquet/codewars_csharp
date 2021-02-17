using System;
using System.Collections.Generic;
using System.Linq;

namespace Range_Exctraction
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine( Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }));
        }

        public static string Extract(int[] args)
        {
            string extracted = "";
            
            List<int> range = new List<int>();
            for (int i = 0; i < args.Length; i++)
            {

                if (i == 0)
                {
                    if (args[i] == args[i + 1] - 1)
                    {
                        range.Add(args[i]);
                    }

                    else
                    {
                        extracted = String.Concat(extracted, ",", $"{args[i]}");
                    }
                }

                else if (i == args.Length - 1)
                {
                    if (args[i] == args[i - 1 ] + 1)
                    {
                        range.Add(args[i]);
                    }

                    else
                    {
                        extracted = String.Concat(extracted, ",", $"{args[i]}");
                    }
                }

                else
                {
                    if (args[i] == args[i + 1] - 1 )
                    {
                        range.Add(args[i]);
                        range.Add(args[i + 1]);
                    }

                    else
                    {
                        if (range.Count > 0)
                        {
                            if (range.Distinct().Count() >= 3)
                            {
                                extracted = String.Concat(extracted, ",", $"{range[0]}", "-", $"{range[range.Count - 1]}");
                                range.Clear();
                            }

                            else
                            {
                                foreach(int num in range.Distinct())
                                {
                                    extracted = String.Concat(extracted, ",", $"{num}");
                                }
                                range.Clear();
                            }


                            
                        }
                        else
                        {
                            extracted = String.Concat(extracted, ",", $"{args[i]}");
                        }
                    }
                }
            }

            if (range.Count > 0)
            {
                if (range.Distinct().Count() >= 3)
                {
                    extracted = String.Concat(extracted, ",", $"{range[0]}", "-", $"{range[range.Count - 1]}");
                    range.Clear();
                }

                else
                {
                    foreach (int num in range.Distinct())
                    {
                        extracted = String.Concat(extracted, ",", $"{num}");
                    }
                    range.Clear();
                }
            }


            extracted = extracted.Remove(0, 1);
            return extracted;
        }
    }
}
