using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class RightSideViewSolution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>();
            HashSet<int> representative = new HashSet<int>();
            void DFS(TreeNode root, int depth)
            {
                if (root == null)
                {
                    return;
                }
                if (!representative.Contains(depth))
                {
                    representative.Add(depth);
                    result.Add(root.val);
                }
                DFS(root.right, depth + 1);
                DFS(root.left, depth + 1);
            }
            DFS(root, 1);
            return result;
        }
    }
}
