using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int hurdleRace(int k, int[] height)
    {
        // Complete this function
        var max = height.Max();
        if (k < max)
        {
            return max - k;
        }
        else
        {
            return 0;
        }
    }

    static void Main(String[] args)
    {
        string[] tokens_n = ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] height_temp = ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp, Int32.Parse);
        int result = hurdleRace(k, height);
        WriteLine(result);
    }
}
