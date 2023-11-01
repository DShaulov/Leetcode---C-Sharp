using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    internal class MaxSubArraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    int currentSum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        currentSum += nums[k];
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }
    }
}
