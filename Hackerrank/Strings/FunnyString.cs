using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using System.Text.RegularExpressions;

namespace Solution
{
    class Program
    {
        static string ReverseStringDirect(string s)
        {
            var array = new char[s.Length];
            var forward = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }

        static string funnyString(string s)
        {
            // Complete this function
            var res = "Not Funny";
            var j = 1;
            var reversed = ReverseStringDirect(s);
            while ((Math.Abs(s[j] - s[j - 1]) == Math.Abs(reversed[j] - reversed[j - 1])) && j < s.Length)
            {
                j++;
                if (j == s.Length)
                {
                    res = "Funny";
                    break;
                }
            }
            // return statement always bottom
            return res;
        }

        static void Main(string[] args)
        {
            var q = int.Parse(ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                var s = ReadLine();
                string result = funnyString(s);
                WriteLine(result);
            }
        }
    }
}