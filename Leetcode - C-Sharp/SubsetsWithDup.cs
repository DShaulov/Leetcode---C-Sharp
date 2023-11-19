using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class SubsetsWithDupSolution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();
            void Permutations(List<int> current,int iteration)
            {
                if (iteration == nums.Length)
                {
                    subsets.Add(new List<int>(current));
                    return;
                }
                current.Add(nums[iteration]);
                Permutations(current,iteration + 1);
                current.RemoveAt(current.Count - 1);
                while (iteration < nums.Length - 1 && nums[iteration] == nums[iteration + 1])
                {
                    iteration++;
                }
                Permutations(current, iteration + 1);
            }
            Permutations(new List<int>(), 0);
            return subsets;
        }
    }
}
