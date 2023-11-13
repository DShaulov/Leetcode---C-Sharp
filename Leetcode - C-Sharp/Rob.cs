using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class RobSolution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int[] answer = new int[nums.Length];
            answer[0] = nums[0];
            answer[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                answer[i] = Math.Max(answer[i - 2] + nums[i], answer[i-1]);
            }   
            return answer[answer.Length - 1];
        }
    }
}
