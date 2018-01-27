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
        static string RemoveDuplicateChars(string key)
        {
            string table = string.Empty;
            string result = string.Empty;
            foreach (char value in key)
            {
                if (table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            var s = ReadLine().ToLower();
            var removed = RemoveDuplicateChars(s);
            var len = 0;
            foreach (char c in removed)
            {
                if (((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')))
                {
                    len++;
                }
            }
            if (len == 26)
            {
                WriteLine("pangram");
            }
            else
            {
                WriteLine("not pangram");
            }
        }
    }
}
