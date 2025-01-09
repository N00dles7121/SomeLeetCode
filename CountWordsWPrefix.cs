using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    // You are given an array of strings words and a string pref.
    // Return the number of strings in words that contain pref as a prefix.
    // A prefix of a string s is any leading contiguous substring of s.

    public static class CountWordsWPrefix
    {
        public static int Solution(string[] words, string pref)
        {
            int count = 0;

            foreach (var word in words)
            {
                if (word.StartsWith(pref)) count++;
            }
            return count;
        }
    }
}