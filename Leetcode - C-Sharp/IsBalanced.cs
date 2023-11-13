using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class IsBalancedSolution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
            {
                return true;
            }
            int maxDepth = 1;
            int minDepth = int.MaxValue;
            int currentDepth = 1;
            void DFS(TreeNode root)
            {
                if (root == null)
                {
                    return;
                }
                if (root.left == null && root.right == null)
                {
                    if (currentDepth > maxDepth)
                    {
                        maxDepth = currentDepth;
                    }
                    if (currentDepth < minDepth)
                    {
                        minDepth = currentDepth;
                    }
                }
                currentDepth++;
                DFS(root.left);
                DFS(root.right);
                currentDepth--;
            }
            DFS(root);
            if (minDepth == maxDepth - 1 || minDepth == maxDepth)
            {
                return true;
            }
            return false;
        }
    }
}
