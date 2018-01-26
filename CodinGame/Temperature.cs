using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int[] temps = new int[n];
        for (int i = 0; i < n; i++)
        {
            temps[i] = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526          
        }
        var min = findMin(temps);
        var x = 0;
        foreach(var i in temps)
        {
            if (i < 0)
            {
                x++;
            }
        }
        if (x == n)
        {
            min = temps.Max();
        }
        Console.WriteLine(min);
    }
    static int findMin(int[] temps)
    {
        if (temps.Length > 0)
        {
            int temp;
            if (temps[0] >= 0)
            {
                temp = temps[0];
            }
            else
            {
                temp = temps[0] * -1;
            }
            for (var i = 0; i < temps.Length; i++)
            {
                var x = 0;
                if (temps[i] >= 0)
                {
                    x = temps[i];
                }
                else
                {
                    x = temps[i] * -1;
                }
                if (x < temp)
                {
                    temp = x;
                }
                else if (x == temp)
                {
                   if (temps[i] >= 0)
                    {
                        temp = temps[i];
                    }
                }
            }
            return temp;
        }
        return 0;
    }
}