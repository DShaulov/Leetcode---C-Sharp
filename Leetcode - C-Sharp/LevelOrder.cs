using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode___C_Sharp.SymmetricTreeSolution;

namespace Leetcode___C_Sharp
{
    public class LevelOrderSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> levels = new List<IList<int>>();
            levels.Append(new List<int>());
            LevelOrderRecursive(root, levels, 1);
            return levels;
        }
        public void LevelOrderRecursive(TreeNode root, IList<IList<int>> levels, int currentLevel)
        {
            if (root == null)
            {
                return;
            }
            else if (levels.Count != currentLevel)
            {
                levels.Add(new List<int>());
            }
            levels[currentLevel - 1].Add(root.val);
            LevelOrderRecursive(root.left, levels, currentLevel + 1);
            LevelOrderRecursive(root.right, levels, currentLevel + 1);
        }
    }
}
