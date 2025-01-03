using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RemoveElement
    {
        // Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
        // The order of the elements may be changed.
        // Then return the number of elements in nums which are not equal to val.


        public static int Solution(int[] nums, int target)
        {
            // Variable to store index of element equal to target.
            int k = 0;

            // Iterate throug array to look for target value.
            for (int i = 0; i < nums.Length; i++)
            {

                // Will keep track of element equal to target and remove it once valid element found. 
                if (nums[i] != target)
                {

                    // Increment k when element replaced.
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}