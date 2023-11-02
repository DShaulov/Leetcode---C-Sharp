using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class MinPathSumSolution
    {
        public int MinPathSum(int[][] grid)
        {
            int[,] pathSum = new int[grid.Length, grid[0].Length];
            pathSum[0, 0] = grid[0][0];
            for (int i = 1; i < grid[0].Length; i++)
            {
                pathSum[0, i] = pathSum[0, i - 1] + grid[0][i];
            }
            for (int i = 1; i < grid.Length; i++)
            {
                pathSum[i, 0] = pathSum[i - 1, 0] + grid[i][0];
            }
            for (int i = 1; i < grid.Length; i++)
            {
                for (int j = 1; j < grid[i].Length; j++)
                {
                    int fromAbove = pathSum[i - 1, j] + grid[i][j];
                    int fromLeft = pathSum[i, j - 1] + grid[i][j];
                    pathSum[i, j] = Math.Min(fromAbove, fromLeft);
                }
            }
            return pathSum[grid.Length - 1, grid[0].Length - 1];
        }
    }
}
