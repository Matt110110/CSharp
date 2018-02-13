using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int marsExploration(string str)
    {
        var count = 0;
        // Complete this function
        var sarray = Enumerable.Range(0, str.Length / 3).Select(i => str.Substring(i * 3, 3));

        foreach (var arr in sarray)
        {
            if (arr[0] != 'S')
            {
                count++;
            }
            if (arr[1] != 'O')
            {
                count++;
            }
            if (arr[2] != 'S')
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int result = marsExploration(s);
        Console.WriteLine(result);
    }
}
