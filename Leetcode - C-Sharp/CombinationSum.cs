using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class CombinationSumSolution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            CombinationSumRecursive(candidates, target, new List<int>(), 0, result);
            return result;
        }
        public void CombinationSumRecursive(int[] candidates, int target, List<int> current, int index, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(current);
            }
            else if (target < 0)
            {
                return;
            }
            else if (index < candidates.Length)
            {
                List<int> newCurrent = new List<int>(current);
                newCurrent.Add(candidates[index]);
                CombinationSumRecursive(candidates, target - candidates[index], newCurrent, index, result);
                CombinationSumRecursive(candidates, target, current, index + 1, result);
            }
            else
            {
                return;
            }
        }
    }
}
