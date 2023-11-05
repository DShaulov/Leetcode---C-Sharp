using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Leetcode___C_Sharp.SymmetricTreeSolution;

namespace Leetcode___C_Sharp
{
    public  class PathSumTwoSolution
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> path = new List<int>();
            int sum = 0;
            void DFS(TreeNode root)
            {
                if (root == null)
                {
                    return;
                }
                else if (sum == targetSum && root.right == null && root.left == null)
                {
                    result.Add(new List<int>(path));
                    return;
                }
                else if (sum > targetSum)
                {
                    return;
                }
                path.Add(root.val);
                sum += root.val;
                DFS(root.left);
                DFS(root.right);
                path.RemoveAt(path.Count - 1);
                sum -= root.val;
            }
            DFS(root);
            return result;
        }
    }
}
