using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class CanJumpSolution
    {
        public bool CanJump(int[] nums)
        {
            int nearestReachable = nums.Length - 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= nearestReachable)
                {
                    nearestReachable = i;
                }
            }
            return nearestReachable == 0;
        }
    }
}
