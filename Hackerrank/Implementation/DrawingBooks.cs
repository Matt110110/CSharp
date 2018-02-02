using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution {

    static int solve(int n, int p)
    {
        // Complete this function
        var turns = 0;
        var isOdd = true;
        if (p%2 == 0)
        {
            isOdd = false;
        }
        if (isOdd)
        {
            if (p == n)
            {
                turns = 0;
            }
             else if (p > n/2)
             {
                // start from back
                while(n > p)
                {
                    turns++;
                    n -= 2;
                }
            }
            else if (p == 1)
            {
                turns = 0;
            }
            else
            {
                 for(int i = 1; i < p; i+=2)
                {
                    turns++;
                }
            }
        }
        else
        {
             if (p == n)
            {
                turns = 0;
            }
            else if (p > n / 2)
            {
                // start from back
                while (n > p+1)
                {
                    turns++;
                    n -= 2;
                }
            }
            else if (p == 1)
            {
                turns = 0;
            }
            else
            {
                for (int i = 1; i < p+1; i += 2)
                {
                    turns++;
                }
            }
        }
        return turns; // Return statement at the end
    }

    static void Main(String[] args)
    {
        var n = int.Parse(ReadLine());
        var p = int.Parse(ReadLine());
        var result = solve(n, p);
        WriteLine(result);
    }
}
