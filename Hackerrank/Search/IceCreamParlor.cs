using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using System.Text.RegularExpressions;

namespace Solution
{
    class Program
    {
        static int[] icecreamParlor(int m, int[] arr)
        {
            // Complete this function
            int[] tags = new int[2];
            List<int> prices = new List<int>(arr);
            prices.Sort();
            var smaller = prices[0];
            var larger = prices[arr.Length - 1];
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i+1; j < arr.Length; j++)
                {
                    var sum = prices[i] + prices[j];
                    if (sum == m)
                    {
                        smaller = prices[i];
                        larger = prices[j];
                        break;
                    }
                }
            }
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == larger)
                {
                    tags[1] = i + 1;
                }                
            }
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == smaller)
                {
                    tags[0] = i + 1;
                }
            }
            Array.Sort(tags);
            // Return statement always bottom
            return tags;
        }

        static void Main(string[] args)
        {
            int t = int.Parse(ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int m = int.Parse(ReadLine());
                int n = int.Parse(ReadLine());
                string[] arr_temp = ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, int.Parse);
                int[] result = icecreamParlor(m, arr);
                WriteLine(string.Join(" ", result));


            }
        }
    }
}
