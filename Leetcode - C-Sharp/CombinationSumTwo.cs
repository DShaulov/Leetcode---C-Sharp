using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class CombinationSumTwoSolution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            CombinationSum2Recursive(candidates, target, 0, new List<int>(), result);
            return result;
        }
        public void CombinationSum2Recursive(int[] candidates, int target, int index, IList<int> current, IList<IList<int>> result)
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
                CombinationSum2Recursive(candidates, target - candidates[index], index + 1, newCurrent, result);
                CombinationSum2Recursive(candidates, target, index + 1, current, result);
            }
            else
            {
                return;
            }
        }
    }
}
