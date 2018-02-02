using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int pickingNumbers(int[] a)
    {
        // Complete this function
        var no = 0;
        
        a = a.OrderByDescending(c => c).ToArray();
        for (var i = 0; i < a.Length; i++)
        {
            var temp = 0;
            for (var j = i; j < a.Length; j++)
            {
                var diff = (a[i] > a[j]) ? a[i] - a[j] : a[j] - a[i];
                if ((diff == 1)||(diff == 0))
                {
                    
                    temp++;
                }
                if (temp > no)
                {
                    no = temp;
                }
            }
        }
        // Return statement always bottom
        return no;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int result = pickingNumbers(a);
        Console.WriteLine(result);
    }
}
