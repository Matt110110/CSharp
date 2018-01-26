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
        static int introTutorial(int V, int[] arr)
        {
            // Complete this function
            return (new List<int>(arr).IndexOf(V));
        }

        static void Main(String[] args)
        {
            int V = int.Parse(ReadLine());
            int n = int.Parse(ReadLine());
            string[] arr_temp = ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);
            WriteLine(introTutorial(V, arr));
        }
    }
}
