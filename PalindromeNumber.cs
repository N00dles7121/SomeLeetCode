using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    //Given an integer x, return true if x is a palindrome, and false otherwise.

    public static class PalindromeNumber
    {
        public static bool Solution(int x)
        {
            string str = x.ToString();
            int lastIndex = str.Length;

            // Compare symmetrical digits in the number
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[lastIndex - 1]) return false;
                lastIndex--;
            }
            return true;
        }
    }
}