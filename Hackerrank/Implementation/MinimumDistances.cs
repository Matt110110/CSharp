using System;
using System.Linq;

class Solution
{
    static int minimumDistances(int[] a)
    {
        var count = a.Length;
        if (!(a.GroupBy(x => x).Any(x => x.Count() > 1)))
        {
            return -1;
        }
        else
        {
            for (var i = 0; i < a.Length; i++)
            {
                var temp = Array.FindLastIndex(a, x => x == a[i]);
                if ((temp - i < count) && (temp != i))
                {
                    count = temp - i;
                    temp = 0;
                }
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var a_temp = Console.ReadLine().Split(' ');
        var a = Array.ConvertAll(a_temp, Int32.Parse);
        var result = minimumDistances(a);
        Console.WriteLine(result);
    }
}