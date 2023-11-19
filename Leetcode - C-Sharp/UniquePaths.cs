using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            int[][] pathNum = new int[m][];
            for (int i = 0; i < m; i++)
            {
                pathNum[i] = new int[n];
                pathNum[i][0] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                pathNum[0][i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    pathNum[i][j] = pathNum[i - 1][j] + pathNum[i][j - 1];
                }
            }
            return pathNum[m - 1][n - 1];
        }
    }
}
