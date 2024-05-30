using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode___C_Sharp
{
    public class WordSearchSolution
    {
        public bool Exist(char[][] board, string word)
        {
            int verLen = board.Length;
            int horLen = board[0].Length;

            if (word.Length > verLen * horLen)
            {
                return false;
            }
            bool[][] visited = new bool[verLen][];
            for (int i = 0; i < verLen; i++)
            {
                visited[i] = new bool[horLen];
            }
            for (int i = 0; i < verLen; i++)
            {
                for (int j = 0; j < horLen; j++)
                {
                    string current = "";
                    if (FindWord(board, visited, current, word, i, j, verLen, horLen))
                    {
                        return true;
                    };
                }
            }
            return false;
        }
        public bool FindWord(char[][] board, bool[][] visited, string current, string target, int i, int j, int verLen, int horLen)
        {
            if (current.Equals(target))
            {
                return true;
            }
            if (i == verLen || i < 0 || j == horLen || j < 0 || visited[i][j] || current.Length > target.Length)
            {
                return false;
            }
            visited[i][j] = true;
            string newCurrent = current + board[i][j].ToString();
            bool found = FindWord(board, visited, newCurrent, target, i + 1, j, verLen, horLen) || FindWord(board, visited, newCurrent, target, i - 1, j, verLen, horLen)
                || FindWord(board, visited, newCurrent, target, i, j + 1, verLen, horLen) || FindWord(board, visited, newCurrent, target, i, j - 1, verLen, horLen);

            if (found) { return true; };
            visited[i][j] = false;
            return false;
            
        }
    }
}
