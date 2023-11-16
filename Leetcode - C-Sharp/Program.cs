// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        NumIslandsSolution sol = new NumIslandsSolution();
        char[][] grid = new char[3][];
        grid[0] = new char[] { '0', '1', '0' };
        grid[1] = new char[] { '1', '0', '1' };
        grid[2] = new char[] { '0', '1', '0' };
        sol.NumIslands(grid);


    }
}