using static System.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

    class Program
    {
        static int res = 0;
        static int fairRations(int[] B)
        {
            // Complete this function
            var count = B.Count(x => x % 2 != 0);
            if (count % 2 != 0)
            {
                return 1;
            }
            else
            {
                for (var i = 0; i < B.Length; i++)
                {
                    if (B[i]%2 != 0)
                    {
                        B[i]++;
                        B[i + 1]++;
                        res += 2;
                    }
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            string[] B_temp = ReadLine().Split(' ');
            int[] B = Array.ConvertAll(B_temp, int.Parse);
            var result = fairRations(B);
            if (result == 1)
            {
                WriteLine("NO");
            }
            else
            {
                WriteLine(result);
            }            
        }
    }

