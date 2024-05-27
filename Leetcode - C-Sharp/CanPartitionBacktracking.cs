using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class CanPartitionBacktrackingSolution
    {
        public bool CanPartition(int[] nums)
        {
            List<int> partitionA = new List<int>();
            List<int> partitionB = new List<int>();
            bool found = false;
            void Check(int index)
            {
                if (partitionA.Count + partitionB.Count == nums.Length)
                {
                    if (partitionA.Sum() == partitionB.Sum())
                    {
                        found = true;
                    }
                    return;
                }
                partitionA.Add(nums[index]);
                Check(index + 1);
                partitionA.RemoveAt(partitionA.Count - 1);
                partitionB.Add(nums[index]);
                Check(index + 1);
                partitionB.RemoveAt(partitionB.Count - 1);
            }
            Check(0);
            return found;
        }
    }
}
