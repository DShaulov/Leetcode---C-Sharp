using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode___C_Sharp.SymmetricTreeSolution;

namespace Leetcode___C_Sharp
{
    public class MaxDepthSolution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            else if (root.left == null)
            {
                return 1 + MaxDepth(root.right);
            }
            else if (root.right == null)
            {
                return 1 + MaxDepth(root.left);
            }
            else
            {
                int leftDepth = 1 + MaxDepth(root.left);
                int rightDepth = 1 + MaxDepth(root.right);
                return (leftDepth < rightDepth) ? rightDepth : leftDepth;
            }
        }
    }
}
