using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class CombinationsSolution
    {
        /*
         *  n = 5, k = 2
         *  all combinations of 2 numbers from [1, 2, 3, 4, 5] - > [1,2], [1,3], ...
         */


        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();    
            IList<int> current = new List<int>();
            void DFS(int index)
            {
                if (current.Count == k)
                {
                    result.Add(new List<int>(current));
                    return;
                }
                for (int i = index; i < n + 1; i++)
                {
                    current.Add(i);
                    DFS(index + i);
                    current.RemoveAt(current.Count - 1);
                }
            }
            DFS(1);
            return result;
        }
    }
}
