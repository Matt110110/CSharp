using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution {

    static int solve(int n, int[] s, int d, int m)
    {
        // Complete this function
        var result = 0;
        if (n > 1)
        {
            for (var i = 0; i <= n-m; i++)
            {
                var sum = 0;
                for (var j = i; j < i + m; j++)
                {
                    sum += s[j];
                }
                if (sum == d)
                {
                    result++;
                }
            }
        }
        else
        {
            if (s[0] == d)
            {
                result = 1;
            }
        }
        // Return statement
        return result;
    }

    static void Main(string[] args)
    {
        var n = int.Parse(ReadLine());
        string[] s_temp = ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        string[] tokens_d = ReadLine().Split(' ');
        var d = int.Parse(tokens_d[0]);
        var m = int.Parse(tokens_d[1]);
        var result = solve(n, s, d, m);
        WriteLine(result);
    }
}
