using System.Collections.Generic;
using System;
using System.Linq;
using static System.Console;
using System.Numerics;

namespace BackupSolution
{
    class Program
    {
        static string counterGame(long n)
        {
            // Complete this function
            var turns = 0;
            while(n != 1)
            {
                var len = 0;
                var temp = n;
                while(temp != 0)
                {
                    temp /= 2;
                    len++;
                }
                var a = (long)1 << (len - 1);
                if (n == a)
                {
                    n /= 2;
                }
                else
                {
                    n -= a;
                }
                turns++;
            }
            return ((turns % 2 == 0) ? "Richard" : "Louise");
        }

        static void Main(string[] args)
        {
            var t = Convert.ToInt32(ReadLine());
            for (var a0 = 0; a0 < t; a0++)
            {
                var n = long.Parse(ReadLine());
                WriteLine(counterGame(n));
            }
        }        
    }
}