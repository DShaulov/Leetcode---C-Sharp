using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class SearchMatrixSolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (target < matrix[0][0] || matrix[matrix.Length - 1][matrix[0].Length - 1] < target)
            {
                return false;
            }
            int middleColumn = (matrix[0].Length / 2) - 1;
            int middleRow = (matrix[matrix.Length - 1].Length / 2) - 1;
            while (true)
            {
                if (matrix[middleColumn][0] <= target && target <= matrix[middleColumn][matrix[0].Length - 1])
                {
                    break;
                }
                if (target == matrix[middleColumn][0])
                {
                    return true;
                }
                if (target < matrix[middleColumn][0])
                {
                    middleColumn /= 2;
                }
                else if (matrix[middleColumn][0] < target)
                {
                    middleColumn = (middleColumn + matrix.Length) / 2;
                }
            }
            int left = 0;
            int right = matrix[0].Length - 1;
            while (true)
            {
                if (target == matrix[middleColumn][middleRow])
                {
                    return true;
                }
                if (left == right - 1)
                {
                    break;
                }
                if (target < matrix[middleColumn][middleRow])
                {
                    right = middleRow;
                }
                else
                {
                    left = middleRow;
                }
                middleRow = (left + right) / 2;

            }
            return false;
        }
    }
}
