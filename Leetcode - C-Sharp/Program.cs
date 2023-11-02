// See https://aka.ms/new-console-template for more information
using Leetcode___C_Sharp;
using System.Globalization;

public class Program
{
    static void Main()
    {
        MinPathSumSolution sol = new MinPathSumSolution();
        int[] nums1 = { 1, 3, 1};
        int[] nums2 = { 1, 5, 1 };
        int[] nums3 = { 4, 2, 1 };
        int[][] grid = new int[3][];
        grid[0] = nums1;
        grid[1] = nums2;
        grid[2] = nums3;
        sol.MinPathSum(grid);
    }
}