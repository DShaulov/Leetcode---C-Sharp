using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode___C_Sharp.SymmetricTreeSolution;

namespace Leetcode___C_Sharp
{
    public class SumNumbersSolution
    {
        public int SumNumbers(TreeNode root)
        {
            int sum = 0;
            List<int> path = new List<int>();
            void DFS(TreeNode root)
            {
                if (root == null)
                {
                    return;
                }
                path.Add(root.val);
                if (root.left == null && root.right == null)
                {
                    for (int i = 1; i <= path.Count; i++)
                    {
                        sum += path[i] * ((int) Math.Pow(10, path.Count - i)); 
                    }
                }
                DFS(root.left);
                DFS(root.right);
                path.RemoveAt(path.Count - 1);

            }
            DFS(root);
            return sum;
        }
    }
}
