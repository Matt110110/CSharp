using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;


class Solution {
    static int bonAppetit(int n, int k, int b, int[] ar) {
        // Complete this function
        var sum = 0;
        int[] arr;
        List<int> tmp = new List<int>(ar);
        tmp.RemoveAt(k);
        arr = tmp.ToArray();
        foreach (var i in arr)
        {
            sum += i;
        }
        int share = sum / 2;
        return share;
    }

    static void Main(string[] args) {
        string[] tokens_n = ReadLine().Split(' ');
        var n = int.Parse(tokens_n[0]);
        var k = int.Parse(tokens_n[1]);
        string[] ar_temp = ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        var b = int.Parse(ReadLine());
        var result = bonAppetit(n, k, b, ar);
        if (b == result)
        {
            WriteLine("Bon Appetit");
        }
        else
        {
            WriteLine($"{b - result}");
        }
    }
}
