using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MajorityElement
    {
        // Given an array nums of size n, return the majority element.
        // The majority element is the element that appears more than ⌊n / 2⌋ times. 
        // You may assume that the majority element always exists in the array.

        public int Solution(int[] nums)
        {
            int num = 0;
            int counter = 0;

            foreach (var n in nums)
            {
                // Since we don't need to count number of occurances of majority element
                // but need just value of the element we can use variable "counter" to keep 
                // track of which value is most frequet.

                if (counter == 0)
                {
                    num = n;
                }
                if (num == n)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
            return num;
        }
    }
}