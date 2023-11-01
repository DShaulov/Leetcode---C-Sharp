using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class ClimbStairsSolution
    {
        public int ClimbStairs(int n)
        {
            return ClimbStairsDynamic(n);
        }
        public int ClimbStairsDynamic(int stepsToTop)
        {
            if (stepsToTop == 1)
            {
                return 1;
            }
            if (stepsToTop == 2)
            {
                return 2;
            }
            int[] ways = new int[stepsToTop+1];
            ways[1] = 1;
            ways[2] = 2;
            for (int i = 3; i <= stepsToTop; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }
            return ways[stepsToTop];
        }
        public int ClimbStairsRecursive(int currentStep, int stepsToTop)
        {
            if (currentStep == stepsToTop || currentStep == stepsToTop - 1)
            {
                return 1;
            }
            else
            {
                return ClimbStairsRecursive(currentStep + 1, stepsToTop) + ClimbStairsRecursive(currentStep + 2, stepsToTop);
            }
        }
        
    }
}
