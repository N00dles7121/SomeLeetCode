using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    // Given an array of integers nums and an integer target, 
    // return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, 
    // and you may not use the same element twice.

    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] solution = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {

                // Check if sum of any key stored in dictionary plus current element
                // in array is equal to target. Return value from dictionary and i.
                if (dict.ContainsKey(target - nums[i]))
                {
                    solution[0] = dict[target - nums[i]];
                    solution[1] = i;

                    return solution;
                }

                // Will store value of element as key and index as value in dictionary.
                dict[nums[i]] = i;
            }

            // Return empty array if no solution found.
            return new int[0];
        }
    }
}