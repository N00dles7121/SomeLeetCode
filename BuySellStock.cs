using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BuySellStock
    {
        // You are given an array prices where prices[i] is the price of a given stock 
        // on the ith day. You want to maximize your profit by choosing a single day 
        // to buy one stock and choosing a different day in the future to sell that stock.

        public int Solution(int[] prices)
        {
            int profit = 0;
            int buyPrice = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                buyPrice = Math.Min(buyPrice, prices[i]);
                profit = Math.Max(profit, prices[i] - buyPrice);
            }
            return profit;
        }
    }
}