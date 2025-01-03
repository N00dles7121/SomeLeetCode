using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LenLastWord
    {
        // Given a string s consisting of words and spaces,
        // return the length of the last word in the string.

        public int Solution(string str)
        {
            // Will split string into string array on every space. This will give us new string array
            // which will store all words from str.
            string[] newStr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Return length of last word in new array
            return newStr[newStr.Length - 1].Length;
        }
    }
}