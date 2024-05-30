// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        WordSearchSolution sol = new WordSearchSolution();
        char[][] board = new char[3][];
        board[0] = new char[4] { 'A', 'B', 'C', 'E' };
        board[1] = new char[4] { 'S', 'F', 'C', 'S' };
        board[2] = new char[4] { 'A', 'D', 'E', 'E' };
        string word = "ABCCED";
        sol.Exist(board, word);

    }
}