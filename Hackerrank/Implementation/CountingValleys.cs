using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int countingValleys(int n, string s)
    {
        // Complete this function
        var vally = 0;
        var level = 0;
        foreach(char c in s)
        {
            if (level == -1 && c == 'U')
            {
                vally++;
            }
            if (c == 'U')
            {
                level++;
            }
            else
            {
                level--;
            }
        }
        return vally;
    }

    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var s = Console.ReadLine();
        var result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
