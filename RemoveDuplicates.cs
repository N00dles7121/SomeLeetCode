using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicates
    {
        public int Solution(int[] nums)
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