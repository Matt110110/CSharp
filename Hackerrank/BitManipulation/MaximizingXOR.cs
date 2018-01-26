using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

class Solution {

    static int maximizingXor(int l, int r)
    {
        var max = -1;
        // Complete this function
        for (var i = l; i<=r; i++)
        {
            for (var j = l; j<= r; j++)
            {
                var temp = i ^ j;
                if (temp > max)
                {
                    max = temp;
                }
            }
        }
        return max;
    }

    static void Main(String[] args)
    {
        var l = int.Parse(Console.ReadLine());
        var r = int.Parse(Console.ReadLine());            
        WriteLine(maximizingXor(l, r));
    }
}