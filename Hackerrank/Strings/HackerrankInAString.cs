using System.Collections.Generic;
using System;
using System.Linq;
using static System.Console;
using System.Numerics;
using System.Text.RegularExpressions;

namespace BackupSolution
{
    class Program
    {
        static string hackerrankInString(string s)
        {
            s.ToLower();
            var index = 0;
            // Complete this function
            var hackerrank = "hackerrank";
            var hr = hackerrank.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == hr[index])
                {
                    index++;
                }
                if (index == hackerrank.Length)
                {
                    return "YES";
                }
            }
            // Return statement always bottom
            return "NO";
        }

        static void Main(string[] args)
        {
            var q = int.Parse(ReadLine());
            for (var a0 = 0; a0 < q; a0++)
            {
                var s = ReadLine();
                var result = hackerrankInString(s);
                WriteLine(result);
            }
        }
    }
}
