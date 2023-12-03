using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class EditDistanceSolution
    {
        public int MinDistance(string word1, string word2)
        {
            int[][] answer = new int[word1.Length][];
            for (int i = 0; i < word1.Length; i++)
            {
                answer[i] = new int[word2.Length];
            }
            // To turn word1[0:i] into an empty word, need i deletions.
            for (int i = 0; i < word1.Length; i++)
            {
                answer[i][0] = 0;
            }
            // To turn word[0:0] into word2[0:i], need i insertions.
            for (int i = 0; i < word2.Length; i++)
            {
                answer[0][i] = i;
            }
            for (int i = 1; i < answer.Length; i++)
            {
                for (int j = 1; j < answer[0].Length; j++)
                {
                    answer[i][j] = Math.Min(answer[i - 1][j], Math.Min(answer[i][j - 1], answer[i - 1][j - 1])) + 1;
                }
            }
            return answer[word1.Length - 1][word2.Length - 1];
        }
    }
}
