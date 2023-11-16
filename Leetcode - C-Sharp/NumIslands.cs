using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class NumIslandsSolution
    {
        public int NumIslands(char[][] grid)
        {
            void Mark(int i, int j)
            {
                if (i < 0 || j < 0 || grid.Length <= i || grid[0].Length <= j || grid[i][j] == '0')
                {
                    return;
                }
                grid[i][j] = '0';
                Mark(i + 1, j);
                Mark(i, j + 1);
                Mark(i - 1, j);
                Mark(i, j - 1);
            }
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        Mark(i, j);
                    }
                }
            }
            return count;
        }
    }
}
