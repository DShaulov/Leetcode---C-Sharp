using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class MaxProfitSolution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int cheapestBuy = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                int currentPrice = prices[i];
                if (currentPrice < cheapestBuy)
                {
                    cheapestBuy = prices[i];
                    continue;
                }
                int profit = currentPrice - cheapestBuy;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            return maxProfit;
        }
    }
}
