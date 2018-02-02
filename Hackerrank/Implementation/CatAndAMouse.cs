using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution {

    static string[] catAndMouse(int x, int y, int z)
    {
        // Complete this function
        string[] result = { "Cat", "A" };
        var distA = 0;
        var distB = 0;
        var diffA = (z > x) ? (z - x) : (x - z);
        var diffB = (z > y) ? (z - y) : (y - z);
        if (diffA > diffB)
        {
            result[1] = "B";
        }
        else if (diffA == diffB)
        {
            result[0] = "Mouse";
            result[1] = "C";
        }
        // Return statement always bottom
        return result;
    }

    static void Main(String[] args)
    {
        var q = Convert.ToInt32(ReadLine());
        for (var a0 = 0; a0 < q; a0++)
        {
            string[] tokens_x = ReadLine().Split(' ');
            var x = int.Parse(tokens_x[0]);
            var y = Convert.ToInt32(tokens_x[1]);
            var z = Convert.ToInt32(tokens_x[2]);
            string[] result = catAndMouse(x, y, z);
            WriteLine(String.Join(" ", result));


        }
    }
}
