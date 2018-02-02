using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
class Solution {

    static int designerPdfViewer(int[] h, string word)
    {
        // Complete this function
        char[] fromWord = word.ToCharArray();
        var maxHeight = 0;
        for (var i = 0; i < fromWord.Length; i++)
        {
            foreach(var c in fromWord)
            {
                var index = (int)c - 97;
                if (maxHeight < h[index])
                {
                    maxHeight = h[index];
                }
            }
        }
        return maxHeight * fromWord.Length;
    }

    static void Main(string[] args)
    {
        string[] h_temp = ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp, Int32.Parse);
        string word = ReadLine();
        int result = designerPdfViewer(h, word);
        WriteLine(result);
    }
}
