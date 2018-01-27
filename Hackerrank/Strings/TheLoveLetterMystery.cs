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
        static int theLoveLetterMystery(string s)
        {
            // Complete this function
            var no = 0;
            for (int i = 0, j = s.Length - 1; i < j; i++, j-- )
            {
                no += Math.Abs(s[i] - s[j]);
            }
            return no;
        }

        static void Main(string[] args)
        {
            var q = int.Parse(ReadLine());
            for (var a0 = 0; a0 < q; a0++)
            {
                string s = ReadLine();
                int result = theLoveLetterMystery(s);
                WriteLine(result);
            }
        }
    }
}
