using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    // You are given a 0-indexed 1-dimensional (1D) integer array original, 
    // and two integers, m and n. You are tasked with creating a 2-dimensional
    // (2D) array with  m rows and n columns using all the elements from original.

    public class ConvertTo2DArray
    {
        public static int[][] Solution(int[] original, int m, int n)
        {

            // Return empty array if 2D array cannot be created
            if (m * n != original.Length)
            {
                return new int[0][];
            }

            // result to store solution rowIndex and columnIndex
            // to keep track of rows and columns during itaration
            int[][] result = new int[m][];
            int rowIndex = 0;
            int columnIndex = 0;

            // Initialize array lengths inside our jagged array
            for (int i = 0; i < result.GetLength(0); i++)
            {
                result[i] = new int[n];
            }

            for (int i = 0; i < original.Length; i++)
            {
                if (columnIndex < n)
                {
                    result[rowIndex][columnIndex] = original[i];
                    columnIndex++;
                    continue;
                }
                rowIndex++;
                i--;
                columnIndex = 0;
            }

            return result;
        }
    }
}