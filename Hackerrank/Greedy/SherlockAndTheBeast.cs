using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution
{

    static void Main(string[] args)
    {
        var t = int.Parse(ReadLine());
        for (var a0 = 0; a0 < t; a0++)
        {
            var n = int.Parse(ReadLine());
            var num = getDescent(n);
            WriteLine(num);
        }

    }
    static string getDescent(int n)
    {
        var ret = "";
        for (var i = n; i >= 0; i--)
        {
            if (i % 3 == 0 &&(n - i) % 5 == 0)
            {
                ret = new string('5', i) + new string('3', n - i);
                break;
            }           
        }
        // Return statement always bottom
        return ((ret == String.Empty) ? "-1" : ret);
    }
}
