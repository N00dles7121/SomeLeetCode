using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    // Given an integer array nums, move all 0's to the end of it while maintaining the
    // relative order of the non-zero elements.
    // Note that you must do this in-place without making a copy of the array.

    public class MoveZeroes
    {
        public static void Solution(int[] nums)
        {

            // List to store values other than 0
            List<int> notZeroes = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Store all not 0 values to the list
                if (nums[i] != 0)
                {
                    notZeroes.Add(nums[i]);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {

                // Assign values from the list to first elements in array 
                if (i < notZeroes.Count)
                {
                    nums[i] = notZeroes[i];
                }

                // Assign 0 to all other elements in the array
                else nums[i] = 0;
            }
        }
    }
}