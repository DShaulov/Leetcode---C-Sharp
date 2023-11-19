using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class SortColorsSolution
    {
        public void SortColors(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > right) 
                {
                    continue;
                }
                if (nums[i] == 0)
                {
                    temp = nums[left];
                    nums[left] = nums[i];
                    nums[i] = temp;
                    left++;
                }
                else if (nums[i] == 2)
                {
                    temp = nums[right];
                    nums[right] = nums[i];
                    nums[i] = temp;
                    right--;
                    i--;
                }
            }
        }
    }
}
