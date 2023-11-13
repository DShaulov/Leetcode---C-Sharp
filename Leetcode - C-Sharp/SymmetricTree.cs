using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(TreeNode left, TreeNode right, int val = 0)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class SymmetricTreeSolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }
            else if ((root.left != null && root.right == null) || (root.left == null && root.right != null))
            {
                return false;
            }
            else
            {
                return IsSymmetricWalk(root.left, root.right);
            }
        }
        public bool IsSymmetricWalk(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if (left.val != right.val)
            {
                return false;
            }
            // Both are leaf nodes
            else if (IsLeaf(left) && IsLeaf(right)) 
            {
                return left.val == right.val;
            }
            else
            {
                if ((left.left != null && right.right == null) || (left.left == null && right.right != null))
                {
                    return false;
                }
                else if ((left.right != null && right.left == null) || (left.right == null && right.left != null)) 
                {
                    return false;
                }
                else
                {
                    return IsSymmetricWalk(left.left, right.right) && IsSymmetricWalk(left.right, right.left);
                }
            }
        }
        public bool IsLeaf(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}
