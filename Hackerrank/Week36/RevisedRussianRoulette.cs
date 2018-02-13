using System.Collections.Generic;
using System;
using System.Linq;
using static System.Console;
using System.Numerics;
using System.Text.RegularExpressions;

// Not all test cases are passing. Test case 2 and test case 3 are giving the wrong answer. I believe there is some mistake in my
// minimum finding algorithm. Have to take a look at it.

namespace BackupSolution
{
    class Program
    {
        static int[] revisedRussianRoulette(int[] doors)
        {
            // Complete this function
            var min = new int[] { 0, 0 };
            min[1] = doors.Count(f => f == 1);
            for (var i = 0; i < doors.Length - 1; i++)
            {
                if (doors[i] == 1)
                {
                    min[0]++;
                    if (doors[i+1] == 1)
                    {
                        i++;
                    }
                }
            }
            return min;
             
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] doors_temp = Console.ReadLine().Split(' ');
            int[] doors = Array.ConvertAll(doors_temp, Int32.Parse);
            int[] result = revisedRussianRoulette(doors);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}