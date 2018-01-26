using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Solution
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            var jumps = 0;
            var i = 0;
            while(i != c.Length-1)
            {
                if ((i < c.Length-2) && (c[i] == 0))
                {
                    jumps++;
                    i += 2;
                }
                else
                {
                    jumps++;
                    i++;
                }
            }
            return jumps;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(ReadLine());
            string[] c_temp = ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int result = jumpingOnClouds(c);
            WriteLine(result);
        }
    }
}