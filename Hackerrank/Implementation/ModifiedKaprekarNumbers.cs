using System;
using System.Collections.Generic;

class Solution
{
    static long[] KaprekarNumbers(long p, long q)
    {
        var res = new List<long>();
        for (var i = p; i <= q; i++)
        {
            var sqr = i * i;
            var sqrStr = Convert.ToString(sqr);
            if (sqr <= 9)
            {
                sqrStr = "0" + sqrStr;
            }
            var left = sqrStr.Substring(0, sqrStr.Length / 2);
            var right = sqrStr.Substring(sqrStr.Length / 2);
            var l = int.Parse(left);
            var r = int.Parse(right);
            if (l + r == i)
            {
                res.Add(i);
            }
        }
        return res.ToArray();
        
    }

    static void Main(string[] args)
    {
        var p = Convert.ToInt64(Console.ReadLine());
        var q = Convert.ToInt64(Console.ReadLine());
        var result = KaprekarNumbers(p, q);
        if (result.Length > 0)
        {
            Console.WriteLine(String.Join(" ", result));
        }
        else
        {
            Console.WriteLine("INVALID RANGE");
        }
    }
}