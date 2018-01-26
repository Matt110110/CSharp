using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Solution
{
    class Program
    {
        static int equalizeArray(int[] arr)
        {
            // Complete this function           
            var dict = new Dictionary<int, int>();
            foreach(var d in arr)
            {
                if (dict.ContainsKey(d))
                {
                    dict[d]++;
                }
                else
                {
                    dict.Add(d, 1);
                }
            }            
            // Can be simplified further? who knows
            return arr.Length - dict.FirstOrDefault(x => x.Value == dict.Values.Max()).Value;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(ReadLine());
            string[] arr_temp = ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = equalizeArray(arr);
            WriteLine(result);
        }
    }
}