using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Array.IndexOf(nums, target - nums[i]);
                if (index != -1 && index != i)
                {
                    return new int[] { i, index };
                }
            }
            return Array.Empty<int>();
        }
    }
}
