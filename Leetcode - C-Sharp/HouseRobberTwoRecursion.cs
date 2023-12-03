using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    internal class HouseRobber2Solution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            int scan(int currentSum, int currentIndex, bool firstTaken)
            {
                if (currentIndex == nums.Length - 1) 
                {
                    if (!firstTaken)
                    {
                        return currentSum + nums[nums.Length - 1];
                    }
                    else
                    {
                        return currentSum;
                    }
                }
                if (currentIndex == nums.Length - 2)
                {
                    if (!firstTaken)
                    {
                        return Math.Max(currentSum + nums[nums.Length - 2], currentSum + nums[nums.Length - 1]);
                    }
                    return currentSum + nums[nums.Length - 2];
                }
                return Math.Max(scan(currentSum, currentIndex + 1, firstTaken), scan(currentSum + nums[currentIndex], currentIndex + 2, firstTaken));
            }
            return Math.Max(scan(0, 1, false), scan(nums[0], 2, true));
        }
    }
}
