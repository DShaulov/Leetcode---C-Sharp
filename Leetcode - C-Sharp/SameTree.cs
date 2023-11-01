using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode___C_Sharp.SymmetricTreeSolution;

namespace Leetcode___C_Sharp
{
    public class SameTreeSolution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p.val != q.val)
            {
                return false;
            }
            else if ((p.left != null && q.left == null) || (p.left == null && q.left != null))
            {
                return false;
            }
            else if ((p.right != null && q.right == null) || (p.right == null && q.right != null))
            {
                return false;
            }
            
        }
    }
}
