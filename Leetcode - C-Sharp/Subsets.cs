using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class SubsetsSolution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> current = new List<int>();
            void dfs(int index)
            {
                if (index == nums.Length)
                {
                    result.Add(new List<int>(current));
                    return;
                }
                current.Add(nums[index]);
                dfs(index + 1);
                current.RemoveAt(current.Count - 1);
                dfs(index + 1);
            }
            dfs(0);
            return result;
        }
    }
}
