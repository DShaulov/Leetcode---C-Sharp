using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class SearchInsertSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int leftMostLookup = 0;
            int rightMostLookup = nums.Length - 1;
            while (true)
            {
                if ((rightMostLookup - leftMostLookup) <= 1)
                {
                    if (nums[leftMostLookup] == target || nums[leftMostLookup] > target)
                    {
                        return leftMostLookup;
                    }
                    else if (nums[rightMostLookup] == target || (nums[leftMostLookup] < target && target < nums[rightMostLookup]))
                    {
                        return rightMostLookup;
                    }
                    else
                    {
                        return rightMostLookup + 1;
                    }
                }
                int middleIndex = (rightMostLookup + leftMostLookup) / 2;
                if (nums[middleIndex] == target)
                {
                    return middleIndex;
                }
                else if (nums[middleIndex] < target)
                {
                    leftMostLookup = middleIndex;
                }
                else
                {
                    rightMostLookup = middleIndex;
                }
            }
        }
    }
}
