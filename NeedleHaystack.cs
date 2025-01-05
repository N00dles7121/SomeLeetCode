using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class NeedleHaystack
    {
        // Given two strings needle and haystack, return the index of the 
        // first occurrence of needle in haystack, or -1 if needle is not part of haystack.


        // Head on solution
        public static int Solution1(string needle, string haystack)
        {
            if (haystack.Contains(needle)) return haystack.IndexOf(needle);
            return -1;
        }

        // More efficient solution
        public static int Solution2(string needle, string haystack)
        {

            // Check if any of strings is null or haystack does not contain needle
            if (haystack == null || needle == null || !haystack.Contains(needle)) return -1;

            // Loop to iterate through haystack
            for (int i = 0; i < haystack.Length; i++)
            {
                // Return i if string from index i to needle.Length is equal to needle
                if (haystack.Substring(i, needle.Length) == needle) return i;
            }

            // return -1 if needle not found
            return -1;
        }
    }
}