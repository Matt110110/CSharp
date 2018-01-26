using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Solution
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            // Complete this function
            var a = 0L;
            var rem = n % s.Length;
            var div = n / s.Length;
            List<char> at = new List<char>(s.ToCharArray());
            for (var i = 0; i < rem; i++)
            {
                if (at[i] == 'a')
                {
                    a++;
                }
            }            
            at.RemoveAll(x => x != 'a');            
            a += at.ToArray().Length * div;
            // Return statement always bottom
            return a;
        }

        static void Main(String[] args)
        {
            string s = ReadLine();
            long n = Convert.ToInt64(ReadLine());
            long result = repeatedString(s, n);
            WriteLine(result);
        }
    }
}
