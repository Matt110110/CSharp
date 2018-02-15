using System;
using System.Linq;
using static System.Console;

class Solution
{
    static int[] serviceLane(int n, int[][] cases, int t, int[] width)
    {
        var res = new int[t];
        for (var i = 0; i < res.Length; i++)
        {
            var arrTemp = width.Skip(cases[i][0]).Take(cases[i][1] - cases[i][0] + 1).ToArray();
            var min = arrTemp.Min();
            res[i] = min;
        }
        return res;
    }

    static void Main(string[] args)
    {
        string[] tokens_n = ReadLine().Split(' ');
        var n = Convert.ToInt32(tokens_n[0]);
        int t = Convert.ToInt32(tokens_n[1]);
        var width_temp = ReadLine().Split(' ');
        var width = Array.ConvertAll(width_temp, Int32.Parse);
        var cases = new int[t][];
        for (var cases_i = 0; cases_i < t; cases_i++)
        {
            var cases_temp = ReadLine().Split(' ');
            cases[cases_i] = Array.ConvertAll(cases_temp, Int32.Parse);
        }
        var result = serviceLane(n, cases, t, width);
        WriteLine(String.Join("\n", result));
    }
}


