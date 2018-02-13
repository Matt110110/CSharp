using System.Collections.Generic;
using System;
using System.Linq;
using static System.Console;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Solution
{
    class Program
    {
        static string acidNaming(string acid_name)
        {
            // Complete this function
            if (new Regex(@"^(hydro)(.){1,}(ic)$").IsMatch(acid_name) || new Regex("^hydroic$").IsMatch(acid_name))
            {
                return "non-metal acid";
            }
            else if (new Regex(@"(ic)$").IsMatch(acid_name))
            {
                return "polyatomic acid";
            }
            else
            {
                return "not an acid";
            }
        }

        static void Main(String[] args)
        {
            var n = int.Parse(ReadLine());
            for (var a0 = 0; a0 < n; a0++)
            {
                var acid_name = ReadLine();
                var result = acidNaming(acid_name);
                WriteLine(result);
            }
        }
    }
}
