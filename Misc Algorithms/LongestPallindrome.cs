/**
* Write a program in Java to identify if the input string contains a palindrome substring of length more than 3 or not. The program outputs the longest palindrome when present, else it returns an empty string. Add this code to a file on your google drive, and share the public link for the file. Sample examples: 1) "baboon" should return "bab" 2) "babab" should return "babab" 3) "alpha" should return "" 4) "abrakarab" should return "rakar" 5) "oyoyoyoastotot" should return "oyoyoyo" and so on.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPallindrome
{
    class Program
    {
        private static string PALLINDROME = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            var input = Console.ReadLine();
            LongestPallindrome(input, 0);
            Console.WriteLine(PALLINDROME);
        }

        private static void LongestPallindrome(string input, int v)
        {
            var l = 3;

            if (input.Length < v + 3)
            {
                return;
            }

            while (v + l <= input.Length)
            {
                CheckPallindrome(input.Substring(v, l));
                l++;
            }
            LongestPallindrome(input, ++v);
        }

        private static void CheckPallindrome(string v)
        {
            var rev = new string(v.Reverse().ToArray());
            if (rev.SequenceEqual(v))
            {
                if (rev.Length > PALLINDROME.Length)
                {
                    PALLINDROME = rev;
                }
            }
        }
    }
}
