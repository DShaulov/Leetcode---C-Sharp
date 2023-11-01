using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class MergeSortedArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] copyArray = new int[m + n];
            Array.Copy(nums1, copyArray, m + n);
            int nums1Pointer = 0;
            int pointerOne = 0;
            int pointerTwo = 0;
            while (true)
            {
                if (pointerOne == m)
                {
                    for (int i = pointerTwo; i < n; i++)
                    {
                        nums1[nums1Pointer] = nums2[i];
                        nums1Pointer++;
                    }
                    break;
                }
                else if (pointerTwo == n)
                {
                    for (int i = pointerOne; i < m; i++)
                    {
                        nums1[nums1Pointer] = copyArray[i];
                        nums1Pointer++;
                    }
                    break;
                }

                if (copyArray[pointerOne] <= nums2[pointerTwo])
                {
                    nums1[nums1Pointer] = copyArray[pointerOne];
                    pointerOne++;
                    nums1Pointer++;
                }
                else
                {
                    nums1[nums1Pointer] = nums2[pointerTwo];
                    pointerTwo++;
                    nums1Pointer++;
                }

            }
        }
    }
}
