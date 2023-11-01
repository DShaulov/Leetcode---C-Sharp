using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class CombinationsSolution
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            return CombineRecursive(n, k, new List<int>(), 1);
        }
        public IList<IList<int>> CombineRecursive(int n, int k, IList<int> current, int iteration)
        {
            if (k == 0)
            {
                return new List<IList<int>> { current };
            }
            List<IList<int>> allLists = new List<IList<int>>();
            for (int i = iteration; i <= n; i++)
            {
                List<int> newList = new List<int>(current);
                newList.Add(i);
                allLists.AddRange(CombineRecursive(n, k-1, newList, iteration + 1));
            }
            return allLists;
        }
    }
}
