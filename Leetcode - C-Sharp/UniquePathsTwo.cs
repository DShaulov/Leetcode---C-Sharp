using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class UniquePathsTwoSolution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            int[][] pathNum = new int[m][];
            int reachable = 1;
            for (int i = 0; i < m; i++)
            {
                pathNum[i] = new int[n];
                if (obstacleGrid[i][0] == 1)
                {
                    reachable = 0;
                }
                pathNum[i][0] = reachable;
            }
            reachable = 1;
            for (int i = 0; i < n; i++)
            {
                if (obstacleGrid[0][i] == 1)
                {
                    reachable = 0;
                }
                pathNum[0][i] = reachable;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        pathNum[i][j] = 0;
                        continue;
                    }
                    pathNum[i][j] = pathNum[i - 1][j] + pathNum[i][j - 1];
                }
            }
            return pathNum[m - 1][n - 1];
        }
    }
}
