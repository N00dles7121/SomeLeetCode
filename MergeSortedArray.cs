using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortedArray
    {
        /* 
        You are given two integer arrays nums1 and nums2, 
        sorted in non-decreasing order, and two integers m and n,
        representing the number of elements in nums1 and nums2 respectively.

        Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        */

        public void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            // Initializing pointers

            int len1 = m - 1;
            int len2 = n - 1;
            int len3 = m + n - 1;

            // Iterate through our arrays from greater to lower and compare stored values. Greater value is assigned to last element in new array.
            while (len2 >= 0)
            {
                if (len1 >= 0 && nums1[len1] > nums2[len2])
                {
                    // Decrement indexers
                    nums1[len3--] = nums1[len1--];
                }

                // When len1 is < 0 copy elements from nums2 to new array.
                else
                {
                    // Decrement indexers
                    nums1[len3--] = nums2[len2--];
                }
            }
        }
    }
}