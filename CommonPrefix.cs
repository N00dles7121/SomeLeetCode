using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class CommonPrefix
    {
        // Write a function to find the longest common prefix string amongst an array of strings.
        // If there is no common prefix, return an empty string "".

        public static string Solution(string[] strs)
        {

            // Strore first string in array as a prefix
            string prefix = strs[0];

            // Return empty string if first element in the array is null or empty
            if (string.IsNullOrWhiteSpace(strs[0])) return prefix;

            // Loop throug the array starting from second element
            for (int i = 1; i < strs.Length; i++)
            {
                // If current element does not start with or "prefix" value, cut last letter from prefix
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
    }
}