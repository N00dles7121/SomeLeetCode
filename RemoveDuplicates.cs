using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RemoveDuplicates
    {
        // Given an integer array nums sorted in non-decreasing order, 
        // remove the duplicates in-place such that each unique element appears only once. 
        // The relative order of the elements should be kept the same. 
        // Then return the number of unique elements in nums.

        public static int Solution(int[] nums)
        {
            // Will store index or duplicate element in the array.
            int k = 1;

            // If array length is less than 2, there can be no duplicates.
            if (nums.Length < 2) return nums.Length;

            for (int i = 1; i < nums.Length; i++)
            {

                // Will skip if element is equal to previous and assign to element with index k once found different value. 
                if (nums[i] != nums[k - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}