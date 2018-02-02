using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution {

    static int[] breakingRecords(int[] score)
    {
        // Complete this function
        var max = score[0];
        var min = score[0];
        int[] count = { 0, 0 };
        foreach (int i in score)
        {
            if (max < i)
            {
                count[0]++;
                max = i;
            }
            if (min > i)
            {
                count[1]++;
                min = i;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        var n = int.Parse(ReadLine());
        string[] score_temp = ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp, Int32.Parse);
        int[] result = breakingRecords(score);
        WriteLine(String.Join(" ", result));
        }
}
